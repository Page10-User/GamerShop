using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gamer_Shop2._0
{
    public partial class Bienvenida : Form
    {
        // Menú expandido bool
        bool isExpanded = false;
        private Form formBG;
        public Bienvenida()
        {
            InitializeComponent();
            this.Load += new EventHandler(Bienvenida_Load);
            this.Paint += new PaintEventHandler(Bievenida_Paint);
            PMenuUS.Paint += new PaintEventHandler(PMenuUS_Paint);
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            // Configura los controles iniciales
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Location = new Point(15, 26);
            PContenidoUS.Visible = false;
        }

        // Función botón Exit
        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botón contraer Menú.
        private void BContracMenu_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Visible = true;
            BContracMenu.Visible = false;
            PContenidoUS.Visible = false;
            formBG.Close();
        }

        // Botón expandir Menú.
        private void BExpandMenu_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            PMenuUS.Location = new Point(0, 0);
            BExpandMenu.Visible = false;
            BContracMenu.Visible = true;
            PContenidoUS.Visible = true;

            // Crear un nuevo formulario para el efecto de oscurecimiento
            Point thisLocation = this.Location;
            Point formBGLocation = new Point(thisLocation.X + 200, thisLocation.Y+1);
            formBG = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.70d, // 70% de opacidad
                BackColor = Color.Black,
                // Configurar tamaño y ubicación para que coincida con Bienvenida
                Width = 638-2,
                Height = this.Height-4,
                Location = formBGLocation,
                WindowState = FormWindowState.Normal,
                TopMost = true,
                ShowInTaskbar = false
            };

            // Mostrar el formulario de oscurecimiento
            formBG.Show();
        }

        // Diseño del bordeado del formulario
        private void Bievenida_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.LightGreen;
            int borderWidth = 2;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth);
            }
        }

        // Modificar borde del menú.
        private void PMenuUS_Paint(object sender, PaintEventArgs e)
        {
            // Definir el color y el grosor del borde
            Color borderColor = Color.LightGreen;
            int borderWidth = 1;

            // Obtener el área del panel
            Control panel = sender as Control;
            Rectangle borderRectangle = panel.ClientRectangle;

            // Reducir el tamaño del área para evitar que el borde se dibuje fuera del panel
            borderRectangle.Width -= 1;
            borderRectangle.Height -= 1;

            // Dibujar el borde
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, borderRectangle);
            }
        }
    }
}

