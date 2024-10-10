using Gamer_Shop2._0.Formularios.InterfazUsuarios;
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
using static Gamer_Shop2._0.ColorTransition;


namespace Gamer_Shop2._0
{
    public partial class Form1 : Form
    {
        Bienvenida existeBienvenida {  get; set; }

        Bienvenida bienvenida;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.PInicio.Paint += new PaintEventHandler(panel1_Paint);
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
            var textBox = sender as RJTextBox_radio_;
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox_radio_;
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
        private void BIniciar_Click(object sender, EventArgs e)
        {
            if (TBUsuario.Texts != string.Empty && TBContraseña.Texts != string.Empty)
            {
                MostrarOInstanciarBienvenidaCS();

                if (TBUsuario.Texts == "EmpleadoUser" && TBContraseña.Texts == "12345678")
                {
                    EmpleadoOptions userOptions = new EmpleadoOptions();
                    bienvenida.userOptions = userOptions;
                    bienvenida.Show();
                    bienvenida.Forminicio = this;
                    this.Hide();
                }
                else if (TBUsuario.Texts == "AdministradorUser" && TBContraseña.Texts == "12345678")
                {
                    AdministradorOptions userOptions = new AdministradorOptions();
                    bienvenida.userOptions = userOptions;
                    bienvenida.Show();
                    bienvenida.Forminicio = this;
                    this.Hide();
                }
                else if (TBUsuario.Texts == "GerenteUser" && TBContraseña.Texts == "12345678")
                {
                    GerenteOptions userOptions = new GerenteOptions();
                    bienvenida.userOptions = userOptions;
                    bienvenida.Show();
                    bienvenida.Forminicio = this;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un usuario y contraseña válidos", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña", "Iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarOInstanciarBienvenidaCS()
        {
            if (existeBienvenida == null)
            {
                Bienvenida bienvenidaForm = new Bienvenida();
                bienvenida = bienvenidaForm;
            }
            else
            {
                existeBienvenida.Show();
            }
        }

        //Eliminar más adelante...
        private void Form1_Load(object sender, EventArgs e)
        {
            TBUsuario.Texts = "AdministradorUser";
            TBContraseña.Texts = "12345678";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar al evento del botón Iniciar
                BIniciar_Click(sender, e);
            }
        }
    }
}
