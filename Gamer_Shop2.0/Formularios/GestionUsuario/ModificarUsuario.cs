using Gamer_Shop2._0.Formularios.GestionProducto;
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

namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    public partial class ModificarUsuario : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public ModificarUsuario()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(ModificarUsuario_Load);
            PContModificarUs.Paint += new PaintEventHandler(PContModificarUs_Paint);
        }

        private void PContModificarUs_Paint(object sender, PaintEventArgs e)
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

        private void ModificarUsuario_Load(object sender, EventArgs e)
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

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Está seguro que desea volver? Se perderán los cambios realizados", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // Crear una nueva instancia de ListaProductos
                ListaUsuario listUs = new ListaUsuario();
                listUs.TopLevel = false;

                // Limpiar el panel actual y volver al anterior formulario.
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(listUs);
                listUs.PanelContainer = PanelContainer;
                listUs.Show();
                this.Close();
            }
        }

        private void TNombreUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TNombreUs.Texts, @"^[a-zA-Z]+$"))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                }
                if (TNombreUs.Texts.Length >= 35)
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

        private void TApellidoUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TApellidoUs.Texts, @"^[a-zA-Z]+$"))
                {
                    e.Cancel = true;
                    TBValidacion8.Visible = true;
                }
                if (TApellidoUs.Texts.Length >= 35)
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

        private void TCuilUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                long number;
                if (!long.TryParse(TCuilUs.Texts, out number))
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

        private void TUsuarioUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TNombreUsuario.Texts.Length >= 20)
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

        private void TContraseñaUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TContraseñaUs.Texts.Length >= 100)
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

        private void TEmailUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool esValido = Regex.IsMatch(TEmailUs.Texts, patronCorreo);

                if (!esValido)
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

        private void TNombreUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TNombreUs.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TApellidoUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TApellidoUs.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TCuilUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TCuilUs.Texts.Trim().Length <= 12;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TLoginUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = textbox.Texts.Trim().Length < 20;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TEmailUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TEmailUs.Texts.Trim().Length < 50;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void BModificarUs_Click(object sender, EventArgs e)
        {
            if (TNombreUs.Texts != string.Empty && TApellidoUs.Texts != string.Empty && TCuilUs.Texts != string.Empty && TNombreUsuario.Texts != string.Empty && TContraseñaUs.Texts != string.Empty && TEmailUs.Texts != string.Empty)
            {
                MessageBox.Show("Usuario modificado con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
