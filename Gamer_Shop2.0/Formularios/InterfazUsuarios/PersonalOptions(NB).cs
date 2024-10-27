﻿using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class PersonalOptions_NB_ : Form
    {
        private int borderRadius = 30; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        public Form1 Forminicio {  get; set; }
        public Panel PanelContainer { get; set; }
        public Bienvenida Mainform { get; set; }
        public Form FondoOscuroCat {  get; set; }
        public PersonalOptions_NB_()
        {
            InitializeComponent();
        }

        private void PersonalOptions_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
        }

        private GraphicsPath CreateRoundedPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Agregar los arcos para las esquinas redondeadas
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 90, 90);

            path.CloseFigure();

            return path;
        }

        private Region CreateRoundedRegion()
        {
            GraphicsPath path = CreateRoundedPath();
            return new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // dibujar el borde redondeado
            GraphicsPath path = CreateRoundedPath();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Lime, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BCerrarSesion_Click(object sender, EventArgs e)
        {
            MsgPersonalizado mensaje = new MsgPersonalizado("Está seguro que desea cerrar sesion?", "Cerrar Sesión", "Interrogacion", null);
            DialogResult result = mensaje.ShowDialog();
            if (result == DialogResult.Yes)
            {
                //Cerramos el mensaje que está en Hide
                mensaje.Close();

                CloseFondoCatalogo();
                Forminicio.Show();
                Mainform.BContracMenu_Click(sender, e);
                this.Close();
                Mainform.Hide();
                mensaje = new MsgPersonalizado("Sesion cerrada con éxito", "Sesion Finalizada", "Informacion", null);
                mensaje.ShowDialog();
            }
            else
            {
                mensaje.Close();
            }
        }

        private void BMiPerfil_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            Mainform.BContracMenu_Click(sender, e);

            //Cerramos el fondoOscuroCatalogo en caso de existir.
            CloseFondoCatalogo();

            // Crear una nueva instancia de ListaProductos
            Usuario user = new Usuario();
            EditarPerfil editarPerfil = new EditarPerfil(user);
            editarPerfil.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(editarPerfil);
            //editarPerfil.PanelContainer = PanelContainer;
            editarPerfil.Show();
            this.Close();
        }

        private void CloseFondoCatalogo()
        {
            if(FondoOscuroCat is Form)
            {
                FondoOscuroCat.Close();
                Mainform.FondoOscuroCatalogo = null;
            }
        }
    }
}
