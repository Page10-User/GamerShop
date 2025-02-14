namespace Gamer_Shop2._0.Formularios.GestionBackups
{
    partial class botonRestaurarBackup
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(botonRestaurarBackup));
            this.LDateTimeBackup = new System.Windows.Forms.Label();
            this.LNameBackup = new System.Windows.Forms.Label();
            this.PBDisc = new System.Windows.Forms.PictureBox();
            this.BRestaurar = new Gamer_Shop2._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // LDateTimeBackup
            // 
            this.LDateTimeBackup.AutoSize = true;
            this.LDateTimeBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDateTimeBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDateTimeBackup.Location = new System.Drawing.Point(313, 23);
            this.LDateTimeBackup.Name = "LDateTimeBackup";
            this.LDateTimeBackup.Size = new System.Drawing.Size(128, 13);
            this.LDateTimeBackup.TabIndex = 10;
            this.LDateTimeBackup.Text = "2025-01-27_14-32-53";
            // 
            // LNameBackup
            // 
            this.LNameBackup.AutoSize = true;
            this.LNameBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNameBackup.Location = new System.Drawing.Point(62, 24);
            this.LNameBackup.Name = "LNameBackup";
            this.LNameBackup.Size = new System.Drawing.Size(230, 13);
            this.LNameBackup.TabIndex = 9;
            this.LNameBackup.Text = "BackupCompleto_2025-01-27_14-32-53";
            // 
            // PBDisc
            // 
            this.PBDisc.Image = ((System.Drawing.Image)(resources.GetObject("PBDisc.Image")));
            this.PBDisc.Location = new System.Drawing.Point(10, 10);
            this.PBDisc.Name = "PBDisc";
            this.PBDisc.Size = new System.Drawing.Size(46, 39);
            this.PBDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBDisc.TabIndex = 8;
            this.PBDisc.TabStop = false;
            // 
            // BRestaurar
            // 
            this.BRestaurar.BackColor = System.Drawing.Color.Black;
            this.BRestaurar.BackgroundColor = System.Drawing.Color.Black;
            this.BRestaurar.BorderColor = System.Drawing.Color.Lime;
            this.BRestaurar.BorderRadius = 20;
            this.BRestaurar.BorderSize = 1;
            this.BRestaurar.FlatAppearance.BorderSize = 0;
            this.BRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRestaurar.ForeColor = System.Drawing.Color.White;
            this.BRestaurar.Location = new System.Drawing.Point(465, 9);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(109, 39);
            this.BRestaurar.TabIndex = 11;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.TextColor = System.Drawing.Color.White;
            this.BRestaurar.UseVisualStyleBackColor = false;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // botonRestaurarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.BRestaurar);
            this.Controls.Add(this.LDateTimeBackup);
            this.Controls.Add(this.LNameBackup);
            this.Controls.Add(this.PBDisc);
            this.Name = "botonRestaurarBackup";
            this.Size = new System.Drawing.Size(584, 59);
            ((System.ComponentModel.ISupportInitialize)(this.PBDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton BRestaurar;
        private System.Windows.Forms.Label LDateTimeBackup;
        private System.Windows.Forms.Label LNameBackup;
        private System.Windows.Forms.PictureBox PBDisc;
    }
}
