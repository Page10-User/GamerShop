namespace Gamer_Shop2._0.Formularios.GestionVenta
{
    partial class ListaClienteVn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaClienteVn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LTituloListaPr = new System.Windows.Forms.Label();
            this.PBImgListaPr = new System.Windows.Forms.PictureBox();
            this.PContListaCl = new System.Windows.Forms.Panel();
            this.DGListaCliente = new System.Windows.Forms.DataGridView();
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CElegirCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BCloseAltaCliente = new Gamer_Shop2._0.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).BeginInit();
            this.PContListaCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloListaPr
            // 
            this.LTituloListaPr.AutoSize = true;
            this.LTituloListaPr.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaPr.Location = new System.Drawing.Point(201, 22);
            this.LTituloListaPr.Name = "LTituloListaPr";
            this.LTituloListaPr.Size = new System.Drawing.Size(311, 42);
            this.LTituloListaPr.TabIndex = 17;
            this.LTituloListaPr.Text = "Lista de Clientes";
            // 
            // PBImgListaPr
            // 
            this.PBImgListaPr.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaPr.BackgroundImage")));
            this.PBImgListaPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaPr.Location = new System.Drawing.Point(159, 23);
            this.PBImgListaPr.Name = "PBImgListaPr";
            this.PBImgListaPr.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaPr.TabIndex = 18;
            this.PBImgListaPr.TabStop = false;
            // 
            // PContListaCl
            // 
            this.PContListaCl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaCl.Controls.Add(this.DGListaCliente);
            this.PContListaCl.Location = new System.Drawing.Point(30, 103);
            this.PContListaCl.Name = "PContListaCl";
            this.PContListaCl.Size = new System.Drawing.Size(629, 321);
            this.PContListaCl.TabIndex = 19;
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
            this.CElegirCl});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaCliente.GridColor = System.Drawing.Color.Black;
            this.DGListaCliente.Location = new System.Drawing.Point(3, 3);
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
            this.DGListaCliente.Size = new System.Drawing.Size(624, 320);
            this.DGListaCliente.TabIndex = 0;
            this.DGListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaCliente_CellClick);
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
            this.BBuscador.Location = new System.Drawing.Point(476, 70);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 27;
            this.BBuscador.TextColor = System.Drawing.Color.White;
            this.BBuscador.UseVisualStyleBackColor = false;
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
            this.TBFiltro.Location = new System.Drawing.Point(509, 68);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 28;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
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
            // CElegirCl
            // 
            this.CElegirCl.HeaderText = "Elegir";
            this.CElegirCl.Name = "CElegirCl";
            this.CElegirCl.ReadOnly = true;
            // 
            // BCloseAltaCliente
            // 
            this.BCloseAltaCliente.BackColor = System.Drawing.Color.Transparent;
            this.BCloseAltaCliente.BackgroundColor = System.Drawing.Color.Transparent;
            this.BCloseAltaCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCloseAltaCliente.BackgroundImage")));
            this.BCloseAltaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCloseAltaCliente.BorderColor = System.Drawing.Color.Transparent;
            this.BCloseAltaCliente.BorderRadius = 0;
            this.BCloseAltaCliente.BorderSize = 0;
            this.BCloseAltaCliente.CausesValidation = false;
            this.BCloseAltaCliente.FlatAppearance.BorderSize = 0;
            this.BCloseAltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BCloseAltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BCloseAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCloseAltaCliente.ForeColor = System.Drawing.Color.White;
            this.BCloseAltaCliente.Location = new System.Drawing.Point(647, 12);
            this.BCloseAltaCliente.Name = "BCloseAltaCliente";
            this.BCloseAltaCliente.Size = new System.Drawing.Size(25, 25);
            this.BCloseAltaCliente.TabIndex = 29;
            this.BCloseAltaCliente.TextColor = System.Drawing.Color.White;
            this.BCloseAltaCliente.UseVisualStyleBackColor = false;
            this.BCloseAltaCliente.Click += new System.EventHandler(this.BCloseAltaCliente_Click);
            // 
            // ListaClienteVn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BCloseAltaCliente);
            this.Controls.Add(this.BBuscador);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.PContListaCl);
            this.Controls.Add(this.PBImgListaPr);
            this.Controls.Add(this.LTituloListaPr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaClienteVn";
            this.Text = "ListaClienteVn";
            this.Load += new System.EventHandler(this.ListaClienteVn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).EndInit();
            this.PContListaCl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloListaPr;
        private System.Windows.Forms.PictureBox PBImgListaPr;
        private System.Windows.Forms.Panel PContListaCl;
        private System.Windows.Forms.DataGridView DGListaCliente;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CElegirCl;
        private RJButton BCloseAltaCliente;
    }
}