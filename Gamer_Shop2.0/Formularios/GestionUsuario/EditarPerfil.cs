﻿using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.RJControls;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    public partial class EditarPerfil : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        Usuario usuarioActual = new Usuario();
        string nombreImagen;
        private List<string> camposActuales = new List<string>(new string[6]);

        public EditarPerfil(Usuario user)
        {
            InitializeComponent();
            NUsuario usuario = new NUsuario();
            usuarioActual = usuario.GetUsuario(user.CUIL); //arreglar
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PContModificarPerfil_Paint(object sender, PaintEventArgs e)
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

        private void PContImgPerfil_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 20;
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
        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            TBNombreUs.Texts = usuarioActual.Nombre;
            TBApellidoUs.Texts = usuarioActual.Apellido;
            TBNombreUsuario.Texts = usuarioActual.Nombre_usuario;
            TBEmailUs.Texts = usuarioActual.Correo;
            TBContrasenaUs.Texts = usuarioActual.Contraseña;
            if (usuarioActual.photoFilePath != null && usuarioActual.photoFilePath != string.Empty)
            {
                string imagePath = Path.Combine(Application.StartupPath, "uploads", usuarioActual.photoFilePath);
                PBImagenPerfil.Image = Image.FromFile(imagePath);
                PBImagenPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                nombreImagen = usuarioActual.photoFilePath;
            }
            guardarCampos();
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
                    TBValidacion.Visible = false;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresNombreSinNumeros(texto))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                    return;
                }

                // Validar que no sea únicamente caracteres especiales
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion16.Visible = true;
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
                    TBValidacion4.Visible = false;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresNombreSinNumeros(texto))
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = true;
                    return;
                }

                // Validar que no sea únicamente caracteres especiales
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion17.Visible = true;
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

        //INICIO Key Press  y Validating TBUsuarioUs
        private void TBUsuarioUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombreUsuario.Texts;

            //Validar longitud
            if(!validador.ValidarLongitudConLimite(texto, 20, e.KeyChar))
            {
                e.Handled = true;
                TBValidacion.Visible = true;
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
                    e.Cancel= true;
                    TBValidacion11.Visible = true;
                    return;
                }

                //validar longitud maxima
                if (!validador.ValidarLongitud(texto,100))
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
                e.Handled= true;
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
                    e.Cancel= true;
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

        //Lanzamiento de los eventos para cambiar la imagen y nombre.
        public event EventHandler<string> CambiarImagenPerfil; //Evento para cambiar la imagen
        public event EventHandler<string> CambiarNombrePerfil; //Evento para cambiar el nombre

        private void BModificarPerfil_Click(object sender, EventArgs e)
        {
            if (comprobarModif(camposActuales))
            {
                if (TBNombreUs.Texts != string.Empty && TBApellidoUs.Texts != string.Empty && TBNombreUsuario.Texts != string.Empty && TBContrasenaUs.Texts != string.Empty && TBEmailUs.Texts != string.Empty)
                {
                    try
                    {
                        NUsuario usuario = new NUsuario();
                        usuario.NModificarPerfil(
                            TBNombreUs.Texts,
                            TBApellidoUs.Texts,
                            TBNombreUsuario.Texts,
                            TBContrasenaUs.Texts,
                            TBEmailUs.Texts,
                            nombreImagen,
                            usuarioActual.CUIL
                            );
                        MsgPersonalizado mensaje = new MsgPersonalizado("Perfil editado con éxito", "Editado", "Informacion", null);
                        mensaje.ShowDialog();
                        guardarCampos();
                        CambiarImagenPerfil?.Invoke(this, nombreImagen);
                        CambiarNombrePerfil?.Invoke(this, TBNombreUs.Texts);
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
                    MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para editar tu perfil", "Error", "Error", generarListaCampos());
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("No hubo modificaciones", "No Modificado", "Informacion", null);
                mensaje.ShowDialog();
            }
        }


        private List<string> generarListaCampos()
        {
            List<string> campos = new List<string>{
                TBNombreUs.Texts,
                TBApellidoUs.Texts,
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
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= EditarPerfil_Load;
            PContModificarPerfil.Paint -= PContModificarPerfil_Paint;
            PContImgPerfil.Paint -= PContImgPerfil_Paint;
            TBNombreUs.KeyPress -= TBNombreUs_KeyPress;
            TBNombreUs.Validating -= TBNombreUs_Validating;
            TBApellidoUs.KeyPress -= TBApellidoUs_KeyPress;
            TBApellidoUs.Validating -= TBApellidoUs_Validating;
            TBNombreUsuario.KeyPress -= TBNombreUs_KeyPress;
            TBNombreUsuario.Validating -= TBNombreUs_Validating;
            TBEmailUs.KeyPress -= TBEmailUs_KeyPress;
            TBEmailUs.Validating += TBEmailUs_Validating;
            TBContrasenaUs.KeyPress -= TBContrasenaUs_KeyPress;
            TBContrasenaUs.Validating -= TBContrasenaUs_Validating;
            TBNombreUs._TextChanged -= TextBox_TextChanged;
            TBApellidoUs._TextChanged -= TextBox_TextChanged;
            TBNombreUsuario._TextChanged -= TextBox_TextChanged;
            TBEmailUs._TextChanged -= TextBox_TextChanged;
            TBContrasenaUs._TextChanged -= TextBox_TextChanged;

            // Liberar los recursos
            base.Dispose();
        }

        private void BModificarFotoPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Seleccione una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                
                // Genera un nombre único para la imagen
                nombreImagen = Guid.NewGuid().ToString() + Path.GetExtension(sourceFilePath);

                // Ruta de destino en tu proyecto (por ejemplo, en una carpeta 'uploads' en la misma ruta de ejecución)
                string destinationPath = Path.Combine(Application.StartupPath, "uploads", nombreImagen);

                // Asegúrate de que la carpeta de destino existe
                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));

                // Copia la imagen a la carpeta de destino
                File.Copy(sourceFilePath, destinationPath, true);
                if (nombreImagen != null)
                {
                    string imagePath = Path.Combine(Application.StartupPath, "uploads", nombreImagen);
                    PBImagenPerfil.Image = Image.FromFile(imagePath);
                    PBImagenPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void guardarCampos()
        {
            camposActuales[0] = TBNombreUs.Texts;
            camposActuales[1] = TBApellidoUs.Texts;
            camposActuales[2] = TBNombreUsuario.Texts;
            camposActuales[3] = TBEmailUs.Texts;
            camposActuales[4] = TBContrasenaUs.Texts;
            camposActuales[5] = nombreImagen;
        }

        private bool comprobarModif(List<string> campos)
        {
            if (campos[0] != TBNombreUs.Texts ||
                campos[1] != TBApellidoUs.Texts ||
                campos[2] != TBNombreUsuario.Texts ||
                campos[3] != TBEmailUs.Texts ||
                campos[4] != TBContrasenaUs.Texts ||
                campos[5] != nombreImagen)
            {
                return true; // Hay modificación
            }
            else
            {
                return false; // No hay modificación
            }
        }
    }
}
