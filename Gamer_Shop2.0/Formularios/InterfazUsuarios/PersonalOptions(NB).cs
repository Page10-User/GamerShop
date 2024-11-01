using Gamer_Shop2._0.Formularios.GestionBackups;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class PersonalOptions_NB_ : Form
    {
        private int borderRadius = 30; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        public Form1 Forminicio {  get; set; }
        public Panel PanelContainer { get; set; }
        public Bienvenida Mainform { get; set; }
        public Form FondoOscuroCat {  get; set; }
        public UserOptionsBase Menu { get; set; }
        public Usuario PUsuario { get; set; }
        public PersonalOptions_NB_()
        {
            InitializeComponent();
        }

        private void PersonalOptions_Load(object sender, EventArgs e)
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
            using (Pen pen = new Pen(Color.Lime, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea cerrar sesion?", "Cerrar Sesión", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();
            if (result == DialogResult.Yes)
            {
                //Cerramos el mensaje que está en Hide.
                mensaje.Dispose();

                //Cerrar sesion
                CerrarSesion(sender, e);

                //Mostramos el mensaje de éxito
                mensaje = new MsgPersonalizado("Sesion cerrada con éxito", "Sesion Finalizada", "Informacion", null);
                mensaje.ShowDialog();
            }
            else
            {
                mensaje.Dispose();

                Mainform.TopMost = true;

                //Cerrar el menú tras elegír una opción
                Mainform.BContracMenu_Click(sender, e);
            }
        }

        private void BMiPerfil_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            Mainform.BContracMenu_Click(sender, e);

            //Cerramos el fondoOscuroCatalogo en caso de existir.
            CloseFondoCatalogo();

            // Crear una nueva instancia de EditarPerfil
            InstanciarYMostrarEditarPerfil();
        }
        //------------------------------------------------------------------------------------InstanciarEditarPerfil-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarEditarPerfil()
        {
            Control control = PanelContainer.Controls[0];
            if (control is EditarPerfil)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Crear una nueva instancia de EditarPerfil
                EditarPerfil editarPerfil = new EditarPerfil(PUsuario);
                editarPerfil.TopLevel = false;

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(editarPerfil);
                //editarPerfil.PanelContainer = PanelContainer;
                Mainform.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                editarPerfil.Show();
                this.Dispose();
            }
        }
        //------------------------------------------------------------------------------------Cerrar Sesión-------------------------------------------------------------------------------\\
        private void CerrarSesion(Object sender, EventArgs e)
        {
            //Cerramos el fondo del catálogo en caso de existir.
            CloseFondoCatalogo();

            //Mostramos el form de inicio
            Forminicio.Show();

            //Ejecutamos el MenuContract
            Mainform.BContracMenu_Click(sender, e);

            //Liberamos memoria
            this.Dispose();
            Menu.Dispose();
            Mainform.Dispose();
        }
        private void CloseFondoCatalogo()
        {
            if(FondoOscuroCat is Form)
            {
                FondoOscuroCat.Dispose();
                Mainform.FondoOscuroCatalogo = null;
            }
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BMiPerfil.Click -= BMiPerfil_Click;
            BCerrarSesion.Click -= BCerrarSesion_Click;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
