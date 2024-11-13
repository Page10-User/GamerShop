using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Gamer_Shop2._0.Datos.DProducto;

namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    public partial class PanelCarrito : Form
    {
        private int borderRadius = 5; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde
        public Dictionary<int,int> idPrCr {  set; get; }
        public Panel PanelContainerCr { get; set; }
        public Panel PanelContainer {  get; set; }
        public Catalogo MainCatalogo { get; set; }
        public Form FondoOscuro { get; set; }

        public Usuario PCUsuario { get; set; }

        public Bienvenida MainForm {  get; set; }
        public PanelCarrito()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PanelCarrito_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            //Cargar productos al carrito.
            MostrarProductosEnFLPCarrito();

            //Calculamos el precio total
            CalcularYMostrarPrecioTotal();
        }

        private void CalcularYMostrarPrecioTotal()
        {
            decimal total = 0;
            foreach (BotonesArticuloCr articuloCr in FLPContenidoPrCarrito.Controls)
            {
                total = Convert.ToInt64(articuloCr.Precio) * Convert.ToInt64(articuloCr.TBCantidadPr.Text) + total;
            }
            LPrecioTotal.Text = total.ToString();
        }

        private void MostrarProductosEnFLPCarrito()
        {
            FLPContenidoPrCarrito.Controls.Clear();

            // Itera sobre cada producto en el diccionario
            foreach (var item in idPrCr)
            {
                int serial = item.Key; // Serial del producto
                int cantidad = item.Value; // Cantidad del producto

                BotonesArticuloCr ArticuloCr = new BotonesArticuloCr();
                NProducto prod = new NProducto();
                ProductoViewModel producto = prod.GetProductoCr(serial); // Obtén el producto por serial

                ArticuloCr.Serial = producto.Serial;
                ArticuloCr.NombreProducto = producto.Nombre;
                ArticuloCr.Precio = producto.Precio.ToString();
                ArticuloCr.Categoria = producto.Categoria;
                ArticuloCr.PhotoFilePath = producto.photoFilePath;
                ArticuloCr.EliminarDelCarritoClick += BEliminarPrCarrito_Click;
                ArticuloCr.ActualizarPrecioCarritoClick += BActualizarPrecioCr_Click;
                ArticuloCr.ActualizarPrecioPorCantidad += ArticuloCr_ActualizarPrecioClick;

                ArticuloCr.MainForm = MainForm;

                ArticuloCr.TBCantidadPr.Text = cantidad.ToString();

                FLPContenidoPrCarrito.Controls.Add(ArticuloCr);
                ArticuloCr.Show();
            }
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
            using (Pen pen = new Pen(Color.SpringGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BExitCarrito_Click(object sender, EventArgs e)
        {
            PanelContainerCr.Controls.Clear();
            PanelContainerCr.SendToBack();
            FondoOscuro.Close();
            MainForm.FondoOscuroCatalogo = null;
            this.Close();
        }

        public event EventHandler<int> EliminarPrCarritoClick;
        private void BEliminarPrCarrito_Click(object sender, int serial)
        {
            //Pasamos el id del producto al catálogo.
            EliminarPrCarritoClick?.Invoke(this,serial);
        }

        private void ArticuloCr_ActualizarPrecioClick(object sender, decimal total)
        {
            decimal precioActual = Convert.ToDecimal(LPrecioTotal.Text);
            LPrecioTotal.Text = Convert.ToString(precioActual + total);
        }

        private void BActualizarPrecioCr_Click(object sender, decimal total)
        {
            decimal totalActual = Convert.ToDecimal(LPrecioTotal.Text);
            LPrecioTotal.Text = (totalActual - total).ToString();
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (VerificarSiHayProductosCargados() == 0)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe cargar como mínimo un producto", "Error", "Error", null);
                mensaje.ShowDialog();
            }
            else
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que quiere seguir con la venta?", "Eliminar Producto", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    InstanciarYMostrarAltaVenta();
                    mensaje.Dispose();
                }
                else
                {
                    mensaje.Dispose();
                }
            }
        }

        private void InstanciarYMostrarAltaVenta()
        {
            AltaVenta AltaVn = new AltaVenta();
            AltaVn.TopLevel = false;

            actualizarCantidadListaProductos();

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaVn);
            AltaVn.PanelContainer = PanelContainer;
            AltaVn.MainForm = MainForm;
            AltaVn.IdPrCr = idPrCr;
            AltaVn.AVUsuario = PCUsuario;
            AltaVn.Show();
            FondoOscuro.Dispose();
            MainForm.FondoOscuroCatalogo = null;
            MainCatalogo.Dispose();
        }

        private int VerificarSiHayProductosCargados()
        {
            int contador = 0;

            // Recorremos todos los controles del FlowLayoutPanel
            foreach (Control control in FLPContenidoPrCarrito.Controls)
            {
                if (control is BotonesArticuloCr)
                {
                    contador++;
                }
            }
            return contador;
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BExitCarrito.Click -= BExitCarrito_Click;
            BComprar.Click -= BRegistrarVenta_Click;
            this.Load -= PanelCarrito_Load;

            // Liberar los recursos
            base.Dispose();
        }

        private void actualizarCantidadListaProductos()
        {
            foreach (Control control in FLPContenidoPrCarrito.Controls)
            {
                // Verifica si el control es del tipo BotonesArticuloCr
                if (control is BotonesArticuloCr articuloControl)
                {
                    int serial = articuloControl.Serial; // Obtén el serial del control
                    int nuevaCantidad;

                    if (int.TryParse(articuloControl.TBCantidadPr.Text, out nuevaCantidad))
                    {
                        if (idPrCr.ContainsKey(serial))
                        {
                            idPrCr[serial] = nuevaCantidad;
                        }
                    }
                    else
                    {
                        MsgPersonalizado mensaje = new MsgPersonalizado("Cantidad inválidad para el producto con serial: " + serial.ToString(),"Error","Error", null);
                        mensaje.ShowDialog();
                    }
                }
            }
        }

    }
}
