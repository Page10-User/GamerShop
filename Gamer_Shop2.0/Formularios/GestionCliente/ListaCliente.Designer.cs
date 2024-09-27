namespace Gamer_Shop2._0.Formularios.GestionCliente
{
    partial class ListaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaCl = new System.Windows.Forms.Panel();
            this.DGListaCliente = new System.Windows.Forms.DataGridView();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificarCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LTituloListaPr = new System.Windows.Forms.Label();
            this.PBImgListaPr = new System.Windows.Forms.PictureBox();
            this.BDescargarCliente = new Gamer_Shop2._0.RJButton();
            this.rjButton1 = new Gamer_Shop2._0.RJButton();
            this.PContListaCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(552, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descargar";
            // 
            // PContListaCl
            // 
            this.PContListaCl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaCl.Controls.Add(this.DGListaCliente);
            this.PContListaCl.Location = new System.Drawing.Point(65, 108);
            this.PContListaCl.Name = "PContListaCl";
            this.PContListaCl.Size = new System.Drawing.Size(437, 290);
            this.PContListaCl.TabIndex = 17;
            // 
            // DGListaCliente
            // 
            this.DGListaCliente.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DGListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CApellido,
            this.CDni,
            this.CTelefono,
            this.CCorreoElectronico,
            this.CModificarCl});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaCliente.DefaultCellStyle = dataGridViewCellStyle18;
            this.DGListaCliente.GridColor = System.Drawing.Color.Black;
            this.DGListaCliente.Location = new System.Drawing.Point(2, 2);
            this.DGListaCliente.Name = "DGListaCliente";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaCliente.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DGListaCliente.Size = new System.Drawing.Size(433, 286);
            this.DGListaCliente.TabIndex = 0;
            // 
            // CNombre
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.CNombre.DefaultCellStyle = dataGridViewCellStyle17;
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CApellido
            // 
            this.CApellido.HeaderText = "Apellido";
            this.CApellido.Name = "CApellido";
            // 
            // CDni
            // 
            this.CDni.HeaderText = "Dni";
            this.CDni.Name = "CDni";
            // 
            // CTelefono
            // 
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.Name = "CTelefono";
            // 
            // CCorreoElectronico
            // 
            this.CCorreoElectronico.HeaderText = "CorreoElectronico";
            this.CCorreoElectronico.Name = "CCorreoElectronico";
            // 
            // CModificarCl
            // 
            this.CModificarCl.HeaderText = "Modificar";
            this.CModificarCl.Name = "CModificarCl";
            // 
            // LTituloListaPr
            // 
            this.LTituloListaPr.AutoSize = true;
            this.LTituloListaPr.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaPr.Location = new System.Drawing.Point(191, 29);
            this.LTituloListaPr.Name = "LTituloListaPr";
            this.LTituloListaPr.Size = new System.Drawing.Size(311, 42);
            this.LTituloListaPr.TabIndex = 16;
            this.LTituloListaPr.Text = "Lista de Clientes";
            // 
            // PBImgListaPr
            // 
            this.PBImgListaPr.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaPr.BackgroundImage")));
            this.PBImgListaPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaPr.Location = new System.Drawing.Point(110, 35);
            this.PBImgListaPr.Name = "PBImgListaPr";
            this.PBImgListaPr.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaPr.TabIndex = 15;
            this.PBImgListaPr.TabStop = false;
            // 
            // BDescargarCliente
            // 
            this.BDescargarCliente.BackColor = System.Drawing.Color.Black;
            this.BDescargarCliente.BackgroundColor = System.Drawing.Color.Black;
            this.BDescargarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDescargarCliente.BackgroundImage")));
            this.BDescargarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BDescargarCliente.BorderColor = System.Drawing.Color.Lime;
            this.BDescargarCliente.BorderRadius = 20;
            this.BDescargarCliente.BorderSize = 1;
            this.BDescargarCliente.FlatAppearance.BorderSize = 0;
            this.BDescargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargarCliente.ForeColor = System.Drawing.Color.White;
            this.BDescargarCliente.Location = new System.Drawing.Point(548, 110);
            this.BDescargarCliente.Name = "BDescargarCliente";
            this.BDescargarCliente.Size = new System.Drawing.Size(84, 76);
            this.BDescargarCliente.TabIndex = 18;
            this.BDescargarCliente.TextColor = System.Drawing.Color.White;
            this.BDescargarCliente.UseVisualStyleBackColor = false;
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
            this.rjButton1.Location = new System.Drawing.Point(387, 76);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(84, 31);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.Text = "Buscar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BDescargarCliente);
            this.Controls.Add(this.PContListaCl);
            this.Controls.Add(this.LTituloListaPr);
            this.Controls.Add(this.PBImgListaPr);
            this.Controls.Add(this.rjButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            this.PContListaCl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJButton BDescargarCliente;
        private System.Windows.Forms.Panel PContListaCl;
        private System.Windows.Forms.DataGridView DGListaCliente;
        private System.Windows.Forms.Label LTituloListaPr;
        private System.Windows.Forms.PictureBox PBImgListaPr;
        private RJButton rjButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CModificarCl;
    }
}