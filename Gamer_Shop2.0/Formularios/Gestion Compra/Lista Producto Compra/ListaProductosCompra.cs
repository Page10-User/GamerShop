using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static Gamer_Shop2._0.Datos.DProducto;

namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    public partial class ListaProductosCompra : Form
    {
        private int borderRadius = 40; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde
        public Form FondoOscurecido { get; set; }
        public Bienvenida MainForm { get; set; }

        public ListaProductosCompra()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void ListaProductosCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Categoría_producto' Puede moverla o quitarla según sea necesario.
            this.categoría_productoTableAdapter.Fill(this.dataSet1.Categoría_producto);
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            BFiltro.SelectedIndex = -1;

            CargarProductosActivos();
        }

        private void CargarProductosActivos()
        {
            NProducto nProducto = new NProducto();
            List<ProductoViewModel> productosActivos = nProducto.ObtenerProductosActivos();

            MostrarProductosEnFLP(productosActivos);
        }

        private void MostrarProductosEnFLP(List<ProductoViewModel> productos)
        {
                flowLayoutPanel1.Controls.Clear();

                foreach (var producto in productos)
                {
                    try {

                        BotonArticuloCompra articuloCompra = new BotonArticuloCompra();

                        articuloCompra.Serial = producto.Serial;
                        articuloCompra.NombreProducto = producto.Nombre;
                        articuloCompra.Precio = producto.Precio.ToString();
                        articuloCompra.Categoria = producto.Categoria;
                        articuloCompra.PhotoFilePath = producto.photoFilePath;
                        articuloCompra.AgregarAlDataGrid += AgregarAlDataGrid_Click;

                        //articuloCompra.PanelContainer = PanelContainer;
                        articuloCompra.MainForm = MainForm;
                        //articuloCompra.MainCatalogo = this;

                        flowLayoutPanel1.Controls.Add(articuloCompra);

                        articuloCompra.Show();

                    }
                    catch
                    {
                        MsgPersonalizado mensaje = new MsgPersonalizado("Error al cargar el producto: " + producto.Nombre + ", Serial: " + producto.Serial, "Error", "Error", null);
                        mensaje.ShowDialog();
                    }
                
                }
        }

        public event EventHandler<int> AgregarAlDataGrid;
        private void AgregarAlDataGrid_Click(object sender, int serial)
        {
            //Pasamos el id del producto al catálogo.
            AgregarAlDataGrid?.Invoke(this, serial);
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

        private void BCloseListaProducto_Click(object sender, EventArgs e)
        {
            MainForm.TopMost = true;
            FondoOscurecido.Dispose();
            this.Dispose();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= ListaProductosCompra_Load;
            BCloseListaProducto.Click -= BCloseListaProducto_Click;

            // Liberar los recursos
            base.Dispose();
        }

        private void BBuscadorProductoCt_Click(object sender, EventArgs e)
        {
            // Verifica si no hay ningun filtro y no se escribió nada en el buscador
            if (BFiltro.SelectedIndex < 0 && string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                foreach (BotonArticuloCompra producto in flowLayoutPanel1.Controls)
                {
                    producto.Visible = true;
                }
            }

            // Verifica si se ha seleccionado alguna categoría y no se escribió nada en el buscador
            if (BFiltro.SelectedIndex >= 0 && string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                string CategoriaSeleccionado = BFiltro.SelectedValue.ToString();

                foreach (BotonArticuloCompra producto in flowLayoutPanel1.Controls)
                {
                    producto.Visible = producto.Categoria == CategoriaSeleccionado;
                }
                BFiltro.SelectedIndex = -1;
            }

            // Verifica si se ha escrito algo en el buscador y no seleccionado ningun filtro
            if (BFiltro.SelectedIndex < 0 && !string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                string buscar = TBFiltroCt.Texts.Trim().ToLower();

                foreach (BotonArticuloCompra producto in flowLayoutPanel1.Controls)
                {
                    bool matches = producto.NombreProducto.ToLower().Contains(buscar) || producto.Precio.ToString().Contains(buscar);

                    producto.Visible = matches;
                }
            }

            // Verificamos si se escogió un filtro y se escribió algo en el buscador
            if (BFiltro.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                string CategoriaSeleccionado = BFiltro.SelectedValue.ToString();
                string buscar = TBFiltroCt.Texts.Trim().ToLower();


                foreach (BotonArticuloCompra producto in flowLayoutPanel1.Controls)
                {
                    bool matchesCategoria = producto.Categoria == CategoriaSeleccionado;
                    bool matchesTexts = producto.NombreProducto.ToLower().Contains(buscar) || producto.Precio.ToString().Contains(buscar);

                    producto.Visible = matchesTexts && matchesCategoria;
                }
                BFiltro.SelectedIndex = -1;

            }
        }

        private void BFiltro_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                BFiltro.SelectedIndex = -1;
                BFiltro.SelectedIndex = -1;
            }
        }

        private void BFiltrarSecond_Click(object sender, EventArgs e)
        {
            // Obtiene el índice seleccionado en el ComboBox para determinar el tipo de filtro
            int selectedIndex = CBFiltrado.SelectedIndex;

            // Extrae los controles de tipo BotonArticuloCompra en una lista
            List<BotonArticuloCompra> productos = flowLayoutPanel1.Controls.OfType<BotonArticuloCompra>().ToList();

            // Ordena la lista en función de la selección del ComboBox
            switch (selectedIndex)
            {
                case 0: // A-Z (orden alfabético ascendente)
                    productos = productos.OrderBy(p => p.NombreProducto).ToList();
                    break;
                case 1: // Z-A (orden alfabético descendente)
                    productos = productos.OrderByDescending(p => p.NombreProducto).ToList();
                    break;
                case 2: // Menor-Mayor (precio)
                    productos = productos.OrderBy(p => Convert.ToInt64(p.Precio)).ToList();
                    break;
                case 3: // Mayor-Menor (precio)
                    productos = productos.OrderByDescending(p => Convert.ToInt64(p.Precio)).ToList();
                    break;
                default:
                    MessageBox.Show("Selección de filtro no válida.");
                    return;
            }
            // Limpia el FlowLayoutPanel y agrega los controles en el nuevo orden
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(productos.ToArray());
        }
    }
}
