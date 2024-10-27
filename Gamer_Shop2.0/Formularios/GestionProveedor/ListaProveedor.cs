using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionProveedor
{
    public partial class ListaProveedor : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public ListaProveedor()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PBuscadorListaProveedor_Paint(object sender, PaintEventArgs e)
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

        private void ListaProveedor_Load(object sender, EventArgs e)
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

        private void PContListaProveedor_Paint(object sender, PaintEventArgs e)
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

        private void DGListaProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaProveedor.Columns["CModificar"].Index && e.RowIndex >= 0)
            {
                // Crear una nueva instancia de ListaProductos
                ModificarProveedor ModificarProveedor = new ModificarProveedor();
                ModificarProveedor.TopLevel = false;

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(ModificarProveedor);
                ModificarProveedor.PanelContainer = PanelContainer;
                ModificarProveedor.Show();
                this.Close();
            }
            else if (e.ColumnIndex == DGListaProveedor.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea eliminar este proveedor?", "Eliminar Proveedor", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    mensaje.Dispose();
                    DGListaProveedor.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    mensaje.Dispose();
                }
            }
        }

        private void BShowRegistrarProveedor_Click(object sender, EventArgs e)
        {
            // Mostrar form
            InstanciarYMostrarAltaProveedor();
        }
        //--------------------------------------------------------InstanciarYMostrarAltaProveedor----------------------------------------------------\\
        private void InstanciarYMostrarAltaProveedor()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            AltaProveedor formAltaProovedor = new AltaProveedor();
            formAltaProovedor.TopLevel = false;
            formAltaProovedor.PanelContainer = PanelContainer;

            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProovedor);
            PanelContainer.BringToFront();

            formAltaProovedor.Show();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-AltaProducto-Events->\\
            this.Load -= ListaProveedor_Load;

            //<-Paint-Events->\\
            PContListaProveedor.Paint -= PContListaProveedor_Paint;

            //<-Click-Events->\\
            BShowRegistrarProveedor.Click -= BShowRegistrarProveedor_Click;

            //<-TextBox-Events->\\
            //...\\

            //<-CellClick-Events-\\
            DGListaProveedor.CellClick -= DGListaProveedor_CellClick;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
