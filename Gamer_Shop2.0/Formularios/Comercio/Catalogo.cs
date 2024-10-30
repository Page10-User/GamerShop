using Gamer_Shop2._0.Formularios.Comercio.Carrito;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Inicio;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Gamer_Shop2._0.Datos.DProducto;

namespace Gamer_Shop2._0.Formularios.Comercio
{
    public partial class Catalogo : Form
    {
        private int borderRadius = 5; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        private Dictionary<int, int> idPrCarrito = new Dictionary<int, int>();

        public Panel PanelContainer { get; set; }
        public Label LabelContainer { get; set; }
        public Bienvenida MainForm { get; set; }
        public Catalogo()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }
        private void Catalogo_Load(object sender, EventArgs e)
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
            FLPContCatalogo.Controls.Clear();

            foreach (var producto in productos)
            {
                BotonesArticulo articuloCt = new BotonesArticulo();

                articuloCt.Serial = producto.Serial;
                articuloCt.NombreProducto = producto.Nombre;        
                articuloCt.Precio = producto.Precio.ToString();   
                articuloCt.Categoria = producto.Categoria; 
                articuloCt.AgregarAlCarritoClick += ArticuloCt_AgregarAlCarritoClick;

                articuloCt.PanelContainer = PanelContainer;
                articuloCt.MainForm = MainForm;
                articuloCt.MainCatalogo = this;

                FLPContCatalogo.Controls.Add(articuloCt);

                articuloCt.Show();
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

        private void BReturn_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea volver? Se perderán los cambios realizados", "Volver", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                VolverAlInicio();
                mensaje.Dispose();
            }
            else
            {
                mensaje.Dispose();
                MainForm.TopMost = true;
            }
        }

        private void BListaVenta_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de ListaVenta
            ListaVenta listVn = new ListaVenta(true);
            listVn.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(listVn);
            listVn.PanelContainer = PanelContainer;
            listVn.Mainform = MainForm;
            listVn.Show();
            this.Dispose();
        }

        private void BCarrito_Click(object sender, EventArgs e)
        {
            Form formBg = new Form();
            
            if (idPrCarrito.Count == 0)
            {
                //Mostrar Carrito Vacio
                InstanciarYMostrarCarrito_V_(formBg);
            }
            else
            {
                //Mostrar Carrito Vacio
                InstanciarYMostrarCarritoConPr(formBg);
            }
        }
        private void ArticuloCt_AgregarAlCarritoClick(object sender, int serial)
        {
            // Verifica si el producto ya está en el carrito
            if (idPrCarrito.ContainsKey(serial))
            {
                // Aumenta la cantidad del producto existente
                idPrCarrito[serial]++;
            }
            else
            {
                // Agrega el producto al carrito con cantidad 1
                idPrCarrito[serial] = 1;
            }
        }

        private void ArticuloCr_EliminarPrCarritoClick(object sender, int serial)
        {
            if (idPrCarrito.ContainsKey(serial))
            {
                // Disminuye la cantidad del producto
                idPrCarrito[serial]--;

                // Si la cantidad llega a 0, elimina el producto del carrito
                if (idPrCarrito[serial] == 0)
                {
                    idPrCarrito.Remove(serial);
                }
            }
        }

        //------------------------------------------------------InstanciarYMostrarCarrito_V_----------------------------------------------------\\
        private void InstanciarYMostrarCarrito_V_(Form formBg)
        {
            PanelCarrito_V_ Pcarrito_V = new PanelCarrito_V_();
            Pcarrito_V.TopLevel = false;
            PContCarrito.Controls.Add(Pcarrito_V);
            Pcarrito_V.PanelContainerCr = PContCarrito;
            Pcarrito_V.FondoOscuro = GenerarFondoOscuro(formBg);
            Pcarrito_V.MainForm = MainForm;
            PContCarrito.BringToFront();
            MainForm.TopMost = false;
            Pcarrito_V.Show();
        }
        //------------------------------------------------------InstanciarYMostrarCarritoConPr----------------------------------------------------\\
        private void InstanciarYMostrarCarritoConPr(Form formBg)
        {
            PanelCarrito Pcarrito = new PanelCarrito();
            Pcarrito.TopLevel = false;
            PContCarrito.Controls.Add(Pcarrito);
            Pcarrito.PanelContainerCr = PContCarrito;
            Pcarrito.PanelContainer = PanelContainer;
            Pcarrito.MainForm = MainForm;
            Pcarrito.FondoOscuro = GenerarFondoOscuro(formBg);
            Pcarrito.MainCatalogo = this;
            Pcarrito.EliminarPrCarritoClick += ArticuloCr_EliminarPrCarritoClick;
            Pcarrito.idPrCr = idPrCarrito;
            PContCarrito.BringToFront();
            MainForm.TopMost = false;
            Pcarrito.Show();
        }
        private Form GenerarFondoOscuro(Form formBG)
        {
            // Modificar formBG
            Point thisLocation = this.Location;
            Point formBGLocation = new Point(thisLocation.X + 338, thisLocation.Y + 146);
            formBG = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.70d, // 70% de opacidad
                BackColor = Color.Black,
                Width = 487,
                Height = this.Height - 4,
                Location = formBGLocation,
                WindowState = FormWindowState.Normal,
                TopMost = true,
                ShowInTaskbar = false
            };

            // Mostrar el formulario de oscurecimiento
            formBG.Show();
            MainForm.FondoOscuroCatalogo = formBG;
            return formBG;
        }

        private void VolverAlInicio()
        {
            // Crear una nueva instancia de inicioDetalle
            InicioDetalle inicioD = new InicioDetalle();
            inicioD.TopLevel = false;

            // Poner visible "version sistema".
            LabelContainer.Visible = true;
            LabelContainer.BringToFront();

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(inicioD);
            inicioD.PanelContainer = PanelContainer;
            MainForm.TopMost = true;
            inicioD.Show();
            inicioD.Location = new Point(50, 130);
            this.Dispose();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BCarrito.Click -= BCarrito_Click;
            BListaVenta.Click -= BListaVenta_Click;
            BReturn.Click -= BReturn_Click;


            // Liberar los recursos
            base.Dispose();
        }
    }
}
