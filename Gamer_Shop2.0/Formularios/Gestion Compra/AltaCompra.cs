using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    public partial class AltaCompra : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public Bienvenida MainForm { get; set; }

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
        private void EditarPerfil_Load(object sender, EventArgs e)
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
                MsgPersonalizado mensaje = new MsgPersonalizado("Debe cargar po lo menos 1 producto", "Error", "Error", null);
                mensaje.ShowDialog();
            }
            else
            {
                if (CBProveedor.SelectedIndex != -1)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("Venta registrada con éxito", "Registro", "Informacion", null);
                    mensaje.ShowDialog();
                    DGListaPrCompra.Rows.Clear();
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
            ListaProductosCompra formAltaCl = new ListaProductosCompra();
            formAltaCl.StartPosition = FormStartPosition.CenterScreen;
            formAltaCl.BringToFront();
            formAltaCl.MainForm = MainForm;
            formAltaCl.FondoOscurecido = formBG;
            formAltaCl.ShowInTaskbar = false;
            formAltaCl.TopMost = true;
            formAltaCl.ShowDialog();
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

                if (columnaClave == null || string.IsNullOrWhiteSpace(columnaClave.ToString()))
                {
                    return;
                }

                string valorIngresado = e.FormattedValue.ToString();

                if (!int.TryParse(valorIngresado, out int cantidad) || cantidad < 0)
                {
                    e.Cancel = true;
                    MsgPersonalizado mensaje = new MsgPersonalizado("Por favor, ingrese un número entero válido.", "Error", "Error", null);
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
            this.Load -= EditarPerfil_Load;
            CBProveedor.Validating -= CBCategoriaPr_Validating;
            BElegirPrLista.Click -= BElegirPrLista_Click;
            DGListaPrCompra.CellClick -= DGListaPr_CellClick;
            PListaPrCompra.Paint -= PListaPrCompra_Paint;
            BComprar.Click -= BComprar_Click;
            BListaDeCompras.Click -= BListaDeCompras_Click;

            // Liberar los recursos
            base.Dispose();
        }
    }
}