using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.GestionBackups;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionProveedor;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Informe;
using Gamer_Shop2._0.Formularios.Inicio;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class AdministradorOptions : UserOptionsBase
    {
        bool isExpandedOption = false;

        //Options definido globalmente para mejor manejo.
        private PersonalOptions Poptions;
        public AdministradorOptions()
        {
            InitializeComponent();
            PPersonalOptions.Paint += new PaintEventHandler(PPersonalOptions_Paint);
        }

        private void PPersonalOptions_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 29;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.Transparent, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void BGestionPr_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarProducto();
        }

        private void BGestionCliente_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarCliente();
        }

        private void BGestionVenta_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarVenta();
        }

        private void BGestionUsuario_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarUsuario();
        }

        private void BGestionCompras_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarCompra();
        }

        private void BGestionProveedor_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarProveedor();
        }

        private void BAccederInformes_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            InstanciarYMostrarReporte();
        }

        private void BOptionsAdmin_Click(object sender, EventArgs e)
        {
            if (!isExpandedOption || !isExpandedOps)
            {
                InstanciarYMostrarPoptions();
            }
            else
            {
                CerrarPoptions();
            }
        }
        //------------------------------------------------------------------------------------InstanciarProducto-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarProducto()
        {
            Control control = PanelContainer.Controls[0];
            if (control is AltaProducto)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Mostrar form
                AltaProducto formAltaProducto = new AltaProducto();
                formAltaProducto.TopLevel = false;
                formAltaProducto.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formAltaProducto);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formAltaProducto.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarCliente-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarCliente()
        {
            Control control = PanelContainer.Controls[0];
            if (control is AltaCliente)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Mostrar form
                AltaCliente formCliente = new AltaCliente(true);
                formCliente.TopLevel = false;
                formCliente.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formCliente);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formCliente.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarVenta-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarVenta()
        {
            Control control = PanelContainer.Controls[0];
            if (control is ListaVenta)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Mostrar form
                ListaVenta formListaVn = new ListaVenta(false);
                formListaVn.TopLevel = false;
                formListaVn.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formListaVn);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formListaVn.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarUsuario-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarUsuario()
        {
            Control control = PanelContainer.Controls[0];
            if (control is AltaUsuario)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Mostrar form
                AltaUsuario formAltaUs = new AltaUsuario();
                formAltaUs.TopLevel = false;
                formAltaUs.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formAltaUs);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formAltaUs.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarCompra-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarCompra()
        {
            Control control = PanelContainer.Controls[0];
            if (control is AltaCompra)
            {
                return;
            }
            else
            {
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
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formAltaCo.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarProveedor-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarProveedor()
        {
            Control control = PanelContainer.Controls[0];
            if (control is AltaProveedor)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Mostrar form
                AltaProveedor formAltaProovedor = new AltaProveedor();
                formAltaProovedor.TopLevel = false;
                formAltaProovedor.PanelContainer = PanelContainer;

                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formAltaProovedor);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formAltaProovedor.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarReporte-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarReporte()
        {
            Control control =  PanelContainer.Controls[0];
            if (control is Reporte)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                Reporte formReporte = new Reporte();
                formReporte.TopLevel = false;
                formReporte.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formReporte);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formReporte.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarPoptions-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarPoptions()
        {
             // Mostrar form
             Poptions = new PersonalOptions();
             Poptions.TopLevel = false;
             Poptions.PanelContainer = PanelContainer;
             Poptions.Mainform = MainForm;
             Poptions.Forminicio = Forminicio;
             Poptions.Menu = this;
             Poptions.BringToFront();
             MandarAtrasBotones();
             PPersonalOptions.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
             PPersonalOptions.Controls.Add(Poptions);

             Poptions.Show();
             isExpandedOption = true;

             //Pasamos Poptions ah Bienvenida.cs
             MainForm.PersonalOps = Poptions;
             MainForm.isExpandedOpts = true;

             //Pasamos los Botones (proveedor y compra).
             PasarBotonesBienvenida();
             isExpandedOps = true;
        }
        //------------------------------------------------------------------------------------Cerrar poptions-------------------------------------------------------------------------------\\
        private void CerrarPoptions()
        {
            Poptions.SendToBack();
            MandarAdelanteBotones();
            Poptions.Dispose();
            isExpandedOption = false;
            MainForm.isExpandedOpts = false;
        }
        //-----------------------------------------------------\\
        private void MandarAtrasBotones()
        {
            BGestionCompras.SendToBack();
            BGestionProveedor.SendToBack();
            BAccederInformes.SendToBack();
        }
        private void MandarAdelanteBotones()
        {
            BGestionCompras.BringToFront();
            BGestionProveedor.BringToFront();
            BAccederInformes.BringToFront();
        }
        private void PasarBotonesBienvenida()
        {
            MainForm.botonCompra = BGestionCompras;
            MainForm.botonProveedor = BGestionProveedor;
            MainForm.botonInforme = BAccederInformes;
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BGestionCliente.Click -= BGestionCliente_Click;
            BGestionPr.Click -= BGestionPr_Click;
            BGestionCompras.Click -= BGestionCompras_Click;
            BGestionUsuario.Click -= BGestionUsuario_Click;
            BGestionProveedor.Click -= BGestionProveedor_Click;
            BGestionVenta.Click -= BGestionVenta_Click;
            BAccederInformes.Click -= BAccederInformes_Click;
            BOptionsAdmin.Click -= BOptionsAdmin_Click;

            // Liberar los recursos
            base.Dispose();
        }

        private void BHouse_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Inicializamos y mostramos el inicio
            VolverAlInicio();
        }

        private void VolverAlInicio()
        {
            Control control = PanelContainer.Controls[0];
            if (control is InicioDetalle)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }
                // Crear una nueva instancia de inicioDetalle
                InicioDetalle inicioD = new InicioDetalle();
                inicioD.TopLevel = false;

                // Poner visible "version sistema".
                LabelContainer.Visible = true;
                LabelContainer.BringToFront();

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(inicioD);
                inicioD.PanelContainer = PanelContainer;
                MainForm.TopMost = true;
                inicioD.Show();
                inicioD.Location = new Point(50, 130);
            }
        }
    }
}
