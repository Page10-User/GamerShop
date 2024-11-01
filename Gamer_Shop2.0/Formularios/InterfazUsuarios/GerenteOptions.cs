﻿using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.Informe;
using Gamer_Shop2._0.Formularios.Inicio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class GerenteOptions : UserOptionsBase
    {

        bool isExpandedOption = false;

        //Options definido globalmente para mejor manejo.
        private PersonalOptions_NB_ Poptions;

        public GerenteOptions()
        {
            InitializeComponent();
            Poptions = new PersonalOptions_NB_();
        }

        private void BGestionUsuario_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            //Mostramos el Alta Usuario
            InstanciarYMostrarUsuario();
        }
        private void BOptionsGerente_Click(object sender, EventArgs e)
        {
            if (!isExpandedOption || !isExpandedOps)
            {
                InstanciarYMostrarPoptions();
            }
            else
            {
                CerrarPoptions();
            }
        }

        private void BAccederInformes_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;
            
            // Mostrar form
            InstanciarYMostrarReporte();
        }
        //------------------------------------------------------------------------------------InstanciarUsuario-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarUsuario()
        {
            Control control = PanelContainer.Controls[0];
            if (control is AltaUsuario)
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

                // Mostrar form
                AltaUsuario formAltaUs = new AltaUsuario();
                formAltaUs.TopLevel = false;
                formAltaUs.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formAltaUs);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formAltaUs.Show();
            }
        }
        //------------------------------------------------------------------------------------InstanciarReporte-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarReporte()
        {
            Control control = PanelContainer.Controls[0];
            if (control is Reporte)
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

                Reporte formReporte = new Reporte();
                formReporte.TopLevel = false;
                formReporte.PanelContainer = PanelContainer;
                PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
                PanelContainer.Controls.Add(formReporte);
                PanelContainer.BringToFront();
                MainForm.TopMost = true; // Volvemos a aplicar el TopMost del Mainform.
                formReporte.Show();
            }
        }

        //------------------------------------------------------------------------------------InstanciarPoptions-------------------------------------------------------------------------------\\
        private void InstanciarYMostrarPoptions()
        {
            // Mostrar form
            Poptions = new PersonalOptions_NB_();
            Poptions.TopLevel = false;
            Poptions.PanelContainer = PanelContainer;
            Poptions.Mainform = MainForm;
            Poptions.Forminicio = Forminicio;
            Poptions.PUsuario = UUsuario;
            Poptions.Menu = this;
            PPersonalOptions.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PPersonalOptions.Controls.Add(Poptions);
            Poptions.Location = new Point(1, 1);

            Poptions.Show();
            isExpandedOption = true;

            //Pasamos Poptions ah Bienvenida.cs
            MainForm.PersonalOpsNB = Poptions;
            MainForm.isExpandedOpts = true;
            isExpandedOps = true;
        }
        //------------------------------------------------------------------------------------Cerrar poptions-------------------------------------------------------------------------------\\
        private void CerrarPoptions()
        {
            Poptions.Dispose();
            isExpandedOption = false;
            MainForm.isExpandedOpts = false;
        }
        //-----------------------------------------------------\\
        public new void Dispose()
        {
            // Desuscribirse de eventos
            BGestionUsuario.Click -= BGestionUsuario_Click;
            BAccederInformes.Click -= BAccederInformes_Click;

            // Liberar los recursos
            base.Dispose();
        }

        private void BHouse_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Inicializamos y mostramos el inicio
            VolverAlInicio();
        }

        private void VolverAlInicio()
        {
            Control control = PanelContainer.Controls[0];
            if (control is InicioDetalle)
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
                // Crear una nueva instancia de inicioDetalle
                InicioDetalle inicioD = new InicioDetalle();
                inicioD.TopLevel = false;

                // Poner visible "version sistema".
                LabelContainer.Visible = true;
                LabelContainer.BringToFront();

                // Limpiar el panel actual y añadir el nuevo formulario
                PanelContainer.Controls.Clear();
                PanelContainer.Controls.Add(inicioD);
                inicioD.PanelContainer = PanelContainer;
                MainForm.TopMost = true;
                inicioD.Show();
                inicioD.Location = new Point(50, 130);
            }
        }
    }
}
