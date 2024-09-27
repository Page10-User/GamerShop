namespace Gamer_Shop2._0.Formularios.InterfazUsuarios
{
    partial class PersonalOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalOptions));
            this.BBackups = new Gamer_Shop2._0.RJButton();
            this.BMiPerfil = new Gamer_Shop2._0.RJButton();
            this.BCerrarSesion = new Gamer_Shop2._0.RJButton();
            this.SuspendLayout();
            // 
            // BBackups
            // 
            this.BBackups.BackColor = System.Drawing.Color.Black;
            this.BBackups.BackgroundColor = System.Drawing.Color.Black;
            this.BBackups.BorderColor = System.Drawing.Color.Lime;
            this.BBackups.BorderRadius = 8;
            this.BBackups.BorderSize = 1;
            this.BBackups.FlatAppearance.BorderSize = 0;
            this.BBackups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackups.ForeColor = System.Drawing.Color.White;
            this.BBackups.Image = ((System.Drawing.Image)(resources.GetObject("BBackups.Image")));
            this.BBackups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackups.Location = new System.Drawing.Point(12, 48);
            this.BBackups.Name = "BBackups";
            this.BBackups.Size = new System.Drawing.Size(80, 31);
            this.BBackups.TabIndex = 1;
            this.BBackups.Text = "Backups";
            this.BBackups.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BBackups.TextColor = System.Drawing.Color.White;
            this.BBackups.UseVisualStyleBackColor = false;
            this.BBackups.Click += new System.EventHandler(this.BBackups_Click);
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
            this.BMiPerfil.Location = new System.Drawing.Point(12, 10);
            this.BMiPerfil.Name = "BMiPerfil";
            this.BMiPerfil.Size = new System.Drawing.Size(80, 31);
            this.BMiPerfil.TabIndex = 0;
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
            this.BCerrarSesion.Location = new System.Drawing.Point(12, 86);
            this.BCerrarSesion.Name = "BCerrarSesion";
            this.BCerrarSesion.Size = new System.Drawing.Size(106, 31);
            this.BCerrarSesion.TabIndex = 4;
            this.BCerrarSesion.Text = "Cerrar Sesion";
            this.BCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCerrarSesion.TextColor = System.Drawing.Color.White;
            this.BCerrarSesion.UseVisualStyleBackColor = false;
            this.BCerrarSesion.Click += new System.EventHandler(this.BCerrarSesion_Click);
            // 
            // PersonalOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(134, 129);
            this.Controls.Add(this.BCerrarSesion);
            this.Controls.Add(this.BBackups);
            this.Controls.Add(this.BMiPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalOptions";
            this.Text = "PersonalOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private RJButton BMiPerfil;
        private RJButton BBackups;
        private RJButton BCerrarSesion;
    }
}