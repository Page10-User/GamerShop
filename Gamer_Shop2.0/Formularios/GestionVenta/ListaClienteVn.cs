using Gamer_Shop2._0.Datos;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
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

namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    public partial class ListaClienteVn : Form
    {
        private int borderRadius = 30; // Radio del borde redondeado
        private int borderWidth = 4; // Grosor del borde
        NCliente ncliente = new NCliente();
        public Form FondoOscurecido { get; set; }

        public ListaClienteVn()
        {
            InitializeComponent();
        }

        private void ListaClienteVn_Load(object sender, EventArgs e)
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

        public event EventHandler<int> ObtenerDNICliente;
        private void DGListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaCliente.Columns["CElegirCl"].Index && e.RowIndex >= 0)
            {
                try
                {
                    // Crear una nueva instancia de Alta Cliente
                    string dni = DGListaCliente.CurrentRow.Cells["DNI"].Value.ToString();
                    ObtenerDNICliente?.Invoke(this, Convert.ToInt32(dni));

                    //Liberamos recursos
                    FondoOscurecido.Dispose();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo obtener los datos del cliente escogido.", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
        }

        private void BCloseAltaCliente_Click(object sender, EventArgs e)
        {
            FondoOscurecido.Dispose();
            this.Dispose();
        }
    }
}
