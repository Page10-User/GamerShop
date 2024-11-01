using Gamer_Shop2._0.Formularios.BorderClasss;
using Gamer_Shop2._0.Formularios.Inicio;
using Gamer_Shop2._0.Formularios.InterfazUsuarios;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gamer_Shop2._0
{

    public partial class Bienvenida : Form
    {
        // --------------------------------------------------------------------------------------------------------------------
        // Variables de estado y referencia
        // --------------------------------------------------------------------------------------------------------------------

        // Indica si el menú está expandido o colapsado
        private bool isExpanded = false;

        // Instancia global del fondo oscuro
        private Form formBG;

        // Almacena las opciones del usuario seleccionadas
        public UserOptionsBase userOptions { get; set; }

        // Almacena al usuario que inició sesion
        public Usuario BUsuario { get; set; }

        // --------------------------------------------------------------------------------------------------------------------
        // Paneles de opciones de menú
        // --------------------------------------------------------------------------------------------------------------------

        // Panel de opciones personales (Menú A)
        public PersonalOptions PersonalOps { get; set; }

        // Panel de opciones personales (Menú E, G) --No Backups
        public PersonalOptions_NB_ PersonalOpsNB { get; set; }

        // --------------------------------------------------------------------------------------------------------------------
        // Referencias a formularios
        // --------------------------------------------------------------------------------------------------------------------

        // Referencia al formulario de inicio para evitar instancias innecesarias
        public Form1 Forminicio { get; set; }

        // --------------------------------------------------------------------------------------------------------------------
        // Formatos visuales
        // --------------------------------------------------------------------------------------------------------------------

        // Formulario de fondo oscuro para el catálogo
        public Form FondoOscuroCatalogo { get; set; }

        // Botones del menú para corregir bugs visuales 
        public Button botonCompra { get; set; }
        public Button botonProveedor { get; set; }
        public Button botonInforme { get; set; }

        // Indica si las opciones están expandibles
        public bool isExpandedOpts { get; set; }


        public Bienvenida()
        {
            InitializeComponent();
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            //Configurando visualización ideal.
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Location = new Point(12, 38);
            BContracMenu.BringToFront();

            // Crear una nueva instancia de ListaProductos
            InicioDetalle inicioD = new InicioDetalle();
            inicioD.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PShowOptions.Controls.Clear();
            PShowOptions.Controls.Add(inicioD);
            inicioD.Show();
            inicioD.Location = new Point(50, 130);

            // Pasamos los valores correspondientes al usaerOptions.
            InstanciarUserOptions();
        }

        // Función botón Exit
        private void BSalir_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("¿Está seguro de que desea cerrar la aplicación?", "Cerrar Aplicación", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();

            if (result == DialogResult.Yes)
            {
                mensaje.Dispose();
                Application.Exit();
            }
            else
            {
                mensaje.Dispose();
                this.TopMost = true;
            }
        }

        // Botón contraer Menú.
        public void BContracMenu_Click(object sender, EventArgs e)
        {
            // Otros aspectos
            OtrosAspectos();

            // Ocultar contenido del menú.
            OcultarContenidoMenu();

            // Mostrar FondoOscuroCatalogo
            FondoOscuroShow();
        }

        // Botón expandir Menú.
        private void BExpandMenu_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            PMenuUS.Location = new Point(0, 0);
            PMenuUS.BringToFront();
            PAddB.BringToFront();
            BExpandMenu.Visible = false;
            BContracMenu.Visible = true;
            PEBorde.Visible = false;

            //Desactivamos el TopMost
            this.TopMost = false;

            //Generamos fondo oscuro tras abrir el menú.
            GenerarFondoOscuro();

            // Cargar contenido del menú.
            PMenuUS.Controls.Add(userOptions);
            userOptions.Forminicio = Forminicio;
            userOptions.UUsuario = BUsuario;
            userOptions.Location = new Point(0, 2);
            userOptions.Visible = true;

            //Quitamos el fondo negro del catalogo para evitar bug visuales.
            FondoOscuroHide();

            //Pasamos el fondo a userOptions (caso EmpleadoOptions).
            PasarFondoOscuroEmpleadoOptions();
        }

        //--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--UI--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\
        private void PMenuUS_Paint(object sender, PaintEventArgs e)
        {
            if (sender == PMenuUS)
            {
                BorderClass rounded = new BorderClass();
                rounded.AplicarBordeRedondeado(PMenuUS, 1, e.Graphics, Color.LightGreen, 1);
            }
        }
        //--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--UI--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\--\\

        private void GenerarFondoOscuro()
        {
            // Crear un nuevo formulario para el efecto de oscurecimiento
            Point thisLocation = this.Location;
            Point formBGLocation = new Point(thisLocation.X + 200, thisLocation.Y + 2);
            formBG = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.70d,
                BackColor = Color.Black,
                Width = 636,
                Height = this.Height - 4,
                Location = formBGLocation,
                TopMost = true,
                WindowState = FormWindowState.Normal,
                ShowInTaskbar = false,
            };
            formBG.Show();
        }
        private void OcultarContenidoMenu()
        {
            userOptions.Hide();

            if (isExpandedOpts)
            {
                bool isExpnd = false;
                if (userOptions is AdministradorOptions)
                {
                    //Cerramos la configuración personal (Admin).
                    PersonalOps.SendToBack();
                    PersonalOps.Dispose();

                    //Posicionamos los botones de compra y proveedor.
                    TraerBotonesAlfrente();
                    userOptions.isExpandedOps = isExpnd;
                }
                else
                {
                    //Cerramos la configuración personal (Empleado y Gerente).
                    PersonalOpsNB.SendToBack();
                    PersonalOpsNB.Dispose();
                    userOptions.isExpandedOps = isExpnd;
                }
            }
        }
        private void FondoOscuroHide()
        {
            if (FondoOscuroCatalogo is Form)
            {
                FondoOscuroCatalogo.Hide();
            }
        }
        private void FondoOscuroShow()
        {
            if (FondoOscuroCatalogo is Form)
            {
                FondoOscuroCatalogo.Show();
            }
        }
        private void PasarFondoOscuroEmpleadoOptions()
        {
            if (FondoOscuroCatalogo is Form && userOptions is EmpleadoOptions)
            {
                userOptions.FondoOscuroCatalogo = FondoOscuroCatalogo;
            }
        }
        private void TraerBotonesAlfrente()
        {
            botonCompra.BringToFront();
            botonProveedor.BringToFront();
            botonInforme.BringToFront();
        }

        private void InstanciarUserOptions()
        {
            userOptions.MainForm = this;                // Pasamos el form Bienvenida al menú.
            userOptions.PanelContainer = PShowOptions;  // Pasamos el panel de Bievenida al menú.
            userOptions.LabelContainer = LVersion;      // Pasamos el label Version al menú.
            userOptions.Forminicio = Forminicio;        // Pasamos el forminicio al menú.
            userOptions.TopLevel = false;               // Ponemos el TopLevel del menú en false.
        }

        private void OtrosAspectos()
        {
            isExpanded = !isExpanded;                   // Manejar si el PersonalOptions está expandido.
            PMenuUS.Location = new Point(-180, 0);      // Manejar la hubicación del menú al contraerse.
            BExpandMenu.Visible = true;                 // Mostrar el boton para expandir el menú.
            BContracMenu.Visible = false;               // Ocultar el boton para cerrar el menú.
            PEBorde.Visible = true;                     // Arreglo de pqueños bugs visuales.
            formBG.Dispose();                           // Cerrar el fondo oscuro.
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            this.Load -= Bienvenida_Load;
            BContracMenu.Click -= BContracMenu_Click;
            BExpandMenu.Click -= BExpandMenu_Click;
            BSalir.Click -= BSalir_Click;
            PMenuUS.Paint -= PMenuUS_Paint;

            // Liberar los recursos
            base.Dispose();
        }
    }
}

