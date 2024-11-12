namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    partial class ListaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCompra));
            this.DGListaCompra = new System.Windows.Forms.DataGridView();
            this.BShowLista = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaCompra = new System.Windows.Forms.Panel();
            this.LTituloListaCompra = new System.Windows.Forms.Label();
            this.PBImgListaCom = new System.Windows.Forms.PictureBox();
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.BShowRegistrarCompra = new Gamer_Shop2._0.RJButton();
            this.BDescargar = new Gamer_Shop2._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCompra)).BeginInit();
            this.PContListaCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaCom)).BeginInit();
            this.SuspendLayout();
            // 
            // DGListaCompra
            // 
            this.DGListaCompra.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaCompra.GridColor = System.Drawing.Color.Black;
            this.DGListaCompra.Location = new System.Drawing.Point(1, 1);
            this.DGListaCompra.Name = "DGListaCompra";
            this.DGListaCompra.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaCompra.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaCompra.Size = new System.Drawing.Size(435, 288);
            this.DGListaCompra.TabIndex = 1;
            this.DGListaCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaCompra_CellClick);
            // 
            // BShowLista
            // 
            this.BShowLista.AutoSize = true;
            this.BShowLista.BackColor = System.Drawing.Color.Transparent;
            this.BShowLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BShowLista.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BShowLista.Location = new System.Drawing.Point(540, 343);
            this.BShowLista.Name = "BShowLista";
            this.BShowLista.Size = new System.Drawing.Size(74, 18);
            this.BShowLista.TabIndex = 21;
            this.BShowLista.Text = "Comprar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(538, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descargar";
            // 
            // PContListaCompra
            // 
            this.PContListaCompra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaCompra.Controls.Add(this.DGListaCompra);
            this.PContListaCompra.Location = new System.Drawing.Point(68, 117);
            this.PContListaCompra.Name = "PContListaCompra";
            this.PContListaCompra.Size = new System.Drawing.Size(437, 290);
            this.PContListaCompra.TabIndex = 17;
            this.PContListaCompra.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaCompra_Paint);
            // 
            // LTituloListaCompra
            // 
            this.LTituloListaCompra.AutoSize = true;
            this.LTituloListaCompra.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaCompra.Location = new System.Drawing.Point(159, 34);
            this.LTituloListaCompra.Name = "LTituloListaCompra";
            this.LTituloListaCompra.Size = new System.Drawing.Size(326, 42);
            this.LTituloListaCompra.TabIndex = 16;
            this.LTituloListaCompra.Text = "Lista de Compras";
            // 
            // PBImgListaCom
            // 
            this.PBImgListaCom.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaCom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaCom.BackgroundImage")));
            this.PBImgListaCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaCom.Location = new System.Drawing.Point(106, 39);
            this.PBImgListaCom.Name = "PBImgListaCom";
            this.PBImgListaCom.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaCom.TabIndex = 15;
            this.PBImgListaCom.TabStop = false;
            // 
            // BBuscador
            // 
            this.BBuscador.BackColor = System.Drawing.Color.Transparent;
            this.BBuscador.BackgroundColor = System.Drawing.Color.Transparent;
            this.BBuscador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBuscador.BackgroundImage")));
            this.BBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BBuscador.BorderColor = System.Drawing.Color.Transparent;
            this.BBuscador.BorderRadius = 0;
            this.BBuscador.BorderSize = 0;
            this.BBuscador.FlatAppearance.BorderSize = 0;
            this.BBuscador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BBuscador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscador.ForeColor = System.Drawing.Color.White;
            this.BBuscador.Location = new System.Drawing.Point(323, 81);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 22;
            this.BBuscador.TextColor = System.Drawing.Color.White;
            this.BBuscador.UseVisualStyleBackColor = false;
            // 
            // TBFiltro
            // 
            this.TBFiltro.BackColor = System.Drawing.Color.Black;
            this.TBFiltro.BorderColor = System.Drawing.Color.Lime;
            this.TBFiltro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TBFiltro.BorderRadius = 2;
            this.TBFiltro.BorderSize = 1;
            this.TBFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFiltro.ForeColor = System.Drawing.Color.White;
            this.TBFiltro.Location = new System.Drawing.Point(356, 79);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 23;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
            // 
            // BShowRegistrarCompra
            // 
            this.BShowRegistrarCompra.BackColor = System.Drawing.Color.Black;
            this.BShowRegistrarCompra.BackgroundColor = System.Drawing.Color.Black;
            this.BShowRegistrarCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BShowRegistrarCompra.BackgroundImage")));
            this.BShowRegistrarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BShowRegistrarCompra.BorderColor = System.Drawing.Color.Lime;
            this.BShowRegistrarCompra.BorderRadius = 20;
            this.BShowRegistrarCompra.BorderSize = 1;
            this.BShowRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.BShowRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BShowRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.BShowRegistrarCompra.Location = new System.Drawing.Point(534, 264);
            this.BShowRegistrarCompra.Name = "BShowRegistrarCompra";
            this.BShowRegistrarCompra.Size = new System.Drawing.Size(84, 76);
            this.BShowRegistrarCompra.TabIndex = 19;
            this.BShowRegistrarCompra.TextColor = System.Drawing.Color.White;
            this.BShowRegistrarCompra.UseVisualStyleBackColor = false;
            this.BShowRegistrarCompra.Click += new System.EventHandler(this.BShowRegistrarCompra_Click);
            // 
            // BDescargar
            // 
            this.BDescargar.BackColor = System.Drawing.Color.Black;
            this.BDescargar.BackgroundColor = System.Drawing.Color.Black;
            this.BDescargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDescargar.BackgroundImage")));
            this.BDescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BDescargar.BorderColor = System.Drawing.Color.Lime;
            this.BDescargar.BorderRadius = 20;
            this.BDescargar.BorderSize = 1;
            this.BDescargar.FlatAppearance.BorderSize = 0;
            this.BDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargar.ForeColor = System.Drawing.Color.White;
            this.BDescargar.Location = new System.Drawing.Point(534, 140);
            this.BDescargar.Name = "BDescargar";
            this.BDescargar.Size = new System.Drawing.Size(84, 76);
            this.BDescargar.TabIndex = 18;
            this.BDescargar.TextColor = System.Drawing.Color.White;
            this.BDescargar.UseVisualStyleBackColor = false;
            // 
            // ListaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BBuscador);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.BShowLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BShowRegistrarCompra);
            this.Controls.Add(this.BDescargar);
            this.Controls.Add(this.PContListaCompra);
            this.Controls.Add(this.LTituloListaCompra);
            this.Controls.Add(this.PBImgListaCom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCompra";
            this.Text = "ListaCompra";
            this.Load += new System.EventHandler(this.ListaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCompra)).EndInit();
            this.PContListaCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaCom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGListaCompra;
        private System.Windows.Forms.Label BShowLista;
        private System.Windows.Forms.Label label1;
        private RJButton BShowRegistrarCompra;
        private RJButton BDescargar;
        private System.Windows.Forms.Panel PContListaCompra;
        private System.Windows.Forms.Label LTituloListaCompra;
        private System.Windows.Forms.PictureBox PBImgListaCom;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
    }
}