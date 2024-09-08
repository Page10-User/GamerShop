namespace Gamer_Shop2._0.PanelMenu
{
    partial class Cosa
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
            this.BAbrirCosa = new System.Windows.Forms.Button();
            this.PCosa = new System.Windows.Forms.Panel();
            this.BCerrarCosa = new System.Windows.Forms.Button();
            this.PCosa.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAbrirCosa
            // 
            this.BAbrirCosa.BackColor = System.Drawing.Color.Black;
            this.BAbrirCosa.FlatAppearance.BorderSize = 0;
            this.BAbrirCosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAbrirCosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAbrirCosa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAbrirCosa.Location = new System.Drawing.Point(163, 30);
            this.BAbrirCosa.Name = "BAbrirCosa";
            this.BAbrirCosa.Size = new System.Drawing.Size(34, 27);
            this.BAbrirCosa.TabIndex = 0;
            this.BAbrirCosa.Text = "M";
            this.BAbrirCosa.UseVisualStyleBackColor = false;
            this.BAbrirCosa.Click += new System.EventHandler(this.BAbrirCosa_Click);
            // 
            // PCosa
            // 
            this.PCosa.BackColor = System.Drawing.Color.Black;
            this.PCosa.Controls.Add(this.BAbrirCosa);
            this.PCosa.Controls.Add(this.BCerrarCosa);
            this.PCosa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PCosa.Location = new System.Drawing.Point(0, 0);
            this.PCosa.Name = "PCosa";
            this.PCosa.Size = new System.Drawing.Size(200, 526);
            this.PCosa.TabIndex = 1;
            // 
            // BCerrarCosa
            // 
            this.BCerrarCosa.BackColor = System.Drawing.Color.Black;
            this.BCerrarCosa.FlatAppearance.BorderSize = 0;
            this.BCerrarCosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCerrarCosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrarCosa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCerrarCosa.Location = new System.Drawing.Point(153, 6);
            this.BCerrarCosa.Name = "BCerrarCosa";
            this.BCerrarCosa.Size = new System.Drawing.Size(34, 27);
            this.BCerrarCosa.TabIndex = 2;
            this.BCerrarCosa.Text = "X";
            this.BCerrarCosa.UseVisualStyleBackColor = false;
            this.BCerrarCosa.Visible = false;
            this.BCerrarCosa.Click += new System.EventHandler(this.BCerrarCosa_Click);
            // 
            // Cosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PCosa);
            this.Name = "Cosa";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(200, 526);
            this.PCosa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAbrirCosa;
        private System.Windows.Forms.Panel PCosa;
        private System.Windows.Forms.Button BCerrarCosa;
    }
}
