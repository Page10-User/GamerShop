using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class BotonArticuloVn : UserControl
    {
        private string descripcion = "Descripción del Producto";
        private int serial = 0;
        private int borderWidth = 1; // Grosor del borde
        private int id = 0;

        public BotonArticuloVn()
        {
            InitializeComponent();
            SubscripcionEventos();
            this.DoubleBuffered = true;
        }

        //Methots
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string NombreProducto
        {
            get { return LNombreProducto.Text; }
            set { LNombreProducto.Text = value; }
        }

        public string Categoria
        {
            get { return LCategoria.Text; }
            set { LCategoria.Text = value; }
        }

        public string Precio
        {
            get { return LPrecio.Text; }
            set { LPrecio.Text = value; }
        }
        //End Methot

        private void SubscripcionEventos()
        {
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde
        }

        public event EventHandler<decimal> EliminarDelCarritoClick;
        private void BEliminarPrVn_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea eliminar el producto de la lista?", "Eliminar Producto", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();
            if (result == DialogResult.Yes)
            {
                //calculamos el total del pr
                decimal precio = Convert.ToDecimal(Precio);
                int cantidad = Convert.ToInt32(TBCantidadPr.Text);
                decimal total = precio * cantidad;

                //Cerramos el mensaje que está en Hide
                mensaje.Dispose();
                EliminarDelCarritoClick?.Invoke(this, total);
                this.Parent.Controls.Remove(this);
                mensaje = new MsgPersonalizado("Producto eliminado correctamente de la lista", "Eliminación", "Informacion", null);
                mensaje.ShowDialog();
            }
            else
            {
                mensaje.Dispose();
            }
        }

        //Validación de cantidad del producto.
        private void cantidadPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // No permitir la entrada
            }
        }

        // Manejar el evento TextChanged para verificar si el número es negativo
        private void cantidadPr_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBCantidadPr.Text)) return;

            if (int.TryParse(TBCantidadPr.Text, out int result))
            {
                if (result < 0)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("El valor no puede ser negativo", "Error", "Error", null);
                    mensaje.ShowDialog();
                    TBCantidadPr.Text = "1";
                }
                else if (result == 0)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("El valor no puede ser 0", "Error", "Error", null);
                    mensaje.ShowDialog();
                    TBCantidadPr.Text = "1";
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese un número entero positivo.", "Error", "Error", null);
                mensaje.ShowDialog();
                TBCantidadPr.Text = "1";
            }
        }
    }
}
