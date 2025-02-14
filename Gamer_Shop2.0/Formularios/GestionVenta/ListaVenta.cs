using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.GestionBackups.ClaseBackups;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class ListaVenta : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NVenta nventa = new NVenta();

        public Panel PanelContainer { get; set; }
        public Bienvenida Mainform { get; set; }

        public Usuario LUsuario { get; set; }

        public Label LabelVersion { get; set; }
        public ListaVenta(bool desdeDonde)
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            ManejarVisibilidadBotonCatalogo(desdeDonde);
        }

        private void PContListaVn_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 1;
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

        private void ManejarVisibilidadBotonCatalogo(bool desdeDonde)
        {
            if (desdeDonde)
            {
                BShowCatalogo.Visible = true;
                LShowCatalogo.Visible = true;
            }
            else
            {
                BShowCatalogo.Visible = false;
                LShowCatalogo.Visible = false;
            }
        }

        private void ListaVenta_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            nventa.getVentas(DGListaVn);

            try
            {
                configurarDataGridView();
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otra excepción
                MessageBox.Show(ex.Message);
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
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BShowCatalogo_Click(object sender, EventArgs e)
        {
            // Instanciar y Mostrar form
            InstanciarYMostrarCatalogo();
        }

        public void configurarDataGridView ()
        {
            if (DGListaVn.Rows.Count > 0)
            {
                DataGridViewButtonColumn botondetalle = new DataGridViewButtonColumn();

                // Configurar propiedades de la columna
                botondetalle.Name = "Detalle_venta"; // Nombre de la columna
                botondetalle.HeaderText = "Detalle de venta"; // Texto del encabezado

                DataGridViewButtonColumn botonRecibo = new DataGridViewButtonColumn();
                //Agregamos boton para generar recibo de venta
                botonRecibo.Name = "CReciboVn";
                botonRecibo.HeaderText = "Generar Recibo";

                // Agregar las columnas al DataGridView
                DGListaVn.Columns.Add(botondetalle);
                DGListaVn.Columns["Detalle_venta"].DisplayIndex = 6;
                DGListaVn.Columns.Add(botonRecibo);
                DGListaVn.Columns["CReciboVn"].DisplayIndex = 7;
            }
        }

        private void DGListaVn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaVn.Columns["Detalle_venta"].Index && e.RowIndex >= 0)
            {
                try
                {
                    NVenta nventa = new NVenta();
                    Venta ventaactual = new Venta();
                    //ventaactual = nventa.GetVenta(int.Parse(DGListaVn.CurrentRow.Cells["ID_Venta"].Value.ToString()));
                  
                    // Crear una nueva instancia de ListaProductos
                    ListaDetalleVenta listadetalles = new ListaDetalleVenta(int.Parse(DGListaVn.CurrentRow.Cells["ID_Venta"].Value.ToString()));
                    listadetalles.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(listadetalles);
                    listadetalles.LUsuario = LUsuario;
                    listadetalles.LabelVersion = LabelVersion;
                    listadetalles.PanelContainer = PanelContainer;
                    listadetalles.Show();
                    //this.Dispose();
                }
                catch (Exception x)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + x.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }else if (e.ColumnIndex == DGListaVn.Columns["CReciboVn"].Index && e.RowIndex >= 0)
            {
                int idventa = Convert.ToInt32(DGListaVn.CurrentRow.Cells["ID_Venta"].Value);
                generarRecibo(idventa);
            }
        }

            //------------------------------------------------------------------------------------InstanciarCatalogo-------------------------------------------------------------------------------\\
            private void InstanciarYMostrarCatalogo()
        {
            Control control = PanelContainer.Controls[0];
             if (control is Form)
             {
                 //Liberamos recursos
                 control.Dispose();
             }

             // Instanciar y Mostrar form
             Catalogo formCatalogo = new Catalogo();
             formCatalogo.TopLevel = false;
             formCatalogo.PanelContainer = PanelContainer;
             formCatalogo.MainForm = Mainform;
             formCatalogo.LabelContainer = LabelVersion;
             formCatalogo.CUsuario = LUsuario;
             PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
             PanelContainer.Controls.Add(formCatalogo);
             PanelContainer.BringToFront();

             formCatalogo.Show();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= ListaVenta_Load;
            PContListaVn.Paint -= PContListaVn_Paint;
            BShowCatalogo.Click -= BShowCatalogo_Click;

            // Liberar los recursos
            //base.Dispose();
        }

        private void BDescargarListVn_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmación para iniciar la descarga
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea descargar la lista de ventas?", "Descargar lista venta?", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Close();

                // Crear el FolderBrowserDialog para seleccionar la carpeta
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    folderDialog.Description = "Seleccione una carpeta para guardar la lista de ventas";
                    folderDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Empezar en C:
                    folderDialog.ShowNewFolderButton = true;

                    // Mostrar el diálogo con el formulario principal como propietario
                    if (folderDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        // Obtener la ruta seleccionada
                        string rutaSeleccionada = folderDialog.SelectedPath;

                        // Llamar a la función de backup con la ruta seleccionada
                        BackupVentas.ExportarVentasACSV(rutaSeleccionada);

                        // Mostrar mensaje de éxito
                        mensaje = new MsgPersonalizado("Lista descargada con éxito!", "Descargar lista", "Informacion", null);
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        // El usuario canceló la selección de carpeta
                        mensaje = new MsgPersonalizado("Operación cancelada.", "Descargar lista", "Informacion", null);
                        mensaje.ShowDialog();
                    }
                }
            }
            else
            {
                mensaje.Close();
            }
        }

        private void generarRecibo(int idventa)
        {
            var context = new ProyectoTallerIIEntities1();

            var detallesVenta = context.Detalle_venta
                                       .Where(d => d.ID_Venta == idventa)
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
                                    .Where(v => v.ID_Venta == idventa)
                                    .Join(context.Método_pago,
                                          venta => venta.ID_Método,
                                          metodo => metodo.ID_Método,
                                          (venta, metodo) => metodo.Descripción)
                                    .FirstOrDefault();

            var clienteInfo = context.Venta
                         .Where(v => v.ID_Venta == idventa)
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
                         .Where(v => v.ID_Venta == idventa)
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
            reciboHtml.AppendLine($"<p style='margin-bottom: -10px;'><strong style='color: rgb(0, 1, 53); font-size: 20px;'>Nro de Recibo:</strong> {idventa}</p>");
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

            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Recibo_Venta_{idventa}.html");
            File.WriteAllText(rutaArchivo, reciboHtml.ToString());

            System.Diagnostics.Process.Start(rutaArchivo);
        }

        private void BBuscador_Click(object sender, EventArgs e)
        {
            buscarVenta();
        }

        private void buscarVenta()
        {
            foreach (DataGridViewRow fila in DGListaVn.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaVn.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }
            FiltrarDataGrid(DGListaVn);
        }

        private void FiltrarDataGrid(DataGridView grid)
        {
            if (grid.DataSource is DataTable dataTable)
            {
                string filtro = TBFiltro.Texts.ToLower();
                if (string.IsNullOrWhiteSpace(filtro))
                {
                    dataTable.DefaultView.RowFilter = string.Empty;
                    return;
                }
                List<string> condiciones = new List<string>();
                foreach (DataColumn columna in dataTable.Columns)
                {
                    if (columna.DataType == typeof(string) || columna.DataType == typeof(int) || columna.DataType == typeof(decimal) || columna.DataType == typeof(double))
                    {
                        condiciones.Add($"CONVERT([{columna.ColumnName}], System.String) LIKE '%{filtro}%'");
                    }
                }
                string expresionFiltro = string.Join(" OR ", condiciones);
                dataTable.DefaultView.RowFilter = expresionFiltro;
            }
            else
            {
                MessageBox.Show("El DataGridView no está enlazado a un DataTable.");
            }
        }

    }
}
