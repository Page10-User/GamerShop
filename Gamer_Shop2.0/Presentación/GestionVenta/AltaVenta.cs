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

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class AltaVenta : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public AltaVenta()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(AltaVenta_Load);
        }

        private void AltaVenta_Load(object sender, EventArgs e)
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
            using (Pen pen = new Pen(Color.Violet, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void TBFecha_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string formato = "DD-MM-YYYY";

                // Intentar convertir la fecha utilizando el formato
                DateTime fechaValidada;
                bool esFechaValida = DateTime.TryParseExact(
                    TBFecha.Texts,                     // La cadena que contiene la fecha
                    formato,                   // El formato esperado
                    System.Globalization.CultureInfo.InvariantCulture, // Cultura invariable
                    System.Globalization.DateTimeStyles.None,          // Sin estilos adicionales
                    out fechaValidada);        // El resultado convertido

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

        private void TBDni_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                int number;
                if (TBDni.Texts.Length > 8 || !int.TryParse(TBDni.Texts, out number))
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

        private void TBEmail_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool esValido = Regex.IsMatch(TBEmail.Texts, patronCorreo);

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

        private void CBCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBCategoria.SelectedIndex == -1)
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

        private void BRegistrarVn_Click(object sender, EventArgs e)
        {
            if (TBFecha.Texts != string.Empty && TBDni.Texts != string.Empty && TBMonto.Texts != string.Empty && TBEmail.Texts != string.Empty && CBCategoria.SelectedItem != null)
            {
                MessageBox.Show("Producto registrado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para registrar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

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

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBDni.Texts.Trim().Length < 9;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

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

        private void TBEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBEmail.Texts.Trim().Length < 50;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void DGListaVn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaVn.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult = MessageBox.Show("Está seguro que desea eliminar esta venta?", "Eliminar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    // Momentaneamente elimina totalmente la fila.
                    // Debería pasar a una lista de "inactivos" xEliminacion logica
                    DGListaVn.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
