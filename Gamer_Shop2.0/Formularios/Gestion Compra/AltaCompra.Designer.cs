namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    partial class AltaCompra
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCompra));
            this.LTituloAltaCompra = new System.Windows.Forms.Label();
            this.PBImgAltaCom = new System.Windows.Forms.PictureBox();
            this.PContAltaCompra = new System.Windows.Forms.Panel();
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.PListaPrCompra = new System.Windows.Forms.Panel();
            this.DGListaPrCompra = new System.Windows.Forms.DataGridView();
            this.CSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombrePr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidadPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecioPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEliminarPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBBuscar = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.BElegirPrLista = new Gamer_Shop2._0.RJButton();
            this.CBProveedor = new Gamer_Shop2._0.RJControls.RJComboBox();
            this.TBValidacion4 = new System.Windows.Forms.Label();
            this.LSelectProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BComprar = new Gamer_Shop2._0.RJButton();
            this.BListaDeCompras = new Gamer_Shop2._0.RJButton();
            this.dataSet11 = new Gamer_Shop2._0.DataSet1();
            this.proveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter1 = new Gamer_Shop2._0.DataSet1TableAdapters.ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgAltaCom)).BeginInit();
            this.PContAltaCompra.SuspendLayout();
            this.PListaPrCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPrCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTituloAltaCompra
            // 
            this.LTituloAltaCompra.AutoSize = true;
            this.LTituloAltaCompra.BackColor = System.Drawing.Color.Transparent;
            this.LTituloAltaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloAltaCompra.ForeColor = System.Drawing.Color.White;
            this.LTituloAltaCompra.Location = new System.Drawing.Point(226, 30);
            this.LTituloAltaCompra.Name = "LTituloAltaCompra";
            this.LTituloAltaCompra.Size = new System.Drawing.Size(235, 42);
            this.LTituloAltaCompra.TabIndex = 5;
            this.LTituloAltaCompra.Text = "Alta Compra";
            this.LTituloAltaCompra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PBImgAltaCom
            // 
            this.PBImgAltaCom.BackColor = System.Drawing.Color.Transparent;
            this.PBImgAltaCom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgAltaCom.BackgroundImage")));
            this.PBImgAltaCom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgAltaCom.Location = new System.Drawing.Point(173, 31);
            this.PBImgAltaCom.Name = "PBImgAltaCom";
            this.PBImgAltaCom.Size = new System.Drawing.Size(47, 41);
            this.PBImgAltaCom.TabIndex = 4;
            this.PBImgAltaCom.TabStop = false;
            // 
            // PContAltaCompra
            // 
            this.PContAltaCompra.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContAltaCompra.Controls.Add(this.BBuscador);
            this.PContAltaCompra.Controls.Add(this.PListaPrCompra);
            this.PContAltaCompra.Controls.Add(this.TBBuscar);
            this.PContAltaCompra.Controls.Add(this.BElegirPrLista);
            this.PContAltaCompra.Controls.Add(this.CBProveedor);
            this.PContAltaCompra.Controls.Add(this.TBValidacion4);
            this.PContAltaCompra.Controls.Add(this.LSelectProveedor);
            this.PContAltaCompra.Location = new System.Drawing.Point(28, 78);
            this.PContAltaCompra.Name = "PContAltaCompra";
            this.PContAltaCompra.Size = new System.Drawing.Size(464, 330);
            this.PContAltaCompra.TabIndex = 6;
            this.PContAltaCompra.Paint += new System.Windows.Forms.PaintEventHandler(this.PContAltaCompra_Paint);
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
            this.BBuscador.Location = new System.Drawing.Point(424, 67);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 19;
            this.BBuscador.TextColor = System.Drawing.Color.White;
            this.BBuscador.UseVisualStyleBackColor = false;
            this.BBuscador.Click += new System.EventHandler(this.BBuscador_Click);
            // 
            // PListaPrCompra
            // 
            this.PListaPrCompra.Controls.Add(this.DGListaPrCompra);
            this.PListaPrCompra.Location = new System.Drawing.Point(12, 99);
            this.PListaPrCompra.Name = "PListaPrCompra";
            this.PListaPrCompra.Size = new System.Drawing.Size(438, 218);
            this.PListaPrCompra.TabIndex = 39;
            this.PListaPrCompra.Paint += new System.Windows.Forms.PaintEventHandler(this.PListaPrCompra_Paint);
            // 
            // DGListaPrCompra
            // 
            this.DGListaPrCompra.AllowUserToAddRows = false;
            this.DGListaPrCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaPrCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSerial,
            this.CNombrePr,
            this.CCantidadPr,
            this.CPrecioPr,
            this.CTotalPr,
            this.CEliminarPr});
            this.DGListaPrCompra.Location = new System.Drawing.Point(1, 1);
            this.DGListaPrCompra.Name = "DGListaPrCompra";
            this.DGListaPrCompra.Size = new System.Drawing.Size(436, 216);
            this.DGListaPrCompra.TabIndex = 0;
            this.DGListaPrCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaPr_CellClick);
            this.DGListaPrCompra.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DGListaPrCompra_CellValidating);
            // 
            // CSerial
            // 
            this.CSerial.HeaderText = "Serial";
            this.CSerial.Name = "CSerial";
            // 
            // CNombrePr
            // 
            this.CNombrePr.HeaderText = "Nombre";
            this.CNombrePr.Name = "CNombrePr";
            // 
            // CCantidadPr
            // 
            this.CCantidadPr.HeaderText = "Cantidad";
            this.CCantidadPr.Name = "CCantidadPr";
            // 
            // CPrecioPr
            // 
            this.CPrecioPr.HeaderText = "Precio";
            this.CPrecioPr.Name = "CPrecioPr";
            // 
            // CTotalPr
            // 
            this.CTotalPr.HeaderText = "Total";
            this.CTotalPr.Name = "CTotalPr";
            // 
            // CEliminarPr
            // 
            this.CEliminarPr.HeaderText = "Eliminar";
            this.CEliminarPr.Name = "CEliminarPr";
            // 
            // TBBuscar
            // 
            this.TBBuscar.BackColor = System.Drawing.Color.Black;
            this.TBBuscar.BorderColor = System.Drawing.Color.Lime;
            this.TBBuscar.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TBBuscar.BorderRadius = 2;
            this.TBBuscar.BorderSize = 1;
            this.TBBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscar.ForeColor = System.Drawing.Color.White;
            this.TBBuscar.Location = new System.Drawing.Point(272, 62);
            this.TBBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TBBuscar.Multiline = false;
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBBuscar.PasswordChar = false;
            this.TBBuscar.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBBuscar.PlaceholderText = "Buscar...";
            this.TBBuscar.Size = new System.Drawing.Size(148, 31);
            this.TBBuscar.TabIndex = 20;
            this.TBBuscar.Texts = "";
            this.TBBuscar.UnderlinedStyle = false;
            // 
            // BElegirPrLista
            // 
            this.BElegirPrLista.BackColor = System.Drawing.Color.Black;
            this.BElegirPrLista.BackgroundColor = System.Drawing.Color.Black;
            this.BElegirPrLista.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BElegirPrLista.BorderRadius = 15;
            this.BElegirPrLista.BorderSize = 1;
            this.BElegirPrLista.FlatAppearance.BorderSize = 0;
            this.BElegirPrLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BElegirPrLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BElegirPrLista.ForeColor = System.Drawing.Color.White;
            this.BElegirPrLista.Location = new System.Drawing.Point(12, 59);
            this.BElegirPrLista.Name = "BElegirPrLista";
            this.BElegirPrLista.Size = new System.Drawing.Size(121, 34);
            this.BElegirPrLista.TabIndex = 40;
            this.BElegirPrLista.Text = "Agregar producto";
            this.BElegirPrLista.TextColor = System.Drawing.Color.White;
            this.BElegirPrLista.UseVisualStyleBackColor = false;
            this.BElegirPrLista.Click += new System.EventHandler(this.BElegirPrLista_Click);
            // 
            // CBProveedor
            // 
            this.CBProveedor.BackColor = System.Drawing.Color.Black;
            this.CBProveedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CBProveedor.BorderSize = 1;
            this.CBProveedor.CustomIndexStart = 1;
            this.CBProveedor.CustomSelectedIndex = 0;
            this.CBProveedor.DataSource = this.proveedorBindingSource1;
            this.CBProveedor.DisplayMember = "Razon_social";
            this.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBProveedor.DropDownWidth = 296;
            this.CBProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.CBProveedor.IconColor = System.Drawing.Color.Lime;
            this.CBProveedor.ListBackColor = System.Drawing.Color.Black;
            this.CBProveedor.ListTextColor = System.Drawing.Color.Lime;
            this.CBProveedor.Location = new System.Drawing.Point(144, 8);
            this.CBProveedor.MinimumSize = new System.Drawing.Size(30, 30);
            this.CBProveedor.Name = "CBProveedor";
            this.CBProveedor.Padding = new System.Windows.Forms.Padding(1);
            this.CBProveedor.Size = new System.Drawing.Size(296, 30);
            this.CBProveedor.TabIndex = 31;
            this.CBProveedor.Texts = "";
            this.CBProveedor.ValueMember = "ID_Proveedor";
            this.CBProveedor.Validating += new System.ComponentModel.CancelEventHandler(this.CBCategoriaPr_Validating);
            // 
            // TBValidacion4
            // 
            this.TBValidacion4.AutoSize = true;
            this.TBValidacion4.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion4.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion4.Location = new System.Drawing.Point(280, 42);
            this.TBValidacion4.Name = "TBValidacion4";
            this.TBValidacion4.Size = new System.Drawing.Size(160, 14);
            this.TBValidacion4.TabIndex = 57;
            this.TBValidacion4.Text = "Por favor, elija una opción válida";
            this.TBValidacion4.Visible = false;
            // 
            // LSelectProveedor
            // 
            this.LSelectProveedor.AutoSize = true;
            this.LSelectProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LSelectProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSelectProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSelectProveedor.Location = new System.Drawing.Point(25, 14);
            this.LSelectProveedor.Name = "LSelectProveedor";
            this.LSelectProveedor.Size = new System.Drawing.Size(98, 24);
            this.LSelectProveedor.TabIndex = 30;
            this.LSelectProveedor.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(507, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Lista de Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(536, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Comprar";
            // 
            // BComprar
            // 
            this.BComprar.BackColor = System.Drawing.Color.Black;
            this.BComprar.BackgroundColor = System.Drawing.Color.Black;
            this.BComprar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BComprar.BackgroundImage")));
            this.BComprar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BComprar.BorderColor = System.Drawing.Color.Lime;
            this.BComprar.BorderRadius = 20;
            this.BComprar.BorderSize = 1;
            this.BComprar.FlatAppearance.BorderSize = 0;
            this.BComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BComprar.ForeColor = System.Drawing.Color.White;
            this.BComprar.Location = new System.Drawing.Point(532, 116);
            this.BComprar.Name = "BComprar";
            this.BComprar.Padding = new System.Windows.Forms.Padding(8);
            this.BComprar.Size = new System.Drawing.Size(84, 76);
            this.BComprar.TabIndex = 28;
            this.BComprar.TextColor = System.Drawing.Color.White;
            this.BComprar.UseVisualStyleBackColor = false;
            this.BComprar.Click += new System.EventHandler(this.BComprar_Click);
            // 
            // BListaDeCompras
            // 
            this.BListaDeCompras.BackColor = System.Drawing.Color.Black;
            this.BListaDeCompras.BackgroundColor = System.Drawing.Color.Black;
            this.BListaDeCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BListaDeCompras.BackgroundImage")));
            this.BListaDeCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BListaDeCompras.BorderColor = System.Drawing.Color.Lime;
            this.BListaDeCompras.BorderRadius = 20;
            this.BListaDeCompras.BorderSize = 1;
            this.BListaDeCompras.FlatAppearance.BorderSize = 0;
            this.BListaDeCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BListaDeCompras.ForeColor = System.Drawing.Color.White;
            this.BListaDeCompras.Location = new System.Drawing.Point(532, 268);
            this.BListaDeCompras.Name = "BListaDeCompras";
            this.BListaDeCompras.Size = new System.Drawing.Size(84, 76);
            this.BListaDeCompras.TabIndex = 26;
            this.BListaDeCompras.TextColor = System.Drawing.Color.White;
            this.BListaDeCompras.UseVisualStyleBackColor = false;
            this.BListaDeCompras.Click += new System.EventHandler(this.BListaDeCompras_Click);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource1
            // 
            this.proveedorBindingSource1.DataMember = "Proveedor";
            this.proveedorBindingSource1.DataSource = this.dataSet11;
            // 
            // proveedorTableAdapter1
            // 
            this.proveedorTableAdapter1.ClearBeforeFill = true;
            // 
            // AltaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BComprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PContAltaCompra);
            this.Controls.Add(this.BListaDeCompras);
            this.Controls.Add(this.LTituloAltaCompra);
            this.Controls.Add(this.PBImgAltaCom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaCompra";
            this.Text = "AltaCompra";
            this.Load += new System.EventHandler(this.AltaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBImgAltaCom)).EndInit();
            this.PContAltaCompra.ResumeLayout(false);
            this.PContAltaCompra.PerformLayout();
            this.PListaPrCompra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPrCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTituloAltaCompra;
        private System.Windows.Forms.PictureBox PBImgAltaCom;
        private System.Windows.Forms.Panel PContAltaCompra;
        private System.Windows.Forms.Label label1;
        private RJButton BListaDeCompras;
        private System.Windows.Forms.Label label2;
        private RJButton BComprar;
        private RJControls.RJComboBox CBProveedor;
        private System.Windows.Forms.Label LSelectProveedor;
        private System.Windows.Forms.Panel PListaPrCompra;
        private System.Windows.Forms.DataGridView DGListaPrCompra;
        private System.Windows.Forms.Label TBValidacion4;
        private RJButton BElegirPrLista;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombrePr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidadPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecioPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEliminarPr;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource proveedorBindingSource1;
        private DataSet1TableAdapters.ProveedorTableAdapter proveedorTableAdapter1;
    }
}