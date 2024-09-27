namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    partial class ListaUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuario));
            this.LShowRegistrarUs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaUs = new System.Windows.Forms.Panel();
            this.DGListaUs = new System.Windows.Forms.DataGridView();
            this.CNombreUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApellidoUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificarUs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CEliminarUs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LTituloListaUs = new System.Windows.Forms.Label();
            this.PBImgListaUs = new System.Windows.Forms.PictureBox();
            this.BShowRegistrar = new Gamer_Shop2._0.RJButton();
            this.BDescargarListUs = new Gamer_Shop2._0.RJButton();
            this.BBuscarUs = new Gamer_Shop2._0.RJButton();
            this.PContListaUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaUs)).BeginInit();
            this.SuspendLayout();
            // 
            // LShowRegistrarUs
            // 
            this.LShowRegistrarUs.AutoSize = true;
            this.LShowRegistrarUs.BackColor = System.Drawing.Color.Transparent;
            this.LShowRegistrarUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LShowRegistrarUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LShowRegistrarUs.Location = new System.Drawing.Point(551, 338);
            this.LShowRegistrarUs.Name = "LShowRegistrarUs";
            this.LShowRegistrarUs.Size = new System.Drawing.Size(77, 18);
            this.LShowRegistrarUs.TabIndex = 27;
            this.LShowRegistrarUs.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(551, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descargar";
            // 
            // PContListaUs
            // 
            this.PContListaUs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaUs.Controls.Add(this.DGListaUs);
            this.PContListaUs.Location = new System.Drawing.Point(64, 108);
            this.PContListaUs.Name = "PContListaUs";
            this.PContListaUs.Size = new System.Drawing.Size(435, 288);
            this.PContListaUs.TabIndex = 23;
            // 
            // DGListaUs
            // 
            this.DGListaUs.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaUs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaUs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGListaUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNombreUs,
            this.CApellidoUs,
            this.CCuil,
            this.CNombreUsuario,
            this.CEmail,
            this.CContraseña,
            this.CModificarUs,
            this.CEliminarUs});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaUs.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGListaUs.GridColor = System.Drawing.Color.Black;
            this.DGListaUs.Location = new System.Drawing.Point(1, 1);
            this.DGListaUs.Name = "DGListaUs";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaUs.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaUs.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGListaUs.Size = new System.Drawing.Size(433, 286);
            this.DGListaUs.TabIndex = 28;
            // 
            // CNombreUs
            // 
            this.CNombreUs.HeaderText = "Nombre";
            this.CNombreUs.Name = "CNombreUs";
            // 
            // CApellidoUs
            // 
            this.CApellidoUs.HeaderText = "Apellido";
            this.CApellidoUs.Name = "CApellidoUs";
            // 
            // CCuil
            // 
            this.CCuil.HeaderText = "Cuil";
            this.CCuil.Name = "CCuil";
            // 
            // CNombreUsuario
            // 
            this.CNombreUsuario.HeaderText = "Nombre Usuario";
            this.CNombreUsuario.Name = "CNombreUsuario";
            // 
            // CEmail
            // 
            this.CEmail.HeaderText = "Email";
            this.CEmail.Name = "CEmail";
            // 
            // CContraseña
            // 
            this.CContraseña.HeaderText = "Contraseña";
            this.CContraseña.Name = "CContraseña";
            // 
            // CModificarUs
            // 
            this.CModificarUs.HeaderText = "Modificar";
            this.CModificarUs.Name = "CModificarUs";
            this.CModificarUs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CModificarUs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CEliminarUs
            // 
            this.CEliminarUs.HeaderText = "Eliminar";
            this.CEliminarUs.Name = "CEliminarUs";
            this.CEliminarUs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CEliminarUs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // LTituloListaUs
            // 
            this.LTituloListaUs.AutoSize = true;
            this.LTituloListaUs.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaUs.Location = new System.Drawing.Point(218, 34);
            this.LTituloListaUs.Name = "LTituloListaUs";
            this.LTituloListaUs.Size = new System.Drawing.Size(269, 42);
            this.LTituloListaUs.TabIndex = 22;
            this.LTituloListaUs.Text = "Lista Usuarios";
            // 
            // PBImgListaUs
            // 
            this.PBImgListaUs.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaUs.BackgroundImage")));
            this.PBImgListaUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaUs.Location = new System.Drawing.Point(175, 36);
            this.PBImgListaUs.Name = "PBImgListaUs";
            this.PBImgListaUs.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaUs.TabIndex = 21;
            this.PBImgListaUs.TabStop = false;
            // 
            // BShowRegistrar
            // 
            this.BShowRegistrar.BackColor = System.Drawing.Color.Black;
            this.BShowRegistrar.BackgroundColor = System.Drawing.Color.Black;
            this.BShowRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BShowRegistrar.BackgroundImage")));
            this.BShowRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BShowRegistrar.BorderColor = System.Drawing.Color.Lime;
            this.BShowRegistrar.BorderRadius = 20;
            this.BShowRegistrar.BorderSize = 2;
            this.BShowRegistrar.FlatAppearance.BorderSize = 0;
            this.BShowRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BShowRegistrar.ForeColor = System.Drawing.Color.White;
            this.BShowRegistrar.Location = new System.Drawing.Point(547, 259);
            this.BShowRegistrar.Name = "BShowRegistrar";
            this.BShowRegistrar.Size = new System.Drawing.Size(84, 76);
            this.BShowRegistrar.TabIndex = 25;
            this.BShowRegistrar.TextColor = System.Drawing.Color.White;
            this.BShowRegistrar.UseVisualStyleBackColor = false;
            this.BShowRegistrar.Click += new System.EventHandler(this.BShowRegistrar_Click);
            // 
            // BDescargarListUs
            // 
            this.BDescargarListUs.BackColor = System.Drawing.Color.Black;
            this.BDescargarListUs.BackgroundColor = System.Drawing.Color.Black;
            this.BDescargarListUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDescargarListUs.BackgroundImage")));
            this.BDescargarListUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BDescargarListUs.BorderColor = System.Drawing.Color.Lime;
            this.BDescargarListUs.BorderRadius = 20;
            this.BDescargarListUs.BorderSize = 2;
            this.BDescargarListUs.FlatAppearance.BorderSize = 0;
            this.BDescargarListUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargarListUs.ForeColor = System.Drawing.Color.White;
            this.BDescargarListUs.Location = new System.Drawing.Point(547, 135);
            this.BDescargarListUs.Name = "BDescargarListUs";
            this.BDescargarListUs.Size = new System.Drawing.Size(84, 76);
            this.BDescargarListUs.TabIndex = 24;
            this.BDescargarListUs.TextColor = System.Drawing.Color.White;
            this.BDescargarListUs.UseVisualStyleBackColor = false;
            // 
            // BBuscarUs
            // 
            this.BBuscarUs.BackColor = System.Drawing.Color.Black;
            this.BBuscarUs.BackgroundColor = System.Drawing.Color.Black;
            this.BBuscarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BBuscarUs.BorderColor = System.Drawing.Color.Lime;
            this.BBuscarUs.BorderRadius = 12;
            this.BBuscarUs.BorderSize = 1;
            this.BBuscarUs.FlatAppearance.BorderSize = 0;
            this.BBuscarUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscarUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBuscarUs.ForeColor = System.Drawing.Color.White;
            this.BBuscarUs.Location = new System.Drawing.Point(389, 76);
            this.BBuscarUs.Name = "BBuscarUs";
            this.BBuscarUs.Size = new System.Drawing.Size(84, 31);
            this.BBuscarUs.TabIndex = 28;
            this.BBuscarUs.Text = "Buscar";
            this.BBuscarUs.TextColor = System.Drawing.Color.White;
            this.BBuscarUs.UseVisualStyleBackColor = false;
            // 
            // ListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BBuscarUs);
            this.Controls.Add(this.LShowRegistrarUs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BShowRegistrar);
            this.Controls.Add(this.BDescargarListUs);
            this.Controls.Add(this.PContListaUs);
            this.Controls.Add(this.LTituloListaUs);
            this.Controls.Add(this.PBImgListaUs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaUsuario";
            this.Text = "ListaUsuarios";
            this.PContListaUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LShowRegistrarUs;
        private System.Windows.Forms.Label label1;
        private RJButton BShowRegistrar;
        private RJButton BDescargarListUs;
        private System.Windows.Forms.Panel PContListaUs;
        private System.Windows.Forms.Label LTituloListaUs;
        private System.Windows.Forms.PictureBox PBImgListaUs;
        private System.Windows.Forms.DataGridView DGListaUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApellidoUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CContraseña;
        private System.Windows.Forms.DataGridViewButtonColumn CModificarUs;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminarUs;
        private RJButton BBuscarUs;
    }
}