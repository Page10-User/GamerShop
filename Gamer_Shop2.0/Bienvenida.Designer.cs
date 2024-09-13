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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LTítulo = new System.Windows.Forms.Label();
            this.LBievenida = new System.Windows.Forms.Label();
            this.PMenuUS = new System.Windows.Forms.Panel();
            this.PEBorde = new System.Windows.Forms.Panel();
            this.PContenidoUS = new System.Windows.Forms.Panel();
            this.BAltaProducto = new System.Windows.Forms.Button();
            this.BContracMenu = new System.Windows.Forms.Button();
            this.PFondoBienvenida = new System.Windows.Forms.Panel();
            this.LFActual = new System.Windows.Forms.Label();
            this.LReloj = new System.Windows.Forms.Label();
            this.THorario = new System.Windows.Forms.Timer(this.components);
            this.PAddB = new System.Windows.Forms.Panel();
            this.BSalir = new Gamer_Shop2._0.RJButton();
            this.BExpandMenu = new Gamer_Shop2._0.RJButton();
            this.PShowOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.PMenuUS.SuspendLayout();
            this.PContenidoUS.SuspendLayout();
            this.PFondoBienvenida.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBLogo.BackgroundImage")));
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(100, 12);
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
            this.LTítulo.Location = new System.Drawing.Point(79, 116);
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
            this.LBievenida.Location = new System.Drawing.Point(37, 176);
            this.LBievenida.Name = "LBievenida";
            this.LBievenida.Size = new System.Drawing.Size(510, 29);
            this.LBievenida.TabIndex = 4;
            this.LBievenida.Text = "Bievenido al sistema de venta Gamer_Shop";
            // 
            // PMenuUS
            // 
            this.PMenuUS.BackColor = System.Drawing.SystemColors.MenuText;
            this.PMenuUS.Controls.Add(this.PEBorde);
            this.PMenuUS.Controls.Add(this.PContenidoUS);
            this.PMenuUS.Location = new System.Drawing.Point(0, 0);
            this.PMenuUS.Name = "PMenuUS";
            this.PMenuUS.Size = new System.Drawing.Size(200, 526);
            this.PMenuUS.TabIndex = 11;
            // 
            // PEBorde
            // 
            this.PEBorde.Location = new System.Drawing.Point(191, 40);
            this.PEBorde.Name = "PEBorde";
            this.PEBorde.Size = new System.Drawing.Size(10, 31);
            this.PEBorde.TabIndex = 16;
            // 
            // PContenidoUS
            // 
            this.PContenidoUS.BackColor = System.Drawing.Color.PaleGreen;
            this.PContenidoUS.Controls.Add(this.BAltaProducto);
            this.PContenidoUS.Controls.Add(this.BContracMenu);
            this.PContenidoUS.Location = new System.Drawing.Point(11, 12);
            this.PContenidoUS.Name = "PContenidoUS";
            this.PContenidoUS.Size = new System.Drawing.Size(177, 502);
            this.PContenidoUS.TabIndex = 13;
            // 
            // BAltaProducto
            // 
            this.BAltaProducto.Location = new System.Drawing.Point(51, 57);
            this.BAltaProducto.Name = "BAltaProducto";
            this.BAltaProducto.Size = new System.Drawing.Size(75, 23);
            this.BAltaProducto.TabIndex = 14;
            this.BAltaProducto.Text = "AltaProducto";
            this.BAltaProducto.UseVisualStyleBackColor = true;
            this.BAltaProducto.Click += new System.EventHandler(this.BAltaProducto_Click);
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
            // PFondoBienvenida
            // 
            this.PFondoBienvenida.BackColor = System.Drawing.Color.Black;
            this.PFondoBienvenida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PFondoBienvenida.BackgroundImage")));
            this.PFondoBienvenida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PFondoBienvenida.Controls.Add(this.LFActual);
            this.PFondoBienvenida.Controls.Add(this.LReloj);
            this.PFondoBienvenida.Controls.Add(this.LTítulo);
            this.PFondoBienvenida.Controls.Add(this.LBievenida);
            this.PFondoBienvenida.Controls.Add(this.PBLogo);
            this.PFondoBienvenida.Location = new System.Drawing.Point(127, 66);
            this.PFondoBienvenida.Name = "PFondoBienvenida";
            this.PFondoBienvenida.Size = new System.Drawing.Size(584, 237);
            this.PFondoBienvenida.TabIndex = 13;
            // 
            // LFActual
            // 
            this.LFActual.AutoSize = true;
            this.LFActual.BackColor = System.Drawing.Color.Transparent;
            this.LFActual.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFActual.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LFActual.Location = new System.Drawing.Point(321, 111);
            this.LFActual.Name = "LFActual";
            this.LFActual.Size = new System.Drawing.Size(158, 29);
            this.LFActual.TabIndex = 6;
            this.LFActual.Text = "Fecha actual";
            // 
            // LReloj
            // 
            this.LReloj.AutoSize = true;
            this.LReloj.BackColor = System.Drawing.Color.Transparent;
            this.LReloj.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReloj.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LReloj.Location = new System.Drawing.Point(296, 54);
            this.LReloj.Name = "LReloj";
            this.LReloj.Size = new System.Drawing.Size(164, 57);
            this.LReloj.TabIndex = 5;
            this.LReloj.Text = "Horario";
            // 
            // PAddB
            // 
            this.PAddB.BackColor = System.Drawing.Color.LightGreen;
            this.PAddB.Location = new System.Drawing.Point(0, 0);
            this.PAddB.Name = "PAddB";
            this.PAddB.Size = new System.Drawing.Size(1, 525);
            this.PAddB.TabIndex = 16;
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Transparent;
            this.BSalir.BackgroundColor = System.Drawing.Color.Transparent;
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.BorderColor = System.Drawing.Color.Lime;
            this.BSalir.BorderRadius = 15;
            this.BSalir.BorderSize = 1;
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
            // PShowOptions
            // 
            this.PShowOptions.BackColor = System.Drawing.Color.Transparent;
            this.PShowOptions.Location = new System.Drawing.Point(75, 43);
            this.PShowOptions.Name = "PShowOptions";
            this.PShowOptions.Size = new System.Drawing.Size(684, 436);
            this.PShowOptions.TabIndex = 17;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 526);
            this.Controls.Add(this.PAddB);
            this.Controls.Add(this.PMenuUS);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.PFondoBienvenida);
            this.Controls.Add(this.BExpandMenu);
            this.Controls.Add(this.PShowOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.PMenuUS.ResumeLayout(false);
            this.PContenidoUS.ResumeLayout(false);
            this.PFondoBienvenida.ResumeLayout(false);
            this.PFondoBienvenida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LTítulo;
        private System.Windows.Forms.Label LBievenida;
        private RJButton BSalir;
        private System.Windows.Forms.Panel PMenuUS;
        private System.Windows.Forms.Button BContracMenu;
        private System.Windows.Forms.Panel PContenidoUS;
        private System.Windows.Forms.Panel PFondoBienvenida;
        private System.Windows.Forms.Label LReloj;
        private System.Windows.Forms.Timer THorario;
        private System.Windows.Forms.Label LFActual;
        private RJButton BExpandMenu;
        private System.Windows.Forms.Panel PEBorde;
        private System.Windows.Forms.Panel PAddB;
        private System.Windows.Forms.Button BAltaProducto;
        private System.Windows.Forms.Panel PShowOptions;
    }
}