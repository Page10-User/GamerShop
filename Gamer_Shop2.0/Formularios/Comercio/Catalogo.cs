using Gamer_Shop2._0.Formularios.Comercio.Carrito;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Inicio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Comercio
{
    public partial class Catalogo : Form
    {
        private int borderRadius = 5; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        List<int> idPrCarrito = new List<int>();

        public Panel PanelContainer { get; set; }
        public Label LabelContainer { get; set; }
        public Bienvenida MainForm { get; set; }
        public Catalogo()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(Catalogo_Load);
            PBuscadorCt.Paint += new PaintEventHandler(PBuscadorCt_Paint);
        }

        private void PBuscadorCt_Paint(object sender, PaintEventArgs e)
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

        private void Catalogo_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            FLPContCatalogo.Controls.Clear();

            // Cargar productos.
            for (int i = 0; i < 5; i++)
            {
                // Instanciamos un/os Producto/s.
                BotonesArticulo articuloCt = new BotonesArticulo();
                articuloCt.Id = i;
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
            DialogResult = MessageBox.Show("Está seguro que desea volver? Se perderán los cambios realizados", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                VolverAlInicio();
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
            listVn.Show();
            this.Close();
        }

        private void BCarrito_Click(object sender, EventArgs e)
        {
            Form formBg = new Form();
            
            if (idPrCarrito.Count == 0)
            {
                PanelCarrito_V_ Pcarrito_V = new PanelCarrito_V_();
                Pcarrito_V.TopLevel = false;
                PContCarrito.Controls.Add(Pcarrito_V);
                Pcarrito_V.PanelContainerCr = PContCarrito;
                Pcarrito_V.FondoOscuro = GenerarFondoOscuro(formBg);
                Pcarrito_V.MainForm = MainForm;
                PContCarrito.BringToFront();
                Pcarrito_V.Show();
            }
            else
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
                Pcarrito.Show();
            }
        }
       private void ArticuloCt_AgregarAlCarritoClick(object sender, int productoId)
        {
            // Agregar la ID del producto al carrito
            idPrCarrito.Add(productoId);
       }

        private void ArticuloCr_EliminarPrCarritoClick(object sender, int productoId)
        {
            // Agregar la ID del producto al carrito
            idPrCarrito.RemoveAt(idPrCarrito.Count - 1);
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
            inicioD.Show();
            inicioD.Location = new Point(50, 130);
            this.Close();
        }
    }
}
