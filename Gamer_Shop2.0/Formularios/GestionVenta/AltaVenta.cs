using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class AltaVenta : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public Bienvenida MainForm { get; set; }
        public AltaVenta()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(AltaVenta_Load);
            BordeRedondeadoPanels();
        }

        private void AltaVenta_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            TBFecha.Texts = DateTime.Now.Date.ToString();
        }

        private void PContAltaVn_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 20;
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

        private void BordePanel(Panel panel, Color borderColor, int borderWidth)
        {
            // Asocia el evento Paint solo si no está ya asociado
            panel.Paint += (sender, e) =>
            {
                // Dibujar el borde en el panel
                Graphics g = e.Graphics;
                Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    g.DrawRectangle(pen, rect);
                }
            };

            // Forzar que el panel se repinte para que se vea el borde
            panel.Invalidate();
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        //Validaciones

        //Validacion Inicio Fecha
        private void TBFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBFecha.Texts.Trim().Length < 10;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBFecha_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string formato = "dd-mm-yyyy";

                DateTime fechaValidada;
                bool esFechaValida = DateTime.TryParseExact(
                    TBFecha.Texts,                     
                    formato,                 
                    System.Globalization.CultureInfo.InvariantCulture, 
                    System.Globalization.DateTimeStyles.None,          
                    out fechaValidada);        

                if (!esFechaValida)
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
        //Validacion Fin Fecha

        //Validacion Inicio Monto
        private void TBMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBMonto.Texts.Trim().Length < 15;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBMonto_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                float number;
                if (!float.TryParse(TBMonto.Texts, out number))
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
        //Validacion Fin Monto

        //Validacion Inicio MetodoPago
        private void CBCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBCategoria.SelectedIndex == -1)
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
        //Validacion Fin MetodoPago

        private void BRegistrarVn_Click(object sender, EventArgs e)
        {
            if (TBFecha.Texts != string.Empty && TBMonto.Texts != string.Empty && CBCategoria.SelectedItem != null)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Venta registrada con éxito", "Registro", "Informacion", null);
                mensaje.ShowDialog();
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para registrar una venta", "Error", "Error", generarListaCampos());
                mensaje.ShowDialog();
            }
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            // Crear un nuevo formulario para el efecto de oscurecimiento
            Form formBG = new Form();
            personalizarFondoNegro(formBG);

            // Mostrar el formulario de oscurecimiento
            formBG.Show();

            //Mostrar form "Alta Cliente"
            AltaCliente formAltaCl = new AltaCliente(false);
            formAltaCl.StartPosition = FormStartPosition.CenterScreen;
            formAltaCl.BringToFront();
            formAltaCl.MainForm = MainForm;
            formAltaCl.FondoOscurecido = formBG;
            formAltaCl.ShowInTaskbar = false;
            formAltaCl.TopMost = true;
            formAltaCl.ShowDialog();
        }

        private void BClienteExistente_Click(object sender, EventArgs e)
        {
            if (PContBuscarDni.Visible)
            {
                PContBuscarDni.Visible = false;
            }
            else
            {
                PContBuscarDni.Visible = true;
            }
        }

        private void BordeRedondeadoPanels()
        {
            PContAltaVn1.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PContAltaVn2.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PContAltaVn3.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PContAltaVn4.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PBuscadorPrVn.Paint += new PaintEventHandler(PContAltaVn_Paint);
        }

        private void personalizarFondoNegro(Form fondoBg)
        {
            fondoBg.StartPosition = FormStartPosition.Manual;
            fondoBg.FormBorderStyle = FormBorderStyle.None;
            fondoBg.Opacity = 0.70d;
            fondoBg.BackColor = Color.Black;
            fondoBg.Width = 638 - 2;
            fondoBg.Height = this.Height - 4;
            fondoBg.Location = this.Location;
            fondoBg.WindowState = FormWindowState.Maximized;
            fondoBg.TopMost = true;
            fondoBg.ShowInTaskbar = false;
        }

        private List<string> generarListaCampos()
        {
            List<string> campos = new List<string>{
                TBFecha.Texts,
                TBMonto.Texts,
                CBCategoria.SelectedItem?.ToString()
             };
            return campos;
        }
    }
}
