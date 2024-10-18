using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.RJControls;
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
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
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
            TNombrePr.Texts = productoActual.Nombre;
            TSerialPr.Texts = productoActual.Serial.ToString();
            TDescripcionPr.Texts = productoActual.Descripcion;
            TPrecioPr.Texts = productoActual.Stock.ToString();
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
                DialogResult = MessageBox.Show("Está seguro que desea volver? Se perderán los cambios realizados", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
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

        private void TNombrePr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TNombrePr.Texts.Length >= 50)
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;

                }
                else
                {
                    TBValidacion.Visible = false;
                }
            }
        }

        private void TSerialPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                long number;
                if (!long.TryParse(TSerialPr.Texts, out number))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                }
                else
                {
                    TBValidacion2.Visible = false;
                }
            }
        }

        private void TDescripcionPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TDescripcionPr.Texts.Length >= 200)
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;

                }
                else
                {
                    TBValidacion3.Visible = false;
                }
            }
        }

        private void TPrecioPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                float number;
                if (!float.TryParse(TPrecioPr.Texts, out number))
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;
                }
                else
                {
                    TBValidacion4.Visible = false;
                }
            }
        }
        private void CBproveedorPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBCategoriaPr.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = true;
                }
                else
                {
                    TBValidacion5.Visible = false;
                }
            }
        }

        private void CBCategoriaPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBCategoriaPr.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                }
                else
                {
                    TBValidacion6.Visible = false;
                }
            }
        }
        

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void BModificarPr_Click(object sender, EventArgs e)
        {
            wasClicked = true;
            if (TNombrePr.Texts != string.Empty && TSerialPr.Texts != string.Empty && TDescripcionPr.Texts != string.Empty && TPrecioPr.Texts != string.Empty && CBProveedorPr.SelectedItem != null)
            {
                try
                {
                    NProducto nproducto = new NProducto();
                    nproducto.NModificarProducto(
                        int.Parse(TSerialPr.Texts),
                        TNombrePr.Texts,
                        TDescripcionPr.Texts,
                        float.Parse(TPrecioPr.Texts),
                        CBCategoriaPr.SelectedIndex + 1,
                        CBProveedorPr.SelectedIndex + 1
                        );

                    MessageBox.Show("Producto modificado con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (ExisteRegistroException ex)
                {
                    // Manejo de la excepción cuando el número de serial ya existe
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Manejo de cualquier otra excepción
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TNombrePr_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TNombrePr.Texts.Trim().Length < 50;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TDescripcionPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TDescripcionPr.Texts.Trim().Length < 200;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TNumberPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = textbox.Texts.Trim().Length < 15;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
