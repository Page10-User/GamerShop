namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    partial class BotonesArticuloCr
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonesArticuloCr));
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.PBfotoPr = new System.Windows.Forms.PictureBox();
            this.LCantidadPr = new System.Windows.Forms.Label();
            this.TBCantidadPr = new System.Windows.Forms.TextBox();
            this.BEliminarPrCr = new Gamer_Shop2._0.RJButton();
            this.PFotoPr = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PBfotoPr)).BeginInit();
            this.PFotoPr.SuspendLayout();
            this.SuspendLayout();
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.White;
            this.LNombreProducto.Location = new System.Drawing.Point(11, 8);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(119, 30);
            this.LNombreProducto.TabIndex = 3;
            this.LNombreProducto.Text = "Nombre Producto\r\n\r\n";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.ForeColor = System.Drawing.Color.White;
            this.LCategoria.Location = new System.Drawing.Point(81, 38);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(61, 13);
            this.LCategoria.TabIndex = 8;
            this.LCategoria.Text = "Categoria";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LPrecio.Location = new System.Drawing.Point(80, 60);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(64, 13);
            this.LPrecio.TabIndex = 9;
            this.LPrecio.Text = "$ 250.000";
            // 
            // PBfotoPr
            // 
            this.PBfotoPr.BackColor = System.Drawing.Color.Transparent;
            this.PBfotoPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBfotoPr.BackgroundImage")));
            this.PBfotoPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBfotoPr.Location = new System.Drawing.Point(1, 1);
            this.PBfotoPr.Name = "PBfotoPr";
            this.PBfotoPr.Size = new System.Drawing.Size(61, 55);
            this.PBfotoPr.TabIndex = 11;
            this.PBfotoPr.TabStop = false;
            // 
            // LCantidadPr
            // 
            this.LCantidadPr.AutoSize = true;
            this.LCantidadPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadPr.ForeColor = System.Drawing.Color.White;
            this.LCantidadPr.Location = new System.Drawing.Point(81, 83);
            this.LCantidadPr.Name = "LCantidadPr";
            this.LCantidadPr.Size = new System.Drawing.Size(57, 13);
            this.LCantidadPr.TabIndex = 10;
            this.LCantidadPr.Text = "Cantidad";
            // 
            // TBCantidadPr
            // 
            this.TBCantidadPr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.TBCantidadPr.ForeColor = System.Drawing.Color.White;
            this.TBCantidadPr.Location = new System.Drawing.Point(144, 76);
            this.TBCantidadPr.Name = "TBCantidadPr";
            this.TBCantidadPr.Size = new System.Drawing.Size(33, 20);
            this.TBCantidadPr.TabIndex = 12;
            this.TBCantidadPr.TextChanged += new System.EventHandler(this.cantidadPr_TextChanged);
            this.TBCantidadPr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadPr_KeyPress);
            this.TBCantidadPr.Validating += new System.ComponentModel.CancelEventHandler(this.TBCantidadPr_Validating);
            // 
            // BEliminarPrCr
            // 
            this.BEliminarPrCr.BackColor = System.Drawing.Color.Transparent;
            this.BEliminarPrCr.BackgroundColor = System.Drawing.Color.Transparent;
            this.BEliminarPrCr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BEliminarPrCr.BackgroundImage")));
            this.BEliminarPrCr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BEliminarPrCr.BorderColor = System.Drawing.Color.Transparent;
            this.BEliminarPrCr.BorderRadius = 0;
            this.BEliminarPrCr.BorderSize = 0;
            this.BEliminarPrCr.FlatAppearance.BorderSize = 0;
            this.BEliminarPrCr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BEliminarPrCr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BEliminarPrCr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarPrCr.ForeColor = System.Drawing.Color.White;
            this.BEliminarPrCr.Location = new System.Drawing.Point(152, 8);
            this.BEliminarPrCr.Name = "BEliminarPrCr";
            this.BEliminarPrCr.Size = new System.Drawing.Size(25, 25);
            this.BEliminarPrCr.TabIndex = 13;
            this.BEliminarPrCr.TextColor = System.Drawing.Color.White;
            this.BEliminarPrCr.UseVisualStyleBackColor = false;
            this.BEliminarPrCr.Click += new System.EventHandler(this.BEliminarDeCarrito_Click);
            // 
            // PFotoPr
            // 
            this.PFotoPr.BackColor = System.Drawing.Color.Transparent;
            this.PFotoPr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PFotoPr.Controls.Add(this.PBfotoPr);
            this.PFotoPr.Location = new System.Drawing.Point(8, 38);
            this.PFotoPr.Name = "PFotoPr";
            this.PFotoPr.Size = new System.Drawing.Size(67, 61);
            this.PFotoPr.TabIndex = 14;
            // 
            // BotonesArticuloCr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.PFotoPr);
            this.Controls.Add(this.BEliminarPrCr);
            this.Controls.Add(this.TBCantidadPr);
            this.Controls.Add(this.LCantidadPr);
            this.Controls.Add(this.LPrecio);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LNombreProducto);
            this.Name = "BotonesArticuloCr";
            this.Size = new System.Drawing.Size(186, 111);
            this.Load += new System.EventHandler(this.BotonesArticuloCr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBfotoPr)).EndInit();
            this.PFotoPr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.PictureBox PBfotoPr;
        private System.Windows.Forms.Label LCantidadPr;
        private RJButton BEliminarPrCr;
        public System.Windows.Forms.TextBox TBCantidadPr;
        private System.Windows.Forms.Panel PFotoPr;
    }
}
