using Gamer_Shop2._0.Formularios.BorderClasss;
using Gamer_Shop2._0.Formularios.InterfazUsuarios;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Validacion;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Gamer_Shop2._0
{
    public partial class Form1 : Form
    {
        private int paintCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--UI--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender == PInicio)
            {
                BorderClass rounded = new BorderClass();
                rounded.AplicarBordeRedondeado(PInicio, 30, e.Graphics, Color.Lime, 2);
            }
        }
        //--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--UI--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\

        private void BSalir_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro de que desea cerrar la aplicación?", "Cerrar Aplicación", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Dispose();
                Application.Exit();
            }
            else
            {
                mensaje.Dispose();
            }
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
                if (TBUsuario.Texts == "EmpleadoUser" && TBContrasena.Texts == "12345678")
                {
                    CrearYMostrarBienvenida<EmpleadoOptions>();
                }
                else if (TBUsuario.Texts == "AdministradorUser" && TBContrasena.Texts == "12345678")
                {
                    CrearYMostrarBienvenida<AdministradorOptions>();
                }
                else if (TBUsuario.Texts == "GerenteUser" && TBContrasena.Texts == "12345678")
                {
                    CrearYMostrarBienvenida<GerenteOptions>();
                }
                else
                {
                    MostrarMensajeError("Por favor, ingrese un usuario y contraseña válidos");
                }
            }
            else
            {
                MostrarMensajeError("Por favor, ingrese su usuario y contraseña");
            }
        }

        private void CrearYMostrarBienvenida<T>() where T : UserOptionsBase, new()
        {
            Bienvenida bienvenidaForm = new Bienvenida();
            bienvenidaForm.userOptions = new T();
            bienvenidaForm.Show();
            bienvenidaForm.Forminicio = this;
            this.Hide();
        }

        private void MostrarMensajeError(string mensaje)
        {
            MsgPersonalizado mensajeDialogo = new MsgPersonalizado(mensaje, "Error al Iniciar Sesion", "Error", null);
            mensajeDialogo.ShowDialog();
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
