﻿using Gamer_Shop2._0.Formularios.GestionVenta;
using System;
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
