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
            this.PMenuUS = new System.Windows.Forms.Panel();
            this.PEBorde = new System.Windows.Forms.Panel();
            this.BContracMenu = new System.Windows.Forms.Button();
            this.PAddB = new System.Windows.Forms.Panel();
            this.PShowOptions = new System.Windows.Forms.Panel();
            this.LVersion = new System.Windows.Forms.Label();
            this.BSalir = new Gamer_Shop2._0.RJButton();
            this.BExpandMenu = new Gamer_Shop2._0.RJButton();
            this.PMenuUS.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenuUS
            // 
            this.PMenuUS.BackColor = System.Drawing.SystemColors.MenuText;
            this.PMenuUS.Controls.Add(this.PEBorde);
            this.PMenuUS.Controls.Add(this.BContracMenu);
            this.PMenuUS.Location = new System.Drawing.Point(0, 0);
            this.PMenuUS.Name = "PMenuUS";
            this.PMenuUS.Size = new System.Drawing.Size(200, 526);
            this.PMenuUS.TabIndex = 11;
            this.PMenuUS.Paint += new System.Windows.Forms.PaintEventHandler(this.PMenuUS_Paint);
            // 
            // PEBorde
            // 
            this.PEBorde.Location = new System.Drawing.Point(191, 40);
            this.PEBorde.Name = "PEBorde";
            this.PEBorde.Size = new System.Drawing.Size(10, 31);
            this.PEBorde.TabIndex = 16;
            // 
            // BContracMenu
            // 
            this.BContracMenu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BContracMenu.FlatAppearance.BorderSize = 0;
            this.BContracMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BContracMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BContracMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BContracMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BContracMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BContracMenu.Location = new System.Drawing.Point(147, 10);
            this.BContracMenu.Name = "BContracMenu";
            this.BContracMenu.Size = new System.Drawing.Size(38, 33);
            this.BContracMenu.TabIndex = 13;
            this.BContracMenu.Text = "X";
            this.BContracMenu.UseVisualStyleBackColor = false;
            this.BContracMenu.Visible = false;
            this.BContracMenu.Click += new System.EventHandler(this.BContracMenu_Click);
            // 
            // PAddB
            // 
            this.PAddB.BackColor = System.Drawing.Color.LimeGreen;
            this.PAddB.Location = new System.Drawing.Point(0, 1);
            this.PAddB.Name = "PAddB";
            this.PAddB.Size = new System.Drawing.Size(1, 525);
            this.PAddB.TabIndex = 16;
            // 
            // PShowOptions
            // 
            this.PShowOptions.BackColor = System.Drawing.Color.Transparent;
            this.PShowOptions.Location = new System.Drawing.Point(75, 43);
            this.PShowOptions.Name = "PShowOptions";
            this.PShowOptions.Size = new System.Drawing.Size(684, 436);
            this.PShowOptions.TabIndex = 17;
            // 
            // LVersion
            // 
            this.LVersion.AutoSize = true;
            this.LVersion.BackColor = System.Drawing.Color.Transparent;
            this.LVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVersion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LVersion.Location = new System.Drawing.Point(743, 501);
            this.LVersion.Name = "LVersion";
            this.LVersion.Size = new System.Drawing.Size(84, 16);
            this.LVersion.TabIndex = 18;
            this.LVersion.Text = "Version 1.0";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Transparent;
            this.BSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BSalir.BorderColor = System.Drawing.Color.Lime;
            this.BSalir.BorderRadius = 0;
            this.BSalir.BorderSize = 0;
            this.BSalir.CausesValidation = false;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(787, 27);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(25, 25);
            this.BSalir.TabIndex = 10;
            this.BSalir.TextColor = System.Drawing.Color.White;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BExpandMenu
            // 
            this.BExpandMenu.BackColor = System.Drawing.Color.Black;
            this.BExpandMenu.BackgroundColor = System.Drawing.Color.Black;
            this.BExpandMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BExpandMenu.BackgroundImage")));
            this.BExpandMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BExpandMenu.BorderColor = System.Drawing.Color.LightGreen;
            this.BExpandMenu.BorderRadius = 9;
            this.BExpandMenu.BorderSize = 1;
            this.BExpandMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BExpandMenu.FlatAppearance.BorderSize = 0;
            this.BExpandMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BExpandMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExpandMenu.ForeColor = System.Drawing.Color.Black;
            this.BExpandMenu.Location = new System.Drawing.Point(187, 38);
            this.BExpandMenu.Name = "BExpandMenu";
            this.BExpandMenu.Size = new System.Drawing.Size(38, 34);
            this.BExpandMenu.TabIndex = 15;
            this.BExpandMenu.TextColor = System.Drawing.Color.Black;
            this.BExpandMenu.UseVisualStyleBackColor = false;
            this.BExpandMenu.Click += new System.EventHandler(this.BExpandMenu_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 526);
            this.Controls.Add(this.LVersion);
            this.Controls.Add(this.PAddB);
            this.Controls.Add(this.PMenuUS);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BExpandMenu);
            this.Controls.Add(this.PShowOptions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            this.PMenuUS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJButton BSalir;
        private System.Windows.Forms.Panel PMenuUS;
        private System.Windows.Forms.Button BContracMenu;
        private RJButton BExpandMenu;
        private System.Windows.Forms.Panel PEBorde;
        private System.Windows.Forms.Panel PAddB;
        private System.Windows.Forms.Panel PShowOptions;
        private System.Windows.Forms.Label LVersion;
    }
}