using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.Gestion_Compra;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionProveedor;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Informe;
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

            // Mostrar form
            AltaProducto formAltaProducto = new AltaProducto();
            formAltaProducto.TopLevel = false;
            formAltaProducto.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProducto);
            PanelContainer.BringToFront();

            formAltaProducto.Show();
        }

        private void BGestionCliente_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            AltaCliente formCliente = new AltaCliente(true);
            formCliente.TopLevel = false;
            formCliente.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formCliente);
            PanelContainer.BringToFront();

            formCliente.Show();
        }

        private void BGestionVenta_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            ListaVenta formListaVn = new ListaVenta(false);
            formListaVn.TopLevel = false;
            formListaVn.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formListaVn);
            PanelContainer.BringToFront();

            formListaVn.Show();
        }

        private void BGestionUsuario_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            AltaUsuario formAltaUs = new AltaUsuario();
            formAltaUs.TopLevel = false;
            formAltaUs.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaUs);
            PanelContainer.BringToFront();

            formAltaUs.Show();
        }

        private void BOptionsAdmin_Click(object sender, EventArgs e)
        {
            if (!isExpandedOption || !isExpandedOps)
            {
                // Mostrar form
                Poptions = new PersonalOptions();
                Poptions.TopLevel = false;
                Poptions.PanelContainer = PanelContainer;
                Poptions.Mainform = MainForm;
                Poptions.Forminicio = Forminicio;
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
            else
            {
                Poptions.SendToBack();
                MandarAdelanteBotones();
                Poptions.Close();
                isExpandedOption = false;
                MainForm.isExpandedOpts = false;
            }
        }

        private void BGestionCompras_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            AltaCompra formAltaCo = new AltaCompra();
            formAltaCo.TopLevel = false;
            formAltaCo.PanelContainer = PanelContainer;

            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaCo);
            PanelContainer.BringToFront();

            formAltaCo.Show();
        }

        private void BGestionProveedor_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            AltaProveedor formAltaProovedor = new AltaProveedor();
            formAltaProovedor.TopLevel = false;
            formAltaProovedor.PanelContainer = PanelContainer;

            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProovedor);
            PanelContainer.BringToFront();

            formAltaProovedor.Show();
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

        private void InstanciarYMostrarReporte()
        {
            Reporte formReporte = new Reporte();
            formReporte.TopLevel = false;
            formReporte.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formReporte);
            PanelContainer.BringToFront();

            formReporte.Show();
        }
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
    }
}
