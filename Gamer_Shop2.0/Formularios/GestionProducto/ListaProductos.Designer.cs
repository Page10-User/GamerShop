namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    partial class ListaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaPr = new System.Windows.Forms.Panel();
            this.DGListaPrInactivos = new System.Windows.Forms.DataGridView();
            this.ID_ProductoIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificarIn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGListaPr = new System.Windows.Forms.DataGridView();
            this.LTituloListaPr = new System.Windows.Forms.Label();
            this.PBImgListaPr = new System.Windows.Forms.PictureBox();
            this.PBackSwitch = new System.Windows.Forms.Panel();
            this.BSwitch = new Gamer_Shop2._0.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MovSwitch = new System.Windows.Forms.Timer(this.components);
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.BShowRegistrarPr = new Gamer_Shop2._0.RJButton();
            this.BDescargarPr = new Gamer_Shop2._0.RJButton();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PContListaPr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPrInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).BeginInit();
            this.PBackSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label.Location = new System.Drawing.Point(545, 340);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(77, 18);
            this.Label.TabIndex = 13;
            this.Label.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(545, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descargar";
            // 
            // PContListaPr
            // 
            this.PContListaPr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaPr.Controls.Add(this.DGListaPrInactivos);
            this.PContListaPr.Controls.Add(this.DGListaPr);
            this.PContListaPr.Location = new System.Drawing.Point(68, 109);
            this.PContListaPr.Name = "PContListaPr";
            this.PContListaPr.Size = new System.Drawing.Size(437, 290);
            this.PContListaPr.TabIndex = 9;
            this.PContListaPr.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaPr_Paint);
            // 
            // DGListaPrInactivos
            // 
            this.DGListaPrInactivos.AllowUserToAddRows = false;
            this.DGListaPrInactivos.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaPrInactivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaPrInactivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaPrInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaPrInactivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ProductoIn,
            this.SerialIn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.CModificarIn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaPrInactivos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGListaPrInactivos.GridColor = System.Drawing.Color.Black;
            this.DGListaPrInactivos.Location = new System.Drawing.Point(2, 3);
            this.DGListaPrInactivos.Name = "DGListaPrInactivos";
            this.DGListaPrInactivos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaPrInactivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaPrInactivos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGListaPrInactivos.Size = new System.Drawing.Size(433, 287);
            this.DGListaPrInactivos.TabIndex = 1;
            this.DGListaPrInactivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaPrInactivos_CellClick);
            // 
            // ID_ProductoIn
            // 
            this.ID_ProductoIn.HeaderText = "ID_Producto";
            this.ID_ProductoIn.Name = "ID_ProductoIn";
            this.ID_ProductoIn.ReadOnly = true;
            this.ID_ProductoIn.Visible = false;
            // 
            // SerialIn
            // 
            this.SerialIn.HeaderText = "Serial";
            this.SerialIn.Name = "SerialIn";
            this.SerialIn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // CModificarIn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.CModificarIn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CModificarIn.HeaderText = "Modificar";
            this.CModificarIn.Name = "CModificarIn";
            this.CModificarIn.ReadOnly = true;
            this.CModificarIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CModificarIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DGListaPr
            // 
            this.DGListaPr.AllowUserToAddRows = false;
            this.DGListaPr.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaPr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaPr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGListaPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaPr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Serial,
            this.Nombre,
            this.Descripción,
            this.Stock,
            this.Precio,
            this.Categoría,
            this.Proveedor,
            this.CModificar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaPr.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGListaPr.GridColor = System.Drawing.Color.Black;
            this.DGListaPr.Location = new System.Drawing.Point(2, 2);
            this.DGListaPr.Name = "DGListaPr";
            this.DGListaPr.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaPr.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaPr.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGListaPr.Size = new System.Drawing.Size(433, 287);
            this.DGListaPr.TabIndex = 0;
            this.DGListaPr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaPr_CellClick);
            // 
            // LTituloListaPr
            // 
            this.LTituloListaPr.AutoSize = true;
            this.LTituloListaPr.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaPr.Location = new System.Drawing.Point(166, 31);
            this.LTituloListaPr.Name = "LTituloListaPr";
            this.LTituloListaPr.Size = new System.Drawing.Size(346, 42);
            this.LTituloListaPr.TabIndex = 8;
            this.LTituloListaPr.Text = "Lista de Productos";
            // 
            // PBImgListaPr
            // 
            this.PBImgListaPr.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaPr.BackgroundImage")));
            this.PBImgListaPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaPr.Location = new System.Drawing.Point(122, 32);
            this.PBImgListaPr.Name = "PBImgListaPr";
            this.PBImgListaPr.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaPr.TabIndex = 7;
            this.PBImgListaPr.TabStop = false;
            // 
            // PBackSwitch
            // 
            this.PBackSwitch.BackColor = System.Drawing.Color.Black;
            this.PBackSwitch.Controls.Add(this.BSwitch);
            this.PBackSwitch.Location = new System.Drawing.Point(68, 78);
            this.PBackSwitch.Name = "PBackSwitch";
            this.PBackSwitch.Size = new System.Drawing.Size(57, 29);
            this.PBackSwitch.TabIndex = 35;
            this.PBackSwitch.Click += new System.EventHandler(this.BSwitch_Click);
            this.PBackSwitch.Paint += new System.Windows.Forms.PaintEventHandler(this.PBackSwitch_Paint);
            // 
            // BSwitch
            // 
            this.BSwitch.BackColor = System.Drawing.Color.White;
            this.BSwitch.BackgroundColor = System.Drawing.Color.White;
            this.BSwitch.BorderColor = System.Drawing.Color.Lime;
            this.BSwitch.BorderRadius = 12;
            this.BSwitch.BorderSize = 1;
            this.BSwitch.FlatAppearance.BorderSize = 0;
            this.BSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSwitch.ForeColor = System.Drawing.Color.Black;
            this.BSwitch.Location = new System.Drawing.Point(3, 2);
            this.BSwitch.Name = "BSwitch";
            this.BSwitch.Size = new System.Drawing.Size(25, 25);
            this.BSwitch.TabIndex = 30;
            this.BSwitch.Text = "S";
            this.BSwitch.TextColor = System.Drawing.Color.Black;
            this.BSwitch.UseVisualStyleBackColor = false;
            this.BSwitch.Click += new System.EventHandler(this.BSwitch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Activo";
            // 
            // MovSwitch
            // 
            this.MovSwitch.Interval = 10;
            this.MovSwitch.Tick += new System.EventHandler(this.MovSwitch_Tick);
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
            this.BBuscador.Location = new System.Drawing.Point(324, 75);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 21;
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
            this.TBFiltro.Location = new System.Drawing.Point(357, 73);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 22;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
            // 
            // BShowRegistrarPr
            // 
            this.BShowRegistrarPr.BackColor = System.Drawing.Color.Black;
            this.BShowRegistrarPr.BackgroundColor = System.Drawing.Color.Black;
            this.BShowRegistrarPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BShowRegistrarPr.BackgroundImage")));
            this.BShowRegistrarPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BShowRegistrarPr.BorderColor = System.Drawing.Color.Lime;
            this.BShowRegistrarPr.BorderRadius = 20;
            this.BShowRegistrarPr.BorderSize = 1;
            this.BShowRegistrarPr.FlatAppearance.BorderSize = 0;
            this.BShowRegistrarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BShowRegistrarPr.ForeColor = System.Drawing.Color.White;
            this.BShowRegistrarPr.Location = new System.Drawing.Point(541, 261);
            this.BShowRegistrarPr.Name = "BShowRegistrarPr";
            this.BShowRegistrarPr.Size = new System.Drawing.Size(84, 76);
            this.BShowRegistrarPr.TabIndex = 11;
            this.BShowRegistrarPr.TextColor = System.Drawing.Color.White;
            this.BShowRegistrarPr.UseVisualStyleBackColor = false;
            this.BShowRegistrarPr.Click += new System.EventHandler(this.BShowRegistrarPr_Click);
            // 
            // BDescargarPr
            // 
            this.BDescargarPr.BackColor = System.Drawing.Color.Black;
            this.BDescargarPr.BackgroundColor = System.Drawing.Color.Black;
            this.BDescargarPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDescargarPr.BackgroundImage")));
            this.BDescargarPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BDescargarPr.BorderColor = System.Drawing.Color.Lime;
            this.BDescargarPr.BorderRadius = 20;
            this.BDescargarPr.BorderSize = 1;
            this.BDescargarPr.FlatAppearance.BorderSize = 0;
            this.BDescargarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargarPr.ForeColor = System.Drawing.Color.White;
            this.BDescargarPr.Location = new System.Drawing.Point(541, 137);
            this.BDescargarPr.Name = "BDescargarPr";
            this.BDescargarPr.Size = new System.Drawing.Size(84, 76);
            this.BDescargarPr.TabIndex = 10;
            this.BDescargarPr.TextColor = System.Drawing.Color.White;
            this.BDescargarPr.UseVisualStyleBackColor = false;
            this.BDescargarPr.Click += new System.EventHandler(this.BDescargarPr_Click);
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID_Producto";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            this.ID_Producto.Visible = false;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.Name = "Categoría";
            this.Categoría.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // CModificar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.CModificar.DefaultCellStyle = dataGridViewCellStyle7;
            this.CModificar.HeaderText = "Modificar";
            this.CModificar.Name = "CModificar";
            this.CModificar.ReadOnly = true;
            this.CModificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.PBackSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BBuscador);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BShowRegistrarPr);
            this.Controls.Add(this.BDescargarPr);
            this.Controls.Add(this.PContListaPr);
            this.Controls.Add(this.LTituloListaPr);
            this.Controls.Add(this.PBImgListaPr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProductos";
            this.Text = "ListaProductos";
            this.Load += new System.EventHandler(this.ListaProductos_Load);
            this.PContListaPr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPrInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaPr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaPr)).EndInit();
            this.PBackSwitch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private RJButton BShowRegistrarPr;
        private RJButton BDescargarPr;
        private System.Windows.Forms.Panel PContListaPr;
        private System.Windows.Forms.Label LTituloListaPr;
        private System.Windows.Forms.PictureBox PBImgListaPr;
        private System.Windows.Forms.DataGridView DGListaPr;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
        private System.Windows.Forms.Panel PBackSwitch;
        private RJButton BSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGListaPrInactivos;
        private System.Windows.Forms.Timer MovSwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ProductoIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn CModificarIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewButtonColumn CModificar;
    }
}