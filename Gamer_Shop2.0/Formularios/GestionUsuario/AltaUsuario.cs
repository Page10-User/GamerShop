﻿using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    public partial class AltaUsuario : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        public Panel PanelContainer { get; set; }
        public Usuario AUUsuario { get; set; }
        public AltaUsuario()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PContAltaUs_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
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
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BShowListaUs_Click(object sender, EventArgs e)
        {
            InstanciarYMostrarListaUsuario();
        }

        //Validaciones

        //INICIO Key Press  y Validating TBNombreUs
        private void TBNombreUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();

            string texto = TBNombreUs.Texts;

            // Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 35, e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Validar el carácter ingresado
            if (!validador.ValidarKeyPressNombreSinNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBNombreUs_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombreUs.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar longitud minima
                if (!validador.ValidarLongitudMinima(texto, 3))
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresNombreSinNumeros(texto))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                    return;
                }

                // Validar que no sea solamente caracteres especiales
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel= true;
                    TBValidacion18.Visible = true;
                    return;
                }

                // Validar longitud maxima
                if (!validador.ValidarLongitud(texto, 35))
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;
                    return;
                }
                TBNombreUs.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        //FIN Key Press  y Validating TBNombreUs

        //INICIO Key Press  y Validating TBApellidoUs
        private void TBApellidoUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();

            string texto = TBApellidoUs.Texts;

            // Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 35, e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Validar el carácter ingresado
            if (!validador.ValidarKeyPressNombreSinNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBApellidoUs_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBApellidoUs.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar longitud minima
                if (!validador.ValidarLongitudMinima(texto, 3))
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresNombreSinNumeros(texto))
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = true;
                    return;
                }

                // Validar que no sea solamente caracteres especiales
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion19.Visible = true;
                    return;
                }

                // Validar longitud maxima
                if (!validador.ValidarLongitud(texto, 35))
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                    return;
                }
                TBApellidoUs.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        //FIN Key Press  y Validating TBApellidoUs

        //INICIO Key Press y Validating TBCuilUs
        private void TBCuilUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBCuilUs.Texts;

            //Validar caracteres numéricos
            if (!validador.ValidarKeyPressSoloNumeros(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar longitud
            if (!validador.ValidarLongitudConLimite(texto, 11, e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void TBCuilUs_Enter(object sender, EventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBCuilUs.Texts.Trim();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                TBCuilUs.Texts = validador.RemoverFormatoCuil(texto);
            }
        }

        private void TBCuilUs_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBCuilUs.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //Validar caracteres
                if (!validador.ValidarCaracteresNumericos(texto))
                {
                    e.Cancel = true;
                    TBValidacion16.Visible = true;
                    return;
                }

                //Validar longitud
                if (!validador.ValidarLongitudExacta(texto, 11))
                {
                    e.Cancel = true;
                    TBValidacion17.Visible = true;
                }

                TBCuilUs.Texts = validador.AplicarFormatoCuil(texto);
            }
        }
        //FIN Key Press y Validating TBCuilUS

        //INICIO Key Press  y Validating TBUsuarioUs
        private void TBUsuarioUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombreUsuario.Texts;

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
        private void TBUsuarioUs_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombreUsuario.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {

                //Validar longitud minima.
                if (!validador.ValidarLongitudMinima(texto, 7))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                    return;
                }

                //Validar caracteres especiales.
                if (!validador.ValidarCaracteresLNECE(texto))
                {
                    e.Cancel = true;
                    TBValidacion8.Visible = true;
                    return;
                }

                //Validar que no sea solo números o caracteres especiales.
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion9.Visible = true;
                    return;
                }

                //Validar longitud máxima.
                if (!validador.ValidarLongitud(texto, 20))
                {
                    e.Cancel = true;
                    TBValidacion10.Visible = true;
                    return;
                }
            }
        }
        //FIN Key Press  y Validating TBUsuarioUs

        //INICIO Key Press  y Validating TBEmailUs
        private void TBEmailUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBEmailUs.Texts.Trim();

            //Validar longitud
            if (!validador.ValidarLongitudConLimite(texto, 100, e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        private void TBEmailUs_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBEmailUs.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //Validar caracteres especiales
                if (!validador.ValidarCorreoElectronico(texto))
                {
                    e.Cancel = true;
                    TBValidacion11.Visible = true;
                    return;
                }

                //validar longitud maxima
                if (!validador.ValidarLongitud(texto, 100))
                {
                    e.Cancel = true;
                    TBValidacion12.Visible = true;
                }
            }
        }
        //FIN Key Press  y Validating TBEmailUs

        //INICIO Key Press  y Validating TBContraseñaUs
        private void TBContrasenaUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContrasenaUs.Texts;

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
        private void TBContrasenaUs_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContrasenaUs.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //Validar longitud mínima
                if (!validador.ValidarLongitudMinima(texto, 7))
                {
                    e.Cancel = true;
                    TBValidacion13.Visible = true;
                    return;
                }

                //Validar caracteres especiales
                if (!validador.ValidarCaracteresLNECE(texto))
                {
                    e.Cancel = true;
                    TBValidacion14.Visible = true;
                    return;
                }

                //Validar longitud máxima
                if (!validador.ValidarLongitud(texto, 20))
                {
                    e.Cancel = true;
                    TBValidacion15.Visible = true;
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

        private void BRegistrarUs_Click(object sender, EventArgs e)
        {
            if (TBNombreUs.Texts != string.Empty && TBApellidoUs.Texts != string.Empty && TBCuilUs.Texts != string.Empty && TBNombreUsuario.Texts != string.Empty && TBContrasenaUs.Texts != string.Empty && TBEmailUs.Texts != string.Empty)
            {
                try
                {
                    ClaseValidacion validador = new ClaseValidacion();
                    string filePath = "";
                    NUsuario usuario = new NUsuario();
                    usuario.NAgregarUsuario(
                        
                        TBNombreUs.Texts,
                        TBApellidoUs.Texts,
                        validador.RemoverFormatoCuil(TBCuilUs.Texts),
                        TBNombreUsuario.Texts,
                        TBContrasenaUs.Texts,
                        TBEmailUs.Texts,
                        1,
                        filePath
                        );
                    MsgPersonalizado mensaje = new MsgPersonalizado("Usuario registrado con éxito", "Registro", "Informacion", null);
                    mensaje.ShowDialog();
                }
                catch (ExisteRegistroException ex)
                {
                    // Manejo de la excepción cuando el número de serial no existe
                    MsgPersonalizado mensaje = new MsgPersonalizado(ex.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
                catch (Exception ex)
                {
                    // Manejo de cualquier otra excepción
                    MsgPersonalizado mensaje = new MsgPersonalizado(ex.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para registrar un usuario", "Error", "Error", generarListaCampos());
                mensaje.ShowDialog();
            }
        }

        //------------------------------------------------------------------------------------InstanciarListaUsuario-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarListaUsuario()
        {
            Control control = PanelContainer.Controls[0];
             if (control is Form)
             {
                 //Liberamos recursos
                 control.Dispose();
             }
             // Crear una nueva instancia de ListaProductos
             ListaUsuario listUs = new ListaUsuario();
             listUs.TopLevel = false;

             // Limpiar el panel actual y añadir el nuevo formulario
             PanelContainer.Controls.Clear();
             listUs.LUsuario = AUUsuario;
             PanelContainer.Controls.Add(listUs);
             listUs.PanelContainer = PanelContainer;
             listUs.Show();
             this.Dispose();
        }
        private List<string> generarListaCampos()
        {
            List<string> campos = new List<string>{
                TBNombreUs.Texts,
                TBApellidoUs.Texts,
                TBCuilUs.Texts,
                TBNombreUsuario.Texts,
                TBEmailUs.Texts,
                TBContrasenaUs.Texts,
             };
            return campos;
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
            TBValidacion8.Visible = false;
            TBValidacion9.Visible = false;
            TBValidacion10.Visible = false;
            TBValidacion11.Visible = false;
            TBValidacion12.Visible = false;
            TBValidacion13.Visible = false;
            TBValidacion14.Visible = false;
            TBValidacion15.Visible = false;
            TBValidacion16.Visible = false;
            TBValidacion17.Visible = false;
            TBValidacion18.Visible = false;
            TBValidacion19.Visible = false;
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= AltaUsuario_Load;
            PContAltaUs.Paint -= PContAltaUs_Paint;
            TBNombreUs.KeyPress -= TBNombreUs_KeyPress;
            TBNombreUs.Validating -= TBNombreUs_Validating;
            TBApellidoUs.KeyPress -= TBApellidoUs_KeyPress;
            TBApellidoUs.Validating -= TBApellidoUs_Validating;
            TBCuilUs.KeyPress -= TBCuilUs_KeyPress;
            TBCuilUs.Enter -= TBCuilUs_Enter;
            TBCuilUs.Validating -= TBCuilUs_Validating;
            TBNombreUsuario.KeyPress -= TBNombreUs_KeyPress;
            TBNombreUsuario.Validating -= TBNombreUs_Validating;
            TBEmailUs.KeyPress -= TBEmailUs_KeyPress;
            TBEmailUs.Validating -= TBEmailUs_Validating;
            TBContrasenaUs.KeyPress -= TBContrasenaUs_KeyPress;
            TBContrasenaUs.Validating -= TBContrasenaUs_Validating;
            TBNombreUs._TextChanged -= TextBox_TextChanged;
            TBApellidoUs._TextChanged -= TextBox_TextChanged;
            TBNombreUsuario._TextChanged -= TextBox_TextChanged;
            TBEmailUs._TextChanged -= TextBox_TextChanged;
            TBContrasenaUs._TextChanged -= TextBox_TextChanged;
            BRegistrarUs.Click -= BRegistrarUs_Click;
            BShowListaUs.Click -= BShowListaUs_Click;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
