using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    public partial class ListaProductos : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NProducto nproducto = new NProducto();

        public Panel PanelContainer { get; set; }
        public ListaProductos()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void ListaProductos_Load(object sender, EventArgs e)
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

        private void ConfigurarDataGridView()
        {
            DataTable productos = nproducto.listaProductosActivos(DGListaPr); // Este método debe devolver un DataTable con los productos

            // Agrega una columna de imagen al DataGridView si no existe
            if (!DGListaPr.Columns.Contains("ImagenProducto"))
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
                    string imagePath = Path.Combine(Application.StartupPath, "uploads", nombreImagen);

                    // Carga la imagen si existe, o utiliza una imagen de "no disponible"
                    Image image;
                    if (File.Exists(imagePath))
                    {
                        image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // Usa una imagen de "no disponible" en caso de que la imagen no se encuentre
                        image = Properties.Resources.default_producto; // Asegúrate de tener una imagen de recurso llamada ImagenNoDisponible
                    }

                    // Agrega una fila con los datos del producto y la imagen
                    DGListaPr.Rows.Add(image, row["ID_Producto"], row["Serial"], row["Nombre"], row["Descripcion"], row["Stock"], row["Precio"], row["Categoria"], row["Proveedor"]);
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
                AltaPr.Show();
                this.Dispose();
        }
        private void DGListaPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaPr.Columns["CModificar"].Index && e.RowIndex >= 0)
            {
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
                    ModificarPr.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Error inesperado, no se pudo Modificar el producto", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
                
                
            }
            else if (e.ColumnIndex == DGListaPr.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea eliminar este producto?", "Eliminar producto", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        mensaje.Dispose();
                        int id = int.Parse(DGListaPr.CurrentRow.Cells["Serial"].Value.ToString());
                        nproducto.NEliminarProducto(id);
                        DGListaPr.Rows.RemoveAt(e.RowIndex); //debería pasarse a la lista de inactivos
                        mensaje = new MsgPersonalizado("Producto eliminado con éxito", "Eliminación", "Informacion", null);
                        mensaje.ShowDialog();
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

            // Liberar los recursos
            base.Dispose();
        }
    }
}
