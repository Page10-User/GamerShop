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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gamer_Shop2._0.Formularios.GestionCliente
{
    public partial class AltaCliente : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public Form FondoOscurecido { get; set; }
        public Bienvenida MainForm { get; set; }
        public AltaCliente(bool desdeDonde)
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(AltaCliente_Load);
            PContAltaCl.Paint += new PaintEventHandler(PContAltaCl_Paint);
            MostrarBotonListaSegunDondeVenga(desdeDonde);
        }
        private void PContAltaCl_Paint(object sender, PaintEventArgs e)
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

        private void AltaCliente_Load(object sender, EventArgs e)
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

        private void BShowListaCl_Click(object sender, EventArgs e)
        {
            // Mostrar form
            ListaCliente formCliente = new ListaCliente();
            formCliente.TopLevel = false;
            formCliente.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formCliente);
            PanelContainer.BringToFront();

            formCliente.Show();
        }

        //Mostrar validaciones
        private void TBNombre_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TBNombre.Texts, @"^[a-zA-Z]+$"))
                {
                    e.Cancel = true;
                    TBValidacion6.Visible = true;
                    //TBValidacion.Visible = false;
                }
                if (TBNombre.Texts.Length >= 35)
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;
                    TBValidacion6.Visible = false;

                }
                else
                {
                    TBValidacion.Visible = false;
                    TBValidacion6.Visible = false;
                }
            }
        }
        private void TBApellido_Validating(object sender, CancelEventArgs e)
        {
            if (TBApellido.Texts != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TBApellido.Texts, @"^[a-zA-Z]+$"))
                {
                    e.Cancel = true;
                    TBValidacion7.Visible = true;
                    TBValidacion2.Visible = false;
                }
                else
                {
                    //2da validación
                    if (TBApellido.Texts.Length >= 35)
                    {
                        e.Cancel = true;
                        TBValidacion2.Visible = true;
                        TBValidacion7.Visible = false;
                    }
                    else
                    {
                        OcultarValidaciones();
                    }
                }
            }
            else
            {
                OcultarValidaciones();
            }
        }
        private void TBDni_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                int number;
                if (TBDni.Texts.Length > 8 || !int.TryParse(TBDni.Texts, out number))
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
        private void TBTelefono_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(TBTelefono.Texts, @"^\d+$") || TBTelefono.Texts.Length >= 15)
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
        private void TBCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool esValido = Regex.IsMatch(TBCorreo.Texts, patronCorreo);

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

        // Validación
        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBNombre.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBApellido.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBDni.Texts.Trim().Length < 8;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBTelefono.Texts.Trim().Length < 15;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        //Boton registrar + validación de los campos.
        private void BRegistrarCl_Click(object sender, EventArgs e)
        {
            if (TBDni.Texts != string.Empty && TBCorreo.Texts != string.Empty && TBNombre.Texts != string.Empty && TBApellido.Texts != string.Empty && TBTelefono.Texts != string.Empty)
            {
                MessageBox.Show("Cliente registrado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para registrar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarBotonListaSegunDondeVenga(bool desdeDonde)
        {
            if (desdeDonde)
            {
                BShowListaCl.Visible = true;
                LShowLista.Visible = true;
                BCloseAltaCliente.Visible = false;
            }
            else
            {
                BShowListaCl.Visible = false;
                LShowLista.Visible = false;
                BCloseAltaCliente.Visible = true;
            }
        }

        private void BCloseAltaCliente_Click(object sender, EventArgs e)
        {
            MainForm.TopMost = true;
            FondoOscurecido.Close();
            this.Close();
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
        }
    }
}