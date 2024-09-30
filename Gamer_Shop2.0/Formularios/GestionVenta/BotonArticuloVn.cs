using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class BotonArticuloVn : UserControl
    {
        private int borderWidth = 1; // Grosor del borde

        public BotonArticuloVn()
        {
            InitializeComponent();
            SubscripcionEventos();
            this.DoubleBuffered = true;
        }

        private void SubscripcionEventos()
        {
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde
        }

        private void BEliminarPrVn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea eliminar el producto de la lista?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Parent.Controls.Remove(this);
                MessageBox.Show("Producto eliminado correctamente de la lista", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Validación de cantidad del producto.
        private void cantidadPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o una tecla de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permitir la entrada
            }
        }

        // Manejar el evento TextChanged para verificar si el número es negativo
        private void cantidadPr_TextChanged(object sender, EventArgs e)
        {
            // Si el texto está vacío, no hacemos nada
            if (string.IsNullOrWhiteSpace(TBCantidadPr.Text)) return;

            // Verificar si el texto es un número positivo
            if (int.TryParse(TBCantidadPr.Text, out int result))
            {
                // Verificar si es negativo
                if (result < 0)
                {
                    MessageBox.Show("El valor no puede ser negativo.");
                    TBCantidadPr.Text = ""; // Limpiar el TextBox si es negativo
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número entero positivo.");
                TBCantidadPr.Text = ""; // Limpiar el TextBox si no es un número entero
            }
        }
    }
}
