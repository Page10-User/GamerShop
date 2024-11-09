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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net;
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
                NProducto prod = new NProducto();
                ProductoViewModel producto = prod.GetProductoCr(serial); // Obtén el producto por serial

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

        //Inicio Validación TBDNIClienteExistente Keypress
        private void TBDNIClienteExistente_Keypress(object sender, KeyPressEventArgs e)
        {
            ClaseValidacion validador = new ClaseValidacion();
            string texto = TBDniClienteExistente.Texts;

            //Validamos la longitud
            if (!validador.ValidarLongitudConLimite(texto, 8, e.KeyChar))
            {
                e.Handled = true;
            }

            //Validar solo número
            if (!validador.ValidarKeyPressSoloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Fin Validación TBDNIClienteExistente KeyPress

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
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe ingresar un producto para realizar una venta", "Error", "Error", null);
                mensaje.ShowDialog();
                MainForm.TopMost = true;
            }
            else
            {
                if (TBFecha.Texts != string.Empty && TBMonto.Texts != string.Empty && CBCategoria.SelectedItem != null && TBDniClExist.Texts != string.Empty)
                {
                    try {
                        NVenta nventa = new NVenta();
                        nventa.NGuardarVenta(
                            float.Parse(TBMonto.Texts),
                            AVUsuario.ID_Usuario,
                            cliente.ID_Cliente,
                            CBCategoria.SelectedIndex = +1
                        );
                    } 
                    catch { 
                    }
                    MsgPersonalizado mensaje = new MsgPersonalizado("Venta registrada con éxito", "Registro", "Informacion", null);
                    mensaje.ShowDialog();
                    MainForm.TopMost = true;
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
                if (control is BotonesArticuloCr)
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
            //PContBuscarDni.Visible = true;
            //TBDniClienteExistente.Texts = DNI.ToString();
            TBDniClExist.Texts = DNI.ToString();
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
            List<string> campos = new List<string>{
                TBFecha.Texts,
                TBMonto.Texts,
                CBCategoria.SelectedItem?.ToString()
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

        private void BBuscarCliente_Dni__Click(object sender, EventArgs e)
        {
            try {
                NCliente nCliente = new NCliente();
                Cliente cliente1 = nCliente.GetCliente(TBDniClienteExistente.Texts);
                MsgPersonalizado mensaje = new MsgPersonalizado("El DNI: " + cliente1.DNI + " se encuentra registrado", "Cliente existente", "Informacion", null);
                mensaje.ShowDialog();
                MainForm.TopMost = true;
                cliente = cliente1;

                //Lo guardamos en el TextBox correspondiente
                TBDniClExist.Texts = cliente1.DNI.ToString();
            }
            catch {
                MsgPersonalizado mensaje = new MsgPersonalizado("El cliente no existe", "Error", "Error", null);
                mensaje.ShowDialog();
                MainForm.TopMost = true;
            }
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
    }
}
