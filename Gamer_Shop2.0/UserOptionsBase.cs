using System.Windows.Forms;

namespace Gamer_Shop2._0
{
    public class UserOptionsBase : Form
    {
        public Panel PanelContainer { get; set; }
        public Label LabelContainer { get; set; }
        public Form1 Forminicio {  get; set; }
        public Bienvenida MainForm { get; set; }
        public Form FondoOscuroCatalogo { get; set; }
        public bool isExpandedOps { get; set; }

        public virtual void DesuscribirseDeEventos()
        {
        }
    }
}
