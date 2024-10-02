using Gamer_Shop2._0.Formularios;
using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.Comercio.Carrito;
using Gamer_Shop2._0.Formularios.Informe;
using Gamer_Shop2._0.Formularios.Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
