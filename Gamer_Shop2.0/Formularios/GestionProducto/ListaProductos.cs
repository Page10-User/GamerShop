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

namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    public partial class ListaProductos : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }
        public ListaProductos()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(ListaProductos_Load);
            PContListaPr.Paint += new PaintEventHandler(PContListaPr_Paint);
            DGListaPr.CellClick += DGListaPr_CellClick;
        }

        private void ListaProductos_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            //Rellenar DatGridView (Ejemplo)
            DGListaPr.Rows.Add("Teclado Gamer", "Teclado mecánico RGB", "4500", "10", "Periféricos");
            DGListaPr.Rows.Add("Mouse Gamer", "Mouse óptico 16000 DPI", "3000", "15", "Periféricos");
            DGListaPr.Rows.Add("Monitor", "Monitor 24' Full HD", "25000", "5", "Monitores");
            DGListaPr.Rows.Add("Placa de Video", "RTX 3060 12GB", "120000", "3", "Componentes");
            DGListaPr.Rows.Add("Auriculares", "Auriculares 7.1 Surround", "7500", "12", "Periféricos");
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
            using (Pen pen = new Pen(Color.Orange, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void PContListaPr_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.Orange, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void BShowRegistrarPr_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de ListaProductos
            AltaProducto AltaPr = new AltaProducto();
            AltaPr.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaPr);
            AltaPr.PanelContainer = PanelContainer;
            AltaPr.Show();
            this.Close();
        }

        private void DGListaPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaPr.Columns["CModificar"].Index && e.RowIndex >= 0)
            {
                // Crear una nueva instancia de ListaProductos
                ModificarProducto ModificarPr = new ModificarProducto();
                ModificarPr.TopLevel = false;

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(ModificarPr);
                ModificarPr.PanelContainer = PanelContainer;
                ModificarPr.Show();
                this.Close();
            }
            else if (e.ColumnIndex == DGListaPr.Columns["CEliminar"].Index && e.RowIndex >= 0)
            {
                DialogResult = MessageBox.Show("Está seguro que desea eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    // Momentaneamente elimina totalmente la fila.
                    // Debería pasar a una lista de "inactivos" xEliminacion logica
                    DGListaPr.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

    }
}
