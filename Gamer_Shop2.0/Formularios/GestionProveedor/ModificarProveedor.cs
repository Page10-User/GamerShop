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
using System.Linq;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionProveedor
{
    public partial class ModificarProveedor : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        Proveedor proveedorActual = new Proveedor();
        private List<string> camposActuales = new List<string>(new string[7]);
        public Bienvenida MainForm { get; set; }
        public Panel PanelContainer { get; set; }
        public ModificarProveedor(Proveedor prov)
        {
            NProveedor nProveedor = new NProveedor();
            proveedorActual = nProveedor.GetProveedor(prov.ID_Proveedor);
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Categoría_producto' Puede moverla o quitarla según sea necesario.
            this.categoría_productoTableAdapter.Fill(this.dataSet1.Categoría_producto);
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            TBRazon.Texts = proveedorActual.Razon_social;
            TBRepresentante.Texts = proveedorActual.Nombre_representante;
            TBContacto.Texts = proveedorActual.Telefono;
            TBCorreo.Texts = proveedorActual.Correo;
            TBDireccion.Texts = proveedorActual.Dirección;

            CBActivoProveedor.DropDownWidth = CBActivoProveedor.Width;

            mostrarCategoriaProveedorActual();
            mostrarEstadoProveedorCB();

            guardarCampos();
        }

        private void mostrarCategoriaProveedorActual()
        {
            if (proveedorActual.ID_CategoriaProducto == 1)
            {
                //Optenemos el primer elemento de la tabla Categoria_producto y lo definimos en el .text del ComboBox
                var context = new ProyectoTallerIIEntities1();
                var primerCategoria = context.Categoría_producto
                                             .FirstOrDefault(d => d.ID_Categoria == proveedorActual.ID_CategoriaProducto);

                CBCategoriaPrProveedor.Texts = primerCategoria.Nombre_Categoria;
            }
            else
            {
                CBCategoriaPrProveedor.SelectedValue = proveedorActual.ID_CategoriaProducto;
            }
        }

        private void mostrarEstadoProveedorCB()
        {
            if (proveedorActual.Activo == "SI")
            {
                CBActivoProveedor.SelectedIndex = 0;
            }
            else
            {
                CBActivoProveedor.SelectedIndex = 1;
            }
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

        private void PContInfoModificarProveedor_Paint(object sender, PaintEventArgs e)
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

        private void PEstadoUs_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 15;
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

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            if (comprobarModif(camposActuales) == true)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea volver? Se perderán los cambios realizados", "Volver", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    //Cerramos el mensaje en Hide
                    mensaje.Dispose();
                    MainForm.TopMost = true;

                    // Mostrar form
                    InstanciarYMostrarListaProveedor();
                }
                else
                {
                    mensaje.Dispose();
                    MainForm.TopMost = true;
                }
            }
            else
            {
                InstanciarYMostrarListaProveedor();
            }
        }

        //--------------------------------------------------------InstanciarYMostrarListaProveedor----------------------------------------------------\\
        private void InstanciarYMostrarListaProveedor()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            ListaProveedor formListProveedor = new ListaProveedor();
            formListProveedor.TopLevel = false;
            formListProveedor.PanelContainer = PanelContainer;
            formListProveedor.MainForm = MainForm;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formListProveedor);
            PanelContainer.BringToFront();

            formListProveedor.Show();
        }

        // Validaciónes

        //INICIO Key Press  y Validating TBRazon
        private void TBRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();

            string texto = TBRazon.Texts;

            // Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 35, e.KeyChar))
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

        private void TBRazon_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBRazon.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar Longitud Minima
                if (!validador.ValidarLongitudMinima(texto, 5))
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresLNECE(texto))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                    return;
                }

                // Validar que no sean solo números o caracteres especiales.
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;
                    return;
                }

                // Validar longitud Máxima
                if (!validador.ValidarLongitud(texto, 35))
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;
                    return;
                }
                TBRazon.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        //FIN Key Press  y Validating TBRazon

        //INICIO Key Press  y Validating TBNombreRepresentante
        private void TBRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();

            string texto = TBRepresentante.Texts;

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

        private void TBRepresentante_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBRepresentante.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar longitud minima
                if (!validador.ValidarLongitudMinima(texto, 3))
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = false;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresNombreSinNumeros(texto))
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                    return;
                }

                // Validar que no sean solo números o caracteres especiales.
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
                    TBValidacion7.Visible = true;
                    return;
                }
                TBRepresentante.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        //FIN Key Press  y Validating TBNombreRepresentante

        //INICIO Key Press  y Validating TBTelefono
        private void TBContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContacto.Texts;

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
        private void TBContacto_Enter(object sender, EventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContacto.Texts.Trim();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                TBContacto.Texts = validador.RemoverFormatoTelefonico(texto);
            }
        }
        private void TBContacto_Validating(object sender, CancelEventArgs e)
        {

            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBContacto.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar que solo contenga números
                if (!validador.ValidarCaracteresNumericos(texto))
                {
                    e.Cancel = true;
                    TBValidacion8.Visible = true;
                    return;
                }
                // Validar que la longitud sea exactamente 13 caracteres
                if (!validador.ValidarLongitudExacta(texto, 13))
                {
                    e.Cancel = true;
                    TBValidacion9.Visible = true;
                    return;
                }
                TBContacto.Texts = validador.AplicarFormatoTelefonico(texto);
            }
        }
        //FIN Key Press  y Validating TBTelefono

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
                    TBValidacion10.Visible = true;
                    return;
                }

                // Validar el formato del correo electrónico
                if (!validador.ValidarCorreoElectronico(texto))
                {
                    e.Cancel = true;
                    TBValidacion11.Visible = true;
                    return;
                }
            }
        }
        //FIN Key Press  y Validating TBCorreo

        //INICIO Key Press  y Validating TBDireccion
        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBDireccion.Texts;

            // Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 13, e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar que no se ingresen caracteres no deseados
            if (!validador.ValidarKeyPressDireccion(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBDireccion_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBDireccion.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar Longitud Minima
                if (!validador.ValidarLongitudMinima(texto, 5))
                {
                    e.Cancel = true;
                    TBValidacion12.Visible = true;
                    return;
                }

                // Validar caracteres
                if (!validador.ValidarCaracteresDireccion(texto))
                {
                    e.Cancel = true;
                    TBValidacion13.Visible = true;
                    return;
                }

                // Validar que no sean solo números o caracteres especiales.
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion14.Visible = true;
                    return;
                }

                // Validar longitud Máxima
                if (!validador.ValidarLongitud(texto, 100))
                {
                    e.Cancel = true;
                    TBValidacion15.Visible = true;
                    return;
                }
            }
        }
        //Validar 
        //FIN Key Press  y Validating TBDireccion

        //INICIO Key Press  y Validating CBCategoriaPrProveedor
        private void CBCategoriaPrProveedor_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string seleccion = CBCategoriaPrProveedor.SelectedItem?.ToString();

            OcultarValidaciones();

            if (!validador.ValidarSeleccion(seleccion))
            {
                CBCategoriaPrProveedor.Texts = "Seleccionar...";
                TBValidacion16.Visible = true;
            }
        }
        //FIN Key Press  y Validating CBCategoriaPrProveedor

        //Inicio TextChanged
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }
        //Fin TextChanged

        //Boton modificar + validación de los campos.
        private void BModificarProveedor_Click(object sender, EventArgs e)
        {
            if (TBRazon.Texts != string.Empty && TBRepresentante.Texts != string.Empty && TBCorreo.Texts != string.Empty && TBRazon.Texts != string.Empty && TBDireccion.Texts != string.Empty && TBContacto.Texts != string.Empty && CBActivoProveedor.SelectedIndex > -1)
            {
                if (comprobarModif(camposActuales))
                {
                    try
                    {
                        ClaseValidacion validador = new ClaseValidacion();
                        NProveedor nProveedor = new NProveedor();
                        nProveedor.NModificarProveedor(
                            proveedorActual.Razon_social,
                            TBRazon.Texts,
                            TBRepresentante.Texts,
                            validador.RemoverFormatoTelefonico(TBContacto.Texts),
                            TBCorreo.Texts,
                            TBDireccion.Texts,
                            CBCategoriaPrProveedor.SelectedIndex + 1,
                            CBActivoProveedor.SelectedItem.ToString()
                            );
                        MsgPersonalizado mensaje = new MsgPersonalizado("Proveedor modificado con éxito", "Modificación", "Informacion", null);
                        mensaje.ShowDialog();
                        guardarCampos();
                    }
                    catch (ExisteRegistroException ex)
                    {
                        // Manejo de la excepción cuando el número de serial ya existe
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
                    MsgPersonalizado mensaje = new MsgPersonalizado("Debe realizar almenos un cambio para modificar el proveedor", "Error al Modificar", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para modificar", "Modificar", "Error", generarListaCampos());
                mensaje.ShowDialog();
            }
        }

        //Generamos el listado con los contenidos de cada campo.
        private List<string> generarListaCampos()
        {
            List<string> campos = new List<string>{
                TBRazon.Texts,
                TBRepresentante.Texts,
                TBContacto.Texts,
                TBCorreo.Texts,
                TBDireccion.Texts,
                CBCategoriaPrProveedor.SelectedItem?.ToString(),
                CBActivoProveedor.SelectedItem?.ToString()
             };
            return campos;
        }

        //Agrupamos todas las validaciones y las ocultamos para evitar redundacia.
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
            //<-AltaProducto-Events->\\
            this.Load -= ModificarProveedor_Load;

            //<-Paint-Events->\\
            PContInfoModificarProveedor.Paint -= PContInfoModificarProveedor_Paint;

            //<-Click-Events->\\
            BReturnToBack.Click -= BReturnToBack_Click;
            BModificarProveedor.Click -= BModificarProveedor_Click;

            //<-TextBox-Events->\\
            //TBRazon
            TBRazon.KeyPress -= TBRazon_KeyPress;
            TBRazon.Validating -= TBRazon_Validating;
            TBRazon._TextChanged -= TextBox_TextChanged;
            //TBRepresentante
            TBRepresentante.KeyPress -= TBRepresentante_KeyPress;
            TBRepresentante.Validating -= TBRepresentante_Validating;
            TBRepresentante._TextChanged -= TextBox_TextChanged;
            //TBTelefono
            TBContacto.KeyPress -= TBContacto_KeyPress;
            TBContacto.Validating -= TBContacto_Validating;
            TBContacto.Enter -= TBContacto_Enter;
            TBContacto._TextChanged -= TextBox_TextChanged;
            //TBCorreo
            TBCorreo.KeyPress -= TBCorreo_KeyPress;
            TBCorreo.Validating -= TBCorreo_Validating;
            TBCorreo._TextChanged -= TextBox_TextChanged;
            //TBDirección
            TBDireccion.KeyPress -= TBDireccion_KeyPress;
            TBDireccion.Validating -= TBDireccion_Validating;
            TBDireccion._TextChanged -= TextBox_TextChanged;
            //CBCategoria
            CBCategoriaPrProveedor.Validating -= CBCategoriaPrProveedor_Validating;

            //<-CellClick-Events-\\
            //...\\

            // Liberar los recursos
            base.Dispose();
        }

        private void guardarCampos()
        {
            camposActuales[0] = TBRazon.Texts;
            camposActuales[1] = TBRepresentante.Texts;
            camposActuales[2] = TBContacto.Texts;
            camposActuales[3] = TBCorreo.Texts;
            camposActuales[4] = TBDireccion.Texts;
            camposActuales[5] = CBCategoriaPrProveedor.SelectedIndex.ToString();
            camposActuales[6] = CBActivoProveedor.SelectedIndex.ToString();
        }

        private bool comprobarModif(List<string> campos)
        {
            if (campos[0] != TBRazon.Texts ||
                campos[1] != TBRepresentante.Texts ||
                campos[2] != TBContacto.Texts ||
                campos[3] != TBCorreo.Texts ||
                campos[4] != TBDireccion.Texts ||
                campos[5] != CBCategoriaPrProveedor.SelectedIndex.ToString() ||
                campos[6] != CBActivoProveedor.SelectedIndex.ToString())
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

