using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    public partial class ModificarProducto : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado

        private int borderWidth = 5; // Grosor del borde

        Producto productoActual = new Producto();

        string nombreImagen;

        private List<string> camposActuales = new List<string>(new string[8]);
        public Panel PanelContainer { get; set; }

        public Usuario MUsuario { get; set; }
        public ModificarProducto(Producto prod)
        {
            InitializeComponent();
            
            NProducto producto = new NProducto();
            
            productoActual = producto.GetProducto(prod.Serial);
            this.Padding = new Padding(borderWidth);
        }

        private void PContModificarPr_Paint(object sender, PaintEventArgs e)
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

        public void cargarProveedores()
        {
            NProveedor nprov = new NProveedor();

            CBProveedorPr.DataSource = nprov.getProveedoresActivos();
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

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Categoría_producto' Puede moverla o quitarla según sea necesario.
            this.categoría_productoTableAdapter.Fill(this.dataSet1.Categoría_producto);
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            TBNombrePr.Texts = productoActual.Nombre;
            TBSerialPr.Texts = productoActual.Serial.ToString();
            TBDescripcionPr.Texts = productoActual.Descripcion;
            TBPrecioPr.Texts = productoActual.Precio.ToString();
        
            rjTextBox1.Texts = productoActual.photoFilePath;

            CBActivoPr.DropDownWidth = CBActivoPr.Width;

            cargarProveedores();
            mostrarCategoriaProveedorActual();
            mostrarCategoriaProductoActual();
            mostrarEstadoProveedorCB();
            guardarCampos();
        }

        private void mostrarCategoriaProveedorActual()
        {
            if (productoActual.ID_Proveedor == 1)
            {
                //Optenemos el primer elemento de la tabla Categoria_producto y lo definimos en el .text del ComboBox
                var context = new ProyectoTallerIIEntities1();
                var primerProveedor = context.Proveedor
                                             .FirstOrDefault(d => d.ID_Proveedor == productoActual.ID_Proveedor);

                CBProveedorPr.Texts = primerProveedor.Razon_social;
            }
            else
            {
                CBProveedorPr.SelectedIndex = productoActual.ID_Proveedor - 1;
            }
        }

        private void mostrarCategoriaProductoActual()
        {
            if (productoActual.ID_Categoria == 1)
            {
                //Optenemos el primer elemento de la tabla Categoria_producto y lo definimos en el .text del ComboBox
                var context = new ProyectoTallerIIEntities1();
                var primerProveedor = context.Categoría_producto
                                             .FirstOrDefault(d => d.ID_Categoria == productoActual.ID_Categoria);

                CBCategoriaPr.Texts = primerProveedor.Nombre_Categoria;
            }
            else
            {
                CBCategoriaPr.SelectedValue = productoActual.ID_Categoria;
            }
        }

        private void mostrarEstadoProveedorCB()
        {
            if (productoActual.Activo == "SI")
            {
                CBActivoPr.SelectedIndex = 0;
            }
            else
            {
                CBActivoPr.SelectedIndex = 1;
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

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            if (comprobarModif(camposActuales) == true)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea volver? Se perderán los cambios realizados", "Volver", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    // Cerramos el mensaje oculto.
                    mensaje.Dispose();

                    // Mostramos la lista de productos
                    InstanciarYMostrarListaProducto();
                }
                else
                {
                    mensaje.Dispose();
                }
            }
            else
            {
                // Mostramos la lista de productos
                InstanciarYMostrarListaProducto();
            }
        }

        //--------------------------------------------------------InstanciarYMostrarListaProducto----------------------------------------------------\\
        private void InstanciarYMostrarListaProducto()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }
            // Crear una nueva instancia de ListaProductos
            ListaProductos listPr = new ListaProductos();
            listPr.TopLevel = false;

            // Limpiar el panel actual y volver al anterior formulario.
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(listPr);
            listPr.PanelContainer = PanelContainer;
            listPr.LUsuario = MUsuario;
            listPr.Show();
            this.Dispose();
        }

        // Validaciones

        // INICIO Validacion TBNombrePr
        private void TBNombrePr_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombrePr.Text;

            //Validar caracteres
            if (!validador.ValidarKeyPressNombreProducto(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 100, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBNombrePr_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBNombrePr.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar longitud minima
                if (!validador.ValidarLongitudMinima(texto, 2))
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;
                    return;
                }

                // Validar que no sea solo caracteres especiales ni números
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                    return;
                }

                // validar caracteres especiales
                if (!validador.ValidarNombreProducto(texto))
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;
                    return;
                }

                // Validar longitud máxima
                if (!validador.ValidarLongitud(texto, 100))
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;
                }
                TBNombrePr.Texts = validador.MayusculaPrimeraLetra(texto);
            }
        }
        // FIN Validacion TBNombrePr

        // INICIO Validacion TBSerialPr
        private void TBSerialPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBSerialPr.Texts;

            //Validar que solo se ingresen números
            if (!validador.ValidarKeyPressSoloNumeros(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar longitud
            if (!validador.ValidarLongitudConLimite(texto, 9, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBSerialPr_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBSerialPr.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //Validar longitud minima.
                if (!validador.ValidarLongitudMinima(texto, 7))
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = true;
                    return;
                }

                //Validar caracteres.
                if (!validador.ValidarCaracteresNumericos(texto))
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                    return;
                }

                //Validar longitud máxima.
                if (!validador.ValidarLongitud(texto, 15))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                }
            }
        }
        // FIN Validacion TBSerialPr

        // INICIO Validacion TBPrecioPr
        private void TBPrecioPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBPrecioPr.Texts;

            //Validar que solo se ingresen números "y 1 coma"
            if (!validador.ValidarKeyPressSoloNumericosFloat(e.KeyChar, texto))
            {
                e.Handled = true;
                return;
            }

            //Validar longitud
            if (!validador.ValidarLongitudConLimite(texto, 11, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBPrecioPr_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBPrecioPr.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                //Validar caracteres.
                if (!validador.ValidarCaracteresNumericosFloat(texto))
                {
                    e.Cancel = true;
                    TBValidacion8.Visible = true;
                    return;
                }

                //Validar longitud máxima.
                if (!validador.ValidarLongitud(texto, 11))
                {
                    e.Cancel = true;
                    TBValidacion9.Visible = true;
                }
            }
        }
        // FIN Validacion TBPrecioPr

        // INICIO Validacion CBProveedorPr
        private void CBProveedorPr_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string seleccion = CBProveedorPr.SelectedItem?.ToString();

            OcultarValidaciones();

            if (!validador.ValidarSeleccion(seleccion))
            {
                //e.Cancel = true;
                CBProveedorPr.Texts = "Seleccionar...";
                TBValidacion10.Visible = true;
            }
        }
        // FIN Validacion CBProveedorPr

        // INICIO Validacion CBCategoriaPr
        private void CBCategoriaPr_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string seleccion = CBCategoriaPr.SelectedItem?.ToString();

            OcultarValidaciones();

            if (!validador.ValidarSeleccion(seleccion))
            {
                //e.Cancel = true;
                CBCategoriaPr.Texts = "Seleccionar...";
                TBValidacion11.Visible = true;
            }
        }
        // FIN Validacion CBCategoriaPr

        // INICIO Validacion TBDescripcion
        private void TBDescripcionPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBDescripcionPr.Text;

            //Validar caracteres
            if (!validador.ValidarKeyPressNombreProducto(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            //Validar longitud con límite
            if (!validador.ValidarLongitudConLimite(texto, 200, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TBDescripcionPr_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBDescripcionPr.Texts.Trim();

            OcultarValidaciones();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                // Validar longitud minima
                if (!validador.ValidarLongitudMinima(texto, 10))
                {
                    e.Cancel = true;
                    TBValidacion12.Visible = true;
                    return;
                }

                // Validar que no sea solo caracteres especiales ni números
                if (!validador.ValidarNoSoloNumerosNiEspeciales(texto))
                {
                    e.Cancel = true;
                    TBValidacion13.Visible = true;
                    return;
                }

                // validar caracteres especiales
                if (!validador.ValidarNombreProducto(texto))
                {
                    e.Cancel = true;
                    TBValidacion14.Visible = true;
                    return;
                }

                // Validar longitud máxima
                if (!validador.ValidarLongitud(texto, 200))
                {
                    e.Cancel = true;
                    TBValidacion15.Visible = true;
                }
            }
        }
        // FIN Validacion TBDescripcion


        //Inicio TextChanged
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }
        //Fin TextChanged

        private void BModificarPr_Click(object sender, EventArgs e)
        {
            if (TBNombrePr.Texts != string.Empty && TBSerialPr.Texts != string.Empty && TBDescripcionPr.Texts != string.Empty && TBPrecioPr.Texts != string.Empty && CBProveedorPr.SelectedItem != null && CBCategoriaPr.SelectedItem != null)
            {
                if (comprobarModif(camposActuales))
                {
                    try
                    {
                        NProducto nproducto = new NProducto();
                        nproducto.NModificarProducto(
                            productoActual.Serial,
                            int.Parse(TBSerialPr.Texts),
                            TBNombrePr.Texts,
                            TBDescripcionPr.Texts,
                            float.Parse(TBPrecioPr.Texts),
                            int.Parse(CBCategoriaPr.SelectedValue.ToString()),
                            int.Parse(CBProveedorPr.SelectedIndex.ToString()) + 1,
                            rjTextBox1.Texts,
                            CBActivoPr.SelectedItem.ToString()
                            );
                        MsgPersonalizado mensaje = new MsgPersonalizado("Producto modificado con éxito", "Modificación", "Informacion", null);
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
                    MsgPersonalizado mensaje = new MsgPersonalizado("Debe realizar almenos un cambio para modificar el producto", "Error al Modificar", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para modificar", "Modificar", "Error", generarListaCampos());
                mensaje.ShowDialog();
            }
        }

        private List<string> generarListaCampos()
        {
            List<string> campos = new List<string>{
                TBNombrePr.Texts,
                TBDescripcionPr.Texts,
                TBSerialPr.Texts,
                TBPrecioPr.Texts,
                CBProveedorPr.SelectedItem?.ToString(),
                CBCategoriaPr.SelectedItem?.ToString(),
                CBActivoPr.SelectedItem?.ToString(),
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
        }

        private void BFotoProducto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Title = "Seleccione una imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;
                rjTextBox1.Texts = sourceFilePath;
                // Genera un nombre único para la imagen
                nombreImagen = Guid.NewGuid().ToString() + Path.GetExtension(sourceFilePath);

                // Ruta de destino en tu proyecto (por ejemplo, en una carpeta 'uploads' en la misma ruta de ejecución)
                string destinationPath = Path.Combine(Application.StartupPath, "uploads", nombreImagen);

                // Asegúrate de que la carpeta de destino existe
                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));

                // Copia la imagen a la carpeta de destino
                File.Copy(sourceFilePath, destinationPath, true);
            }
        }

        private void guardarCampos()
        {
            camposActuales[0] = TBSerialPr.Texts;
            camposActuales[1] = TBNombrePr.Texts;
            camposActuales[2] = TBPrecioPr.Texts;
            camposActuales[3] = CBProveedorPr.SelectedIndex.ToString();
            camposActuales[4] = CBCategoriaPr.SelectedIndex.ToString();
            camposActuales[5] = TBDescripcionPr.Texts;
            camposActuales[6] = rjTextBox1.Texts;
            camposActuales[7] = CBActivoPr.SelectedIndex.ToString();
        }
        private bool comprobarModif(List<string> campos)
        {
            if (campos[0] != TBSerialPr.Texts ||
                campos[1] != TBNombrePr.Texts ||
                campos[2] != TBPrecioPr.Texts ||
                campos[3] != CBProveedorPr.SelectedIndex.ToString() ||
                campos[4] != CBCategoriaPr.SelectedIndex.ToString() ||
                campos[5] != TBDescripcionPr.Texts ||
                campos[6] != rjTextBox1.Texts ||
                campos[7] != CBActivoPr.SelectedIndex.ToString())
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
            this.Load -= ModificarProducto_Load;

            //<-Paint-Events->\\
            PContModificarPr.Paint -= PContModificarPr_Paint;

            //<-Click-Events->\\
            BModificarPr.Click -= BModificarPr_Click;
            BReturnToBack.Click -= BReturnToBack_Click;
            BFotoProducto.Click -= BFotoProducto_Click;

            //<-TextBox-Events->\\
            //TBNombrePr
            TBNombrePr.KeyPress -= TBNombrePr_KeyPress;
            TBNombrePr.Validating -= TBNombrePr_Validating;
            TBNombrePr._TextChanged -= TextBox_TextChanged;
            //TBSerialPr
            TBSerialPr.KeyPress -= TBSerialPr_KeyPress;
            TBSerialPr.Validating -= TBSerialPr_Validating;
            TBSerialPr._TextChanged -= TextBox_TextChanged;
            //TBPrecioPr
            TBPrecioPr.KeyPress -= TBPrecioPr_KeyPress;
            TBPrecioPr.Validating -= TBPrecioPr_Validating;
            TBPrecioPr._TextChanged -= TextBox_TextChanged;
            //CBProveedorPr
            CBProveedorPr.Validating -= CBProveedorPr_Validating;
            //CBCategoriaPr
            CBCategoriaPr.Validating -= CBCategoriaPr_Validating;
            //TBDescripcionPr
            TBDescripcionPr.KeyPress -= TBDescripcionPr_KeyPress;
            TBDescripcionPr.Validating -= TBDescripcionPr_Validating;
            TBDescripcionPr._TextChanged -= TextBox_TextChanged;

            // Liberar los recursos
            base.Dispose();
        }
    }
}

