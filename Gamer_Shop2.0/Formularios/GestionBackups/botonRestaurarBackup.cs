using Gamer_Shop2._0.Formularios.GestionBackups.ClaseRestauraciones;
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
    public partial class botonRestaurarBackup : UserControl
    {
        public string rutaBak = "";

        public botonRestaurarBackup()
        {
            InitializeComponent();
        }

        //Methots
        public string Ruta
        {
            get { return rutaBak; }
            set { rutaBak = value; }
        }
        public string NombreBackup
        {
            get { return LNameBackup.Text; }
            set { LNameBackup.Text = value; }
        }
        public string FechaBackup
        {
            get { return LDateTimeBackup.Text; }
            set { LDateTimeBackup.Text = value; }
        }
        //Methots
        private void BRestaurar_Click(object sender, EventArgs e)
        {
            RestauracionCompleta.HacerRestauracion(Ruta);
        }
    }
}
