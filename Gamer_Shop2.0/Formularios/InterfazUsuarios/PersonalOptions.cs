﻿using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.GestionBackups;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class PersonalOptions : Form
    {
        private int borderRadius = 30; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        public Form1 Forminicio { get; set; }
        public Panel PanelContainer { get; set; }
        public Panel LabelContainer { get; set; }
        public Bienvenida Mainform { get; set; }
        public UserOptionsBase Menu { get; set; }
        public Usuario PUsuario { get; set; }

        public PersonalOptions()
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
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
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
                mensaje.Dispose();

                //Cerramos todo y Mostramos el form de inicio
                CerrarSesion(sender, e);

                //Mostramos el mensaje de éxito
                mensaje = new MsgPersonalizado("Sesion cerrada con éxito", "Sesion Finalizada", "Informacion", null);
                mensaje.ShowDialog();
            }
            else
            {
                mensaje.Dispose();

                Mainform.TopMost = true;

                //Cerrar el menú tras elegír una opción
                Mainform.BContracMenu_Click(sender, e);
            }
        }

        private void BMiPerfil_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            Mainform.BContracMenu_Click(sender, e);

            //Mostramos el form EditarPerfil
            InstanciarYMostrarEditarPerfil();
        }

        private void BBackups_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            Mainform.BContracMenu_Click(sender, e);

            // Crear una nueva instancia de Backups
            InstanciarYMostrarBackup();
        }
        //------------------------------------------------------------------------------------InstanciarEditarPerfil-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarEditarPerfil()
        {
            Control control = PanelContainer.Controls[0];
            if (control is EditarPerfil)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                // Crear una nueva instancia de EditarPerfil
                EditarPerfil editarPerfil = new EditarPerfil(PUsuario);
                editarPerfil.TopLevel = false;
                editarPerfil.CambiarImagenPerfil += BCambiarImagenPerfil_Click;
                editarPerfil.CambiarNombrePerfil += CambiarNombrePerfil_Click;

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(editarPerfil);
                Mainform.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                editarPerfil.Show();

                //Liberamos memoria.
                this.Dispose();
            }
        }

        public event EventHandler<string> CambiarNombrePerfil; //Lanzamos el evento para cambiar el nombre del usuario en el form de Bienvenida.

        private void CambiarNombrePerfil_Click (object sender, string nombre)
        {
            //Pasamos el nombre del perfil al formulario de Bienvenida.
            CambiarNombrePerfil?.Invoke(this, nombre);
        }

        public event EventHandler<string> CambiarImagenPerfil; //Lanzamos el evento para cambiar la imagen del usuario en el form de Bienvenida.
        private void BCambiarImagenPerfil_Click(object sender, string img)
        {
            //Pasamos la dirección de la imagen al formulario de Bienvenida.
            CambiarImagenPerfil?.Invoke(this, img);
        }
        //------------------------------------------------------------------------------------InstanciarBackups-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarBackup()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Backups)
            {
                return;
            }
            else
            {
                if (control is Form)
                {
                    //Liberamos recursos
                    control.Dispose();
                }

                Backups backups = new Backups();
                backups.TopLevel = false;

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(backups);
                //editarPerfil.PanelContainer = PanelContainer;
                Mainform.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                backups.Show();

                //Liberamos memoria.
                this.Dispose();
            }
        }
        //------------------------------------------------------------------------------------Cerrar Sesión-------------------------------------------------------------------------------\\
        private void CerrarSesion(Object sender,EventArgs e)
        {
            //Mostramos el form de inicio sesion
            Forminicio.Show();

            //Ejecutamos el MenuContract
            Mainform.BContracMenu_Click(sender, e);

            //Liberamos memoria
            this.Dispose();
            Menu.Dispose();
            Mainform.Dispose();
        }
        public new void Dispose()
        {
            // Desuscribirse de eventos
            BMiPerfil.Click -= BMiPerfil_Click;
            BBackups.Click -= BBackups_Click;
            BCerrarSesion.Click -= BCerrarSesion_Click;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
