using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
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

namespace Gamer_Shop2._0.Formularios.GestionProveedor
{
    public partial class ListaProveedor : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NProveedor nProveedor = new NProveedor();
        bool wasChanged;
        private int destinoX;
        private bool moviendoADerecha;
        public Panel PanelContainer { get; set; }
        public Bienvenida MainForm { get; set; }
        public ListaProveedor()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado

            wasChanged = true;
        }

        private void PBuscadorListaProveedor_Paint(object sender, PaintEventArgs e)
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

        private void ListaProveedor_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            try
            {
                ConfigurarDataGridViewActivos();
                ConfigurarDataGridViewInactivos();
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otra excepción
                MessageBox.Show(ex.Message);
            }

            DGListaProveedorInactivos.Visible = false;
            DGListaProveedorInactivos.SendToBack();
        }

        private void ConfigurarDataGridViewActivos()
        {
            DataTable proveedores = nProveedor.listaProveedores(DGListaProveedor); // Este método debe devolver un DataTable con los proveedores

            // Limpia el DataGridView y agrega los proveedores
            DGListaProveedor.Rows.Clear();
            foreach (DataRow row in proveedores.Rows)
            {
                if (row["Activo"].ToString() == "SI")
                {
                    // Agrega una fila con los datos del proveedor
                    DGListaProveedor.Rows.Add(row["ID_Proveedor"], row["Razon_social"], row["Nombre_representante"], row["Telefono"], row["Correo"], row["Dirección"], row["Activo"], row["Categoria"]);
                }
            }
        }

        private void ConfigurarDataGridViewInactivos()
        {
            DataTable proveedores = nProveedor.listaProveedores(DGListaProveedorInactivos); // Este método debe devolver un DataTable con los proveedores

            // Limpia el DataGridView y agrega los proveedores
            DGListaProveedorInactivos.Rows.Clear();
            foreach (DataRow row in proveedores.Rows)
            {
                if (row["Activo"].ToString() == "NO")
                {
                    // Agrega una fila con los datos del proveedor
                    DGListaProveedorInactivos.Rows.Add(row["ID_Proveedor"], row["Razon_social"], row["Nombre_representante"], row["Telefono"], row["Correo"], row["Dirección"], row["Activo"], row["Categoria"]);
                }
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

        private void PBackSwitch_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 30;
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

        private void PContListaProveedor_Paint(object sender, PaintEventArgs e)
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

        private void DGListaProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaProveedor.Columns["CModificar"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Crear una nueva instancia de ListaProductos
                    int id = int.Parse(DGListaProveedor.CurrentRow.Cells["ID_Proveedor"].Value.ToString());
                    NProveedor nproveedor = new NProveedor();
                    ModificarProveedor ModificarProveedor = new ModificarProveedor(nproveedor.GetProveedor(id));
                    ModificarProveedor.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(ModificarProveedor);
                    ModificarProveedor.PanelContainer = PanelContainer;
                    ModificarProveedor.MainForm = MainForm;
                    ModificarProveedor.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo Modificar el proveedor", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else if (e.ColumnIndex == DGListaProveedor.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea eliminar este proveedor?", "Eliminar Proveedor", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(DGListaProveedor.CurrentRow.Cells["ID_Proveedor"].Value.ToString());
                        NProveedor nproveedor = new NProveedor();
                        nproveedor.NEliminarProveedor(id);
                        mensaje.Close();
                        DGListaProveedor.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception)
                    {
                        mensaje = new MsgPersonalizado("No se pudo eliminar el producto", "Error", "Error", null);
                        mensaje.ShowDialog();
                    }
                }
                else
                {
                    mensaje.Dispose();
                }
            }
        }

        private void DGListaProveedorInactivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaProveedorInactivos.Columns["CModificarIn"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Crear una nueva instancia de ListaProductos
                    int id = int.Parse(DGListaProveedorInactivos.CurrentRow.Cells["ID_ProveedorIn"].Value.ToString());
                    NProveedor nproveedor = new NProveedor();
                    ModificarProveedor ModificarProveedor = new ModificarProveedor(nproveedor.GetProveedor(id));
                    ModificarProveedor.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(ModificarProveedor);
                    ModificarProveedor.PanelContainer = PanelContainer;
                    ModificarProveedor.MainForm = MainForm;
                    ModificarProveedor.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo Modificar el proveedor", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void BShowRegistrarProveedor_Click(object sender, EventArgs e)
        {
            // Mostrar form
            InstanciarYMostrarAltaProveedor();
        }
        //--------------------------------------------------------InstanciarYMostrarAltaProveedor----------------------------------------------------\\
        private void InstanciarYMostrarAltaProveedor()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            AltaProveedor formAltaProovedor = new AltaProveedor();
            formAltaProovedor.TopLevel = false;
            formAltaProovedor.PanelContainer = PanelContainer;

            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProovedor);
            PanelContainer.BringToFront();

            formAltaProovedor.Show();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-AltaProducto-Events->\\
            this.Load -= ListaProveedor_Load;

            //<-Paint-Events->\\
            PContListaProveedor.Paint -= PContListaProveedor_Paint;

            //<-Click-Events->\\
            BShowRegistrarProveedor.Click -= BShowRegistrarProveedor_Click;

            //<-TextBox-Events->\\
            //...\\

            //<-CellClick-Events-\\
            //DGListaProveedor.CellClick -= DGListaProveedor_CellClick;

            // Liberar los recursos
            base.Dispose();
        }

        private void BSwitch_Click(object sender, EventArgs e)
        {
            if (!MovSwitch.Enabled)
            {
                if (wasChanged == true)
                {
                    BSwitch.Text = "N";
                    PBackSwitch.BackColor = Color.Red;
                    wasChanged = false;

                    mostrarListaInactivosYOcultarListaActivos();

                    movimientoBotonDerecha();

                }
                else
                {
                    BSwitch.Text = "S";
                    PBackSwitch.BackColor = Color.Black;
                    wasChanged = true;

                    mostrarListaActivosYOcultarListaInactivos();

                    movimientoBotonIzquierda();
                }
            }
        }

        private void mostrarListaActivosYOcultarListaInactivos()
        {
            DGListaProveedor.BringToFront();
            DGListaProveedor.Visible = true;
            DGListaProveedorInactivos.SendToBack();
            DGListaProveedorInactivos.Visible = false;
        }

        private void mostrarListaInactivosYOcultarListaActivos()
        {
            DGListaProveedorInactivos.BringToFront();
            DGListaProveedorInactivos.Visible = true;
            DGListaProveedor.SendToBack();
            DGListaProveedor.Visible = false;
        }

        private void movimientoBotonDerecha()
        {
            destinoX = BSwitch.Location.X + 25; // Ajusta la distancia a mover
            moviendoADerecha = true;
            MovSwitch.Start();
        }

        private void movimientoBotonIzquierda()
        {
            destinoX = BSwitch.Location.X - 25; // Ajusta la distancia a mover
            moviendoADerecha = false;
            MovSwitch.Start();
        }

        private void MovSwitch_Tick(object sender, EventArgs e)
        {
            if (moviendoADerecha)
            {
                if (BSwitch.Location.X < destinoX)
                {
                    BSwitch.Location = new Point(BSwitch.Location.X + 2, BSwitch.Location.Y);
                }
                else
                {
                    MovSwitch.Stop();
                }
            }
            else
            {
                if (BSwitch.Location.X > destinoX)
                {
                    BSwitch.Location = new Point(BSwitch.Location.X - 2, BSwitch.Location.Y);
                }
                else
                {
                    MovSwitch.Stop();
                }
            }
        }

        private void BBuscador_Click(object sender, EventArgs e)
        {
            if (DGListaProveedor.Visible)
            {
                buscarListaActiva();
            }
            else
            {
                buscarListaInactiva();
            }
        }

        private void buscarListaActiva()
        {
            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaProveedor.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaProveedor.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaProveedor);
        }
        private void buscarListaInactiva()
        {
            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaProveedorInactivos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaProveedorInactivos.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaProveedorInactivos);
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

        private void BDescargar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación para iniciar la descarga
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea descargar la lista de proveedores?", "Descargar lista proveedor?", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Close();

                // Crear el FolderBrowserDialog para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione una carpeta para guardar la lista de proveedores";
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Empezar en C:
                    folderDialog.ShowNewFolderButton = true;

                    // Mostrar el diálogo con el formulario principal como propietario
                    if (folderDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada
                        string rutaSeleccionada = folderDialog.SelectedPath;

                        // Llamar a la función de backup con la ruta seleccionada
                        BackupProveedores.ExportarProveedoresACSV(rutaSeleccionada);

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
