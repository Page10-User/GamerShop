namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    partial class BotonArticuloVn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonArticuloVn));
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.TBCantidadPr = new System.Windows.Forms.TextBox();
            this.LCantidadPr = new System.Windows.Forms.Label();
            this.BEliminarPrVn = new Gamer_Shop2._0.RJButton();
            this.SuspendLayout();
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.White;
            this.LNombreProducto.Location = new System.Drawing.Point(5, 10);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(119, 30);
            this.LNombreProducto.TabIndex = 15;
            this.LNombreProducto.Text = "Nombre Producto\r\n\r\n";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.ForeColor = System.Drawing.Color.White;
            this.LCategoria.Location = new System.Drawing.Point(191, 12);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(61, 13);
            this.LCategoria.TabIndex = 16;
            this.LCategoria.Text = "Categoria";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LPrecio.Location = new System.Drawing.Point(5, 27);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(64, 13);
            this.LPrecio.TabIndex = 17;
            this.LPrecio.Text = "$ 250,000";
            // 
            // TBCantidadPr
            // 
            this.TBCantidadPr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.TBCantidadPr.ForeColor = System.Drawing.Color.White;
            this.TBCantidadPr.Location = new System.Drawing.Point(379, 8);
            this.TBCantidadPr.Name = "TBCantidadPr";
            this.TBCantidadPr.Size = new System.Drawing.Size(33, 20);
            this.TBCantidadPr.TabIndex = 19;
            this.TBCantidadPr.TextChanged += new System.EventHandler(this.cantidadPr_TextChanged);
            this.TBCantidadPr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadPr_KeyPress);
            this.TBCantidadPr.Validated += new System.EventHandler(this.cantidadPr_TextChanged);
            // 
            // LCantidadPr
            // 
            this.LCantidadPr.AutoSize = true;
            this.LCantidadPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadPr.ForeColor = System.Drawing.Color.White;
            this.LCantidadPr.Location = new System.Drawing.Point(316, 12);
            this.LCantidadPr.Name = "LCantidadPr";
            this.LCantidadPr.Size = new System.Drawing.Size(57, 13);
            this.LCantidadPr.TabIndex = 18;
            this.LCantidadPr.Text = "Cantidad";
            // 
            // BEliminarPrVn
            // 
            this.BEliminarPrVn.BackColor = System.Drawing.Color.Transparent;
            this.BEliminarPrVn.BackgroundColor = System.Drawing.Color.Transparent;
            this.BEliminarPrVn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BEliminarPrVn.BackgroundImage")));
            this.BEliminarPrVn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BEliminarPrVn.BorderColor = System.Drawing.Color.Transparent;
            this.BEliminarPrVn.BorderRadius = 0;
            this.BEliminarPrVn.BorderSize = 0;
            this.BEliminarPrVn.FlatAppearance.BorderSize = 0;
            this.BEliminarPrVn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BEliminarPrVn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BEliminarPrVn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEliminarPrVn.ForeColor = System.Drawing.Color.White;
            this.BEliminarPrVn.Location = new System.Drawing.Point(418, 6);
            this.BEliminarPrVn.Name = "BEliminarPrVn";
            this.BEliminarPrVn.Size = new System.Drawing.Size(25, 25);
            this.BEliminarPrVn.TabIndex = 14;
            this.BEliminarPrVn.TextColor = System.Drawing.Color.White;
            this.BEliminarPrVn.UseVisualStyleBackColor = false;
            this.BEliminarPrVn.Click += new System.EventHandler(this.BEliminarPrVn_Click);
            // 
            // BotonArticuloVn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.TBCantidadPr);
            this.Controls.Add(this.LCantidadPr);
            this.Controls.Add(this.LPrecio);
            this.Controls.Add(this.LCategoria);
            this.Controls.Add(this.LNombreProducto);
            this.Controls.Add(this.BEliminarPrVn);
            this.Name = "BotonArticuloVn";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(447, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton BEliminarPrVn;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LCantidadPr;
        public System.Windows.Forms.TextBox TBCantidadPr;
    }
}
