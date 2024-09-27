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
            this.DGListaPr = new System.Windows.Forms.DataGridView();
            this.CProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEstadoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCancelarCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPr)).BeginInit();
            this.SuspendLayout();
            // 
            // DGListaPr
            // 
            this.DGListaPr.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaPr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaPr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaPr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.DGListaPr.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaPr.GridColor = System.Drawing.Color.Black;
            this.DGListaPr.Location = new System.Drawing.Point(184, 82);
            this.DGListaPr.Name = "DGListaPr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaPr.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaPr.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaPr.Size = new System.Drawing.Size(433, 286);
            this.DGListaPr.TabIndex = 1;
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
            // 
            // ListaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGListaPr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCompra";
            this.Text = "ListaCompra";
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGListaPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEstadoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCancelarCompra;
    }
}