using Gamer_Shop2._0.Formularios.Comercio.Carrito;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Inicio;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Gamer_Shop2._0.Datos.DProducto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        public Usuario CUsuario { get; set; }
        public Catalogo()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }
        private void Catalogo_Load(object sender, EventArgs e)
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
                articuloCt.ACTUsuario = CUsuario;
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

        private void BBuscadorProductoCt_Click(object sender, EventArgs e)
        {
            // Verifica si no hay ningun filtro y no se escribió nada en el buscador
            if (BFiltro.SelectedIndex < 0 && string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                foreach (BotonesArticulo producto in FLPContCatalogo.Controls)
                {
                    producto.Visible = true;
                }
            }

            // Verifica si se ha seleccionado alguna categoría y no se escribió nada en el buscador
            if (BFiltro.SelectedIndex >= 0 && string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                string CategoriaSeleccionado = BFiltro.SelectedValue.ToString();

                foreach (BotonesArticulo producto in FLPContCatalogo.Controls)
                {
                    producto.Visible = producto.Categoria == CategoriaSeleccionado;
                }
            }

            // Verifica si se ha escrito algo en el buscador y no seleccionado ningun filtro
            if (BFiltro.SelectedIndex < 0 && !string.IsNullOrWhiteSpace(TBFiltroCt.Texts))
            {
                string buscar = TBFiltroCt.Texts.Trim().ToLower();

                foreach (BotonesArticulo producto in FLPContCatalogo.Controls)
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


                foreach (BotonesArticulo producto in FLPContCatalogo.Controls)
                {
                    bool matchesCategoria = producto.Categoria == CategoriaSeleccionado;
                    bool matchesTexts = producto.NombreProducto.ToLower().Contains(buscar) || producto.Precio.ToString().Contains(buscar);

                    producto.Visible = matchesTexts && matchesCategoria;
                }
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
    }
}
