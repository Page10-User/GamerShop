using Gamer_Shop2._0.Formularios;
using Gamer_Shop2._0.Formularios.Inicio;
using Gamer_Shop2._0.Formularios.InterfazUsuarios;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0
{

    public partial class Bienvenida : Form
    {
        // Menú expandido bool
        bool isExpanded = false;
        private Form formBG;

        //Options definido globalmente para mejor manejo.
        private AdministradorOptions userOptions;

        //Panel Poptions del Menu (A)
        public PersonalOptions PersonalOps { get; set; }
        //Panel Poptions del Menu (E,G)
        public PersonalOptions_NB_ PersonalOpsNB { get; set; }

        //Botones Proveedor y Compra del Menu (temas visuales).
        public Button botonCompra {  get; set; }
        public Button botonProveedor {  get; set; }

        public bool isExpandedOpts { get; set; }

        public Bienvenida()
        {
            InitializeComponent();
            this.Load += new EventHandler(Bienvenida_Load);
            this.Paint += new PaintEventHandler(Bievenida_Paint);
            PMenuUS.Paint += new PaintEventHandler(PMenuUS_Paint);
            userOptions = new AdministradorOptions();
            userOptions.MainForm = this;
            userOptions.PanelContainer = PShowOptions;
            userOptions.LabelContainer = LVersion;
            userOptions.TopLevel = false;
        }

        private void PFondoBienvenida_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 90;
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

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            //Configurando visualización ideal.
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Location = new Point(12, 38);
            BContracMenu.BringToFront();

            //Cargar detalles de inicio.
            // Crear una nueva instancia de ListaProductos
            InicioDetalle inicioD = new InicioDetalle();
            inicioD.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PShowOptions.Controls.Clear();
            PShowOptions.Controls.Add(inicioD);
            inicioD.Show();
            inicioD.Location = new Point(50, 130);
        }

        // Función botón Exit
        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botón contraer Menú.
        public void BContracMenu_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Visible = true;
            BContracMenu.Visible = false;
            PEBorde.Visible = true;
            formBG.Close();

            // Ocultar contenido del menú.
            userOptions.Visible = false;

            if (isExpandedOpts)
            {
                bool isExpnd = false;
                if (userOptions is AdministradorOptions)
                {
                    //Cerramos la configuración personal (Admin).
                    PersonalOps.SendToBack();
                    PersonalOps.Close();

                    //Posicionamos los botones de compra y proveedor.
                    botonCompra.BringToFront();
                    botonProveedor.BringToFront();
                    userOptions.isExpandedOps = isExpnd;
                }
                else
                {
                    //Cerramos la configuración personal (Empleado y Gerente).
                    PersonalOps.SendToBack();
                    PersonalOpsNB.Close();
                    userOptions.isExpandedOps = isExpnd;
                }
            }
        }

        // Botón expandir Menú.
        private void BExpandMenu_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            PMenuUS.Location = new Point(0, 0);
            PMenuUS.BringToFront();
            PAddB.BringToFront();
            BExpandMenu.Visible = false;
            BContracMenu.Visible = true;
            PEBorde.Visible = false;

            // Crear un nuevo formulario para el efecto de oscurecimiento
            Point thisLocation = this.Location;
            Point formBGLocation = new Point(thisLocation.X + 200, thisLocation.Y + 1);
            formBG = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.70d, // 70% de opacidad
                BackColor = Color.Black,
                Width = 638 - 2,
                Height = this.Height - 4,
                Location = formBGLocation,
                WindowState = FormWindowState.Normal,
                TopMost = true,
                ShowInTaskbar = false
            };

            // Mostrar el formulario de oscurecimiento
            formBG.Show();

            // Cargar contenido del menú.
            PMenuUS.Controls.Add(userOptions);
            userOptions.Location = new Point(0, 1);
            userOptions.Visible = true;
        }

        // Diseño del bordeado del formulario
        private void Bievenida_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.LightGreen;
            int borderWidth = 1;

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

