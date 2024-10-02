using Gamer_Shop2._0.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionProveedor
{
    public partial class ModificarProveedor : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public ModificarProveedor()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(ModificarProveedor_Load);
            PContInfoModificarProveedor.Paint += new PaintEventHandler(PContInfoModificarProveedor_Paint);
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
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

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Está seguro que desea volver? Se perderán los cambios realizados", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // Mostrar form
                ListaProveedor formListProveedor = new ListaProveedor();
                formListProveedor.TopLevel = false;
                formListProveedor.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formListProveedor);
                PanelContainer.BringToFront();

                formListProveedor.Show();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        // Validaciónes

        //Validación Inicio Nombre/Razón Social
        private void TBRazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBRazon.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TBRazon.Texts.Length >= 35)
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
        //Validación Fin Nombre/Razón Social

        //Validación Inicio Nombre representante
        private void TBRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBRepresentante.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBRepresentante_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TBRepresentante.Texts, @"^[a-zA-Z]+$"))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                }
                if (TBRepresentante.Texts.Length >= 35)
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
        //Validación Fin Nombre representante

        //Validación Inicio Teléfono
        private void TBContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBContacto.Texts.Trim().Length < 15;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBContacto_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TBContacto.Texts, @"^\d+$") ||  TBContacto.Texts.Length >= 15)
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
        //Validación Fin Teléfono

        //Validación Inicio Correo
        private void TBCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBCorreo.Texts.Trim().Length < 50;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool esValido = Regex.IsMatch(TBCorreo.Texts, patronCorreo);

                if (!esValido)
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
        //Validación Fin Correo

        //Validación Inicio Dirección
        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBDireccion.Texts.Trim().Length < 150;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBDireccion_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TBDireccion.Texts.Length >= 150)
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
        //Validación Fin Dirección

        //Validación Inicio CategoriaProveedor
        private void CBCategoriaPrProveedor_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBCategoriaPrProveedor.SelectedIndex == -1)
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
        //Validación Fin CategoriaProveedor

        //Boton modificar + validación de los campos.
        private void BModificarProveedor_Click(object sender, EventArgs e)
        {
            if (TBRepresentante.Texts != string.Empty && TBCorreo.Texts != string.Empty && TBRazon.Texts != string.Empty && TBDireccion.Texts != string.Empty && TBContacto.Texts != string.Empty)
            {
                MessageBox.Show("Proveedor modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para modificar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
