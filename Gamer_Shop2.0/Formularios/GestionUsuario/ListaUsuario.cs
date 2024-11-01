﻿using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    public partial class ListaUsuario : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde
        NUsuario nUsuario = new NUsuario();

        public Panel PanelContainer { get; set; }
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
            nUsuario.listaUsuariosActivos(DGListaUs);
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
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void ConfigurarDataGridView()
        {
            
                // Crear una columna de tipo Imagen
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                {
                    HeaderText = "Imagen",
                    Name = "ImagenPerfil",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };

                // Agregar la columna al DataGridView

                DGListaUs.Columns.Add(imageColumn);
                DGListaUs.Columns["ID_Usuario"].Visible = false;
                DGListaUs.Columns["CModificarUs"].DisplayIndex = 10;
                DGListaUs.Columns["CEliminarUs"].DisplayIndex = 11;

                foreach (DataGridViewRow row in DGListaUs.Rows)
                {

                    Image imagenUsuario;

                    try
                    {
                        // Asumiendo que el nombre del archivo está en Resources
                        imagenUsuario = Image.FromFile("C:\\Users\\Usuario\\Pictures\\validaciones.png");
                        if (imagenUsuario == null) throw new Exception();
                    }
                    catch (Exception)
                    {
                        // Cargar una imagen predeterminada si no se encuentra la imagen
                        imagenUsuario = Image.FromFile("\\Gamer_Shop2.0\\Resources\\imagen_default.png");
                    }

                    row.Cells["ImagenPerfil"].Value = imagenUsuario;
                }

                //Ocultar la columna que contiene las rutas de las imágenes(photoFilePath)
                if (DGListaUs.Columns["ImagenPerfil"] != null)
                {
                    DGListaUs.Columns["photoFilePath"].Visible = false;
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
                    PanelContainer.Controls.Add(ModificarUs);
                    ModificarUs.PanelContainer = PanelContainer;
                    ModificarUs.Show();
                    this.Dispose();
                }
                catch (Exception)
                {
                    MsgPersonalizado mensaje = new MsgPersonalizado("No se pudo Modificar el producto", "Error", "Error", null);
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
