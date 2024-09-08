namespace Gamer_Shop2._0
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LTítulo = new System.Windows.Forms.Label();
            this.LBievenida = new System.Windows.Forms.Label();
            this.BSalir = new Gamer_Shop2._0.RJButton();
            this.PMenuUS = new System.Windows.Forms.Panel();
            this.PContenidoUS = new System.Windows.Forms.Panel();
            this.BContracMenu = new System.Windows.Forms.Button();
            this.BExpandMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PMenuUS.SuspendLayout();
            this.PContenidoUS.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBLogo.BackgroundImage")));
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(359, 68);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(110, 116);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 2;
            this.PBLogo.TabStop = false;
            // 
            // LTítulo
            // 
            this.LTítulo.AutoSize = true;
            this.LTítulo.BackColor = System.Drawing.Color.Transparent;
            this.LTítulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTítulo.ForeColor = System.Drawing.Color.White;
            this.LTítulo.Location = new System.Drawing.Point(334, 170);
            this.LTítulo.Name = "LTítulo";
            this.LTítulo.Size = new System.Drawing.Size(162, 29);
            this.LTítulo.TabIndex = 3;
            this.LTítulo.Text = "Gamer_Shop";
            // 
            // LBievenida
            // 
            this.LBievenida.AutoSize = true;
            this.LBievenida.BackColor = System.Drawing.Color.Transparent;
            this.LBievenida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBievenida.ForeColor = System.Drawing.Color.White;
            this.LBievenida.Location = new System.Drawing.Point(165, 230);
            this.LBievenida.Name = "LBievenida";
            this.LBievenida.Size = new System.Drawing.Size(510, 29);
            this.LBievenida.TabIndex = 4;
            this.LBievenida.Text = "Bievenido al sistema de venta Gamer_Shop";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Transparent;
            this.BSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BSalir.BorderRadius = 15;
            this.BSalir.BorderSize = 2;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(794, 12);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(33, 31);
            this.BSalir.TabIndex = 10;
            this.BSalir.TextColor = System.Drawing.Color.White;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // PMenuUS
            // 
            this.PMenuUS.BackColor = System.Drawing.SystemColors.MenuText;
            this.PMenuUS.Controls.Add(this.PContenidoUS);
            this.PMenuUS.Location = new System.Drawing.Point(0, 0);
            this.PMenuUS.Name = "PMenuUS";
            this.PMenuUS.Size = new System.Drawing.Size(200, 524);
            this.PMenuUS.TabIndex = 11;
            // 
            // PContenidoUS
            // 
            this.PContenidoUS.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PContenidoUS.Controls.Add(this.BContracMenu);
            this.PContenidoUS.Location = new System.Drawing.Point(11, 12);
            this.PContenidoUS.Name = "PContenidoUS";
            this.PContenidoUS.Size = new System.Drawing.Size(177, 502);
            this.PContenidoUS.TabIndex = 13;
            // 
            // BContracMenu
            // 
            this.BContracMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BContracMenu.FlatAppearance.BorderSize = 0;
            this.BContracMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BContracMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BContracMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BContracMenu.Location = new System.Drawing.Point(136, 3);
            this.BContracMenu.Name = "BContracMenu";
            this.BContracMenu.Size = new System.Drawing.Size(38, 33);
            this.BContracMenu.TabIndex = 13;
            this.BContracMenu.Text = "X";
            this.BContracMenu.UseVisualStyleBackColor = false;
            this.BContracMenu.Visible = false;
            this.BContracMenu.Click += new System.EventHandler(this.BContracMenu_Click);
            // 
            // BExpandMenu
            // 
            this.BExpandMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BExpandMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.BExpandMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BExpandMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExpandMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExpandMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BExpandMenu.Location = new System.Drawing.Point(195, 26);
            this.BExpandMenu.Name = "BExpandMenu";
            this.BExpandMenu.Size = new System.Drawing.Size(38, 34);
            this.BExpandMenu.TabIndex = 12;
            this.BExpandMenu.Text = "M";
            this.BExpandMenu.UseVisualStyleBackColor = false;
            this.BExpandMenu.Click += new System.EventHandler(this.BExpandMenu_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 526);
            this.Controls.Add(this.PMenuUS);
            this.Controls.Add(this.LBievenida);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.LTítulo);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.BExpandMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PMenuUS.ResumeLayout(false);
            this.PContenidoUS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LTítulo;
        private System.Windows.Forms.Label LBievenida;
        private RJButton BSalir;
        private System.Windows.Forms.Panel PMenuUS;
        private System.Windows.Forms.Button BExpandMenu;
        private System.Windows.Forms.Button BContracMenu;
        private System.Windows.Forms.Panel PContenidoUS;
    }
}