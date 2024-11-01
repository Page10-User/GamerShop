using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

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
                BotonArticuloCompra articuloCompra = new BotonArticuloCompra();

                articuloCompra.Serial = producto.Serial;
                articuloCompra.NombreProducto = producto.Nombre;
                articuloCompra.Precio = producto.Precio.ToString();
                articuloCompra.Categoria = producto.Categoria;
                articuloCompra.AgregarAlDataGrid += AgregarAlDataGrid_Click;

                //articuloCompra.PanelContainer = PanelContainer;
                articuloCompra.MainForm = MainForm;
                //articuloCompra.MainCatalogo = this;

                flowLayoutPanel1.Controls.Add(articuloCompra);

                articuloCompra.Show();
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
    }
}
