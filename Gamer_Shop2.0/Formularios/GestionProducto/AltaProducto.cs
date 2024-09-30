using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.RJControls;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    public partial class AltaProducto : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }

        public AltaProducto()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(AltaProducto_Load);
            PContAltaPr.Paint += new PaintEventHandler(PContAltaPr_Paint);
        }

        private void PContAltaPr_Paint(object sender, PaintEventArgs e)
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

        private void AltaProducto_Load(object sender, EventArgs e)
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

        private void BShowListaPr_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de ListaProductos
            ListaProductos listPr = new ListaProductos();
            listPr.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(listPr);
            listPr.PanelContainer = PanelContainer;
            listPr.Show();
            this.Close();
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

        private void TDescripcionPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TDescripcionPr.Texts.Length >= 200)
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

        private void TPrecioPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                float number;
                if (!float.TryParse(TPrecioPr.Texts, out number))
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

        private void TStockPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                int number;
                if (!int.TryParse(TStockPr.Texts, out number))
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

        private void TSerialPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                long number;
                if (!long.TryParse(TSerialPr.Texts, out number))
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
                    TBValidacion4.Visible = true;
                }
                else
                {
                    TBValidacion4.Visible = false;
                }
            }
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }


        private void BRegistrarPr_Click(object sender, EventArgs e)
        {
            if (TNombrePr.Texts != string.Empty && TSerialPr.Texts != string.Empty && TDescripcionPr.Texts != string.Empty && TPrecioPr.Texts != string.Empty && TStockPr.Texts != string.Empty && CBCategoriaPr.SelectedItem != null)
            {
                try
                {
                    NProducto nproducto = new NProducto();
                    nproducto.NAgregarProducto(
                        int.Parse(TSerialPr.Texts), TNombrePr.Texts, TDescripcionPr.Texts,
                        int.Parse(TStockPr.Texts), float.Parse(TPrecioPr.Texts), CBCategoriaPr.SelectedIndex+1
                        );
                    MessageBox.Show("Producto registrado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Este producto ya existe", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } else
            {
                MessageBox.Show("Debe completar todos los campos para registrar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TNombrePr_KeyPress (object sender, KeyPressEventArgs e)
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
            bool longitud = TPrecioPr.Texts.Trim().Length < 25;

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
