using Gamer_Shop2._0.Formularios.BorderClasss;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Inicio
{
    public partial class InicioDetalle : Form
    {

        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; } //Referencia a panel.
        public InicioDetalle()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void InicioDetalle_Load(object sender, EventArgs e)
        {
            // Mostrar la fecha actual inmediatamente
            LFActual.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Mostrar la hora actual inmediatamente
            LReloj.Text = DateTime.Now.ToString("HH:mm:ss");

            // Iniciar el temporizador para actualizar la hora cada segundo
            THorario.Interval = 1000;
            THorario.Start();

            // Form redondeado
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
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        //Reloj a tiempo real
        private void THorario_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del Label con la hora actual
            LReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= InicioDetalle_Load;
            THorario.Tick -= THorario_Tick;

            // Liberar los recursos
            base.Dispose();
        }
    }
}