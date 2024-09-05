namespace Gamer_Shop2._0
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LContraseña = new System.Windows.Forms.Label();
            this.PInicio = new System.Windows.Forms.Panel();
            this.LGamerShop = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BSalir = new Gamer_Shop2._0.RJButton();
            this.TBUsuario = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.TBContraseña = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.rjButton1 = new Gamer_Shop2._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LUsuario.Location = new System.Drawing.Point(14, 158);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(60, 19);
            this.LUsuario.TabIndex = 1;
            this.LUsuario.Text = "Usuario";
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LContraseña.Location = new System.Drawing.Point(14, 195);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(84, 19);
            this.LContraseña.TabIndex = 2;
            this.LContraseña.Text = "Contraseña";
            // 
            // PInicio
            // 
            this.PInicio.BackColor = System.Drawing.Color.Black;
            this.PInicio.Controls.Add(this.BSalir);
            this.PInicio.Controls.Add(this.TBUsuario);
            this.PInicio.Controls.Add(this.TBContraseña);
            this.PInicio.Controls.Add(this.rjButton1);
            this.PInicio.Controls.Add(this.LGamerShop);
            this.PInicio.Controls.Add(this.LContraseña);
            this.PInicio.Controls.Add(this.LUsuario);
            this.PInicio.Controls.Add(this.pictureBox1);
            this.PInicio.Location = new System.Drawing.Point(268, 121);
            this.PInicio.Name = "PInicio";
            this.PInicio.Size = new System.Drawing.Size(223, 285);
            this.PInicio.TabIndex = 0;
            // 
            // LGamerShop
            // 
            this.LGamerShop.AutoSize = true;
            this.LGamerShop.BackColor = System.Drawing.Color.Transparent;
            this.LGamerShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGamerShop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LGamerShop.Location = new System.Drawing.Point(37, 103);
            this.LGamerShop.Name = "LGamerShop";
            this.LGamerShop.Size = new System.Drawing.Size(156, 29);
            this.LGamerShop.TabIndex = 5;
            this.LGamerShop.Text = "Gamer_Shop";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.Black;
            this.BSalir.BackgroundColor = System.Drawing.Color.Black;
            this.BSalir.BackgroundImage = global::Gamer_Shop2._0.Properties.Resources.Simbolo_X;
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.BorderColor = System.Drawing.Color.Transparent;
            this.BSalir.BorderRadius = 15;
            this.BSalir.BorderSize = 1;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(175, 10);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(40, 32);
            this.BSalir.TabIndex = 6;
            this.BSalir.TextColor = System.Drawing.Color.White;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click_1);
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TBUsuario.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.TBUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBUsuario.BorderRadius = 15;
            this.TBUsuario.BorderSize = 2;
            this.TBUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.White;
            this.TBUsuario.Location = new System.Drawing.Point(104, 146);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TBUsuario.Multiline = false;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBUsuario.PasswordChar = false;
            this.TBUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBUsuario.PlaceholderText = "";
            this.TBUsuario.Size = new System.Drawing.Size(101, 31);
            this.TBUsuario.TabIndex = 3;
            this.TBUsuario.Texts = "";
            this.TBUsuario.UnderlinedStyle = false;
            // 
            // TBContraseña
            // 
            this.TBContraseña.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TBContraseña.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.TBContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBContraseña.BorderSize = 2;
            this.TBContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseña.ForeColor = System.Drawing.Color.White;
            this.TBContraseña.Location = new System.Drawing.Point(104, 184);
            this.TBContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TBContraseña.Multiline = false;
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.TBContraseña.PasswordChar = true;
            this.TBContraseña.Size = new System.Drawing.Size(100, 28);
            this.TBContraseña.TabIndex = 1;
            this.TBContraseña.Texts = "";
            this.TBContraseña.UnderlinedStyle = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.rjButton1.BorderRadius = 14;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(18, 240);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(113, 29);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Iniciar";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 526);
            this.Controls.Add(this.PInicio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PInicio.ResumeLayout(false);
            this.PInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.Panel PInicio;
        private System.Windows.Forms.Label LGamerShop;
        private System.Windows.Forms.Timer timer1;
        private RJButton rjButton1;
        private RJControls.RJTextBox TBContraseña;
        private RJControls.RJTextBox_radio_ TBUsuario;
        private RJButton BSalir;
    }
}

