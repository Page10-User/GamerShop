using Gamer_Shop2._0.Formularios.InterfazUsuarios;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.RJControls;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gamer_Shop2._0
{
    public partial class Form1 : Form
    {
        Bienvenida existeBienvenida {  get; set; }

        Bienvenida bienvenida;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.PInicio.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 60;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();

                
                panel.Region = new Region(path);

                
                using (Pen pen = new Pen(Color.Green, 5))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Green;
            int borderWidth = 1;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth);
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Validating

        //INICIO Key Press  y Validating TBUsuarioUs
        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBUsuario.Texts;

            //Validar longitud
            if (!validador.ValidarLongitudConLimite(texto, 20, e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar que no se ingresen caracteres no deseados
            if (!validador.ValidarKeyPressLNECE(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBUsuario_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBUsuario.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {

                //Validar longitud minima.
                if (!validador.ValidarLongitudMinima(texto, 7))
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;
                    return;
                }

                //Validar caracteres especiales.
                if (!validador.ValidarCaracteresLNECE(texto))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                    return;
                }

                //Validar que no sea solo números o caracteres especiales.
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;
                    return;
                }

                //Validar longitud máxima.
                if (!validador.ValidarLongitud(texto, 20))
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;
                    return;
                }
            }
        }
        //FIN Key Press  y Validating TBUsuarioUs

        //INICIO Key Press  y Validating TBContraseñaUs
        private void TBContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContrasena.Texts;

            //Validar que no se ingresen caracteres no deseados
            if (!validador.ValidarKeyPressLNECE(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar longitud
            if (!validador.ValidarLongitudConLimite(texto, 20, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBContrasena_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContrasena.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //Validar longitud mínima
                if (!validador.ValidarLongitudMinima(texto, 7))
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = true;
                    return;
                }

                //Validar caracteres especiales
                if (!validador.ValidarCaracteresLNECE(texto))
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                    return;
                }

                //Validar longitud máxima
                if (!validador.ValidarLongitud(texto, 20))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                    return;
                }
            }
        }
        //FIN Key Press  y Validating TBContraseñaUs

        //Inicio TextChanged
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }
        //Fin TextChanged

        private void BIniciar_Click(object sender, EventArgs e)
        {
            if (TBUsuario.Texts != string.Empty && TBContrasena.Texts != string.Empty)
            {
                MostrarOInstanciarBienvenidaCS();

                if (TBUsuario.Texts == "EmpleadoUser" && TBContrasena.Texts == "12345678")
                {
                    EmpleadoOptions userOptions = new EmpleadoOptions();
                    bienvenida.userOptions = userOptions;
                    bienvenida.Show();
                    bienvenida.Forminicio = this;
                    this.Hide();
                }
                else if (TBUsuario.Texts == "AdministradorUser" && TBContrasena.Texts == "12345678")
                {
                    AdministradorOptions userOptions = new AdministradorOptions();
                    bienvenida.userOptions = userOptions;
                    bienvenida.Show();
                    bienvenida.Forminicio = this;
                    this.Hide();
                }
                else if (TBUsuario.Texts == "GerenteUser" && TBContrasena.Texts == "12345678")
                {
                    GerenteOptions userOptions = new GerenteOptions();
                    bienvenida.userOptions = userOptions;
                    bienvenida.Show();
                    bienvenida.Forminicio = this;
                    this.Hide();
                }
                else
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese un usuario y contraseña válidos", "Error al Iniciar Sesion", "Informacion", null);
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese su usuario y contraseña", "Error al Iniciar Sesion", "Error", null);
                mensaje.ShowDialog();
            }
        }
        private void MostrarOInstanciarBienvenidaCS()
        {
            if (existeBienvenida == null)
            {
                Bienvenida bienvenidaForm = new Bienvenida();
                bienvenida = bienvenidaForm;
            }
        }

        //Eliminar más adelante...
        private void Form1_Load(object sender, EventArgs e)
        {
            TBUsuario.Texts = "AdministradorUser";
            TBContrasena.Texts = "12345678";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar al evento del botón Iniciar
                BIniciar_Click(sender, e);
            }
        }

        private void OcultarValidaciones()
        {
            TBValidacion.Visible = false;
            TBValidacion2.Visible = false;
            TBValidacion3.Visible = false;
            TBValidacion4.Visible = false;
            TBValidacion5.Visible = false;
            TBValidacion6.Visible = false;
            TBValidacion7.Visible = false;
        }
    }
}
