using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Excepciones;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    public partial class AltaCompra : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        bool FiltroWasChanged = false;

        public Panel PanelContainer { get; set; }
        public Bienvenida MainForm { get; set; }

        public Usuario ACUsuario { get; set; }

        public AltaCompra()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PContAltaCompra_Paint(object sender, PaintEventArgs e)
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

        private void PListaPrCompra_Paint(object sender, PaintEventArgs e)
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
                using (Pen pen = new Pen(Color.LightGreen, 4))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void AltaCompra_Load(object sender, EventArgs e)
        {
            cargarProveedores();

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

        public void cargarProveedores()
        {
            NProveedor nprov = new NProveedor();
            
            CBProveedor.DataSource = nprov.getProveedoresActivos();
        }

        private void BListaDeCompras_Click(object sender, EventArgs e)
        {
            // Mostrar form
            InstanciarYMostrarListaCompra();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        //Validación Inicio CategoriaProveedor
        private void CBCategoriaPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBProveedor.SelectedIndex == -1)
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

        //Validación Fin CategoriaProveedor

        private void BComprar_Click(object sender, EventArgs e)
        {
            if (DGListaPrCompra.Rows.Count == 0 || DGListaPrCompra.Rows.Count == 1 && DGListaPrCompra.Rows[0].IsNewRow)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe cargar por lo menos 1 producto", "Error", "Error", null);
                mensaje.ShowDialog();
            }
            else
            {
                if (CBProveedor.SelectedIndex >= 0)
                {
                    try
                    {
                        NCompra ncompra = new NCompra();
               
                        List<Detalle_compra> detallescompra = new List<Detalle_compra>();
                        float total = 0;
                        NDetalleCompra ndetalle = new NDetalleCompra();

                        foreach (DataGridViewRow row in DGListaPrCompra.Rows)
                        {
                            float subtotal = float.Parse(row.Cells["CPrecioPr"].Value.ToString()) * int.Parse(row.Cells["CCantidadPr"].Value.ToString());

                            Detalle_compra detalle = ndetalle.NGenerarDetalle
                            (
                            int.Parse(row.Cells["ID_Producto"].Value.ToString()),
                        
                            subtotal,
                            int.Parse(row.Cells["CCantidadPr"].Value.ToString()),
                            float.Parse(row.Cells["CPrecioPr"].Value.ToString())
                            );
                            detallescompra.Add(detalle);
                            total += subtotal;
                        }


                        // Llama al método para registrar la compra en la capa de datos
                        ncompra.NGuardarCompra(total, ACUsuario.ID_Usuario, CBProveedor.Texts , ndetalle.NGuardarDetalles(detallescompra));

                        NProducto nproducto = new NProducto();
                        foreach (Detalle_compra detalle in detallescompra)
                        {
                            Producto prod = nproducto.GetProductoID(detalle.ID_Producto);
                            int stockNuevo = prod.Stock + detalle.Cantidad;
                            nproducto.actualizarStock(
                                prod.ID_Producto,
                                stockNuevo
                            );
                        }


                        MsgPersonalizado mensaje = new MsgPersonalizado("compra registrada con éxito", "Registro", "Informacion", null);
                        mensaje.ShowDialog();
                        DGListaPrCompra.Rows.Clear();
                        MainForm.TopMost = true;
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
                    MsgPersonalizado mensaje = new MsgPersonalizado("Por favor seleccione un proveedor para registrar la compra", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void DGListaPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Eliminar un producto del dataGrid
            if (e.ColumnIndex == DGListaPrCompra.Columns["CEliminarPr"].Index && e.RowIndex >= 0)
            {
                var fila = DGListaPrCompra.Rows[e.RowIndex];
                var columnaClave = fila.Cells["CNombrePr"].Value;

                if (columnaClave != null && !string.IsNullOrWhiteSpace(columnaClave.ToString()))
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea eliminar este producto?", "Eliminar Producto", "Interrogacion", null);
                    DialogResult result = mensaje.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        DGListaPrCompra.Rows.RemoveAt(e.RowIndex);
                        mensaje.Dispose();
                    }
                    else
                    {
                        mensaje.Dispose();
                    }
                }
            }
            //Modificar cantidad del dataGrid
            if(e.ColumnIndex == DGListaPrCompra.Columns["CCantidadPr"].Index && e.RowIndex >= 0)
            {
                var fila = DGListaPrCompra.Rows[e.RowIndex];
                var columnaClave = fila.Cells["CNombrePr"].Value;

                if (columnaClave != null && !string.IsNullOrWhiteSpace(columnaClave.ToString()))
                {
                    DGListaPrCompra.Columns["CCantidadPr"].ReadOnly = false;
                }
                else
                {
                    DGListaPrCompra.Columns["CCantidadPr"].ReadOnly = true;
                }
            }
        }

        private void BElegirPrLista_Click(object sender, EventArgs e)
        {
            // Crear un nuevo formulario para el efecto de oscurecimiento
            Form formBG = new Form();
            personalizarFondoNegro(formBG);

            // Mostrar el formulario de oscurecimiento
            formBG.Show();

            //Mostrar form "Alta Cliente"
            ListaProductosCompra formListaCompra = new ListaProductosCompra();
            formListaCompra.StartPosition = FormStartPosition.CenterScreen;
            formListaCompra.BringToFront();
            formListaCompra.MainForm = MainForm;
            formListaCompra.FondoOscurecido = formBG;
            formListaCompra.AgregarAlDataGrid += AltaCompra_CargarProductoDG;
            formListaCompra.ShowInTaskbar = false;
            formListaCompra.TopMost = true;
            formListaCompra.ShowDialog();
        }
        private void AltaCompra_CargarProductoDG(object sender, int Serial)
        {
            try
            {
                // Obtenemos el producto usando la serial
                NProducto nproducto = new NProducto();
                Producto producto = nproducto.GetProducto(Serial);

                // Verificar si el producto ya existe en el DataGridView
                if (DGListaPrCompra.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in DGListaPrCompra.Rows)
                    {
                        if (Convert.ToInt32(row.Cells["CSerial"].Value) == producto.Serial)
                        {
                            // Si existe aumentamos su cantidad.
                            int cantidadActual = Convert.ToInt32(row.Cells["CCantidadPr"].Value);
                            row.Cells["CCantidadPr"].Value = cantidadActual + 1;

                            // Actualizamos el total
                            decimal precio = Convert.ToDecimal(row.Cells["CPrecioPr"].Value);
                            row.Cells["CTotalPr"].Value = (cantidadActual + 1) * precio;

                            return;
                        }
                    }
                }
                // Si el producto no existe, agregar una nueva fila en el DataGridView
                DGListaPrCompra.Rows.Add(
                    producto.ID_Producto,
                    producto.Nombre,
                    producto.Serial,
                    producto.ID_Categoria,
                    1,
                    producto.Precio,
                    producto.Precio
                );

            }
            catch (Exception ex)
            {
                // Mostrar un mensaje personalizado en caso de error
                MsgPersonalizado mensaje = new MsgPersonalizado("Error al intentar cargar el producto al DataGridView" + ex.Message, "Error", "Error", null);
                mensaje.ShowDialog();
            }
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

        private void DGListaPrCompra_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (DGListaPrCompra.Columns[e.ColumnIndex].Name == "CCantidadPr")
            {
                var fila = DGListaPrCompra.Rows[e.RowIndex];
                var columnaClave = fila.Cells["CNombrePr"].Value;

                // Verifica si el producto (NombrePr) está vacío; si es así, no valida nada
                if (columnaClave == null || string.IsNullOrWhiteSpace(columnaClave.ToString()))
                {
                    return;
                }

                string valorIngresado = e.FormattedValue.ToString();

                // Verifica si el valor ingresado es un número entero válido y positivo
                if (!int.TryParse(valorIngresado, out int cantidad) || cantidad < 0)
                {
                    e.Cancel = true;
                    MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese un número entero válido.", "Error", "Error", null);
                    mensaje.ShowDialog();
                    return;
                }

                // Obtén el precio desde la columna "CPrecioPr"
                if (fila.Cells["CPrecioPr"].Value != null && decimal.TryParse(fila.Cells["CPrecioPr"].Value.ToString(), out decimal precio))
                {
                    // Calcula el total y lo actualiza en "CTotalPr"
                    fila.Cells["CTotalPr"].Value = cantidad * precio;
                }
                else
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Error al obtener el precio del producto.", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        //------------------------------------------------------------------------------------InstanciarListaCompra-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarListaCompra()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            // Mostrar form
            ListaCompra formListCo = new ListaCompra();
            formListCo.TopLevel = false;
            formListCo.PanelContainer = PanelContainer;
            formListCo.MainForm = MainForm;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formListCo);
            PanelContainer.BringToFront();

            formListCo.Show();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= AltaCompra_Load;
            CBProveedor.Validating -= CBCategoriaPr_Validating;
            BElegirPrLista.Click -= BElegirPrLista_Click;
            DGListaPrCompra.CellClick -= DGListaPr_CellClick;
            PListaPrCompra.Paint -= PListaPrCompra_Paint;
            BComprar.Click -= BComprar_Click;
            BListaDeCompras.Click -= BListaDeCompras_Click;

            // Liberar los recursos
            base.Dispose();
        }

        private void BBuscador_Click(object sender, EventArgs e)
        {
            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaPrCompra.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaPrCompra.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaPrCompra);
        }
        private void FiltrarDataGrid(DataGridView data)
        {
            string filtro = TBBuscar.Texts.ToLower();

            foreach (DataGridViewRow fila in data.Rows)
            {
                // Verifica si alguna celda en la fila contiene el texto del filtro
                bool cumpleFiltro = fila.Cells
                    .Cast<DataGridViewCell>()
                    .Any(celda => celda.Value != null && celda.Value.ToString().ToLower().Contains(filtro));

                // Ajusta la visibilidad de la fila según el resultado del filtro
                fila.Visible = cumpleFiltro;
            }
        }
    }
}