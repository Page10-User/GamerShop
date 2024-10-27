using Gamer_Shop2._0.Formularios.GestionVenta;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    public partial class PanelCarrito_V_ : Form
    {

        private int borderRadius = 5; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        public Panel PanelContainerCr { get; set; }
        public Form FondoOscuro {  get; set; }
        public  Bienvenida MainForm { get; set; }
        public PanelCarrito_V_()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PCarritoVacio_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.GreenYellow, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void PanelCarrito_V__Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
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
            using (Pen pen = new Pen(Color.SpringGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BExitCarrito_Click(object sender, EventArgs e)
        {
            PanelContainerCr.Controls.Clear();
            PanelContainerCr.SendToBack();
            FondoOscuro.Dispose();
            MainForm.FondoOscuroCatalogo = null;
            this.Dispose();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BExitCarrito.Click -= BExitCarrito_Click;
            this.Load -= PanelCarrito_V__Load;
            PCarritoVacio.Paint -= PCarritoVacio_Paint;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
