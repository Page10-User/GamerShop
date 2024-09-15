namespace Gamer_Shop2._0.Formularios.Comercio
{
    partial class BotonesArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotonesArticulo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBfotoPr = new System.Windows.Forms.PictureBox();
            this.LNombreProducto = new System.Windows.Forms.Label();
            this.LPrecio = new System.Windows.Forms.Label();
            this.PFotoPr = new System.Windows.Forms.Panel();
            this.BComprarAhora = new Gamer_Shop2._0.RJButton();
            this.BAgregarCarrito = new Gamer_Shop2._0.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBfotoPr)).BeginInit();
            this.PFotoPr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(3)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.BAgregarCarrito);
            this.panel1.Controls.Add(this.BComprarAhora);
            this.panel1.Controls.Add(this.PFotoPr);
            this.panel1.Controls.Add(this.LPrecio);
            this.panel1.Controls.Add(this.LNombreProducto);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 235);
            this.panel1.TabIndex = 0;
            // 
            // PBfotoPr
            // 
            this.PBfotoPr.BackColor = System.Drawing.Color.Transparent;
            this.PBfotoPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBfotoPr.BackgroundImage")));
            this.PBfotoPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBfotoPr.Location = new System.Drawing.Point(10, 3);
            this.PBfotoPr.Name = "PBfotoPr";
            this.PBfotoPr.Size = new System.Drawing.Size(109, 81);
            this.PBfotoPr.TabIndex = 1;
            this.PBfotoPr.TabStop = false;
            // 
            // LNombreProducto
            // 
            this.LNombreProducto.AutoSize = true;
            this.LNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreProducto.ForeColor = System.Drawing.Color.White;
            this.LNombreProducto.Location = new System.Drawing.Point(13, 93);
            this.LNombreProducto.Name = "LNombreProducto";
            this.LNombreProducto.Size = new System.Drawing.Size(128, 32);
            this.LNombreProducto.TabIndex = 2;
            this.LNombreProducto.Text = "Nombre Producto\r\n\r\n";
            // 
            // LPrecio
            // 
            this.LPrecio.AutoSize = true;
            this.LPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LPrecio.Location = new System.Drawing.Point(12, 125);
            this.LPrecio.Name = "LPrecio";
            this.LPrecio.Size = new System.Drawing.Size(71, 16);
            this.LPrecio.TabIndex = 3;
            this.LPrecio.Text = "$ 250.000";
            // 
            // PFotoPr
            // 
            this.PFotoPr.BackColor = System.Drawing.Color.White;
            this.PFotoPr.Controls.Add(this.PBfotoPr);
            this.PFotoPr.Location = new System.Drawing.Point(15, 3);
            this.PFotoPr.Name = "PFotoPr";
            this.PFotoPr.Size = new System.Drawing.Size(129, 87);
            this.PFotoPr.TabIndex = 4;
            // 
            // BComprarAhora
            // 
            this.BComprarAhora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BComprarAhora.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BComprarAhora.BorderColor = System.Drawing.Color.Red;
            this.BComprarAhora.BorderRadius = 12;
            this.BComprarAhora.BorderSize = 1;
            this.BComprarAhora.FlatAppearance.BorderSize = 0;
            this.BComprarAhora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BComprarAhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BComprarAhora.ForeColor = System.Drawing.Color.White;
            this.BComprarAhora.Location = new System.Drawing.Point(2, 155);
            this.BComprarAhora.Name = "BComprarAhora";
            this.BComprarAhora.Size = new System.Drawing.Size(154, 29);
            this.BComprarAhora.TabIndex = 5;
            this.BComprarAhora.Text = "Comprar Ahora";
            this.BComprarAhora.TextColor = System.Drawing.Color.White;
            this.BComprarAhora.UseVisualStyleBackColor = false;
            // 
            // BAgregarCarrito
            // 
            this.BAgregarCarrito.BackColor = System.Drawing.Color.Maroon;
            this.BAgregarCarrito.BackgroundColor = System.Drawing.Color.Maroon;
            this.BAgregarCarrito.BorderColor = System.Drawing.Color.Navy;
            this.BAgregarCarrito.BorderRadius = 12;
            this.BAgregarCarrito.BorderSize = 0;
            this.BAgregarCarrito.FlatAppearance.BorderSize = 0;
            this.BAgregarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCarrito.ForeColor = System.Drawing.Color.White;
            this.BAgregarCarrito.Location = new System.Drawing.Point(2, 190);
            this.BAgregarCarrito.Name = "BAgregarCarrito";
            this.BAgregarCarrito.Size = new System.Drawing.Size(154, 29);
            this.BAgregarCarrito.TabIndex = 6;
            this.BAgregarCarrito.Text = "Agregar al Carrito";
            this.BAgregarCarrito.TextColor = System.Drawing.Color.White;
            this.BAgregarCarrito.UseVisualStyleBackColor = false;
            // 
            // BotonesArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "BotonesArticulo";
            this.Size = new System.Drawing.Size(162, 239);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBfotoPr)).EndInit();
            this.PFotoPr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LPrecio;
        private System.Windows.Forms.Label LNombreProducto;
        private System.Windows.Forms.PictureBox PBfotoPr;
        private System.Windows.Forms.Panel PFotoPr;
        private RJButton BComprarAhora;
        private RJButton BAgregarCarrito;
    }
}
