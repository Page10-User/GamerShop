using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    public partial class ListaUsuario : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NUsuario nUsuario = new NUsuario();
        public Panel PanelContainer { get; set; }
        public Usuario LUsuario { get; set; }
        public ListaUsuario()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
        }

        private void PBuscadorListaUs_Paint(object sender, PaintEventArgs e)
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
        private void PContListaUs_Paint(object sender, PaintEventArgs e)
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

        private void ListaUsuario_Load(object sender, EventArgs e)
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

        private void quitamosUsuarioActualLista()
        {
            string cuilActual = LUsuario.CUIL;

            foreach (DataGridViewRow row in DGListaUs.Rows)
            {
                if (row.Cells["CUIL"].Value?.ToString() == cuilActual)
                {
                    DGListaUs.Rows.Remove(row);
                    break;
                }
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

        private void ConfigurarDataGridView()
        {

            DataTable usuarios = nUsuario.listaUsuariosActivos(DGListaUs); // Este método debe devolver un DataTable con los productos

            // Agrega una columna de imagen al DataGridView si no existe
            if (!DGListaUs.Columns.Contains("ImagenUsuario"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "ImagenUsuario";
                imageColumn.HeaderText = "Imagen";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen a la celda
                DGListaUs.Columns.Insert(0, imageColumn); // Inserta la columna de imagen en la primera posición
            }

            // Limpia el DataGridView y agrega los productos
            DGListaUs.Rows.Clear();
            foreach (DataRow row in usuarios.Rows)
            {
                if (row["Activo"].ToString() == "SI")
                {
                    string nombreImagen = row["photoFilePath"].ToString(); // Columna de la base de datos con el nombre del archivo de imagen
                    string imagePath = Path.Combine(Application.StartupPath, "uploads", nombreImagen);

                    // Carga la imagen si existe, o utiliza una imagen de "no disponible"
                    Image image;
                    if (File.Exists(imagePath))
                    {
                        image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // Usa una imagen de "no disponible" en caso de que la imagen no se encuentre
                        image = Properties.Resources.default_producto; // Asegúrate de tener una imagen de recurso llamada ImagenNoDisponible
                    }

                    // Agrega una fila con los datos del producto y la imagen
                    DGListaUs.Rows.Add(image, row["ID_Usuario"], row["Nombre"], row["Apellido"], row["CUIL"], row["Nombre_usuario"], row["Contraseña"], row["Correo"], row["Tipo usuario"], row["Activo"]);
                }
            }

            
        }

        private void BShowRegistrar_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de RegistrarUsuario
            InstanciarYMostrarAltaUsuario();
        }

        private void DGListaUs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaUs.Columns["CModificarUs"].Index && e.RowIndex >= 0)
            {
                try
                {
                    string cuil = DGListaUs.CurrentRow.Cells["CUIL"].Value.ToString();
                    NUsuario user = new NUsuario();
                    // Crear una nueva instancia de ListaProductos
                    ModificarUsuario ModificarUs = new ModificarUsuario(user.GetUsuario(cuil));
                    ModificarUs.TopLevel = false;

                    // Limpiar el panel actual y añadir el nuevo formulario
                    PanelContainer.Controls.Clear();
                    ModificarUs.MUsuario = LUsuario;
                    PanelContainer.Controls.Add(ModificarUs);
                    ModificarUs.PanelContainer = PanelContainer;
                    ModificarUs.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo Modificar el usuario", "Error", "Error", null);
                    mensaje.ShowDialog();
                }
            }
            else if (e.ColumnIndex == DGListaUs.Columns["CEliminarUs"].Index && e.RowIndex >= 0)
            {
                MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro que desea eliminar este usuario?", "Eliminar Usuario", "Interrogacion", null);
                DialogResult result = mensaje.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        //Cerramos el mensaje que está en Hide.
                        string cuil = DGListaUs.CurrentRow.Cells["CUIL"].Value.ToString();
                        NUsuario user = new NUsuario();
                        user.NEliminarUsuario(cuil);
                        mensaje.Dispose();
                        DGListaUs.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception)
                    {
                        mensaje = new MsgPersonalizado("No se pudo eliminar el producto", "Error", "Error", null);
                        mensaje.ShowDialog();
                    }
                }
                else
                {
                    mensaje.Dispose();
                }
            }
        }
        //--------------------------------------------------------------InstanciarYMostrarAltaUsuario-----------------------------------------------------------\\
        private void InstanciarYMostrarAltaUsuario()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Form)
            {
                //Liberamos recursos
                control.Dispose();
            }

            // Mostrar form
            AltaUsuario AltaUs = new AltaUsuario();
            AltaUs.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaUs);
            AltaUs.PanelContainer = PanelContainer;
            AltaUs.Show();
            this.Dispose();
        }
        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= ListaUsuario_Load;
            PContListaUs.Paint -= PContListaUs_Paint;
            TBFiltro.Paint -= PBuscadorListaUs_Paint;
            DGListaUs.CellClick -= DGListaUs_CellClick;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
