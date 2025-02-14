using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
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

namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    public partial class ListaProductos : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NProducto nproducto = new NProducto();
        bool wasChanged;
        private int destinoX;
        private bool moviendoADerecha;
        public Usuario LUsuario { get; set; }

        public Panel PanelContainer { get; set; }
        public ListaProductos()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado

            wasChanged = true;
        }

        private void ListaProductos_Load(object sender, EventArgs e)
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

            DGListaPrInactivos.Visible = false;
            DGListaPrInactivos.SendToBack();
        }
        private void PBuscadorListaPr_Paint(object sender, PaintEventArgs e)
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

        private void PContListaPr_Paint(object sender, PaintEventArgs e)
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

        private void ConfigurarDataGridViewActivos()
        {
            DataTable productos = nproducto.listaProductosActivos(DGListaPr); // Este método debe devolver un DataTable con los productos

            // Agrega una columna de imagen al DataGridView si no existe
            if (!DGListaPrInactivos.Columns.Contains("ImagenProducto"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "ImagenProducto";
                imageColumn.HeaderText = "Imagen";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen a la celda
                DGListaPr.Columns.Insert(0, imageColumn); // Inserta la columna de imagen en la primera posición
            }

            // Limpia el DataGridView y agrega los productos
            DGListaPr.Rows.Clear();
            foreach (DataRow row in productos.Rows)
            {
                if (row["Activo"].ToString() == "SI")
                {
                    string nombreImagen = row["photoFilePath"].ToString(); // Columna de la base de datos con el nombre del archivo de imagen
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\uploads\" + nombreImagen);

                    // Carga la imagen si existe, o utiliza una imagen de "no disponible"
                    Image image;
                    if (File.Exists(imagePath))
                    {
                        image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        image = Properties.Resources.default_producto;
                    }

                    // Agrega una fila con los datos del producto y la imagen
                    DGListaPr.Rows.Add(image, row["ID_Producto"], row["Serial"], row["Nombre"], row["Descripcion"], row["Stock"], row["Precio"], row["Categoria"], row["Proveedor"]);
                }
            }
        }

        private void ConfigurarDataGridViewInactivos()
        {
            DataTable productos = nproducto.listaProductosActivos(DGListaPrInactivos); // Este método debe devolver un DataTable con los productos

            // Agrega una columna de imagen al DataGridView si no existe
            if (!DGListaPrInactivos.Columns.Contains("ImagenProducto"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "ImagenProducto";
                imageColumn.HeaderText = "Imagen";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                DGListaPrInactivos.Columns.Insert(0, imageColumn);
            }

            // Limpia el DataGridView y agrega los productos
            DGListaPrInactivos.Rows.Clear();
            foreach (DataRow row in productos.Rows)
            {
                if (row["Activo"].ToString() == "NO")
                {
                    string nombreImagen = row["photoFilePath"].ToString();
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\uploads\" + nombreImagen);

                    // Carga la imagen si existe, o utiliza una imagen de "no disponible"
                    Image image;
                    if (File.Exists(imagePath))
                    {
                        image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // Usa una imagen de "no disponible" en caso de que la imagen no se encuentre
                        image = Properties.Resources.default_producto;
                    }

                    // Agrega una fila con los datos del producto y la imagen
                    DGListaPrInactivos.Rows.Add(image, row["ID_Producto"], row["Serial"], row["Nombre"], row["Descripcion"], row["Stock"], row["Precio"], row["Categoria"], row["Proveedor"]);
                }
            }
        }

        private void BShowRegistrarPr_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de ListaProductos
            InstanciarYMostrarAltaProducto();
        }
        //------------------------------------------------------InstanciarYMostrarAltaProducto--------------------------------------------------\\
        private void InstanciarYMostrarAltaProducto()
        {
            Control control = PanelContainer.Controls[0];
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                //mostramos el form AltaProducto
                AltaProducto AltaPr = new AltaProducto();
                AltaPr.TopLevel = false;

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(AltaPr);
                AltaPr.PanelContainer = PanelContainer;
                AltaPr.AUsuario = LUsuario;
                AltaPr.Show();
                this.Dispose();
        }
        private void DGListaPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaPr.Columns["CModificar"].Index && e.RowIndex >= 0)
            {
                if (LUsuario.ID_TipoUsuario == 1)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No tienes los permisos necesarios para modificar un producto","Error", "Error", null);
                    mensaje.ShowDialog();
                    return;
                }
                //Crear una nueva instancia de ModificarProducto
                try
                {
                    int serial = int.Parse(DGListaPr.CurrentRow.Cells["Serial"].Value.ToString());
                    NProducto prod = new NProducto();
                    
                    ModificarProducto ModificarPr = new ModificarProducto(prod.GetProducto(serial));
                    ModificarPr.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(ModificarPr);
                    ModificarPr.PanelContainer = PanelContainer;
                    ModificarPr.MUsuario = LUsuario;
                    ModificarPr.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Error inesperado, no se pudo Modificar el producto", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void DGListaPrInactivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaPrInactivos.Columns["CModificarIn"].Index && e.RowIndex >= 0 && LUsuario.ID_TipoUsuario == 2)
            {
                //Crear una nueva instancia de ModificarProducto
                try
                {
                    int serial = int.Parse(DGListaPrInactivos.CurrentRow.Cells["SerialIn"].Value.ToString());
                    NProducto prod = new NProducto();
                    ModificarProducto ModificarPr = new ModificarProducto(prod.GetProducto(serial));
                    ModificarPr.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(ModificarPr);
                    ModificarPr.PanelContainer = PanelContainer;
                    ModificarPr.MUsuario = LUsuario;
                    ModificarPr.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Error inesperado, no se pudo Modificar el producto", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("No cuentas con los permitos necesarios para modificar un producto", "Error", "Error", null);
                mensaje.ShowDialog();
            }
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-ListaProductos-Events->\\
            this.Load -= ListaProductos_Load;
            //<-Paint-Events->\\
            PContListaPr.Paint -= PContListaPr_Paint;

            //<-Click-Events->\\
            BShowRegistrarPr.Click -= BShowRegistrarPr_Click;

            //<-TextBox-Events->\\
            //...\\

            //<-CellClick-Events->\\
            DGListaPr.CellClick -= DGListaPr_CellClick;
            DGListaPrInactivos.CellClick -= DGListaPrInactivos_CellClick;

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
            DGListaPr.BringToFront();
            DGListaPr.Visible = true;
            DGListaPrInactivos.SendToBack();
            DGListaPrInactivos.Visible = false;


        }

        private void mostrarListaInactivosYOcultarListaActivos()
        {
            DGListaPrInactivos.BringToFront();
            DGListaPrInactivos.Visible = true;
            DGListaPr.SendToBack();
            DGListaPr.Visible = false;
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
            if (DGListaPr.Visible)
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
            // Limpiar la lista original antes de llenarla

            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaPr.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaPr.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaPr);
        }
        private void buscarListaInactiva()
        {
            // Limpiar la lista original antes de llenarla

            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaPrInactivos.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaPrInactivos.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaPrInactivos);
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

        private void BDescargarPr_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación para iniciar la descarga
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea descargar la lista de productos?", "Descargar lista producto?", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Close();

                // Crear el FolderBrowserDialog para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione una carpeta para guardar la lista de productos";
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Empezar en C:
                    folderDialog.ShowNewFolderButton = true;

                    // Mostrar el diálogo con el formulario principal como propietario
                    if (folderDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada
                        string rutaSeleccionada = folderDialog.SelectedPath;

                        // Llamar a la función de backup con la ruta seleccionada
                        BackupProductos.ExportarProductosACSV(rutaSeleccionada);

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
