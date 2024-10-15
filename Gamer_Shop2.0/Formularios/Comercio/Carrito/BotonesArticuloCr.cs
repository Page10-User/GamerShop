using Gamer_Shop2._0.Formularios.MSGPersonalizado;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    public partial class BotonesArticuloCr : UserControl
    {

        private int borderRadius = 10; // Radio del borde redondeado
        private int borderWidth = 2; // Grosor del borde
        public BotonesArticuloCr()
        {
            InitializeComponent();
            LPrecio.BringToFront();
            this.Load += new EventHandler(BotonesArticuloCr_Load);
        }

        private void BotonesArticuloCr_Load(object sender, EventArgs e)
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

        public event EventHandler<int> EliminarDelCarritoClick;
        private void BEliminarDeCarrito_Click(object sender, EventArgs e)
        {

            MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea eliminar el producto del carrito?", "Eliminar Producto", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                //Pasamos el id del producto al catálogo (caso futuro).
                EliminarDelCarritoClick?.Invoke(this, 1);
                this.Parent.Controls.Remove(this);
                mensaje = new MsgPersonalizado("Producto eliminado correctamente", "Eliminación", "Informacion", null);
                mensaje.ShowDialog();
            }
            else
            {
                mensaje.Close();
            }
        }

        //Validación de cantidad del producto.
        private void cantidadPr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

                    TBCantidadPr.Text = "";
                }
                else if (result == 0)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("El valor no puede ser 0", "Error", "Error", null);
                    mensaje.ShowDialog();
                    TBCantidadPr.Text = "";
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese un número entero positivo.", "Error", "Error", null);
                mensaje.ShowDialog();
                TBCantidadPr.Text = "";
            }
        }
    }
}
