﻿using Gamer_Shop2._0.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    public partial class EditarPerfil : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public EditarPerfil()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(EditarPerfil_Load);
            PContModificarPerfil.Paint += new PaintEventHandler(PContModificarPerfil_Paint);
            PContImgPerfil.Paint += new PaintEventHandler(PContImgPerfil_Paint);
        }

        private void PContModificarPerfil_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 60;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void PContImgPerfil_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 20;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void EditarPerfil_Load(object sender, EventArgs e)
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

        private void TNombrePr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TNombreUs.Texts.Length >= 100)
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;

                }
                else
                {
                    TBValidacion.Visible = false;
                }
            }
        }

        private void TApellidoUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TApellidoUs.Texts.Length >= 100)
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;

                }
                else
                {
                    TBValidacion2.Visible = false;
                }
            }
        }

        private void TUsuarioUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TNombreUsuario.Texts.Length >= 20)
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;

                }
                else
                {
                    TBValidacion3.Visible = false;
                }
            }
        }

        private void TContraseñaUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TContraseñaUs.Texts.Length >= 100)
                {
                    e.Cancel = true;
                    TBValidacion5.Visible = true;

                }
                else
                {
                    TBValidacion5.Visible = false;
                }
            }
        }

        private void TEmailUs_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                bool esValido = Regex.IsMatch(TEmailUs.Texts, patronCorreo);

                if (!esValido)
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;

                }
                else
                {
                    TBValidacion4.Visible = false;
                }
            }
        }



        private void TNombreUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TNombreUs.Texts.Trim().Length < 100;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TApellidoUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TApellidoUs.Texts.Trim().Length < 100;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TLoginUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = textbox.Texts.Trim().Length < 20;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TEmailUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TEmailUs.Texts.Trim().Length < 50;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        private void BModificarPerfil_Click(object sender, EventArgs e)
        {
            if (TNombreUs.Texts != string.Empty && TApellidoUs.Texts != string.Empty && TNombreUsuario.Texts != string.Empty && TContraseñaUs.Texts != string.Empty && TEmailUs.Texts != string.Empty)
            {
                MessageBox.Show("Perfil modificado con éxito", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para modificar", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
