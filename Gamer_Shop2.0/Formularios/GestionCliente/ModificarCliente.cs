using Gamer_Shop2._0.Formularios.GestionProducto;
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

namespace Gamer_Shop2._0.Formularios.GestionCliente
{
    public partial class ModificarCliente : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public ModificarCliente()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(ModificarCliente_Load);
            PContModificarCl.Paint += new PaintEventHandler(PContModificarCl_Paint);
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
            using (Pen pen = new Pen(Color.Lime, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BReturnToBack_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Está seguro que desea volver? Se perderán los cambios realizados", "Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                // Crear una nueva instancia de ListaCLiente
                ListaCliente listCl = new ListaCliente();
                listCl.TopLevel = false;

                // Limpiar el panel actual y volver al anterior formulario.
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(listCl);
                listCl.PanelContainer = PanelContainer;
                listCl.Show();
                this.Close();
            }
        }

        private void TNombreCl_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TNombreCl.Texts.Length >= 35)
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

        private void TApellidoCl_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TApellidoCl.Texts.Length >= 35)
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

        private void TTelefonoCl_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                long number;
                if (!long.TryParse(TTelefonoCl.Texts, out number))
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

        private void TEmailCl_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool esValido = Regex.IsMatch(TEmailCl.Texts, patronCorreo);

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

        private void TNombreCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TNombreCl.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TApellidoCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TApellidoCl.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TTelefonoCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TTelefonoCl.Texts.Trim().Length < 20;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TEmailCl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TEmailCl.Texts.Trim().Length < 50;

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
            if (TNombreCl.Texts != string.Empty && TApellidoCl.Texts != string.Empty && TTelefonoCl.Texts != string.Empty && TEmailCl.Texts != string.Empty)
            {
                MessageBox.Show("Usuario modificado con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para modificar", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
