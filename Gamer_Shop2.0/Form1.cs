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
using static Gamer_Shop2._0.ColorTransition;


namespace Gamer_Shop2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.PInicio.Paint += new PaintEventHandler(panel1_Paint);
            TBUsuario.Validating += new CancelEventHandler(TextBox_Validating);
            TBContraseña.Validating += new CancelEventHandler(TextBox_Validating);
            TBUsuario.KeyPress += new KeyPressEventHandler(TBUsuarioUs_KeyPress);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

                
                using (Pen pen = new Pen(Color.Green, 5))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Green;
            int borderWidth = 1;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth);
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            var textBox = sender as RJControls.RJTextBox_radio_;
            if (textBox != null)
            {
                if (textBox.Texts.Length <= 7 || textBox.Texts.Length >= 20)
                {
                    e.Cancel = true;
                    if (textBox == TBUsuario)
                    {
                        TBValidacion.Visible = true;
                    }
                    else if (textBox == TBContraseña)
                    {
                        TBValidacion2.Visible = true;
                    }
                }
                else
                {
                    if (textBox == TBUsuario)
                    {
                        TBValidacion.Visible = false;
                    }
                    else if (textBox == TBContraseña)
                    {
                        TBValidacion2.Visible = false;
                    }
                }
            }
        }



        private void TBUsuario__TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void TBContraseña__TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;

        }

        private void BIniciar_Click(object sender, EventArgs e)
        {
            if (TBUsuario.Validate() == true && TBContraseña.Validate() == true){
                Bienvenida bienvenida = new Bienvenida();
                bienvenida.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBUsuarioUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBUsuario.Texts.Trim().Length < 21;

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
