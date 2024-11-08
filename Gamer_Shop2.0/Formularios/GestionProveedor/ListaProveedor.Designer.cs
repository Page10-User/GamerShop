namespace Gamer_Shop2._0.Formularios.GestionProveedor
{
    partial class ListaProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProveedor));
            this.BRegistrarProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaProveedor = new System.Windows.Forms.Panel();
            this.DGListaProveedorInactivos = new System.Windows.Forms.DataGridView();
            this.ID_ProveedorIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificarIn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGListaProveedor = new System.Windows.Forms.DataGridView();
            this.ID_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_representante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LTituloListaProveedor = new System.Windows.Forms.Label();
            this.PBImgListaProveedor = new System.Windows.Forms.PictureBox();
            this.PBackSwitch = new System.Windows.Forms.Panel();
            this.BSwitch = new Gamer_Shop2._0.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.MovSwitch = new System.Windows.Forms.Timer(this.components);
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.BShowRegistrarProveedor = new Gamer_Shop2._0.RJButton();
            this.BDescargar = new Gamer_Shop2._0.RJButton();
            this.PContListaProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaProveedorInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaProveedor)).BeginInit();
            this.PBackSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // BRegistrarProveedor
            // 
            this.BRegistrarProveedor.AutoSize = true;
            this.BRegistrarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.BRegistrarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRegistrarProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BRegistrarProveedor.Location = new System.Drawing.Point(531, 340);
            this.BRegistrarProveedor.Name = "BRegistrarProveedor";
            this.BRegistrarProveedor.Size = new System.Drawing.Size(77, 18);
            this.BRegistrarProveedor.TabIndex = 29;
            this.BRegistrarProveedor.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(533, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descargar";
            // 
            // PContListaProveedor
            // 
            this.PContListaProveedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContListaProveedor.Controls.Add(this.DGListaProveedorInactivos);
            this.PContListaProveedor.Controls.Add(this.DGListaProveedor);
            this.PContListaProveedor.Location = new System.Drawing.Point(63, 114);
            this.PContListaProveedor.Name = "PContListaProveedor";
            this.PContListaProveedor.Size = new System.Drawing.Size(437, 290);
            this.PContListaProveedor.TabIndex = 25;
            this.PContListaProveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaProveedor_Paint);
            // 
            // DGListaProveedorInactivos
            // 
            this.DGListaProveedorInactivos.AllowUserToAddRows = false;
            this.DGListaProveedorInactivos.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaProveedorInactivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaProveedorInactivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaProveedorInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaProveedorInactivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ProveedorIn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.CModificarIn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaProveedorInactivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaProveedorInactivos.GridColor = System.Drawing.Color.Black;
            this.DGListaProveedorInactivos.Location = new System.Drawing.Point(1, 1);
            this.DGListaProveedorInactivos.Name = "DGListaProveedorInactivos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaProveedorInactivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaProveedorInactivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaProveedorInactivos.Size = new System.Drawing.Size(435, 288);
            this.DGListaProveedorInactivos.TabIndex = 2;
            this.DGListaProveedorInactivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaProveedorInactivos_CellClick);
            // 
            // ID_ProveedorIn
            // 
            this.ID_ProveedorIn.HeaderText = "ID_Proveedor";
            this.ID_ProveedorIn.Name = "ID_ProveedorIn";
            this.ID_ProveedorIn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Razon social";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre representante";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // CModificarIn
            // 
            this.CModificarIn.HeaderText = "Modificar";
            this.CModificarIn.Name = "CModificarIn";
            this.CModificarIn.Text = "";
            // 
            // DGListaProveedor
            // 
            this.DGListaProveedor.AllowUserToAddRows = false;
            this.DGListaProveedor.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGListaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Proveedor,
            this.Razon_social,
            this.Nombre_representante,
            this.Telefono,
            this.Correo,
            this.Dirección,
            this.Activo,
            this.Categoria,
            this.CModificar,
            this.CEliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaProveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGListaProveedor.GridColor = System.Drawing.Color.Black;
            this.DGListaProveedor.Location = new System.Drawing.Point(1, 1);
            this.DGListaProveedor.Name = "DGListaProveedor";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaProveedor.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DGListaProveedor.Size = new System.Drawing.Size(435, 288);
            this.DGListaProveedor.TabIndex = 1;
            this.DGListaProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaProveedor_CellClick);
            // 
            // ID_Proveedor
            // 
            this.ID_Proveedor.HeaderText = "ID_Proveedor";
            this.ID_Proveedor.Name = "ID_Proveedor";
            this.ID_Proveedor.Visible = false;
            // 
            // Razon_social
            // 
            this.Razon_social.HeaderText = "Razon social";
            this.Razon_social.Name = "Razon_social";
            // 
            // Nombre_representante
            // 
            this.Nombre_representante.HeaderText = "Nombre representante";
            this.Nombre_representante.Name = "Nombre_representante";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // CModificar
            // 
            this.CModificar.HeaderText = "Modificar";
            this.CModificar.Name = "CModificar";
            // 
            // CEliminar
            // 
            this.CEliminar.HeaderText = "Eliminar";
            this.CEliminar.Name = "CEliminar";
            // 
            // LTituloListaProveedor
            // 
            this.LTituloListaProveedor.AutoSize = true;
            this.LTituloListaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaProveedor.Location = new System.Drawing.Point(147, 18);
            this.LTituloListaProveedor.Name = "LTituloListaProveedor";
            this.LTituloListaProveedor.Size = new System.Drawing.Size(392, 42);
            this.LTituloListaProveedor.TabIndex = 24;
            this.LTituloListaProveedor.Text = "Lista de Proveedores";
            // 
            // PBImgListaProveedor
            // 
            this.PBImgListaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.PBImgListaProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgListaProveedor.BackgroundImage")));
            this.PBImgListaProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgListaProveedor.Location = new System.Drawing.Point(104, 21);
            this.PBImgListaProveedor.Name = "PBImgListaProveedor";
            this.PBImgListaProveedor.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaProveedor.TabIndex = 23;
            this.PBImgListaProveedor.TabStop = false;
            // 
            // PBackSwitch
            // 
            this.PBackSwitch.BackColor = System.Drawing.Color.Black;
            this.PBackSwitch.Controls.Add(this.BSwitch);
            this.PBackSwitch.Location = new System.Drawing.Point(64, 83);
            this.PBackSwitch.Name = "PBackSwitch";
            this.PBackSwitch.Size = new System.Drawing.Size(57, 29);
            this.PBackSwitch.TabIndex = 37;
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
            this.label2.Location = new System.Drawing.Point(63, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 36;
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
            this.BBuscador.Location = new System.Drawing.Point(319, 79);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 30;
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
            this.TBFiltro.Location = new System.Drawing.Point(352, 77);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 31;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
            // 
            // BShowRegistrarProveedor
            // 
            this.BShowRegistrarProveedor.BackColor = System.Drawing.Color.Black;
            this.BShowRegistrarProveedor.BackgroundColor = System.Drawing.Color.Black;
            this.BShowRegistrarProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BShowRegistrarProveedor.BackgroundImage")));
            this.BShowRegistrarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BShowRegistrarProveedor.BorderColor = System.Drawing.Color.Lime;
            this.BShowRegistrarProveedor.BorderRadius = 20;
            this.BShowRegistrarProveedor.BorderSize = 1;
            this.BShowRegistrarProveedor.FlatAppearance.BorderSize = 0;
            this.BShowRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BShowRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.BShowRegistrarProveedor.Location = new System.Drawing.Point(529, 261);
            this.BShowRegistrarProveedor.Name = "BShowRegistrarProveedor";
            this.BShowRegistrarProveedor.Size = new System.Drawing.Size(84, 76);
            this.BShowRegistrarProveedor.TabIndex = 27;
            this.BShowRegistrarProveedor.TextColor = System.Drawing.Color.White;
            this.BShowRegistrarProveedor.UseVisualStyleBackColor = false;
            this.BShowRegistrarProveedor.Click += new System.EventHandler(this.BShowRegistrarProveedor_Click);
            // 
            // BDescargar
            // 
            this.BDescargar.BackColor = System.Drawing.Color.Black;
            this.BDescargar.BackgroundColor = System.Drawing.Color.Black;
            this.BDescargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDescargar.BackgroundImage")));
            this.BDescargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BDescargar.BorderColor = System.Drawing.Color.Lime;
            this.BDescargar.BorderRadius = 20;
            this.BDescargar.BorderSize = 1;
            this.BDescargar.FlatAppearance.BorderSize = 0;
            this.BDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDescargar.ForeColor = System.Drawing.Color.White;
            this.BDescargar.Location = new System.Drawing.Point(529, 137);
            this.BDescargar.Name = "BDescargar";
            this.BDescargar.Size = new System.Drawing.Size(84, 76);
            this.BDescargar.TabIndex = 26;
            this.BDescargar.TextColor = System.Drawing.Color.White;
            this.BDescargar.UseVisualStyleBackColor = false;
            // 
            // ListaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.PBackSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BBuscador);
            this.Controls.Add(this.TBFiltro);
            this.Controls.Add(this.BRegistrarProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BShowRegistrarProveedor);
            this.Controls.Add(this.BDescargar);
            this.Controls.Add(this.PContListaProveedor);
            this.Controls.Add(this.LTituloListaProveedor);
            this.Controls.Add(this.PBImgListaProveedor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaProveedor";
            this.Text = "ListaProveedor";
            this.Load += new System.EventHandler(this.ListaProveedor_Load);
            this.PContListaProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaProveedorInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaProveedor)).EndInit();
            this.PBackSwitch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BRegistrarProveedor;
        private System.Windows.Forms.Label label1;
        private RJButton BShowRegistrarProveedor;
        private RJButton BDescargar;
        private System.Windows.Forms.Panel PContListaProveedor;
        private System.Windows.Forms.DataGridView DGListaProveedor;
        private System.Windows.Forms.Label LTituloListaProveedor;
        private System.Windows.Forms.PictureBox PBImgListaProveedor;
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_representante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewButtonColumn CModificar;
        private System.Windows.Forms.DataGridViewButtonColumn CEliminar;
        private System.Windows.Forms.DataGridView DGListaProveedorInactivos;
        private System.Windows.Forms.Panel PBackSwitch;
        private RJButton BSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer MovSwitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ProveedorIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn CModificarIn;
    }
}