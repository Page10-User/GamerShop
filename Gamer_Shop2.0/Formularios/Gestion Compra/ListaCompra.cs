using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    public partial class ListaCompra : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NCompra ncompra = new NCompra();

        public Bienvenida MainForm { get; set; }
        public Panel PanelContainer { get; set; }
        public ListaCompra()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void ListaCompra_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            ncompra.getCompras(DGListaCompra);

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

        private void PContListaCompra_Paint(object sender, PaintEventArgs e)
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

        public void configurarDataGridView()
        {
            if (DGListaCompra.Rows.Count > 0) {
                DataGridViewButtonColumn botondetalle = new DataGridViewButtonColumn();

                // Configurar propiedades de la columna
                botondetalle.Name = "Detalle_compra"; // Nombre de la columna
                botondetalle.HeaderText = "Detalle de compra"; // Texto del encabezado

                // Agregar la columna al DataGridView
                DGListaCompra.Columns.Add(botondetalle);
                DGListaCompra.Columns["Detalle_compra"].DisplayIndex = 5;
            }
            
        }

        private void DGListaCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaCompra.Columns["Detalle_compra"].Index && e.RowIndex >= 0)
            {
                try
                {
                   NCompra nCompra = new NCompra();
                   Compra compraactual = new Compra();  
                    //ventaactual = nventa.GetVenta(int.Parse(DGListaVn.CurrentRow.Cells["ID_Venta"].Value.ToString()));

                    // Crear una nueva instancia de ListaProductos
                    ListaDetalleCompra listadetalles = new ListaDetalleCompra(int.Parse(DGListaCompra.CurrentRow.Cells["ID_Compra"].Value.ToString()));
                    listadetalles.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    PanelContainer.Controls.Add(listadetalles);
                    listadetalles.PanelContainer = PanelContainer;
                    listadetalles.Show();
                    //this.Dispose();
                }
                catch (Exception x)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se puede mostrar el detalle" + x.Message, "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void BShowRegistrarCompra_Click(object sender, EventArgs e)
        {
            // Mostrar form
            InstanciarYMostrarAltaCompra();
        }

        //------------------------------------------------------------------------------------InstanciarAltaCompra-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarAltaCompra()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            // Mostrar form
            AltaCompra formAltaCo = new AltaCompra();
            formAltaCo.TopLevel = false;
            formAltaCo.PanelContainer = PanelContainer;
            formAltaCo.MainForm = MainForm;

            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaCo);
            PanelContainer.BringToFront();

            formAltaCo.Show();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= ListaCompra_Load;
            PContListaCompra.Paint -= PContListaCompra_Paint;
            BShowRegistrarCompra.Click -= BShowRegistrarCompra_Click;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
