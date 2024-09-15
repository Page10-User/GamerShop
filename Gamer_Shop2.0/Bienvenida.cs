﻿using Gamer_Shop2._0.Formularios;
using Gamer_Shop2._0.Formularios.InterfazUsuarios;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Gamer_Shop2._0
{

    public partial class Bienvenida : Form
    {
        // Menú expandido bool
        bool isExpanded = false;
        private Form formBG;

        //Options definido globalmente para mejor manejo.
        private EmpleadoOptions empleadoOptions;

        public Bienvenida()
        {
            InitializeComponent();
            this.Load += new EventHandler(Bienvenida_Load);
            this.Paint += new PaintEventHandler(Bievenida_Paint);
            PMenuUS.Paint += new PaintEventHandler(PMenuUS_Paint);
            this.PFondoBienvenida.Paint += new PaintEventHandler(PFondoBienvenida_Paint);
            empleadoOptions = new EmpleadoOptions();
            empleadoOptions.MainForm = this;
            empleadoOptions.PanelContainer = PShowOptions;
            empleadoOptions.LabelContainer = LVersion;
            empleadoOptions.TopLevel = false;
        }

        private void PFondoBienvenida_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 90;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.GreenYellow, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void Bienvenida_Load(object sender, EventArgs e)
        {
            //Configurando visualización ideal.
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Location = new Point(12, 38);
            BContracMenu.BringToFront();

            //Mostrando fecha actual.
            LFActual.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Mostrando el horario en tiempo real.
            THorario.Interval = 1000;
            THorario.Tick += THorario_Tick;
            THorario.Start();
        }

        // Función botón Exit
        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botón contraer Menú.
        public void BContracMenu_Click(object sender, EventArgs e)
        {
            isExpanded = !isExpanded;
            PMenuUS.Location = new Point(-180, 0);
            BExpandMenu.Visible = true;
            BContracMenu.Visible = false;
            PEBorde.Visible = true;
            formBG.Close();

            // Eliminar contenido del menú
            PMenuUS.Controls.Add(empleadoOptions);
            empleadoOptions.Visible = false;
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

            // Crear un nuevo formulario para el efecto de oscurecimiento
            Point thisLocation = this.Location;
            Point formBGLocation = new Point(thisLocation.X + 200, thisLocation.Y + 1);
            formBG = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.70d, // 70% de opacidad
                BackColor = Color.Black,
                Width = 638 - 2,
                Height = this.Height - 4,
                Location = formBGLocation,
                WindowState = FormWindowState.Normal,
                TopMost = true,
                ShowInTaskbar = false
            };

            // Mostrar el formulario de oscurecimiento
            formBG.Show();

            // Cargar contenido del menú.
            PMenuUS.Controls.Add(empleadoOptions);
            empleadoOptions.Location = new Point(0, 1);
            empleadoOptions.Visible = true;
        }

        // Diseño del bordeado del formulario
        private void Bievenida_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.LightGreen;
            int borderWidth = 1;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth);
            }
        }

        // Modificar borde del menú.
        private void PMenuUS_Paint(object sender, PaintEventArgs e)
        {
            // Definir el color y el grosor del borde
            Color borderColor = Color.LightGreen;
            int borderWidth = 1;

            // Obtener el área del panel
            Control panel = sender as Control;
            Rectangle borderRectangle = panel.ClientRectangle;

            // Reducir el tamaño del área para evitar que el borde se dibuje fuera del panel
            borderRectangle.Width -= 1;
            borderRectangle.Height -= 1;

            // Dibujar el borde
            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, borderRectangle);
            }
        }

        //Reloj a tiempo real
        private void THorario_Tick(object sender, EventArgs e)
        {
            // Actualizar el texto del Label con la hora actual
            LReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

