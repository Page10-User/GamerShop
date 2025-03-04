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

namespace Gamer_Shop2._0.Formularios.GestionCliente
{
    public partial class ModificarCliente : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        Cliente clienteActual = new Cliente();
        private List<string> camposActuales = new List<string>(new string[4]);

        public Panel PanelContainer { get; set; }
        public ModificarCliente(Cliente cliente)
        {
            InitializeComponent();
            NCliente ncliente = new NCliente();
            clienteActual = ncliente.GetCliente(cliente.DNI);
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PContModificarCl_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.Lime, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            TBNombre.Texts = clienteActual.Nombre;
            TBApellido.Texts = clienteActual.Apellido;
            TBTelefono.Texts = validador.AplicarFormatoTelefonico(clienteActual.Teléfono);
            TBCorreo.Texts = clienteActual.Correo;

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
            using (Pen pen = new Pen(Color.Lime, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            if (comprobarModif(camposActuales) == true)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea volver? Se perderán los cambios realizados", "Volver", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    mensaje.Dispose();

                    // Crear una nueva instancia de ListaCLiente
                    InstanciarYMostrarListaCliente();
                }
                else
                {
                    mensaje.Dispose();
                }
            }
            else
            {
                // Mostramos la lista de clientes
                InstanciarYMostrarListaCliente();
            }
        }
        //--------------------------------------------------------InstanciarYMostrarListaCliente----------------------------------------------------\\
        private void InstanciarYMostrarListaCliente()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            ListaCliente listCl = new ListaCliente();
            listCl.TopLevel = false;

            // Limpiar el panel actual y volver al anterior formulario.
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(listCl);
            listCl.PanelContainer = PanelContainer;
            listCl.Show();
            this.Dispose();
        }

        //Validaciones

        //INICIO Key Press  y Validating TBNombre
        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();

            string texto = TBNombre.Texts;

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

        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombre.Texts.Trim();

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

                // Validar que no sea unicamente caracteres especiales
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion11.Visible = true;
                    return;
                }

                // Validar longitud maxima
                if (!validador.ValidarLongitud(texto, 35))
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;
                    return;
                }
                TBNombre.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        //FIN Key Press  y Validating TBNombre
        //---------------------------------------------------------------------------------------------\\
        //INICIO Key Press  y Validating TBApellido
        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBApellido.Texts;

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
        private void TBApellido_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBApellido.Texts.Trim();

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

                // Validar que no sea unicamente caracteres especiales
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion12.Visible = true;
                    return;
                }

                // Validar longitud maxima
                if (!validador.ValidarLongitud(texto, 35))
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                    return;
                }
                TBApellido.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        //FIN Key Press  y Validating TBApellido
        //---------------------------------------------------------------------------------------------\\
        //INICIO Key Press  y Validating TBTelefono
        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBTelefono.Texts;

            // Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 13, e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            // Validar que solo se ingresen números
            if (!validador.ValidarKeyPressSoloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Función para quitar el formato del teléfono para editar.
        private void TBTelefono_Enter(object sender, EventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBTelefono.Texts.Trim();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                TBTelefono.Texts = validador.RemoverFormatoTelefonico(texto);
            }
        }
        private void TBTelefono_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBTelefono.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar que solo contenga números
                if (!validador.ValidarCaracteresNumericos(texto))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                    return;
                }
                // Validar que la longitud sea exactamente 13 caracteres
                if (!validador.ValidarLongitudExacta(texto, 13))
                {
                    e.Cancel = true;
                    TBValidacion8.Visible = true;
                    return;
                }
                TBTelefono.Texts = validador.AplicarFormatoTelefonico(texto);
            }
        }
        //FIN Key Press  y Validating TBTelefono
        //---------------------------------------------------------------------------------------------\\
        //INICIO Key Press  y Validating TBCorreo
        private void TBCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBCorreo.Texts;

            // Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 100, e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBCorreo.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //validar longitud del correo elctrónico
                if (!validador.ValidarLongitud(texto, 100))
                {
                    e.Cancel = true;
                    TBValidacion9.Visible = true;
                    return;
                }

                // Validar el formato del correo electrónico
                if (!validador.ValidarCorreoElectronico(texto))
                {
                    e.Cancel = true;
                    TBValidacion10.Visible = true;
                    return;
                }
            }
        }
        //FIN Key Press  y Validating TBCorreo
        //---------------------------------------------------------------------------------------------\\

        //Inicio TextChanged
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }
        //Fin TextChanged

        private void BModificarUs_Click(object sender, EventArgs e)
        {
            if (TBNombre.Texts != string.Empty && TBApellido.Texts != string.Empty && TBTelefono.Texts != string.Empty && TBCorreo.Texts != string.Empty)
            {
                if (comprobarModif(camposActuales))
                {
                    try
                    {
                        ClaseValidacion validador = new ClaseValidacion();
                        NCliente cliente = new NCliente();
                        cliente.NModificarCliente(
                             clienteActual.DNI,
                             TBNombre.Texts,
                             TBApellido.Texts,
                             validador.RemoverFormatoTelefonico(TBTelefono.Texts),
                             TBCorreo.Texts
                             );
                        MsgPersonalizado mensaje = new MsgPersonalizado("Clieente modificado con éxito", "Modificación", "Informacion", null);
                        mensaje.ShowDialog();
                        guardarCampos();
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
                    MsgPersonalizado mensaje = new MsgPersonalizado("Debe realizar almenos un cambio para modificar el Cliente", "Error al Modificar", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para modificar un cliente", "Error", "Error", generarListaCampos());
                mensaje.ShowDialog();
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
            TBValidacion8.Visible = false;
            TBValidacion9.Visible = false;
            TBValidacion10.Visible = false;
            TBValidacion11.Visible = false;
            TBValidacion12.Visible = false;
        }

        private List<string> generarListaCampos()
        {
            List<string> campos = new List<string>{
                TBNombre.Texts,
                TBApellido.Texts,
                TBTelefono.Texts,
                TBCorreo.Texts,
             };
            return campos;
        }

        private void guardarCampos()
        {
            camposActuales[0] = TBNombre.Texts;
            camposActuales[1] = TBApellido.Texts;
            camposActuales[2] = TBTelefono.Texts;
            camposActuales[3] = TBCorreo.Texts;
        }

        private bool comprobarModif(List<string> campos)
        {
            if (campos[0] != TBNombre.Texts ||
                campos[1] != TBApellido.Texts ||
                campos[2] != TBTelefono.Texts ||
                campos[3] != TBCorreo.Texts)
            {
                return true; // Hay modificación
            }
            else
            {
                return false; // No hay modificación
            }
        }
        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-AltaProducto-Events->\\
            this.Load -= ModificarCliente_Load;

            //<-Paint-Events->\\
            PContModificarCl.Paint -= PContModificarCl_Paint;

            //<-Click-Events->\\
            BReturnToBack.Click -= BReturnToBack_Click;
            BModificarCl.Click -= BModificarUs_Click;

            //<-TextBox-Events->\\
            //TBNombreCl
            TBNombre.KeyPress -= TBNombre_KeyPress;
            TBNombre.Validating -= TBNombre_Validating;
            TBNombre._TextChanged -= TextBox_TextChanged;
            //TBApellidoCl
            TBApellido.KeyPress -= TBApellido_KeyPress;
            TBApellido.Validating -= TBApellido_Validating;
            TBApellido._TextChanged -= TextBox_TextChanged;
            //TBTeléfono
            TBTelefono.KeyPress -= TBTelefono_KeyPress;
            TBTelefono.Validating -= TBTelefono_Validating;
            TBTelefono._TextChanged -= TextBox_TextChanged;
            //TBCorreo
            TBCorreo.KeyPress -= TBCorreo_KeyPress;
            TBCorreo.Validating -= TBCorreo_Validating;
            TBCorreo._TextChanged -= TextBox_TextChanged;

            //<-CellClick-Events-\\
            //...\\

            // Liberar los recursos
            base.Dispose();
        }
    }
}
