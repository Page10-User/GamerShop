using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
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
    public partial class ListaVenta : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NVenta nventa = new NVenta();

        public Panel PanelContainer { get; set; }
        public Bienvenida Mainform { get; set; }

        public Usuario LUsuario { get; set; }

        public Label LabelVersion { get; set; }
        public ListaVenta(bool desdeDonde)
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            ManejarVisibilidadBotonCatalogo(desdeDonde);
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

        private void ManejarVisibilidadBotonCatalogo(bool desdeDonde)
        {
            if (desdeDonde)
            {
                BShowCatalogo.Visible = true;
                LShowCatalogo.Visible = true;
            }
            else
            {
                BShowCatalogo.Visible = false;
                LShowCatalogo.Visible = false;
            }
        }

        private void ListaVenta_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            nventa.getVentas(DGListaVn);

            try
            {
                configurarDataGridView();
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otra excepción
                MessageBox.Show(ex.Message);
            }
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

        private void BShowCatalogo_Click(object sender, EventArgs e)
        {
            // Instanciar y Mostrar form
            InstanciarYMostrarCatalogo();
        }

        public void configurarDataGridView ()
        {
            if (DGListaVn.Rows.Count > 0)
            {
                DataGridViewButtonColumn botondetalle = new DataGridViewButtonColumn();

                // Configurar propiedades de la columna
                botondetalle.Name = "Detalle_venta"; // Nombre de la columna
                botondetalle.HeaderText = "Detalle de venta"; // Texto del encabezado

                // Agregar la columna al DataGridView
                DGListaVn.Columns.Add(botondetalle);
                DGListaVn.Columns["Detalle_venta"].DisplayIndex = 6;
            }
        }

        private void DGListaVn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaVn.Columns["Detalle_venta"].Index && e.RowIndex >= 0)
            {
                try
                {
                    NVenta nventa = new NVenta();
                    Venta ventaactual = new Venta();
                    //ventaactual = nventa.GetVenta(int.Parse(DGListaVn.CurrentRow.Cells["ID_Venta"].Value.ToString()));
                  
                    // Crear una nueva instancia de ListaProductos
                    ListaDetalleVenta listadetalles = new ListaDetalleVenta(int.Parse(DGListaVn.CurrentRow.Cells["ID_Venta"].Value.ToString()));
                    listadetalles.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(listadetalles);
                    listadetalles.LUsuario = LUsuario;
                    listadetalles.LabelVersion = LabelVersion;
                    listadetalles.PanelContainer = PanelContainer;
                    listadetalles.Show();
                    //this.Dispose();
                }
                catch (Exception x)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + x.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

            //------------------------------------------------------------------------------------InstanciarCatalogo-------------------------------------------------------------------------------\\
            private void InstanciarYMostrarCatalogo()
        {
            Control control = PanelContainer.Controls[0];
             if (control is Form)
             {
                 //Liberamos recursos
                 control.Dispose();
             }

             // Instanciar y Mostrar form
             Catalogo formCatalogo = new Catalogo();
             formCatalogo.TopLevel = false;
             formCatalogo.PanelContainer = PanelContainer;
             formCatalogo.MainForm = Mainform;
             formCatalogo.LabelContainer = LabelVersion;
             formCatalogo.CUsuario = LUsuario;
             PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
             PanelContainer.Controls.Add(formCatalogo);
             PanelContainer.BringToFront();

             formCatalogo.Show();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= ListaVenta_Load;
            PContListaVn.Paint -= PContListaVn_Paint;
            BShowCatalogo.Click -= BShowCatalogo_Click;

            // Liberar los recursos
            //base.Dispose();
        }

        private void BDescargarListVn_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación para iniciar la descarga
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea descargar la lista de ventas?", "Descargar lista venta?", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Close();

                // Crear el FolderBrowserDialog para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione una carpeta para guardar la lista de ventas";
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Empezar en C:
                    folderDialog.ShowNewFolderButton = true;

                    // Mostrar el diálogo con el formulario principal como propietario
                    if (folderDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada
                        string rutaSeleccionada = folderDialog.SelectedPath;

                        // Llamar a la función de backup con la ruta seleccionada
                        BackupVentas.ExportarVentasACSV(rutaSeleccionada);

                        // Mostrar mensaje de éxito
                        mensaje = new MsgPersonalizado("Lista descargada con éxito!", "Descargar lista", "Informacion", null);
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        // El usuario canceló la selección de carpeta
                        mensaje = new MsgPersonalizado("Operación cancelada.", "Descargar lista", "Advertencia", null);
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
