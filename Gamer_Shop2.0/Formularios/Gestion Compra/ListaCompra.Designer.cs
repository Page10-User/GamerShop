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
            this.BShowRegistrarCompra = new Gamer_Shop2._0.RJButton();
            this.BDescargar = new Gamer_Shop2._0.RJButton();
            this.rjButton1 = new Gamer_Shop2._0.RJButton();
            this.CProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstadoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCancelarCompra = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.DGListaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CProveedor,
            this.CFechaCompra,
            this.CProducto,
            this.CPrecioUnitario,
            this.CPrecioTotal,
            this.CEstadoCompra,
            this.CCancelarCompra});
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
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjButton1.BorderColor = System.Drawing.Color.Lime;
            this.rjButton1.BorderRadius = 12;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(383, 80);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(84, 31);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.Text = "Buscar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // CProveedor
            // 
            this.CProveedor.HeaderText = "Nombre Proveedor";
            this.CProveedor.Name = "CProveedor";
            // 
            // CFechaCompra
            // 
            this.CFechaCompra.HeaderText = "Fecha Compra";
            this.CFechaCompra.Name = "CFechaCompra";
            // 
            // CProducto
            // 
            this.CProducto.HeaderText = "Producto/s";
            this.CProducto.Name = "CProducto";
            // 
            // CPrecioUnitario
            // 
            this.CPrecioUnitario.HeaderText = "Precio Unitario/s";
            this.CPrecioUnitario.Name = "CPrecioUnitario";
            // 
            // CPrecioTotal
            // 
            this.CPrecioTotal.HeaderText = "Total";
            this.CPrecioTotal.Name = "CPrecioTotal";
            // 
            // CEstadoCompra
            // 
            this.CEstadoCompra.HeaderText = "Estado Compra";
            this.CEstadoCompra.Name = "CEstadoCompra";
            // 
            // CCancelarCompra
            // 
            this.CCancelarCompra.HeaderText = "Cancelar";
            this.CCancelarCompra.Name = "CCancelarCompra";
            this.CCancelarCompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CCancelarCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BShowLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BShowRegistrarCompra);
            this.Controls.Add(this.BDescargar);
            this.Controls.Add(this.PContListaCompra);
            this.Controls.Add(this.LTituloListaCompra);
            this.Controls.Add(this.PBImgListaCom);
            this.Controls.Add(this.rjButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCompra";
            this.Text = "ListaCompra";
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
        private RJButton rjButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstadoCompra;
        private System.Windows.Forms.DataGridViewButtonColumn CCancelarCompra;
    }
}