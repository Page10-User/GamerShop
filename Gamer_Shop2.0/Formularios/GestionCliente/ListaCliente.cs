using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionCliente
{
    public partial class ListaCliente : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NCliente ncliente = new NCliente();

        public Panel PanelContainer { get; set; }
        public ListaCliente()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth);
        }

        private void PBuscadorListaCl_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 10;
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

        private void ListaCLiente_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            ncliente.listaClientesActivos(DGListaCliente);
            try
            {
                ConfigurarDataGridView();
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
            using (Pen pen = new Pen(Color.Lime, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void PContListaCl_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.Lime, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ConfigurarDataGridView()
        {
            DGListaCliente.Columns["ID_Cliente"].Visible = false;
            DGListaCliente.Columns["CModificarCl"].DisplayIndex = 6;

        }

        private void DGListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaCliente.Columns["CModificarCl"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Crear una nueva instancia de Alta Cliente
                    string dni = DGListaCliente.CurrentRow.Cells["DNI"].Value.ToString();
                    NCliente cliente = new NCliente();

                    ModificarCliente ModificarCl = new ModificarCliente(cliente.GetCliente(dni));
                    ModificarCl.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(ModificarCl);
                    ModificarCl.PanelContainer = PanelContainer;
                    ModificarCl.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo Modificar el producto", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void BAltaCliente_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de Alta CLiente
            InstanciarYMostrarAltaCliente();
        }
        //--------------------------------------------------------InstanciarYMostrarAltaCliente----------------------------------------------------\\
        private void InstanciarYMostrarAltaCliente()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }
            
            AltaCliente AltaCl = new AltaCliente(true);
            AltaCl.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaCl);
            AltaCl.PanelContainer = PanelContainer;
            AltaCl.Show();
            this.Dispose();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-AltaProducto-Events->\\
            this.Load -= ListaCLiente_Load;

            //<-Paint-Events->\\
            PContListaCl.Paint -= PContListaCl_Paint;

            //<-Click-Events->\\
            BAltaCliente.Click -= BAltaCliente_Click;

            //<-TextBox-Events->\\
            //...\\

            //<-CellClick-Events-\\
            DGListaCliente.CellClick -= DGListaCliente_CellClick;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
