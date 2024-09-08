using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.PanelMenu
{
    public partial class Cosa : UserControl
    {
        public Cosa()
        {
            InitializeComponent();
        }

        private void BAbrirCosa_Click(object sender, EventArgs e)
        {
            PCosa.Location = new Point(180, 0);
            BCerrarCosa.Visible = true;
            BAbrirCosa.Visible = false;
        }

        private void BCerrarCosa_Click(object sender, EventArgs e)
        {
            PCosa.Location = new Point(0, 0);
            BCerrarCosa.Visible = false;
            BAbrirCosa.Visible = true;
        }
    }
}
