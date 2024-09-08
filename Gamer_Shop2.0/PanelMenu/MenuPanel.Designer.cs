namespace Gamer_Shop2._0.PanelMenu
{
    partial class MenuPanel
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
            this.components = new System.ComponentModel.Container();
            this.PMenu = new System.Windows.Forms.Panel();
            this.BExitMenu = new System.Windows.Forms.Button();
            this.BMenu = new Gamer_Shop2._0.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.Black;
            this.PMenu.Controls.Add(this.BExitMenu);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(200, 526);
            this.PMenu.TabIndex = 13;
            // 
            // BExitMenu
            // 
            this.BExitMenu.BackColor = System.Drawing.Color.Black;
            this.BExitMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BExitMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.BExitMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BExitMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BExitMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BExitMenu.Location = new System.Drawing.Point(165, 3);
            this.BExitMenu.Name = "BExitMenu";
            this.BExitMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BExitMenu.Size = new System.Drawing.Size(32, 29);
            this.BExitMenu.TabIndex = 14;
            this.BExitMenu.Text = "X";
            this.BExitMenu.UseVisualStyleBackColor = false;
            this.BExitMenu.Visible = false;
            this.BExitMenu.Click += new System.EventHandler(this.BExitMenu_Click);
            // 
            // BMenu
            // 
            this.BMenu.BackColor = System.Drawing.Color.Black;
            this.BMenu.BackgroundColor = System.Drawing.Color.Black;
            this.BMenu.BorderColor = System.Drawing.Color.Black;
            this.BMenu.BorderRadius = 6;
            this.BMenu.BorderSize = 1;
            this.BMenu.FlatAppearance.BorderSize = 0;
            this.BMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMenu.ForeColor = System.Drawing.Color.White;
            this.BMenu.Location = new System.Drawing.Point(196, 26);
            this.BMenu.Name = "BMenu";
            this.BMenu.Size = new System.Drawing.Size(31, 29);
            this.BMenu.TabIndex = 14;
            this.BMenu.Text = "M";
            this.BMenu.TextColor = System.Drawing.Color.White;
            this.BMenu.UseVisualStyleBackColor = false;
            this.BMenu.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.BMenu);
            this.Name = "MenuPanel";
            this.Size = new System.Drawing.Size(609, 526);
            this.PMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private RJButton BMenu;
        private System.Windows.Forms.Button BExitMenu;
        private System.Windows.Forms.Timer timer1;
    }
}
