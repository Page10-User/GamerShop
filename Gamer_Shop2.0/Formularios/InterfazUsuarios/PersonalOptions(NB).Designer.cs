namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    partial class PersonalOptions_NB_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalOptions_NB_));
            this.BMiPerfil = new Gamer_Shop2._0.RJButton();
            this.BCerrarSesion = new Gamer_Shop2._0.RJButton();
            this.SuspendLayout();
            // 
            // BMiPerfil
            // 
            this.BMiPerfil.BackColor = System.Drawing.Color.Black;
            this.BMiPerfil.BackgroundColor = System.Drawing.Color.Black;
            this.BMiPerfil.BorderColor = System.Drawing.Color.Lime;
            this.BMiPerfil.BorderRadius = 8;
            this.BMiPerfil.BorderSize = 1;
            this.BMiPerfil.FlatAppearance.BorderSize = 0;
            this.BMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMiPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMiPerfil.ForeColor = System.Drawing.Color.White;
            this.BMiPerfil.Image = ((System.Drawing.Image)(resources.GetObject("BMiPerfil.Image")));
            this.BMiPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BMiPerfil.Location = new System.Drawing.Point(12, 12);
            this.BMiPerfil.Name = "BMiPerfil";
            this.BMiPerfil.Size = new System.Drawing.Size(80, 31);
            this.BMiPerfil.TabIndex = 2;
            this.BMiPerfil.Text = "Mi Perfil";
            this.BMiPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BMiPerfil.TextColor = System.Drawing.Color.White;
            this.BMiPerfil.UseVisualStyleBackColor = false;
            this.BMiPerfil.Click += new System.EventHandler(this.BMiPerfil_Click);
            // 
            // BCerrarSesion
            // 
            this.BCerrarSesion.BackColor = System.Drawing.Color.Black;
            this.BCerrarSesion.BackgroundColor = System.Drawing.Color.Black;
            this.BCerrarSesion.BorderColor = System.Drawing.Color.Lime;
            this.BCerrarSesion.BorderRadius = 8;
            this.BCerrarSesion.BorderSize = 1;
            this.BCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BCerrarSesion.Image")));
            this.BCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrarSesion.Location = new System.Drawing.Point(12, 57);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(106, 31);
            this.BCerrarSesion.TabIndex = 3;
            this.BCerrarSesion.Text = "Cerrar Sesion";
            this.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCerrarSesion.TextColor = System.Drawing.Color.White;
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // PersonalOptions_NB_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(130, 103);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.BMiPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalOptions_NB_";
            this.Text = "PersonalOptions_NB_";
            this.ResumeLayout(false);

        }

        #endregion
        private RJButton BMiPerfil;
        private RJButton BCerrarSesion;
    }
}