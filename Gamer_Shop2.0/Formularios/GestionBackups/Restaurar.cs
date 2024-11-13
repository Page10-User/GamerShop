using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionBackups
{
    public partial class Restaurar : Form
    {
        public Form FondoOscuro { get; set; }

        public Restaurar()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            FondoOscuro.Dispose();
            this.Dispose();
        }
    }
}
