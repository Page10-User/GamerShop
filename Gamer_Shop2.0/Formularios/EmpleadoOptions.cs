using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gamer_Shop2._0.Formularios
{
    public partial class EmpleadoOptions : Form
    {
        public Panel PanelContainer { get; set; }
        public Bienvenida MainForm { get; set; }
        public EmpleadoOptions()
        {
            InitializeComponent();
        }

        private void BGestionPr_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            // Mostrar form
            AltaProducto formAltaProducto = new AltaProducto();
            formAltaProducto.TopLevel = false;
            formAltaProducto.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProducto);
            PanelContainer.BringToFront();

            formAltaProducto.Show();
        }
    }
}
