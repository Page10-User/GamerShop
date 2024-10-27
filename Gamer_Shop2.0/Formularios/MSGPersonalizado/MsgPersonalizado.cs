using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.MSGPersonalizado
{
    public partial class MsgPersonalizado : Form
    {
        Form fondoBG; // <----- Fondo negro

        public MsgPersonalizado(string descripcion, string titulo, string tipo, List<string> camposVacios)
        {
            InitializeComponent();
            LDescripcion.Text = descripcion;
            LTitulo.Text = titulo;
            mostrarIMGTipo(tipo);
            mostrarBotonesTipo(tipo);
            generarFondoOscuro();
            mostrarCantidadCamposIncompletos(camposVacios);
        }

        private void BAceptarOSalir_Click(object sender, EventArgs e)
        {
            fondoBG.Close();
            this.Dispose();
        }

        private void mostrarIMGTipo(string tipoIMG)
        {
            string basePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\MSGPersonalizado\IMGTipo\"));

            switch (tipoIMG)
            {
                case "Error":
                    PBTipoMsg.ImageLocation = basePath + "TError.png";
                    break;
                case "Interrogacion":
                    PBTipoMsg.ImageLocation = basePath + "TInterrogacion.png";
                    break;
                case "Informacion":
                    PBTipoMsg.ImageLocation = basePath + "TExclamacion.png";
                    break;
            }
            PBTipoMsg.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void mostrarBotonesTipo(string tipoBoton)
        {
            switch (tipoBoton)
            {
                case "Error":
                    BRespuestaNO.Visible = false;
                    BRespuestaSI.Visible = false;
                    break;
                case "Interrogacion":
                    BAceptar.Visible = false;
                    break;
                case "Informacion":
                    BRespuestaNO.Visible = false;
                    BRespuestaSI.Visible = false;
                    break;
            }
        }

        private void generarFondoOscuro()
        {
            fondoBG = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.70d, // 70% de opacidad
                BackColor = Color.Black,
                WindowState = FormWindowState.Maximized,
                TopMost = true,
                ShowInTaskbar = false
            };
            fondoBG.Show();
        }

        private void mostrarCantidadCamposIncompletos(List<string> camposVacios)
        {
            if (contarCamposVacios(camposVacios) > 0)
            {
                LcantidadCampos.Text = contarCamposVacios(camposVacios).ToString();
            }
            else
            {
                label1.Visible = false;
                LcantidadCampos.Visible = false;
            }
        }

        private int contarCamposVacios(List<string> camposVacios)
        {
            if (camposVacios != null)
            {
                int cantidad = camposVacios.Count(campo => string.IsNullOrWhiteSpace(campo)); //Definimos la variable y contamos los campos vacios.

                return cantidad; //Retornamos la variable cantidad
            }
            else
            {
                return 0;
            }
        }

        private void BRespuestaNO_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            fondoBG.Close();
            this.Hide();
        }

        private void BRespuestaSI_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            fondoBG.Close();
            this.Hide();
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos
            BRespuestaNO.Click -= BRespuestaNO_Click;
            BRespuestaSI.Click -= BRespuestaSI_Click;
            BAceptar.Click -= BAceptarOSalir_Click;
            BSalir.Click -= BAceptarOSalir_Click;

            // Liberar los recursos
            base.Dispose();
        }
    }
}
