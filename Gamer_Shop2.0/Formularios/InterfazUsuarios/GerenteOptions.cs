using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.GestionVenta;
using Gamer_Shop2._0.Formularios.Informe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class GerenteOptions : UserOptionsBase
    {

        bool isExpandedOption = false;

        //Options definido globalmente para mejor manejo.
        private PersonalOptions_NB_ Poptions;

        public GerenteOptions()
        {
            InitializeComponent();
            Poptions = new PersonalOptions_NB_();
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
        private void BOptionsGerente_Click(object sender, EventArgs e)
        {
            if (!isExpandedOption || !isExpandedOps)
            {
                // Mostrar form
                Poptions = new PersonalOptions_NB_();
                Poptions.TopLevel = false;
                Poptions.PanelContainer = PanelContainer;
                Poptions.Mainform = MainForm;
                Poptions.Forminicio = Forminicio;
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
            else
            {
                Poptions.Close();
                isExpandedOption = false;
                MainForm.isExpandedOpts = false;
            }
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
    }
}
