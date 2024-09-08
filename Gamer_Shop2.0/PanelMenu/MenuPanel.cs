using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gamer_Shop2._0.PanelMenu
{
    public partial class MenuPanel : UserControl
    {
        private bool isMenuExpanded = false;
        private int expandedPosition = 0;  // Posición cuando el panel está completamente desplegado.
        private int collapsedPosition = -180; // Posición cuando el panel está oculto fuera de la vista.
        private int animationStep = 10;     // Velocidad de desplazamiento en píxeles por tick.

        public MenuPanel()
        {
            InitializeComponent();
            timer1.Interval = 1;
        }

        // Evento para mostrar el menú al hacer clic en BMenu
        private void BMenu_Click(object sender, EventArgs e)
        {
            isMenuExpanded = !isMenuExpanded;
            timer1.Start(); // Inicia el desplazamiento
            BExitMenu.Visible = isMenuExpanded; // Mostrar/ocultar el botón de cerrar dependiendo del estado
        }

        // Evento para cerrar el menú al hacer clic en BExitMenu
        private void BExitMenu_Click(object sender, EventArgs e)
        {
            isMenuExpanded = false;     // Contraer el menú
            timer1.Start();             // Iniciar el desplazamiento hacia fuera
            BExitMenu.Visible = false; // Ocultar el botón de cerrar
        }

        // Animación de desplazamiento
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMenuExpanded)
            {
                // Desplazar el panel hacia la derecha (mostrando el panel)
                if (PMenu.Location.X < expandedPosition)
                {
                    PMenu.Location = new Point(PMenu.Location.X + animationStep, PMenu.Location.Y);
                    if (PMenu.Location.X >= expandedPosition)  // Asegurar posición exacta
                    {
                        PMenu.Location = new Point(expandedPosition, PMenu.Location.Y);
                        timer1.Stop(); // Detener la animación cuando el panel alcanza su posición expandida
                    }
                }
            }
            else
            {
                // Desplazar el panel hacia la izquierda (ocultando el panel)
                if (PMenu.Location.X > collapsedPosition)
                {
                    PMenu.Location = new Point(PMenu.Location.X - animationStep, PMenu.Location.Y);
                    if (PMenu.Location.X <= collapsedPosition)  // Asegurar posición exacta
                    {
                        PMenu.Location = new Point(collapsedPosition, PMenu.Location.Y);
                        timer1.Stop(); // Detener la animación cuando el panel está completamente oculto
                    }
                }
            }
        }
    }
}

