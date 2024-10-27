using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Load += new EventHandler(ListaProductos_Load);
            PContListaPr.Paint += new PaintEventHandler(PContListaPr_Paint);
            DGListaPr.CellClick += DGListaPr_CellClick;
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            nproducto.listaProductosActivos(DGListaPr);
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
            // Crear una columna de tipo Imagen
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Imagen",
                Name = "ImagenProducto",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };

            // Agregar la columna al DataGridView
            
            DGListaPr.Columns.Add(imageColumn);
            DGListaPr.Columns["ID_Producto"].Visible = false;
            DGListaPr.Columns["CModificar"].DisplayIndex = 10;
            DGListaPr.Columns["CEliminar"].DisplayIndex = 11;

            foreach (DataGridViewRow row in DGListaPr.Rows)
            {

                
                Image imagenProducto;

                try
                {
                    // Asumiendo que el nombre del archivo está en Resources
                    imagenProducto = Image.FromFile("C:\\Users\\Usuario\\Pictures\\validaciones.png");
                    if (imagenProducto == null) throw new Exception();
                }
                catch (Exception)
                {
                    // Cargar una imagen predeterminada si no se encuentra la imagen
                    imagenProducto = Image.FromFile("\\Gamer_Shop2.0\\Resources\\imagen_default.png");
                }

                row.Cells["ImagenProducto"].Value = imagenProducto;
            }

            //Ocultar la columna que contiene las rutas de las imágenes(photoFilePath)
            if (DGListaPr.Columns["ImagenProducto"] != null)
            {
                DGListaPr.Columns["photoFilePath"].Visible = false;
            }
        }

        private void BShowRegistrarPr_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de ListaProductos
            AltaProducto AltaPr = new AltaProducto();
            AltaPr.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaPr);
            AltaPr.PanelContainer = PanelContainer;
            AltaPr.Show();
            this.Close();
        }

        private void DGListaPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaPr.Columns["CModificar"].Index && e.RowIndex >= 0)
            {
                // Crear una nueva instancia de ModificarProducto
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
                    this.Close();
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
                        mensaje.Close();
                        int id = int.Parse(DGListaPr.CurrentRow.Cells["Serial"].Value.ToString());
                        nproducto.NEliminarProducto(id);
                        DGListaPr.Rows.RemoveAt(e.RowIndex); //debería pasarse a la lista de inactivos
                        mensaje = new MsgPersonalizado("Producto eliminado con éxito", "Eliminación", "Error", null);
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
                    mensaje.Close();
                }
            }
        }
    }
}
