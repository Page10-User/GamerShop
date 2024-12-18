﻿using Gamer_Shop2._0.Formularios.Comercio;
using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionProducto;
using Gamer_Shop2._0.Formularios.GestionUsuario;
using Gamer_Shop2._0.Formularios.GestionVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    public partial class EmpleadoOptions : Form
    {
        bool isExpandedOption = false;
        public Panel PanelContainer { get; set; } //Referencia a Control para los forms de gestion.
        public Label LabelContainer { get; set; } //Referencia al Label de version para poner visible o no.
        public Bienvenida MainForm { get; set; } //Referencia a Bienvenida para usar su función MenuContract.
        public bool isExpandedOps { get; set; } //Referencia al booleano utilizado para evaluar si la configuración está abierta o no.

        //Options definido globalmente para mejor manejo.
        private PersonalOptions_NB_ Poptions ;

        public EmpleadoOptions()
        {
            InitializeComponent();
            Poptions = new PersonalOptions_NB_();
        }

        private void BGestionPr_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            AltaProducto formAltaProducto = new AltaProducto();
            formAltaProducto.TopLevel = false;
            formAltaProducto.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formAltaProducto);
            PanelContainer.BringToFront();

            formAltaProducto.Show();
        }

        private void BGestionCliente_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            ListaCliente formCliente = new ListaCliente();
            formCliente.TopLevel = false;
            formCliente.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formCliente);
            PanelContainer.BringToFront();

            formCliente.Show();
        }

        private void BGestionVenta_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            ListaVenta formListaVn = new ListaVenta();
            formListaVn.TopLevel = false;
            formListaVn.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formListaVn);
            PanelContainer.BringToFront();

            formListaVn.Show();
        }

        private void BCatalogo_Click(object sender, EventArgs e)
        {
            //Cerrar el menú tras elegír una opción 
            MainForm.BContracMenu_Click(sender, e);

            //Ocultar Otros.
            LabelContainer.Visible = false;

            // Mostrar form
            Catalogo formCatalogo = new Catalogo();
            formCatalogo.TopLevel = false;
            formCatalogo.PanelContainer = PanelContainer;
            formCatalogo.LabelContainer = LabelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formCatalogo);
            PanelContainer.BringToFront();

            formCatalogo.Show();
        }

        private void BOptionsEmpleado_Click(object sender, EventArgs e)
        {
            if (!isExpandedOption || !isExpandedOps)
            {
                // Mostrar form
                Poptions = new PersonalOptions_NB_();
                Poptions.TopLevel = false;
                Poptions.PanelContainer = PanelContainer;
                Poptions.Mainform = MainForm;
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
            else
            {
                Poptions.Close();
                isExpandedOption = false;
                MainForm.isExpandedOpts = false;
            }
        }
    }
}
