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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label2 = new System.Windows.Forms.Label();
            this.BAltaCliente = new Gamer_Shop2._0.RJButton();
            this.PBuscadorListaCl = new System.Windows.Forms.Panel();
            this.BBuscadorListaCl = new Gamer_Shop2._0.RJButton();
            this.TBuscarListaCl = new System.Windows.Forms.TextBox();
            this.PContListaCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).BeginInit();
            this.PBuscadorListaCl.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombre,
            this.CApellido,
            this.CDni,
            this.CTelefono,
            this.CCorreoElectronico,
            this.CModificarCl});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGListaCliente.GridColor = System.Drawing.Color.Black;
            this.DGListaCliente.Location = new System.Drawing.Point(2, 2);
            this.DGListaCliente.Name = "DGListaCliente";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGListaCliente.Size = new System.Drawing.Size(433, 286);
            this.DGListaCliente.TabIndex = 0;
            // 
            // CNombre
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.CNombre.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.PBImgListaPr.Location = new System.Drawing.Point(144, 35);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(552, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Registrar";
            // 
            // BAltaCliente
            // 
            this.BAltaCliente.BackColor = System.Drawing.Color.Black;
            this.BAltaCliente.BackgroundColor = System.Drawing.Color.Black;
            this.BAltaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAltaCliente.BackgroundImage")));
            this.BAltaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BAltaCliente.BorderColor = System.Drawing.Color.Lime;
            this.BAltaCliente.BorderRadius = 20;
            this.BAltaCliente.BorderSize = 1;
            this.BAltaCliente.FlatAppearance.BorderSize = 0;
            this.BAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAltaCliente.ForeColor = System.Drawing.Color.White;
            this.BAltaCliente.Location = new System.Drawing.Point(548, 250);
            this.BAltaCliente.Name = "BAltaCliente";
            this.BAltaCliente.Size = new System.Drawing.Size(84, 76);
            this.BAltaCliente.TabIndex = 23;
            this.BAltaCliente.TextColor = System.Drawing.Color.White;
            this.BAltaCliente.UseVisualStyleBackColor = false;
            this.BAltaCliente.Click += new System.EventHandler(this.BAltaCliente_Click);
            // 
            // PBuscadorListaCl
            // 
            this.PBuscadorListaCl.BackColor = System.Drawing.Color.Black;
            this.PBuscadorListaCl.Controls.Add(this.BBuscadorListaCl);
            this.PBuscadorListaCl.Controls.Add(this.TBuscarListaCl);
            this.PBuscadorListaCl.Location = new System.Drawing.Point(314, 74);
            this.PBuscadorListaCl.Name = "PBuscadorListaCl";
            this.PBuscadorListaCl.Size = new System.Drawing.Size(188, 31);
            this.PBuscadorListaCl.TabIndex = 25;
            this.PBuscadorListaCl.Paint += new System.Windows.Forms.PaintEventHandler(this.PBuscadorListaCl_Paint);
            // 
            // BBuscadorListaCl
            // 
            this.BBuscadorListaCl.BackColor = System.Drawing.Color.Transparent;
            this.BBuscadorListaCl.BackgroundColor = System.Drawing.Color.Transparent;
            this.BBuscadorListaCl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBuscadorListaCl.BackgroundImage")));
            this.BBuscadorListaCl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BBuscadorListaCl.BorderColor = System.Drawing.Color.Transparent;
            this.BBuscadorListaCl.BorderRadius = 0;
            this.BBuscadorListaCl.BorderSize = 0;
            this.BBuscadorListaCl.FlatAppearance.BorderSize = 0;
            this.BBuscadorListaCl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BBuscadorListaCl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BBuscadorListaCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscadorListaCl.ForeColor = System.Drawing.Color.White;
            this.BBuscadorListaCl.Location = new System.Drawing.Point(6, 2);
            this.BBuscadorListaCl.Name = "BBuscadorListaCl";
            this.BBuscadorListaCl.Size = new System.Drawing.Size(26, 26);
            this.BBuscadorListaCl.TabIndex = 4;
            this.BBuscadorListaCl.TextColor = System.Drawing.Color.White;
            this.BBuscadorListaCl.UseVisualStyleBackColor = false;
            // 
            // TBuscarListaCl
            // 
            this.TBuscarListaCl.BackColor = System.Drawing.Color.Black;
            this.TBuscarListaCl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuscarListaCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuscarListaCl.ForeColor = System.Drawing.Color.Silver;
            this.TBuscarListaCl.Location = new System.Drawing.Point(34, 6);
            this.TBuscarListaCl.Name = "TBuscarListaCl";
            this.TBuscarListaCl.Size = new System.Drawing.Size(132, 17);
            this.TBuscarListaCl.TabIndex = 4;
            this.TBuscarListaCl.Text = "Buscar...";
            // 
            // ListaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.PBuscadorListaCl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BAltaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BDescargarCliente);
            this.Controls.Add(this.PContListaCl);
            this.Controls.Add(this.LTituloListaPr);
            this.Controls.Add(this.PBImgListaPr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaCliente";
            this.Text = "ListaCliente";
            this.PContListaCl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).EndInit();
            this.PBuscadorListaCl.ResumeLayout(false);
            this.PBuscadorListaCl.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn CModificarCl;
        private System.Windows.Forms.Label label2;
        private RJButton BAltaCliente;
        private System.Windows.Forms.Panel PBuscadorListaCl;
        private RJButton BBuscadorListaCl;
        private System.Windows.Forms.TextBox TBuscarListaCl;
    }
}