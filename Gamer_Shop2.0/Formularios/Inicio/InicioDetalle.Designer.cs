namespace Gamer_Shop2._0.Formularios.Inicio
{
    partial class InicioDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDetalle));
            this.LFActual = new System.Windows.Forms.Label();
            this.LReloj = new System.Windows.Forms.Label();
            this.LTítulo = new System.Windows.Forms.Label();
            this.LBievenida = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.THorario = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LFActual
            // 
            this.LFActual.AutoSize = true;
            this.LFActual.BackColor = System.Drawing.Color.Transparent;
            this.LFActual.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFActual.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LFActual.Location = new System.Drawing.Point(322, 111);
            this.LFActual.Name = "LFActual";
            this.LFActual.Size = new System.Drawing.Size(158, 29);
            this.LFActual.TabIndex = 11;
            this.LFActual.Text = "Fecha actual";
            // 
            // LReloj
            // 
            this.LReloj.AutoSize = true;
            this.LReloj.BackColor = System.Drawing.Color.Transparent;
            this.LReloj.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LReloj.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LReloj.Location = new System.Drawing.Point(297, 54);
            this.LReloj.Name = "LReloj";
            this.LReloj.Size = new System.Drawing.Size(0, 57);
            this.LReloj.TabIndex = 10;
            // 
            // LTítulo
            // 
            this.LTítulo.AutoSize = true;
            this.LTítulo.BackColor = System.Drawing.Color.Transparent;
            this.LTítulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTítulo.ForeColor = System.Drawing.Color.White;
            this.LTítulo.Location = new System.Drawing.Point(80, 116);
            this.LTítulo.Name = "LTítulo";
            this.LTítulo.Size = new System.Drawing.Size(162, 29);
            this.LTítulo.TabIndex = 8;
            this.LTítulo.Text = "Gamer_Shop";
            // 
            // LBievenida
            // 
            this.LBievenida.AutoSize = true;
            this.LBievenida.BackColor = System.Drawing.Color.Transparent;
            this.LBievenida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBievenida.ForeColor = System.Drawing.Color.White;
            this.LBievenida.Location = new System.Drawing.Point(38, 176);
            this.LBievenida.Name = "LBievenida";
            this.LBievenida.Size = new System.Drawing.Size(510, 29);
            this.LBievenida.TabIndex = 9;
            this.LBievenida.Text = "Bievenido al sistema de venta Gamer_Shop";
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBLogo.BackgroundImage")));
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(101, 12);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(110, 116);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 7;
            this.PBLogo.TabStop = false;
            // 
            // THorario
            // 
            this.THorario.Tick += new System.EventHandler(this.THorario_Tick);
            // 
            // InicioDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 237);
            this.Controls.Add(this.LFActual);
            this.Controls.Add(this.LTítulo);
            this.Controls.Add(this.LBievenida);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.LReloj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioDetalle";
            this.Load += new System.EventHandler(this.InicioDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFActual;
        private System.Windows.Forms.Label LReloj;
        private System.Windows.Forms.Label LTítulo;
        private System.Windows.Forms.Label LBievenida;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Timer THorario;
    }
}