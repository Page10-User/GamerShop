using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionProveedor;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionCliente
{
    public partial class ListaCliente : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NCliente ncliente = new NCliente();

        public Panel PanelContainer { get; set; }
        public ListaCliente()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth);
        }

        private void PBuscadorListaCl_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 10;
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

        private void ListaCLiente_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            try
            {
                ConfigurarDataGridView();
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
            using (Pen pen = new Pen(Color.Lime, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void PContListaCl_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.Lime, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ConfigurarDataGridView()
        {
            DataTable clientes = ncliente.listaClientes(DGListaCliente); // Este método debe devolver un DataTable con los proveedores

            // Limpia el DataGridView y agrega los proveedores
            DGListaCliente.Rows.Clear();
            foreach (DataRow row in clientes.Rows)
            {
                // Agrega una fila con los datos del proveedor
                DGListaCliente.Rows.Add(row["ID_Cliente"], row["DNI"], row["Nombre"], row["Apellido"], row["Teléfono"], row["Correo"]);
            }
        }

        private void DGListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaCliente.Columns["CModificarCl"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Crear una nueva instancia de Alta Cliente
                    string dni = DGListaCliente.CurrentRow.Cells["DNI"].Value.ToString();
                    NCliente cliente = new NCliente();

                    ModificarCliente ModificarCl = new ModificarCliente(cliente.GetCliente(dni));
                    ModificarCl.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(ModificarCl);
                    ModificarCl.PanelContainer = PanelContainer;
                    ModificarCl.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo Modificar el cliente", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void BAltaCliente_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de Alta CLiente
            InstanciarYMostrarAltaCliente();
        }
        //--------------------------------------------------------InstanciarYMostrarAltaCliente----------------------------------------------------\\
        private void InstanciarYMostrarAltaCliente()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }
            
            AltaCliente AltaCl = new AltaCliente(true);
            AltaCl.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaCl);
            AltaCl.PanelContainer = PanelContainer;
            AltaCl.Show();
            this.Dispose();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-AltaProducto-Events->\\
            this.Load -= ListaCLiente_Load;

            //<-Paint-Events->\\
            PContListaCl.Paint -= PContListaCl_Paint;

            //<-Click-Events->\\
            BAltaCliente.Click -= BAltaCliente_Click;

            //<-TextBox-Events->\\
            //...\\

            //<-CellClick-Events-\\
            DGListaCliente.CellClick -= DGListaCliente_CellClick;

            // Liberar los recursos
            base.Dispose();
        }

        private void BBuscador_Click(object sender, EventArgs e)
        {
            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaCliente.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaCliente.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaCliente);
        }
        private void FiltrarDataGrid(DataGridView data)
        {
            string filtro = TBFiltro.Texts.ToLower();

            foreach (DataGridViewRow fila in data.Rows)
            {
                // Verifica si alguna celda en la fila contiene el texto del filtro
                bool cumpleFiltro = fila.Cells
                    .Cast<DataGridViewCell>()
                    .Any(celda => celda.Value != null && celda.Value.ToString().ToLower().Contains(filtro));

                // Ajusta la visibilidad de la fila según el resultado del filtro
                fila.Visible = cumpleFiltro;
            }
        }

        private void BDescargarCliente_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación para iniciar la descarga
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea descargar la lista de clientes?", "Descargar lista cliente?", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Close();

                // Crear el FolderBrowserDialog para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione una carpeta para guardar la lista de clientes";
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Empezar en C:
                    folderDialog.ShowNewFolderButton = true;

                    // Mostrar el diálogo con el formulario principal como propietario
                    if (folderDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada
                        string rutaSeleccionada = folderDialog.SelectedPath;

                        // Llamar a la función de backup con la ruta seleccionada
                        BackupClientes.ExportarClientesACSV(rutaSeleccionada);

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
