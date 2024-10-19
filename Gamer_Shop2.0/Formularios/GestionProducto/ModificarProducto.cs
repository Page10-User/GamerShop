using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
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

namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    public partial class ModificarProducto : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        Producto productoActual = new Producto();
        bool wasClicked = false;

        public Panel PanelContainer { get; set; }
        public ModificarProducto(int id)
        {
            InitializeComponent();

            NProducto producto = new NProducto();
            
            productoActual = producto.GetProducto(id);
            this.Padding = new Padding(borderWidth);
            this.Load += new EventHandler(ModificarProducto_Load);
            PContModificarPr.Paint += new PaintEventHandler(PContModificarPr_Paint);
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

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            TBNombrePr.Texts = productoActual.Nombre;
            TBSerialPr.Texts = productoActual.Serial.ToString();
            TBDescripcionPr.Texts = productoActual.Descripcion;
            TBPrecioPr.Texts = productoActual.Precio.ToString();
            CBCategoriaPr.SelectedIndex = productoActual.ID_Categoria-1;
            CBProveedorPr.SelectedIndex = productoActual.ID_Proveedor - 1;

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
            if (wasClicked != true)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea volver ? Se perderán los cambios realizados", "Volver", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    // Cerramos el mensaje oculto.
                    mensaje.Close();

                    // Crear una nueva instancia de ListaProductos
                    ListaProductos listPr = new ListaProductos();
                    listPr.TopLevel = false;

                    // Limpiar el panel actual y volver al anterior formulario.
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(listPr);
                    listPr.PanelContainer = PanelContainer;
                    listPr.Show();
                    this.Close();
                }
                else
                {
                    mensaje.Close();
                }
            }
            else
            {
                ListaProductos listPr = new ListaProductos();
                listPr.TopLevel = false;

                // Limpiar el panel actual y volver al anterior formulario.
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(listPr);
                listPr.PanelContainer = PanelContainer;
                listPr.Show();
                this.Close();
            }
            
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
            if (!validador.ValidarLongitudConLimite(texto, 15, e.KeyChar))
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
                if (!validador.ValidarLongitudMinima(texto, 8))
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
                e.Cancel = true;
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
                e.Cancel = true;
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
                TBDescripcionPr.Texts = validador.MayusculaPrimeraLetra(texto);
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
            wasClicked = true;
            if (TBNombrePr.Texts != string.Empty && TBSerialPr.Texts != string.Empty && TBDescripcionPr.Texts != string.Empty && TBPrecioPr.Texts != string.Empty && CBProveedorPr.SelectedItem != null)
            {
                try
                {
                    NProducto nproducto = new NProducto();
                    nproducto.NModificarProducto(
                        int.Parse(TBSerialPr.Texts),
                        TBNombrePr.Texts,
                        TBDescripcionPr.Texts,
                        float.Parse(TBPrecioPr.Texts),
                        CBCategoriaPr.SelectedIndex + 1,
                        CBProveedorPr.SelectedIndex + 1
                        );
                    MsgPersonalizado mensaje = new MsgPersonalizado("Producto modificado con éxito", "Modificación", "Informacion",null);
                    mensaje.ShowDialog();
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
    }
}
