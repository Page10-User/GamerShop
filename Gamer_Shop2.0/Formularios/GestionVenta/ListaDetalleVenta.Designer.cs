namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    partial class ListaDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDetalleCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaVn = new System.Windows.Forms.Panel();
            this.DGListaDVn = new System.Windows.Forms.DataGridView();
            this.LTituloListaUs = new System.Windows.Forms.Label();
            this.PBImgListaUs = new System.Windows.Forms.PictureBox();
            this.BDescargarListVn = new Gamer_Shop2._0.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PContListaVn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaDVn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaUs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(553, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Descargar";
            // 
            // PContListaVn
            // 
            this.PContListaVn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaVn.Controls.Add(this.DGListaDVn);
            this.PContListaVn.Location = new System.Drawing.Point(65, 127);
            this.PContListaVn.Name = "PContListaVn";
            this.PContListaVn.Size = new System.Drawing.Size(435, 288);
            this.PContListaVn.TabIndex = 31;
            this.PContListaVn.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaVn_Paint);
            // 
            // DGListaDVn
            // 
            this.DGListaDVn.AllowUserToAddRows = false;
            this.DGListaDVn.AllowUserToDeleteRows = false;
            this.DGListaDVn.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaDVn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaDVn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaDVn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaDVn.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaDVn.GridColor = System.Drawing.Color.Black;
            this.DGListaDVn.Location = new System.Drawing.Point(1, 1);
            this.DGListaDVn.Name = "DGListaDVn";
            this.DGListaDVn.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaDVn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaDVn.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaDVn.Size = new System.Drawing.Size(433, 286);
            this.DGListaDVn.TabIndex = 28;
            // 
            // LTituloListaUs
            // 
            this.LTituloListaUs.AutoSize = true;
            this.LTituloListaUs.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaUs.Location = new System.Drawing.Point(209, 19);
            this.LTituloListaUs.Name = "LTituloListaUs";
            this.LTituloListaUs.Size = new System.Drawing.Size(304, 42);
            this.LTituloListaUs.TabIndex = 30;
            this.LTituloListaUs.Text = "Detalle de venta";
            // 
            // PBImgListaUs
            // 
            this.PBImgListaUs.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaUs.BackgroundImage")));
            this.PBImgListaUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaUs.Location = new System.Drawing.Point(163, 20);
            this.PBImgListaUs.Name = "PBImgListaUs";
            this.PBImgListaUs.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaUs.TabIndex = 29;
            this.PBImgListaUs.TabStop = false;
            // 
            // BDescargarListVn
            // 
            this.BDescargarListVn.BackColor = System.Drawing.Color.Black;
            this.BDescargarListVn.BackgroundColor = System.Drawing.Color.Black;
            this.BDescargarListVn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDescargarListVn.BackgroundImage")));
            this.BDescargarListVn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BDescargarListVn.BorderColor = System.Drawing.Color.Lime;
            this.BDescargarListVn.BorderRadius = 20;
            this.BDescargarListVn.BorderSize = 2;
            this.BDescargarListVn.FlatAppearance.BorderSize = 0;
            this.BDescargarListVn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargarListVn.ForeColor = System.Drawing.Color.White;
            this.BDescargarListVn.Location = new System.Drawing.Point(550, 220);
            this.BDescargarListVn.Name = "BDescargarListVn";
            this.BDescargarListVn.Size = new System.Drawing.Size(84, 76);
            this.BDescargarListVn.TabIndex = 32;
            this.BDescargarListVn.TextColor = System.Drawing.Color.White;
            this.BDescargarListVn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(225, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID Venta Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(134, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cliente";
            // 
            // ListaDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BDescargarListVn);
            this.Controls.Add(this.PContListaVn);
            this.Controls.Add(this.LTituloListaUs);
            this.Controls.Add(this.PBImgListaUs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaDetalleVenta";
            this.Text = "ListaVenta";
            this.Load += new System.EventHandler(this.ListaVenta_Load);
            this.PContListaVn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaDVn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private RJButton BDescargarListVn;
        private System.Windows.Forms.Panel PContListaVn;
        private System.Windows.Forms.DataGridView DGListaDVn;
        private System.Windows.Forms.Label LTituloListaUs;
        private System.Windows.Forms.PictureBox PBImgListaUs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}