namespace Gamer_Shop2._0.Formularios.GestionProveedor
{
    partial class ListaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProveedor));
            this.BRegistrarProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaProveedor = new System.Windows.Forms.Panel();
            this.DGListaProveedor = new System.Windows.Forms.DataGridView();
            this.LTituloListaProveedor = new System.Windows.Forms.Label();
            this.PBImgListaProveedor = new System.Windows.Forms.PictureBox();
            this.BShowRegistrarProveedor = new Gamer_Shop2._0.RJButton();
            this.BDescargar = new Gamer_Shop2._0.RJButton();
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.CModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PContListaProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // BRegistrarProveedor
            // 
            this.BRegistrarProveedor.AutoSize = true;
            this.BRegistrarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BRegistrarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BRegistrarProveedor.Location = new System.Drawing.Point(531, 340);
            this.BRegistrarProveedor.Name = "BRegistrarProveedor";
            this.BRegistrarProveedor.Size = new System.Drawing.Size(77, 18);
            this.BRegistrarProveedor.TabIndex = 29;
            this.BRegistrarProveedor.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(533, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descargar";
            // 
            // PContListaProveedor
            // 
            this.PContListaProveedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaProveedor.Controls.Add(this.DGListaProveedor);
            this.PContListaProveedor.Location = new System.Drawing.Point(63, 114);
            this.PContListaProveedor.Name = "PContListaProveedor";
            this.PContListaProveedor.Size = new System.Drawing.Size(437, 290);
            this.PContListaProveedor.TabIndex = 25;
            this.PContListaProveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaProveedor_Paint);
            // 
            // DGListaProveedor
            // 
            this.DGListaProveedor.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CModificar,
            this.CEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaProveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaProveedor.GridColor = System.Drawing.Color.Black;
            this.DGListaProveedor.Location = new System.Drawing.Point(1, 1);
            this.DGListaProveedor.Name = "DGListaProveedor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaProveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaProveedor.Size = new System.Drawing.Size(435, 288);
            this.DGListaProveedor.TabIndex = 1;
            this.DGListaProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaProveedor_CellClick);
            // 
            // LTituloListaProveedor
            // 
            this.LTituloListaProveedor.AutoSize = true;
            this.LTituloListaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaProveedor.Location = new System.Drawing.Point(147, 32);
            this.LTituloListaProveedor.Name = "LTituloListaProveedor";
            this.LTituloListaProveedor.Size = new System.Drawing.Size(392, 42);
            this.LTituloListaProveedor.TabIndex = 24;
            this.LTituloListaProveedor.Text = "Lista de Proveedores";
            // 
            // PBImgListaProveedor
            // 
            this.PBImgListaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaProveedor.BackgroundImage")));
            this.PBImgListaProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaProveedor.Location = new System.Drawing.Point(104, 35);
            this.PBImgListaProveedor.Name = "PBImgListaProveedor";
            this.PBImgListaProveedor.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaProveedor.TabIndex = 23;
            this.PBImgListaProveedor.TabStop = false;
            // 
            // BShowRegistrarProveedor
            // 
            this.BShowRegistrarProveedor.BackColor = System.Drawing.Color.Black;
            this.BShowRegistrarProveedor.BackgroundColor = System.Drawing.Color.Black;
            this.BShowRegistrarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BShowRegistrarProveedor.BackgroundImage")));
            this.BShowRegistrarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BShowRegistrarProveedor.BorderColor = System.Drawing.Color.Lime;
            this.BShowRegistrarProveedor.BorderRadius = 20;
            this.BShowRegistrarProveedor.BorderSize = 1;
            this.BShowRegistrarProveedor.FlatAppearance.BorderSize = 0;
            this.BShowRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BShowRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.BShowRegistrarProveedor.Location = new System.Drawing.Point(529, 261);
            this.BShowRegistrarProveedor.Name = "BShowRegistrarProveedor";
            this.BShowRegistrarProveedor.Size = new System.Drawing.Size(84, 76);
            this.BShowRegistrarProveedor.TabIndex = 27;
            this.BShowRegistrarProveedor.TextColor = System.Drawing.Color.White;
            this.BShowRegistrarProveedor.UseVisualStyleBackColor = false;
            this.BShowRegistrarProveedor.Click += new System.EventHandler(this.BShowRegistrarProveedor_Click);
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
            this.BDescargar.Location = new System.Drawing.Point(529, 137);
            this.BDescargar.Name = "BDescargar";
            this.BDescargar.Size = new System.Drawing.Size(84, 76);
            this.BDescargar.TabIndex = 26;
            this.BDescargar.TextColor = System.Drawing.Color.White;
            this.BDescargar.UseVisualStyleBackColor = false;
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
            this.BBuscador.Location = new System.Drawing.Point(319, 79);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 30;
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
            this.TBFiltro.Location = new System.Drawing.Point(352, 77);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 31;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
            // 
            // CModificar
            // 
            this.CModificar.HeaderText = "Modificar";
            this.CModificar.Name = "CModificar";
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            // 
            // ListaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BBuscador);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.BRegistrarProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BShowRegistrarProveedor);
            this.Controls.Add(this.BDescargar);
            this.Controls.Add(this.PContListaProveedor);
            this.Controls.Add(this.LTituloListaProveedor);
            this.Controls.Add(this.PBImgListaProveedor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProveedor";
            this.Text = "ListaProveedor";
            this.Load += new System.EventHandler(this.ListaProveedor_Load);
            this.PContListaProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BRegistrarProveedor;
        private System.Windows.Forms.Label label1;
        private RJButton BShowRegistrarProveedor;
        private RJButton BDescargar;
        private System.Windows.Forms.Panel PContListaProveedor;
        private System.Windows.Forms.DataGridView DGListaProveedor;
        private System.Windows.Forms.Label LTituloListaProveedor;
        private System.Windows.Forms.PictureBox PBImgListaProveedor;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
        private System.Windows.Forms.DataGridViewButtonColumn CModificar;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
    }
}