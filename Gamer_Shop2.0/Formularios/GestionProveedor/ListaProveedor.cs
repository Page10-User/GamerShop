using Gamer_Shop2._0.Formularios.GestionProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Load += new EventHandler(ListaProveedor_Load);
            PContListaProveedor.Paint += new PaintEventHandler(PContListaProveedor_Paint);
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
                DialogResult = MessageBox.Show("Está seguro que desea eliminar este proveedor?", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    DGListaProveedor.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void BShowRegistrarProveedor_Click(object sender, EventArgs e)
        {
            // Mostrar form
            AltaProveedor formAltaProovedor = new AltaProveedor();
            formAltaProovedor.TopLevel = false;
            formAltaProovedor.PanelContainer = PanelContainer;

            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProovedor);
            PanelContainer.BringToFront();

            formAltaProovedor.Show();
        }

        private void ListaProveedor_Load_1(object sender, EventArgs e)
        {
            DGListaProveedor.Rows.Add("Teclado Gamer", "Teclado mecánico RGB", "4500", "10", "Periféricos");
        }
    }
}
