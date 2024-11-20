using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.Comercio.Carrito;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using Gamer_Shop2._0.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;
using static Gamer_Shop2._0.Datos.DProducto;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class AltaVenta : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public Bienvenida MainForm { get; set; }
        public Dictionary<int, int> IdPrCr { set; get; }

        public Usuario AVUsuario { get; set; }

        Cliente cliente;
        public AltaVenta()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            BordeRedondeadoPanels();
        }

        private void MostrarProductosEnFLPCarrito()
        {
            FLPListaProductosVenta.Controls.Clear();

            // Itera sobre cada producto en el diccionario
            foreach (var item in IdPrCr)
            {
                int serial = item.Key; // Serial del producto
                int cantidad = item.Value; // Cantidad del producto

                BotonArticuloVn ArticuloCr = new BotonArticuloVn();
                Debug.WriteLine($"Intentando obtener el producto con serial: {serial}");
                NProducto prod = new NProducto();
                ProductoViewModel producto = prod.GetProductoCr(serial); // Obtén el producto por serial

                if (producto != null)
                {
                    Debug.WriteLine($"Producto encontrado: ID={producto.ID}, Nombre={producto.Nombre}, Precio={producto.Precio}");
                }
                else
                {
                    Debug.WriteLine($"No se encontró el producto con serial: {serial}");
                    continue; // Salta la iteración si el producto no existe
                }

                ArticuloCr.ID = producto.ID;
                ArticuloCr.Serial = producto.Serial;
                ArticuloCr.NombreProducto = producto.Nombre;
                ArticuloCr.Precio = producto.Precio.ToString();
                ArticuloCr.Categoria = producto.Categoria;

                ArticuloCr.MainForm = MainForm;

                //Asociamos al evento Eliminar.
                ArticuloCr.EliminarDelCarritoClick += ArticuloCr_EliminarPrCarritoClick;
                ArticuloCr.RecalcularPrecio += ArticuloCr_ActualizarPrecioClick;

                ArticuloCr.TBCantidadPr.Text = cantidad.ToString();

                FLPListaProductosVenta.Controls.Add(ArticuloCr);
                ArticuloCr.Show();
            }
        }

        private void AltaVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Método_pago' Puede moverla o quitarla según sea necesario.
            this.método_pagoTableAdapter.Fill(this.dataSet1.Método_pago);
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            TBFecha.Texts = DateTime.Now.ToString("dd-MM-yyyy");
            MostrarProductosEnFLPCarrito();
            AplicarMonto();
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

        //Validaciones

        //INICIO Validacion Fecha
        
        // Generado automaticamente por el sistema (además es inmodificable).

        //FIN Validacion Fecha

        //INICIO Validacion Monto

        // Monto generado automaticamente por el sistema (además es inmodificable).
            
        //FIN Validacion Monto

        //INICIO Validacion MetodoPago
        private void CBCategoria_Validating(object sender, CancelEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string seleccion = CBCategoria.SelectedItem?.ToString();

            OcultarValidaciones();

            if (!validador.ValidarSeleccion(seleccion))
            {
                e.Cancel = true;
                CBCategoria.Texts = "Seleccionar...";
                TBValidacion.Visible = true;
            }
        }
        //FIN Validacion MetodoPago

        //Inicio TextChanged
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }
        //Fin TextChanged

        private void BRegistrarVn_Click(object sender, EventArgs e)
        {
            if (VerificarSiHayProductosCargados() == 0)
            {
                Debug.WriteLine("No hay productos cargados en el carrito.");
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe ingresar un producto para realizar una venta", "Error", "Error", null);
                mensaje.ShowDialog();
                MainForm.TopMost = true;
            }
            else
            {
                if (TBFecha.Texts != string.Empty && TBMonto.Texts != string.Empty && CBCategoria.SelectedItem != null && TBDniClExist.Texts != string.Empty)
                {
                    try {
                        List<Detalle_venta> detallesVenta = new List<Detalle_venta>();
                        float total = 0;
                        NDetalleVenta ndetalle = new NDetalleVenta();

                        foreach (BotonArticuloVn botonArticulo in FLPListaProductosVenta.Controls)
                        {
                            float subtotal = int.Parse(botonArticulo.Precio) * int.Parse(botonArticulo.TBCantidadPr.Text);

                                Detalle_venta detalle = ndetalle.NGenerarDetalle
                                (
                                botonArticulo.ID,
                                subtotal,
                                int.Parse(botonArticulo.TBCantidadPr.Text),
                                 float.Parse(botonArticulo.Precio)
                                );

                                detallesVenta.Add(detalle);

                            total += subtotal;
                            }
                        

                        // Llama al método para registrar la venta en la capa de datos
                        NVenta nventa  = new NVenta();
                        NCliente cliente = new NCliente();


                        int idcliente = cliente.GetCliente(TBDniClExist.Texts).ID_Cliente;

                        nventa.NGuardarVenta(total, AVUsuario.ID_Usuario, idcliente, CBCategoria.SelectedIndex + 1, ndetalle.NGuardarDetalles(detallesVenta));

                        NProducto nproducto = new NProducto();
                        foreach (Detalle_venta detalle in detallesVenta)
                        {
                            Producto prod = nproducto.GetProductoID(detalle.ID_Producto);
                            int stockNuevo = prod.Stock - detalle.Cantidad;

                            if (stockNuevo < 0)
                            {
                                MsgPersonalizado mensajeError = new MsgPersonalizado(
                                    $"Error: La cantidad solicitada para '{prod.Nombre}' excede el stock disponible.",
                                    "Error de stock", "Error", null);
                                mensajeError.ShowDialog();
                                MainForm.TopMost = true;
                                return;
                            }

                            nproducto.actualizarStock(prod.ID_Producto, stockNuevo);
                        }
                        MsgPersonalizado mensaje = new MsgPersonalizado("Venta registrada con éxito", "Registro", "Informacion", null);
                        mensaje.ShowDialog();
                        MainForm.TopMost = true;
                        BReciboVn.Visible = true;
                        LRecibo.Visible = true;

                    }
                    catch (ExisteRegistroException ex)
                    {
                        // Manejo de la excepción cuando el número de serial no existe
                        MsgPersonalizado msg = new MsgPersonalizado(ex.Message, "Error", "Error", null);
                        msg.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de cualquier otra excepción
                        MsgPersonalizado msg = new MsgPersonalizado(ex.Message, "Error", "Error", null);
                        msg.ShowDialog();
                    }
                    
                    }
                else
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Debe completar todos los campos para registrar una venta", "Error", "Error", generarListaCampos());
                    mensaje.ShowDialog();
                    MainForm.TopMost = true;
                }
            }
        }

        private int VerificarSiHayProductosCargados()
        {
            int contador = 0;

            // Recorremos todos los controles del FlowLayoutPanel
            foreach (Control control in FLPListaProductosVenta.Controls)
            {
                if (control is BotonArticuloVn)
                {
                    contador++;
                }
            }
            return contador;
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
            formAltaCl.ObtenerDNICliente += FormAltaCl_ObtenerDNICliente;
            formAltaCl.ShowInTaskbar = false;
            formAltaCl.TopMost = true;
            formAltaCl.ShowDialog();
        }

        private void FormAltaCl_ObtenerDNICliente(object sender, int DNI)
        {
            TBDniClExist.Texts = DNI.ToString();
        }

        private void BClienteExistente_Click(object sender, EventArgs e)
        {
            //if (PContBuscarDni.Visible)
            //{
            //    PContBuscarDni.Visible = false;
            //}
            //else
            //{
            //    PContBuscarDni.Visible = true;
            //}
            //Nueva implementación---------------------------------
            Form formBG = new Form();
            personalizarFondoNegro(formBG);

            formBG.Show();

            ListaClienteVn listClVn = new ListaClienteVn();
            listClVn.StartPosition = FormStartPosition.CenterScreen;
            listClVn.BringToFront();
            listClVn.FondoOscurecido = formBG;
            listClVn.ObtenerDNICliente += FormAltaCl_ObtenerDNICliente;
            listClVn.ShowInTaskbar = false;
            listClVn.TopMost = true;
            listClVn.ShowDialog();
        }

        private void AplicarMonto()
        {
            decimal total = 0;

            // Recorre cada control en el FlowLayoutPanel
            foreach (Control control in FLPListaProductosVenta.Controls)
            {
                if (control is BotonArticuloVn botonArticulo)
                {
                    // Intenta obtener el precio y la cantidad
                    if (decimal.TryParse(botonArticulo.Precio, out decimal precio) &&
                        int.TryParse(botonArticulo.TBCantidadPr.Text, out int cantidad))
                    {
                        total += precio * cantidad;
                    }
                }
            }
            TBMonto.Texts = total.ToString("F2");
        }

        private void mostrarIDEjemplo()
        {
            foreach (BotonArticuloVn control in FLPListaProductosVenta.Controls)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("ID DEL PRODUCTO: " + control.ID.ToString(), "ID_Producto","Error",null);
                mensaje.ShowDialog();
            }
        }

        private void ArticuloCr_EliminarPrCarritoClick(object sender, decimal total)
        {
            decimal precioActual = Convert.ToDecimal(TBMonto.Texts);
            TBMonto.Texts = Convert.ToString(precioActual - total);
        }
        private void ArticuloCr_ActualizarPrecioClick(object sender, decimal total)
        {
            decimal precioActual = Convert.ToDecimal(TBMonto.Texts);
            TBMonto.Texts = Convert.ToString(precioActual + total);
        }

        private void BordeRedondeadoPanels()
        {
            PContAltaVn1.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PContAltaVn2.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PContAltaVn3.Paint += new PaintEventHandler(PContAltaVn_Paint);
            PContAltaVn4.Paint += new PaintEventHandler(PContAltaVn_Paint);
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
            string combo = "";
            if (CBCategoria.Texts != "Seleccionar...")
            {
                combo = CBCategoria.SelectedItem.ToString();
            }
            List<string> campos = new List<string>{
                TBFecha.Texts,
                TBMonto.Texts,
                TBDniClExist.Texts,
                combo
             };
            return campos;
        }

        private void OcultarValidaciones()
        {
            TBValidacion.Visible = false;
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= AltaVenta_Load;
            PContAltaVn1.Paint -= PContAltaVn_Paint;
            PContAltaVn2.Paint -= PContAltaVn_Paint;
            PContAltaVn3.Paint -= PContAltaVn_Paint;
            PContAltaVn4.Paint -= PContAltaVn_Paint;
            BRegistrarVn.Click -= BRegistrarVn_Click;
            BClienteExistente.Click -= BClienteExistente_Click;
            BNuevoCliente.Click -= BNuevoCliente_Click;
            CBCategoria.Validating -= CBCategoria_Validating;
            TBFecha._TextChanged -= TextBox_TextChanged;
            TBMonto._TextChanged -= TextBox_TextChanged;

            // Liberar los recursos
            base.Dispose();
        }

        private void BBuscador_Click(object sender, EventArgs e)
        {
            // Verifica si no se escribió nada en el buscador
            if (string.IsNullOrWhiteSpace(TBFiltro.Texts))
            {
                foreach (BotonArticuloVn producto in FLPListaProductosVenta.Controls)
                {
                    producto.Visible = true;
                }
            }

            // Verifica si no se escribió nada en el buscador
            if (!string.IsNullOrWhiteSpace(TBFiltro.Texts))
            {
                string buscar = TBFiltro.Texts.Trim().ToLower();

                foreach (BotonArticuloVn producto in FLPListaProductosVenta.Controls)
                {
                    bool matches = producto.NombreProducto.ToLower().Contains(buscar) || producto.Precio.ToString().Contains(buscar);

                    producto.Visible = matches;
                }
            }
        }

        private void BReciboVn_Click(object sender, EventArgs e)
        {
            var context = new ProyectoTallerIIEntities1();

            var idVenta = context.Venta
                                 .OrderByDescending(v => v.ID_Venta)
                                 .Select(v => v.ID_Venta)
                                 .FirstOrDefault();

            if (idVenta == 0)
            {
                MessageBox.Show("No hay ventas registradas.");
                return;
            }

            var detallesVenta = context.Detalle_venta
                                       .Where(d => d.ID_Venta == idVenta)
                                       .Join(context.Producto,
                                             detalle => detalle.ID_Producto,
                                             producto => producto.ID_Producto,
                                             (detalle, producto) => new
                                             {
                                                 NombreProducto = producto.Nombre,
                                                 Cantidad = detalle.Cantidad,
                                                 PrecioUnitario = detalle.Precio_actual
                                             })
                                       .ToList();

            // Obtener el nombre del método de pago
            var metodoPago = context.Venta
                                    .Where(v => v.ID_Venta == idVenta)
                                    .Join(context.Método_pago,
                                          venta => venta.ID_Método,
                                          metodo => metodo.ID_Método,
                                          (venta, metodo) => metodo.Descripción)
                                    .FirstOrDefault();

            var clienteInfo = context.Venta
                         .Where(v => v.ID_Venta == idVenta)
                         .Join(context.Cliente,
                               venta => venta.ID_Cliente,
                               cliente => cliente.ID_Cliente,
                               (venta, cliente) => new
                               {
                                   cliente.Nombre,
                                   cliente.Apellido,
                                   cliente.DNI,
                                   cliente.Teléfono,
                                   cliente.Correo
                               })
                          .FirstOrDefault();

            var usuarioInfo = context.Venta
                         .Where(v => v.ID_Venta == idVenta)
                         .Join(context.Usuario,
                               venta => venta.ID_Usuario,
                               usuario => usuario.ID_Usuario,
                               (venta, usuario) => new
                               {
                                   usuario.Nombre,
                                   usuario.Apellido,
                                   usuario.Correo
                               })
                         .FirstOrDefault();

            // Generar el contenido HTML del recibo
            string logoPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\logo3.png"));
            string logoUrl = "file:///" + logoPath.Replace("\\", "/");

            StringBuilder reciboHtml = new StringBuilder();
            reciboHtml.AppendLine("<html>");
            reciboHtml.AppendLine("<head><style>body { font-family: Arial, sans-serif; padding: 40px; } table { width: 100%; border-collapse: collapse; } th, td { padding: 8px; text-align: left; } .total { font-weight: bold; }");
            reciboHtml.AppendLine("th { border-top: 2px solid red; border-bottom: 2px solid red; }");
            reciboHtml.AppendLine("td { border: none; }");
            reciboHtml.AppendLine("</style></head>");
            
            reciboHtml.AppendLine("<body>");
            reciboHtml.AppendLine($"<img src='{logoUrl}' alt='Logo' style='height: 150px; float: right; margin-left: 20px; vertical-align: middle;' />");
            reciboHtml.AppendLine("<h1 style='color: darkblue; font-size: 70px; margin-bottom: -10px;'>Recibo</h1>");
            reciboHtml.AppendLine($"<p style='font-size: 20px; margin-bottom: -10px;'><strong> Gamer_Shop </strong></p>");
            reciboHtml.AppendLine($"<p style='font-size: 15px;'><strong>Dirección: Calle Aleatoria 123, Zona Comercial, Corrientes, PA, 12345</strong></p>");


            //-------------------------------------------------------------------------------------------------------------------------------------------------\\
            reciboHtml.AppendLine("<table style='width: 100%; margin-bottom: 20px;'>");
            reciboHtml.AppendLine("<tr>");

            // Columna de datos de la factura
            reciboHtml.AppendLine("<td style='width: 33%; vertical-align: top;'>");
            reciboHtml.AppendLine("<h2 style='color: darkblue; font-size: 24px; margin-bottom: 10px;'>Detalles</h2>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='color: rgb(0, 1, 53); font-size: 20px;'>Nro de Recibo:</strong> {idVenta}</p>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='color: rgb(0, 1, 53); font-size: 20px;'>Fecha:</strong> {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}</p>");
            DateTime fechaVencimiento = DateTime.Now.AddDays(3);
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='color: rgb(0, 1, 53); font-size: 20px;'>Fecha de vencimiento:</strong> {fechaVencimiento.ToString("dd/MM/yyyy HH:mm:ss")}</p>");

            // Columna de datos del método
            reciboHtml.AppendLine($"<p><strong style='color: rgb(0, 1, 53); font-size: 20px;'>Método de Pago:</strong> {metodoPago}</p>");
            reciboHtml.AppendLine("</td>");

            // Columna de datos del cliente
            reciboHtml.AppendLine("<td style='width: 33%; vertical-align: top;'>");
            reciboHtml.AppendLine("<h2 style='color: darkblue; font-size: 24px; margin-bottom: 10px;'>Enviar A</h2>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='font-size: 17px;'>Cliente:</strong> {clienteInfo.Nombre} {clienteInfo.Apellido}</p>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='font-size: 17px;'>DNI:</strong> {clienteInfo.DNI}</p>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='font-size: 17px;'>Teléfono:</strong> {clienteInfo.Teléfono}</p>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='font-size: 17px;'>Correo:</strong> {clienteInfo.Correo}</p>");
            reciboHtml.AppendLine("</td>");

            // Columna de datos del usuario
            reciboHtml.AppendLine("<td style='width: 33%; vertical-align: top;'>");
            reciboHtml.AppendLine("<h2 style='color: darkblue; font-size: 24px; margin-bottom: 10px;'>Enviado Por</h2>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='font-size: 17px;'>Vendedor:</strong> {usuarioInfo.Nombre} {usuarioInfo.Apellido}</p>");
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='font-size: 17px;'>Correo:</strong> {usuarioInfo.Correo}</p>");
            reciboHtml.AppendLine("</td>");

            reciboHtml.AppendLine("</tr>");
            reciboHtml.AppendLine("</table>");
            //-------------------------------------------------------------------------------------------------------------------------------------------------\\


            reciboHtml.AppendLine("<table>");
            reciboHtml.AppendLine("<tr style='color: rgb(0, 1, 53); font-size: 20px;'><th>Producto</th><th>Cantidad</th><th>Precio Unitario</th><th>Subtotal</th></tr>");

            decimal total = 0;
            foreach (var detalle in detallesVenta)
            {
                decimal subtotal = detalle.Cantidad * Convert.ToDecimal(detalle.PrecioUnitario);
                total += subtotal;
                reciboHtml.AppendLine($"<tr><td>{detalle.NombreProducto}</td><td>{detalle.Cantidad}</td><td>{detalle.PrecioUnitario:C}</td><td>{subtotal:C}</td></tr>");
            }

            // Mostrar el total
            reciboHtml.AppendLine($"<tr><td colspan='3' class='total' style='color: rgb(0, 1, 53); font-size: 20px;'>Total</td><td class='total' style='color: rgb(0, 1, 53); font-size: 20px;'>{total:C}</td></tr>");
            reciboHtml.AppendLine("</table>");
            reciboHtml.AppendLine("<p> <strong> ¡Gracias por elegirnos, que tenga un buen día! </strong></p>");
            reciboHtml.AppendLine("</body></html>");

            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Recibo_Venta_{idVenta}.html");
            File.WriteAllText(rutaArchivo, reciboHtml.ToString());

            System.Diagnostics.Process.Start(rutaArchivo);
        }
    }
}
