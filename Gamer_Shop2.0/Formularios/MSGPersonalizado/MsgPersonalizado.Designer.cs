namespace Gamer_Shop2._0.Formularios.MSGPersonalizado
{
    partial class MsgPersonalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgPersonalizado));
            this.LTitulo = new System.Windows.Forms.Label();
            this.LDescripcion = new System.Windows.Forms.Label();
            this.PBTipoMsg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LcantidadCampos = new System.Windows.Forms.Label();
            this.PContMsg = new System.Windows.Forms.Panel();
            this.BRespuestaNO = new Gamer_Shop2._0.RJButton();
            this.BRespuestaSI = new Gamer_Shop2._0.RJButton();
            this.BSalir = new Gamer_Shop2._0.RJButton();
            this.BAceptar = new Gamer_Shop2._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBTipoMsg)).BeginInit();
            this.PContMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.White;
            this.LTitulo.Location = new System.Drawing.Point(43, 8);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(58, 22);
            this.LTitulo.TabIndex = 0;
            this.LTitulo.Text = "Titulo";
            // 
            // LDescripcion
            // 
            this.LDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LDescripcion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcion.ForeColor = System.Drawing.Color.White;
            this.LDescripcion.Location = new System.Drawing.Point(1, 1);
            this.LDescripcion.Name = "LDescripcion";
            this.LDescripcion.Size = new System.Drawing.Size(374, 65);
            this.LDescripcion.TabIndex = 1;
            this.LDescripcion.Text = "MSG";
            this.LDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBTipoMsg
            // 
            this.PBTipoMsg.BackColor = System.Drawing.Color.Transparent;
            this.PBTipoMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBTipoMsg.Location = new System.Drawing.Point(12, 6);
            this.PBTipoMsg.Name = "PBTipoMsg";
            this.PBTipoMsg.Size = new System.Drawing.Size(25, 25);
            this.PBTipoMsg.TabIndex = 12;
            this.PBTipoMsg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Campos incompletos:";
            // 
            // LcantidadCampos
            // 
            this.LcantidadCampos.AutoSize = true;
            this.LcantidadCampos.BackColor = System.Drawing.Color.Transparent;
            this.LcantidadCampos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LcantidadCampos.ForeColor = System.Drawing.Color.White;
            this.LcantidadCampos.Location = new System.Drawing.Point(153, 134);
            this.LcantidadCampos.Name = "LcantidadCampos";
            this.LcantidadCampos.Size = new System.Drawing.Size(14, 15);
            this.LcantidadCampos.TabIndex = 14;
            this.LcantidadCampos.Text = "1";
            // 
            // PContMsg
            // 
            this.PContMsg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PContMsg.BackgroundImage")));
            this.PContMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PContMsg.Controls.Add(this.LDescripcion);
            this.PContMsg.Location = new System.Drawing.Point(11, 48);
            this.PContMsg.Name = "PContMsg";
            this.PContMsg.Size = new System.Drawing.Size(376, 67);
            this.PContMsg.TabIndex = 17;
            // 
            // BRespuestaNO
            // 
            this.BRespuestaNO.BackColor = System.Drawing.Color.Black;
            this.BRespuestaNO.BackgroundColor = System.Drawing.Color.Black;
            this.BRespuestaNO.BorderColor = System.Drawing.Color.Lime;
            this.BRespuestaNO.BorderRadius = 10;
            this.BRespuestaNO.BorderSize = 1;
            this.BRespuestaNO.FlatAppearance.BorderSize = 0;
            this.BRespuestaNO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BRespuestaNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BRespuestaNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRespuestaNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRespuestaNO.ForeColor = System.Drawing.Color.White;
            this.BRespuestaNO.Location = new System.Drawing.Point(60, 124);
            this.BRespuestaNO.Name = "BRespuestaNO";
            this.BRespuestaNO.Size = new System.Drawing.Size(41, 34);
            this.BRespuestaNO.TabIndex = 16;
            this.BRespuestaNO.Text = "NO";
            this.BRespuestaNO.TextColor = System.Drawing.Color.White;
            this.BRespuestaNO.UseVisualStyleBackColor = false;
            this.BRespuestaNO.Click += new System.EventHandler(this.BRespuestaNO_Click);
            // 
            // BRespuestaSI
            // 
            this.BRespuestaSI.BackColor = System.Drawing.Color.Black;
            this.BRespuestaSI.BackgroundColor = System.Drawing.Color.Black;
            this.BRespuestaSI.BorderColor = System.Drawing.Color.Lime;
            this.BRespuestaSI.BorderRadius = 10;
            this.BRespuestaSI.BorderSize = 1;
            this.BRespuestaSI.FlatAppearance.BorderSize = 0;
            this.BRespuestaSI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BRespuestaSI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BRespuestaSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRespuestaSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRespuestaSI.ForeColor = System.Drawing.Color.White;
            this.BRespuestaSI.Location = new System.Drawing.Point(12, 124);
            this.BRespuestaSI.Name = "BRespuestaSI";
            this.BRespuestaSI.Size = new System.Drawing.Size(41, 34);
            this.BRespuestaSI.TabIndex = 15;
            this.BRespuestaSI.Text = "SI";
            this.BRespuestaSI.TextColor = System.Drawing.Color.White;
            this.BRespuestaSI.UseVisualStyleBackColor = false;
            this.BRespuestaSI.Click += new System.EventHandler(this.BRespuestaSI_Click);
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
            this.BSalir.Location = new System.Drawing.Point(368, 8);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(20, 20);
            this.BSalir.TabIndex = 11;
            this.BSalir.TextColor = System.Drawing.Color.White;
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BAceptar
            // 
            this.BAceptar.BackColor = System.Drawing.Color.Black;
            this.BAceptar.BackgroundColor = System.Drawing.Color.Black;
            this.BAceptar.BorderColor = System.Drawing.Color.Lime;
            this.BAceptar.BorderRadius = 13;
            this.BAceptar.BorderSize = 1;
            this.BAceptar.FlatAppearance.BorderSize = 0;
            this.BAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAceptar.ForeColor = System.Drawing.Color.White;
            this.BAceptar.Location = new System.Drawing.Point(291, 124);
            this.BAceptar.Name = "BAceptar";
            this.BAceptar.Size = new System.Drawing.Size(97, 34);
            this.BAceptar.TabIndex = 2;
            this.BAceptar.Text = "Aceptar";
            this.BAceptar.TextColor = System.Drawing.Color.White;
            this.BAceptar.UseVisualStyleBackColor = false;
            this.BAceptar.Click += new System.EventHandler(this.BAceptar_Click);
            // 
            // MsgPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.PContMsg);
            this.Controls.Add(this.BRespuestaNO);
            this.Controls.Add(this.BRespuestaSI);
            this.Controls.Add(this.LcantidadCampos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PBTipoMsg);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BAceptar);
            this.Controls.Add(this.LTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgPersonalizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsgPersonalizado";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PBTipoMsg)).EndInit();
            this.PContMsg.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Label LDescripcion;
        private RJButton BAceptar;
        private RJButton BSalir;
        private System.Windows.Forms.PictureBox PBTipoMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LcantidadCampos;
        private RJButton BRespuestaSI;
        private RJButton BRespuestaNO;
        private System.Windows.Forms.Panel PContMsg;
    }
}