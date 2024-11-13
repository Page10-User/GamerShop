using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    public partial class BotonesArticuloCr : UserControl
    {

        private int borderRadius = 10; // Radio del borde redondeado
        private int borderWidth = 2; // Grosor del borde
        private int serial = 0;
        private string descripcion = "Descripción del Producto";
        private string photoFilePath;
        private string cantidadActual;

        public Bienvenida MainForm { get; set; }

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

            //Aplicamos la imagen (si tiene)
            if (PhotoFilePath is null)
            {
                PBfotoPr.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\imagen_default.png")));
                PBfotoPr.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                string imagePath = Path.Combine(Application.StartupPath, "uploads", photoFilePath);
                PBfotoPr.Image = Image.FromFile(imagePath);
                PBfotoPr.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            cantidadActual = TBCantidadPr.Text;
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

        //Methots
        public int Serial
        {
            get { return serial; }
            set { serial = value; }
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

        public Image ImgProducto
        {
            get { return PBfotoPr.Image; }
            set { PBfotoPr.Image = value; }
        }

        public string Precio
        {
            get { return LPrecio.Text; }
            set { LPrecio.Text = value; }
        }

        public string PhotoFilePath
        {
            get { return photoFilePath; }
            set { photoFilePath = value; }
        }
        //End Methot

        public event EventHandler<int> EliminarDelCarritoClick;
        public event EventHandler<decimal> ActualizarPrecioCarritoClick;
        private void BEliminarDeCarrito_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea eliminar el producto del carrito?", "Eliminar Producto", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                //Eliminamos el mensaje oculto
                mensaje.Dispose();

                //Pasamos el id del producto al catálogo (caso actual sjdsjd).
                EliminarDelCarritoClick?.Invoke(this, Serial);

                ActualizarPrecioCarritoClick?.Invoke(this, Convert.ToDecimal(Precio) * Convert.ToInt64(TBCantidadPr.Text)); //Actualizar precio en carrito con evento
                this.Parent.Controls.Remove(this);
                mensaje = new MsgPersonalizado("Producto eliminado correctamente", "Eliminación", "Informacion", null);
                mensaje.ShowDialog();
                MainForm.TopMost = true;
            }
            else
            {
                mensaje.Dispose();
                MainForm.TopMost = true;
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

                    TBCantidadPr.Text = "1";
                    MainForm.TopMost = true;
                }
                else if (result == 0)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("El valor no puede ser 0", "Error", "Error", null);
                    mensaje.ShowDialog();
                    TBCantidadPr.Text = "1";
                    MainForm.TopMost = true;
                }
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese un número entero positivo.", "Error", "Error", null);
                mensaje.ShowDialog();
                TBCantidadPr.Text = "1";
                MainForm.TopMost = true;
            }
        }

        public event EventHandler<decimal> ActualizarPrecioPorCantidad;
        private void TBCantidadPr_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt64(cantidadActual) != Convert.ToInt64(TBCantidadPr.Text))
            {
                decimal precioAnt = Convert.ToDecimal(Precio);
                int cantidadAnt = Convert.ToInt32(cantidadActual);
                decimal totalAnterior = precioAnt * cantidadAnt; //Mayor

                decimal precio = Convert.ToDecimal(Precio);
                int cantidad = Convert.ToInt32(TBCantidadPr.Text);
                decimal precioActualizado = precio * cantidad; //Menor

                decimal totalActualizado = precioActualizado - totalAnterior;

                NProducto nproducto = new NProducto();
                Producto producto = nproducto.GetProducto(Serial);
                int stockActual = producto.Stock;

                if (Convert.ToInt32(TBCantidadPr.Text) <= stockActual)
                {
                    ActualizarPrecioPorCantidad?.Invoke(this, totalActualizado);
                    cantidadActual = TBCantidadPr.Text;
                }
                else
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede especificar una cantidad mayor a la del stock disponible del producto, stock: " + producto.Stock.ToString(), "Error", "Error", null);
                    mensaje.ShowDialog();
                    TBCantidadPr.Text = cantidadActual;
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
