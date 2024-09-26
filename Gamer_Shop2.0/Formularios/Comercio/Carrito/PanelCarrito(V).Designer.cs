namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    partial class PanelCarrito_V_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCarrito_V_));
            this.LCarrito = new System.Windows.Forms.Label();
            this.PCarritoVacio = new System.Windows.Forms.Panel();
            this.BExitCarrito = new Gamer_Shop2._0.RJButton();
            this.LMsjContenidoCarritoVacio = new System.Windows.Forms.Label();
            this.PCarritoVacio.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCarrito
            // 
            this.LCarrito.AutoSize = true;
            this.LCarrito.BackColor = System.Drawing.Color.White;
            this.LCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCarrito.ForeColor = System.Drawing.Color.Black;
            this.LCarrito.Location = new System.Drawing.Point(12, 9);
            this.LCarrito.Name = "LCarrito";
            this.LCarrito.Size = new System.Drawing.Size(71, 24);
            this.LCarrito.TabIndex = 3;
            this.LCarrito.Text = "Carrito";
            // 
            // PCarritoVacio
            // 
            this.PCarritoVacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.PCarritoVacio.Controls.Add(this.LMsjContenidoCarritoVacio);
            this.PCarritoVacio.Location = new System.Drawing.Point(8, 58);
            this.PCarritoVacio.Name = "PCarritoVacio";
            this.PCarritoVacio.Size = new System.Drawing.Size(178, 33);
            this.PCarritoVacio.TabIndex = 5;
            // 
            // BExitCarrito
            // 
            this.BExitCarrito.BackColor = System.Drawing.Color.Transparent;
            this.BExitCarrito.BackgroundColor = System.Drawing.Color.Transparent;
            this.BExitCarrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BExitCarrito.BackgroundImage")));
            this.BExitCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BExitCarrito.BorderColor = System.Drawing.Color.Transparent;
            this.BExitCarrito.BorderRadius = 0;
            this.BExitCarrito.BorderSize = 0;
            this.BExitCarrito.FlatAppearance.BorderSize = 0;
            this.BExitCarrito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BExitCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BExitCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExitCarrito.ForeColor = System.Drawing.Color.White;
            this.BExitCarrito.Location = new System.Drawing.Point(157, 8);
            this.BExitCarrito.Name = "BExitCarrito";
            this.BExitCarrito.Size = new System.Drawing.Size(25, 25);
            this.BExitCarrito.TabIndex = 4;
            this.BExitCarrito.TextColor = System.Drawing.Color.White;
            this.BExitCarrito.UseVisualStyleBackColor = false;
            this.BExitCarrito.Click += new System.EventHandler(this.BExitCarrito_Click);
            // 
            // LMsjContenidoCarritoVacio
            // 
            this.LMsjContenidoCarritoVacio.AutoSize = true;
            this.LMsjContenidoCarritoVacio.BackColor = System.Drawing.Color.Transparent;
            this.LMsjContenidoCarritoVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMsjContenidoCarritoVacio.ForeColor = System.Drawing.Color.White;
            this.LMsjContenidoCarritoVacio.Location = new System.Drawing.Point(3, 9);
            this.LMsjContenidoCarritoVacio.Name = "LMsjContenidoCarritoVacio";
            this.LMsjContenidoCarritoVacio.Size = new System.Drawing.Size(172, 13);
            this.LMsjContenidoCarritoVacio.TabIndex = 6;
            this.LMsjContenidoCarritoVacio.Text = "No se cargó ningun producto";
            this.LMsjContenidoCarritoVacio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelCarrito_V_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(194, 430);
            this.Controls.Add(this.PCarritoVacio);
            this.Controls.Add(this.BExitCarrito);
            this.Controls.Add(this.LCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelCarrito_V_";
            this.Text = "PanelCarrito_V_";
            this.PCarritoVacio.ResumeLayout(false);
            this.PCarritoVacio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton BExitCarrito;
        private System.Windows.Forms.Label LCarrito;
        private System.Windows.Forms.Panel PCarritoVacio;
        private System.Windows.Forms.Label LMsjContenidoCarritoVacio;
    }
}