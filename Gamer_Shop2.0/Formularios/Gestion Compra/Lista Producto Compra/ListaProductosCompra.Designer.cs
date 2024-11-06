namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    partial class ListaProductosCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductosCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BCloseListaProducto = new Gamer_Shop2._0.RJButton();
            this.CBFiltrado = new Gamer_Shop2._0.RJControls.RJComboBox();
            this.BFiltro = new Gamer_Shop2._0.RJControls.RJComboBox();
            this.categoríaproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Gamer_Shop2._0.DataSet1();
            this.BBuscadorProductoCt = new Gamer_Shop2._0.RJButton();
            this.TBFiltroCt = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.categoría_productoTableAdapter = new Gamer_Shop2._0.DataSet1TableAdapters.Categoría_productoTableAdapter();
            this.BFiltrarSecond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoríaproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(205, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Productos";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 342);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BCloseListaProducto
            // 
            this.BCloseListaProducto.BackColor = System.Drawing.Color.Transparent;
            this.BCloseListaProducto.BackgroundColor = System.Drawing.Color.Transparent;
            this.BCloseListaProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BCloseListaProducto.BackgroundImage")));
            this.BCloseListaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BCloseListaProducto.BorderColor = System.Drawing.Color.Transparent;
            this.BCloseListaProducto.BorderRadius = 0;
            this.BCloseListaProducto.BorderSize = 0;
            this.BCloseListaProducto.CausesValidation = false;
            this.BCloseListaProducto.FlatAppearance.BorderSize = 0;
            this.BCloseListaProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BCloseListaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BCloseListaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCloseListaProducto.ForeColor = System.Drawing.Color.White;
            this.BCloseListaProducto.Location = new System.Drawing.Point(647, 12);
            this.BCloseListaProducto.Name = "BCloseListaProducto";
            this.BCloseListaProducto.Size = new System.Drawing.Size(25, 25);
            this.BCloseListaProducto.TabIndex = 15;
            this.BCloseListaProducto.TextColor = System.Drawing.Color.White;
            this.BCloseListaProducto.UseVisualStyleBackColor = false;
            this.BCloseListaProducto.Click += new System.EventHandler(this.BCloseListaProducto_Click);
            // 
            // CBFiltrado
            // 
            this.CBFiltrado.BackColor = System.Drawing.Color.Black;
            this.CBFiltrado.BorderColor = System.Drawing.Color.Lime;
            this.CBFiltrado.BorderSize = 1;
            this.CBFiltrado.CustomIndexStart = 1;
            this.CBFiltrado.CustomSelectedIndex = 0;
            this.CBFiltrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBFiltrado.DropDownWidth = 149;
            this.CBFiltrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFiltrado.ForeColor = System.Drawing.Color.DimGray;
            this.CBFiltrado.IconColor = System.Drawing.Color.Lime;
            this.CBFiltrado.Items.AddRange(new object[] {
            "A-Z",
            "Z-A",
            "Menor-Mayor",
            "Mayor-Menor",
            "Menor Cantidad - Mayor Cantidad",
            "Mayor cantidad - Menor Cantidad"});
            this.CBFiltrado.ListBackColor = System.Drawing.Color.Black;
            this.CBFiltrado.ListTextColor = System.Drawing.Color.Lime;
            this.CBFiltrado.Location = new System.Drawing.Point(523, 45);
            this.CBFiltrado.MinimumSize = new System.Drawing.Size(30, 30);
            this.CBFiltrado.Name = "CBFiltrado";
            this.CBFiltrado.Padding = new System.Windows.Forms.Padding(1);
            this.CBFiltrado.Size = new System.Drawing.Size(149, 30);
            this.CBFiltrado.TabIndex = 6;
            this.CBFiltrado.Texts = "Filtrar...";
            // 
            // BFiltro
            // 
            this.BFiltro.BackColor = System.Drawing.Color.Transparent;
            this.BFiltro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BFiltro.BackgroundImage")));
            this.BFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BFiltro.BorderColor = System.Drawing.Color.Transparent;
            this.BFiltro.BorderSize = 1;
            this.BFiltro.CustomIndexStart = 1;
            this.BFiltro.CustomSelectedIndex = 0;
            this.BFiltro.DataSource = this.categoríaproductoBindingSource;
            this.BFiltro.DisplayMember = "Nombre_Categoria";
            this.BFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.BFiltro.DropDownWidth = 150;
            this.BFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BFiltro.ForeColor = System.Drawing.Color.DimGray;
            this.BFiltro.IconColor = System.Drawing.Color.Transparent;
            this.BFiltro.ListBackColor = System.Drawing.Color.White;
            this.BFiltro.ListTextColor = System.Drawing.Color.Black;
            this.BFiltro.Location = new System.Drawing.Point(196, 44);
            this.BFiltro.MinimumSize = new System.Drawing.Size(30, 30);
            this.BFiltro.Name = "BFiltro";
            this.BFiltro.Padding = new System.Windows.Forms.Padding(1);
            this.BFiltro.Size = new System.Drawing.Size(30, 30);
            this.BFiltro.TabIndex = 62;
            this.BFiltro.Texts = "";
            this.BFiltro.ValueMember = "Nombre_Categoria";
            // 
            // categoríaproductoBindingSource
            // 
            this.categoríaproductoBindingSource.DataMember = "Categoría_producto";
            this.categoríaproductoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BBuscadorProductoCt
            // 
            this.BBuscadorProductoCt.BackColor = System.Drawing.Color.Transparent;
            this.BBuscadorProductoCt.BackgroundColor = System.Drawing.Color.Transparent;
            this.BBuscadorProductoCt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BBuscadorProductoCt.BackgroundImage")));
            this.BBuscadorProductoCt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BBuscadorProductoCt.BorderColor = System.Drawing.Color.Transparent;
            this.BBuscadorProductoCt.BorderRadius = 0;
            this.BBuscadorProductoCt.BorderSize = 0;
            this.BBuscadorProductoCt.FlatAppearance.BorderSize = 0;
            this.BBuscadorProductoCt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BBuscadorProductoCt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BBuscadorProductoCt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBuscadorProductoCt.ForeColor = System.Drawing.Color.White;
            this.BBuscadorProductoCt.Location = new System.Drawing.Point(12, 46);
            this.BBuscadorProductoCt.Name = "BBuscadorProductoCt";
            this.BBuscadorProductoCt.Size = new System.Drawing.Size(26, 26);
            this.BBuscadorProductoCt.TabIndex = 60;
            this.BBuscadorProductoCt.TextColor = System.Drawing.Color.White;
            this.BBuscadorProductoCt.UseVisualStyleBackColor = false;
            this.BBuscadorProductoCt.Click += new System.EventHandler(this.BBuscadorProductoCt_Click);
            this.BBuscadorProductoCt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BFiltro_MouseUp);
            // 
            // TBFiltroCt
            // 
            this.TBFiltroCt.BackColor = System.Drawing.Color.Black;
            this.TBFiltroCt.BorderColor = System.Drawing.Color.Lime;
            this.TBFiltroCt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TBFiltroCt.BorderRadius = 2;
            this.TBFiltroCt.BorderSize = 1;
            this.TBFiltroCt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFiltroCt.ForeColor = System.Drawing.Color.White;
            this.TBFiltroCt.Location = new System.Drawing.Point(45, 44);
            this.TBFiltroCt.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltroCt.Multiline = false;
            this.TBFiltroCt.Name = "TBFiltroCt";
            this.TBFiltroCt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltroCt.PasswordChar = false;
            this.TBFiltroCt.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltroCt.PlaceholderText = "Buscar...";
            this.TBFiltroCt.Size = new System.Drawing.Size(148, 31);
            this.TBFiltroCt.TabIndex = 61;
            this.TBFiltroCt.Texts = "";
            this.TBFiltroCt.UnderlinedStyle = false;
            // 
            // categoría_productoTableAdapter
            // 
            this.categoría_productoTableAdapter.ClearBeforeFill = true;
            // 
            // BFiltrarSecond
            // 
            this.BFiltrarSecond.BackColor = System.Drawing.Color.Transparent;
            this.BFiltrarSecond.FlatAppearance.BorderSize = 0;
            this.BFiltrarSecond.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BFiltrarSecond.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BFiltrarSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFiltrarSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFiltrarSecond.ForeColor = System.Drawing.Color.White;
            this.BFiltrarSecond.Location = new System.Drawing.Point(434, 48);
            this.BFiltrarSecond.Name = "BFiltrarSecond";
            this.BFiltrarSecond.Size = new System.Drawing.Size(83, 23);
            this.BFiltrarSecond.TabIndex = 63;
            this.BFiltrarSecond.Text = "Filtrar por";
            this.BFiltrarSecond.UseVisualStyleBackColor = false;
            this.BFiltrarSecond.Click += new System.EventHandler(this.BFiltrarSecond_Click);
            // 
            // ListaProductosCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BFiltrarSecond);
            this.Controls.Add(this.BFiltro);
            this.Controls.Add(this.BBuscadorProductoCt);
            this.Controls.Add(this.TBFiltroCt);
            this.Controls.Add(this.BCloseListaProducto);
            this.Controls.Add(this.CBFiltrado);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProductosCompra";
            this.Text = "ListaProductosCompra";
            this.Load += new System.EventHandler(this.ListaProductosCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoríaproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RJControls.RJComboBox CBFiltrado;
        private RJButton BCloseListaProducto;
        private RJControls.RJComboBox BFiltro;
        private RJButton BBuscadorProductoCt;
        private RJControls.RJTextBox_radio_ TBFiltroCt;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource categoríaproductoBindingSource;
        private DataSet1TableAdapters.Categoría_productoTableAdapter categoría_productoTableAdapter;
        private System.Windows.Forms.Button BFiltrarSecond;
    }
}