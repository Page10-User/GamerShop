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
            this.TBValidacion2 = new System.Windows.Forms.Label();
            this.TBValidacion = new System.Windows.Forms.Label();
            this.LGamerShop = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TBContraseña = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.TBUsuario = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.BSalir = new Gamer_Shop2._0.RJButton();
            this.BIniciar = new Gamer_Shop2._0.RJButton();
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
            this.LUsuario.Location = new System.Drawing.Point(14, 141);
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
            this.LContraseña.Location = new System.Drawing.Point(14, 184);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(84, 19);
            this.LContraseña.TabIndex = 2;
            this.LContraseña.Text = "Contraseña";
            // 
            // PInicio
            // 
            this.PInicio.BackColor = System.Drawing.Color.Black;
            this.PInicio.Controls.Add(this.TBContraseña);
            this.PInicio.Controls.Add(this.TBValidacion2);
            this.PInicio.Controls.Add(this.TBUsuario);
            this.PInicio.Controls.Add(this.TBValidacion);
            this.PInicio.Controls.Add(this.BIniciar);
            this.PInicio.Controls.Add(this.LGamerShop);
            this.PInicio.Controls.Add(this.LContraseña);
            this.PInicio.Controls.Add(this.LUsuario);
            this.PInicio.Controls.Add(this.pictureBox1);
            this.PInicio.Location = new System.Drawing.Point(311, 111);
            this.PInicio.Name = "PInicio";
            this.PInicio.Size = new System.Drawing.Size(223, 285);
            this.PInicio.TabIndex = 0;
            // 
            // TBValidacion2
            // 
            this.TBValidacion2.AutoSize = true;
            this.TBValidacion2.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion2.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion2.Location = new System.Drawing.Point(2, 202);
            this.TBValidacion2.Name = "TBValidacion2";
            this.TBValidacion2.Size = new System.Drawing.Size(218, 14);
            this.TBValidacion2.TabIndex = 9;
            this.TBValidacion2.Text = "La contraseña debe tener mas de 7 caracteres.";
            this.TBValidacion2.Visible = false;
            // 
            // TBValidacion
            // 
            this.TBValidacion.AutoSize = true;
            this.TBValidacion.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion.Location = new System.Drawing.Point(19, 159);
            this.TBValidacion.Name = "TBValidacion";
            this.TBValidacion.Size = new System.Drawing.Size(200, 14);
            this.TBValidacion.TabIndex = 8;
            this.TBValidacion.Text = "El usuario debe tener mas de 7 caracteres.";
            this.TBValidacion.Visible = false;
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
            // TBContraseña
            // 
            this.TBContraseña.BackColor = System.Drawing.Color.Black;
            this.TBContraseña.BorderColor = System.Drawing.Color.Lime;
            this.TBContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TBContraseña.BorderRadius = 0;
            this.TBContraseña.BorderSize = 2;
            this.TBContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBContraseña.Location = new System.Drawing.Point(105, 172);
            this.TBContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.TBContraseña.Multiline = false;
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBContraseña.PasswordChar = false;
            this.TBContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBContraseña.PlaceholderText = "";
            this.TBContraseña.Size = new System.Drawing.Size(103, 31);
            this.TBContraseña.TabIndex = 11;
            this.TBContraseña.Texts = "";
            this.TBContraseña.UnderlinedStyle = true;
            this.TBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuarioUs_KeyPress);
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.Black;
            this.TBUsuario.BorderColor = System.Drawing.Color.Lime;
            this.TBUsuario.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TBUsuario.BorderRadius = 0;
            this.TBUsuario.BorderSize = 2;
            this.TBUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBUsuario.Location = new System.Drawing.Point(105, 126);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TBUsuario.Multiline = false;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBUsuario.PasswordChar = false;
            this.TBUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TBUsuario.PlaceholderText = "";
            this.TBUsuario.Size = new System.Drawing.Size(103, 31);
            this.TBUsuario.TabIndex = 10;
            this.TBUsuario.Texts = "";
            this.TBUsuario.UnderlinedStyle = true;
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuarioUs_KeyPress);
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.White;
            this.BSalir.BackgroundColor = System.Drawing.Color.White;
            this.BSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BSalir.BackgroundImage")));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSalir.BorderColor = System.Drawing.Color.Lime;
            this.BSalir.BorderRadius = 19;
            this.BSalir.BorderSize = 2;
            this.BSalir.CausesValidation = false;
            this.BSalir.FlatAppearance.BorderSize = 0;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.White;
            this.BSalir.Location = new System.Drawing.Point(792, 12);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(39, 40);
            this.BSalir.TabIndex = 9;
            this.BSalir.TextColor = System.Drawing.Color.White;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BIniciar
            // 
            this.BIniciar.BackColor = System.Drawing.SystemColors.Window;
            this.BIniciar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BIniciar.BorderColor = System.Drawing.Color.Lime;
            this.BIniciar.BorderRadius = 14;
            this.BIniciar.BorderSize = 2;
            this.BIniciar.FlatAppearance.BorderSize = 0;
            this.BIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIniciar.ForeColor = System.Drawing.Color.Black;
            this.BIniciar.Location = new System.Drawing.Point(18, 240);
            this.BIniciar.Name = "BIniciar";
            this.BIniciar.Size = new System.Drawing.Size(113, 29);
            this.BIniciar.TabIndex = 1;
            this.BIniciar.Text = "Iniciar";
            this.BIniciar.TextColor = System.Drawing.Color.Black;
            this.BIniciar.UseVisualStyleBackColor = false;
            this.BIniciar.Click += new System.EventHandler(this.BIniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(843, 526);
            this.Controls.Add(this.BSalir);
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
        private RJButton BIniciar;
        private RJButton BSalir;
        private System.Windows.Forms.Label TBValidacion;
        private System.Windows.Forms.Label TBValidacion2;
        private RJControls.RJTextBox_radio_ TBUsuario;
        private RJControls.RJTextBox_radio_ TBContraseña;
    }
}

