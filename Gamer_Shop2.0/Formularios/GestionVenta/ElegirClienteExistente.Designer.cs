namespace Gamer_Shop2._0.Formularios.GestionVenta { 
    partial class ElegirClienteExistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirClienteExistente));
            this.PContListaCl = new System.Windows.Forms.Panel();
            this.DGListaCliente = new System.Windows.Forms.DataGridView();
            this.LTituloListaPr = new System.Windows.Forms.Label();
            this.PBImgListaPr = new System.Windows.Forms.PictureBox();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSeleccionarCl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.PContListaCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).BeginInit();
            this.SuspendLayout();
            // 
            // PContListaCl
            // 
            this.PContListaCl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaCl.Controls.Add(this.DGListaCliente);
            this.PContListaCl.Location = new System.Drawing.Point(127, 113);
            this.PContListaCl.Name = "PContListaCl";
            this.PContListaCl.Size = new System.Drawing.Size(437, 290);
            this.PContListaCl.TabIndex = 17;
            this.PContListaCl.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaCl_Paint);
            // 
            // DGListaCliente
            // 
            this.DGListaCliente.AllowUserToAddRows = false;
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
            this.ID_Cliente,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Teléfono,
            this.Correo,
            this.CSeleccionarCl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaCliente.GridColor = System.Drawing.Color.Black;
            this.DGListaCliente.Location = new System.Drawing.Point(2, 2);
            this.DGListaCliente.Name = "DGListaCliente";
            this.DGListaCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaCliente.Size = new System.Drawing.Size(433, 286);
            this.DGListaCliente.TabIndex = 0;
            this.DGListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaCliente_CellClick);
            this.DGListaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaCliente_CellClick);
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
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.ReadOnly = true;
            this.ID_Cliente.Visible = false;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Telefono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // CSeleccionarCl
            // 
            this.CSeleccionarCl.HeaderText = "Seleccionar";
            this.CSeleccionarCl.Name = "CSeleccionarCl";
            this.CSeleccionarCl.ReadOnly = true;
            this.CSeleccionarCl.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSeleccionarCl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BBuscador
            // 
            this.BBuscador.BackColor = System.Drawing.Color.Transparent;
            this.BBuscador.BackgroundColor = System.Drawing.Color.Transparent;
            this.BBuscador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBuscador.BackgroundImage")));
            this.BBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BBuscador.BorderColor = System.Drawing.Color.Transparent;
            this.BBuscador.BorderRadius = 0;
            this.BBuscador.BorderSize = 0;
            this.BBuscador.FlatAppearance.BorderSize = 0;
            this.BBuscador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BBuscador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscador.ForeColor = System.Drawing.Color.White;
            this.BBuscador.Location = new System.Drawing.Point(258, 80);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 25;
            this.BBuscador.TextColor = System.Drawing.Color.White;
            this.BBuscador.UseVisualStyleBackColor = false;
            this.BBuscador.Click += new System.EventHandler(this.BBuscador_Click);
            // 
            // TBFiltro
            // 
            this.TBFiltro.BackColor = System.Drawing.Color.Black;
            this.TBFiltro.BorderColor = System.Drawing.Color.Lime;
            this.TBFiltro.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TBFiltro.BorderRadius = 2;
            this.TBFiltro.BorderSize = 1;
            this.TBFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFiltro.ForeColor = System.Drawing.Color.White;
            this.TBFiltro.Location = new System.Drawing.Point(291, 77);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 26;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
            // 
            // ElegirClienteExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BBuscador);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.PContListaCl);
            this.Controls.Add(this.LTituloListaPr);
            this.Controls.Add(this.PBImgListaPr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ElegirClienteExistente";
            this.Text = "ElegirClienteExistente";
            this.Load += new System.EventHandler(this.ElegirClienteExistente_Load);
            this.PContListaCl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PContListaCl;
        private System.Windows.Forms.DataGridView DGListaCliente;
        private System.Windows.Forms.Label LTituloListaPr;
        private System.Windows.Forms.PictureBox PBImgListaPr;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewButtonColumn CSeleccionarCl;
    }
}