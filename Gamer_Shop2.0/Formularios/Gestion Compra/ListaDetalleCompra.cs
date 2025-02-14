using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class ListaDetalleCompra : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        Compra compra = new Compra();

        public Panel PanelContainer { get; set; }
        public Bienvenida Mainform { get; set; }
        public ListaDetalleCompra(int id)
        {
            InitializeComponent();

            NCompra ncompra = new NCompra(); 
            compra = ncompra.GetCompra(id);
            NDetalleCompra ndcompra = new NDetalleCompra();
            NDetalleVenta ndventa = new NDetalleVenta();

            ndcompra.getDetalles(DGListaDVn, compra.ID_Compra);

            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PContListaVn_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 1;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ListaVenta_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
        }

        private GraphicsPath CreateRoundedPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Agregar los arcos para las esquinas redondeadas
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 90, 90);

            path.CloseFigure();

            return path;
        }

        private Region CreateRoundedRegion()
        {
            GraphicsPath path = CreateRoundedPath();
            return new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // dibujar el borde redondeado
            GraphicsPath path = CreateRoundedPath();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= ListaVenta_Load;
            PContListaVn.Paint -= PContListaVn_Paint;
       

            // Liberar los recursos
            base.Dispose();
        }

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            // Mostrar form
            ListaCompra formListCo = new ListaCompra();
            formListCo.TopLevel = false;
            formListCo.PanelContainer = PanelContainer;
            formListCo.MainForm = Mainform;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formListCo);
            PanelContainer.BringToFront();

            formListCo.Show();
        }

        private void BDescargarListVn_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación para iniciar la descarga
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea descargar la lista de detalles compra?", "Descargar lista detalles compra?", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Close();

                // Crear el FolderBrowserDialog para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione una carpeta para guardar la lista de detalles compra";
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Empezar en C:
                    folderDialog.ShowNewFolderButton = true;

                    // Mostrar el diálogo con el formulario principal como propietario
                    if (folderDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada
                        string rutaSeleccionada = folderDialog.SelectedPath;

                        // Llamar a la función de backup con la ruta seleccionada
                        BackupDetalleCompras.ExportarDetalleComprasACSV(rutaSeleccionada, compra.ID_Compra);

                        // Mostrar mensaje de éxito
                        mensaje = new MsgPersonalizado("Lista descargada con éxito!", "Descargar lista", "Informacion", null);
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        // El usuario canceló la selección de carpeta
                        mensaje = new MsgPersonalizado("Operación cancelada.", "Descargar lista", "Informacion", null);
                        mensaje.ShowDialog();
                    }
                }
            }
            else
            {
                mensaje.Close();
            }
        }
    }
}
