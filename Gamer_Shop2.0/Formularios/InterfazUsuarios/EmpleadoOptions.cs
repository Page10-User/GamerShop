using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Inicio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class EmpleadoOptions : UserOptionsBase
    {
        bool isExpandedOption = false;

        //Options definido globalmente para mejor manejo.
        private PersonalOptions_NB_ Poptions ;

        public EmpleadoOptions()
        {
            InitializeComponent();
            Poptions = new PersonalOptions_NB_();
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

        private void BCatalogo_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción 
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            InstanciarYMostrarCatalogo();
        }

        private void BOptionsEmpleado_Click(object sender, EventArgs e)
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

                //Cerrar FondoOscuroCatalogo en caso de existir.
                CloseFondoOscuro();
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

                //Cerrar FondoOscuroCatalogo en caso de existir.
                CloseFondoOscuro();
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
                ListaVenta formListaVn = new ListaVenta(true);
                formListaVn.TopLevel = false;
                formListaVn.PanelContainer = PanelContainer;
                formListaVn.Mainform = MainForm;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formListaVn);
                PanelContainer.BringToFront();

                //Cerrar FondoOscuroCatalogo en caso de existir.
                CloseFondoOscuro();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formListaVn.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarCatalogo-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarCatalogo()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Catalogo)
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
                Catalogo formCatalogo = new Catalogo();
                formCatalogo.TopLevel = false;
                formCatalogo.PanelContainer = PanelContainer;
                formCatalogo.LabelContainer = LabelContainer;
                formCatalogo.MainForm = MainForm;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formCatalogo);
                PanelContainer.BringToFront();

                //Cerrar FondoOscuroCatalogo en caso de existir.
                CloseFondoOscuro();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formCatalogo.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarPoptions-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarPoptions()
        {
            // Mostrar form
            Poptions = new PersonalOptions_NB_();
            Poptions.TopLevel = false;
            Poptions.PanelContainer = PanelContainer;
            Poptions.Mainform = MainForm;
            Poptions.Forminicio = Forminicio;
            Poptions.Menu = this;
            Poptions.FondoOscuroCat = FondoOscuroCatalogo;
            PPersonalOptions.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PPersonalOptions.Controls.Add(Poptions);
            Poptions.Location = new Point(1, 1);

            Poptions.Show();
            isExpandedOption = true;

            //Pasamos Poptions ah Bienvenida.cs
            MainForm.PersonalOpsNB = Poptions;
            MainForm.isExpandedOpts = true;
            isExpandedOps = true;
        }
        //------------------------------------------------------------------------------------Cerrar poptions-------------------------------------------------------------------------------\\
        private void CerrarPoptions()
        {
            Poptions.Dispose();
            isExpandedOption = false;
            MainForm.isExpandedOpts = false;
        }
        //-----------------------------------------------------\\
        private void CloseFondoOscuro()
        {
            if (FondoOscuroCatalogo is Form)
            {
                FondoOscuroCatalogo.Close();
                MainForm.FondoOscuroCatalogo = null;
            }
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BGestionCliente.Click -= BGestionCliente_Click;
            BGestionPr.Click -= BGestionPr_Click;
            BGestionVenta.Click -= BGestionVenta_Click;
            BCatalogo.Click -= BCatalogo_Click;

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
                CloseFondoOscuro();
                inicioD.Show();
                inicioD.Location = new Point(50, 130);
            }
        }
    }
}
