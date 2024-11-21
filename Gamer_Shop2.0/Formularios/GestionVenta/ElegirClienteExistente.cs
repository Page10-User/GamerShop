using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class ElegirClienteExistente : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        public Form FondoOscurecido { get; set; }
        public Bienvenida MainForm { get; set; }

        NCliente ncliente = new NCliente();

        public Panel PanelContainer { get; set; }
        public ElegirClienteExistente()
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

        private void ElegirClienteExistente_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
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
            DataTable clientes = ncliente.listaClientes(DGListaCliente); // Este método debe devolver un DataTable con los proveedores

            // Limpia el DataGridView y agrega los proveedores
            DGListaCliente.Rows.Clear();
            foreach (DataRow row in clientes.Rows)
            {
                // Agrega una fila con los datos del proveedor
                DGListaCliente.Rows.Add(row["ID_Cliente"], row["DNI"], row["Nombre"], row["Apellido"], row["Teléfono"], row["Correo"]);
            }
        }

        private void DGListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.ColumnIndex == DGListaCliente.Columns["CSeleccionarCl"].Index && e.RowIndex >= 0)
                {



                    string dni = DGListaCliente.CurrentRow.Cells["DNI"].Value.ToString();
                    ElegirCliente?.Invoke(e, dni);


                    MainForm.TopMost = true;
                    FondoOscurecido.Dispose();
                    this.Dispose();
                }

            }
            catch (Exception)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo elegir este cliente", "Error", "Error", null);
                mensaje.ShowDialog();
            }
        }




        //--------------------------------------------------------InstanciarYMostrarAltaCliente----------------------------------------------------\\
        public event EventHandler<string> ElegirCliente;


        public new void Dispose()
        {
            // Desuscribirse de eventos
            //<-AltaProducto-Events->\\
            this.Load -= ElegirClienteExistente_Load;

            //<-Paint-Events->\\
            PContListaCl.Paint -= PContListaCl_Paint;



            //<-TextBox-Events->\\
            //...\\

            //<-CellClick-Events-\\
            DGListaCliente.CellClick -= DGListaCliente_CellClick;

            // Liberar los recursos
            base.Dispose();
        }

        private void BBuscador_Click(object sender, EventArgs e)
        {
            // Llenar la lista original con todas las filas del DataGridView
            foreach (DataGridViewRow fila in DGListaCliente.Rows)
            {
                if (!fila.IsNewRow)
                {
                    Dictionary<string, object> filaDict = new Dictionary<string, object>();
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        filaDict[DGListaCliente.Columns[celda.ColumnIndex].Name] = celda.Value;
                    }
                }
            }

            FiltrarDataGrid(DGListaCliente);
        }
        private void FiltrarDataGrid(DataGridView data)
        {
            string filtro = TBFiltro.Texts.ToLower();

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
