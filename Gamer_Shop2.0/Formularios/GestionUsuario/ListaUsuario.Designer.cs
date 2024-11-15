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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuario));
            this.LShowRegistrarUs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PContListaUs = new System.Windows.Forms.Panel();
            this.DGListaUsInactivos = new System.Windows.Forms.DataGridView();
            this.ID_UsuarioIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUILIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_UsuarioIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificarUsIn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGListaUs = new System.Windows.Forms.DataGridView();
            this.LTituloListaUs = new System.Windows.Forms.Label();
            this.PBImgListaUs = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PBackSwitch = new System.Windows.Forms.Panel();
            this.BSwitch = new Gamer_Shop2._0.RJButton();
            this.BBuscador = new Gamer_Shop2._0.RJButton();
            this.TBFiltro = new Gamer_Shop2._0.RJControls.RJTextBox_radio_();
            this.BShowRegistrar = new Gamer_Shop2._0.RJButton();
            this.BDescargarListUs = new Gamer_Shop2._0.RJButton();
            this.MovSwich = new System.Windows.Forms.Timer(this.components);
            this.ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CModificarUs = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PContListaUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUsInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaUs)).BeginInit();
            this.PBackSwitch.SuspendLayout();
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
            this.PContListaUs.Controls.Add(this.DGListaUsInactivos);
            this.PContListaUs.Controls.Add(this.DGListaUs);
            this.PContListaUs.Location = new System.Drawing.Point(64, 108);
            this.PContListaUs.Name = "PContListaUs";
            this.PContListaUs.Size = new System.Drawing.Size(435, 288);
            this.PContListaUs.TabIndex = 23;
            this.PContListaUs.Paint += new System.Windows.Forms.PaintEventHandler(this.PContListaUs_Paint);
            // 
            // DGListaUsInactivos
            // 
            this.DGListaUsInactivos.AllowUserToAddRows = false;
            this.DGListaUsInactivos.BackgroundColor = System.Drawing.Color.Black;
            this.DGListaUsInactivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaUsInactivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGListaUsInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGListaUsInactivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_UsuarioIn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.CUILIn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Tipo_UsuarioIn,
            this.dataGridViewTextBoxColumn9,
            this.CModificarUsIn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListaUsInactivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGListaUsInactivos.GridColor = System.Drawing.Color.Black;
            this.DGListaUsInactivos.Location = new System.Drawing.Point(1, 2);
            this.DGListaUsInactivos.Name = "DGListaUsInactivos";
            this.DGListaUsInactivos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGListaUsInactivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DGListaUsInactivos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGListaUsInactivos.Size = new System.Drawing.Size(433, 286);
            this.DGListaUsInactivos.TabIndex = 29;
            this.DGListaUsInactivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaUsInactivos_CellClick);
            // 
            // ID_UsuarioIn
            // 
            this.ID_UsuarioIn.HeaderText = "ID Usuario";
            this.ID_UsuarioIn.Name = "ID_UsuarioIn";
            this.ID_UsuarioIn.ReadOnly = true;
            this.ID_UsuarioIn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // CUILIn
            // 
            this.CUILIn.HeaderText = "CUIL";
            this.CUILIn.Name = "CUILIn";
            this.CUILIn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre de usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Tipo_UsuarioIn
            // 
            this.Tipo_UsuarioIn.HeaderText = "Tipo de usuario";
            this.Tipo_UsuarioIn.Name = "Tipo_UsuarioIn";
            this.Tipo_UsuarioIn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // CModificarUsIn
            // 
            this.CModificarUsIn.HeaderText = "Modificar";
            this.CModificarUsIn.Name = "CModificarUsIn";
            this.CModificarUsIn.ReadOnly = true;
            this.CModificarUsIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CModificarUsIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DGListaUs
            // 
            this.DGListaUs.AllowUserToAddRows = false;
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
            this.ID_Usuario,
            this.Nombre,
            this.Apellido,
            this.CUIL,
            this.Nombre_usuario,
            this.Contraseña,
            this.Correo,
            this.Tipo_usuario,
            this.Activo,
            this.CModificarUs});
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
            this.DGListaUs.ReadOnly = true;
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
            this.DGListaUs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGListaUs_CellClick);
            // 
            // LTituloListaUs
            // 
            this.LTituloListaUs.AutoSize = true;
            this.LTituloListaUs.BackColor = System.Drawing.Color.Transparent;
            this.LTituloListaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloListaUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloListaUs.Location = new System.Drawing.Point(218, 20);
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
            this.PBImgListaUs.Location = new System.Drawing.Point(175, 22);
            this.PBImgListaUs.Name = "PBImgListaUs";
            this.PBImgListaUs.Size = new System.Drawing.Size(47, 41);
            this.PBImgListaUs.TabIndex = 21;
            this.PBImgListaUs.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Activo";
            // 
            // PBackSwitch
            // 
            this.PBackSwitch.BackColor = System.Drawing.Color.Black;
            this.PBackSwitch.Controls.Add(this.BSwitch);
            this.PBackSwitch.Location = new System.Drawing.Point(65, 75);
            this.PBackSwitch.Name = "PBackSwitch";
            this.PBackSwitch.Size = new System.Drawing.Size(57, 29);
            this.PBackSwitch.TabIndex = 33;
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
            this.BBuscador.Location = new System.Drawing.Point(318, 73);
            this.BBuscador.Name = "BBuscador";
            this.BBuscador.Size = new System.Drawing.Size(26, 26);
            this.BBuscador.TabIndex = 28;
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
            this.TBFiltro.Location = new System.Drawing.Point(351, 71);
            this.TBFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TBFiltro.Multiline = false;
            this.TBFiltro.Name = "TBFiltro";
            this.TBFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TBFiltro.PasswordChar = false;
            this.TBFiltro.PlaceholderColor = System.Drawing.Color.Gray;
            this.TBFiltro.PlaceholderText = "Buscar...";
            this.TBFiltro.Size = new System.Drawing.Size(148, 31);
            this.TBFiltro.TabIndex = 29;
            this.TBFiltro.Texts = "";
            this.TBFiltro.UnderlinedStyle = false;
            this.TBFiltro.Paint += new System.Windows.Forms.PaintEventHandler(this.PBuscadorListaUs_Paint);
            // 
            // BShowRegistrar
            // 
            this.BShowRegistrar.BackColor = System.Drawing.Color.Black;
            this.BShowRegistrar.BackgroundColor = System.Drawing.Color.Black;
            this.BShowRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BShowRegistrar.BackgroundImage")));
            this.BShowRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            this.BDescargarListUs.Click += new System.EventHandler(this.BDescargarListUs_Click);
            // 
            // MovSwich
            // 
            this.MovSwich.Interval = 1;
            this.MovSwich.Tick += new System.EventHandler(this.MovSwitch_Tick);
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.HeaderText = "ID Usuario";
            this.ID_Usuario.Name = "ID_Usuario";
            this.ID_Usuario.ReadOnly = true;
            this.ID_Usuario.Visible = false;
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
            // CUIL
            // 
            this.CUIL.HeaderText = "CUIL";
            this.CUIL.Name = "CUIL";
            this.CUIL.ReadOnly = true;
            // 
            // Nombre_usuario
            // 
            this.Nombre_usuario.HeaderText = "Nombre de usuario";
            this.Nombre_usuario.Name = "Nombre_usuario";
            this.Nombre_usuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Tipo_usuario
            // 
            this.Tipo_usuario.HeaderText = "Tipo de usuario";
            this.Tipo_usuario.Name = "Tipo_usuario";
            this.Tipo_usuario.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            // 
            // CModificarUs
            // 
            this.CModificarUs.HeaderText = "Modificar";
            this.CModificarUs.Name = "CModificarUs";
            this.CModificarUs.ReadOnly = true;
            this.CModificarUs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CModificarUs.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListaUsuario
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
            this.Load += new System.EventHandler(this.ListaUsuario_Load);
            this.PContListaUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUsInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGListaUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgListaUs)).EndInit();
            this.PBackSwitch.ResumeLayout(false);
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
        private RJButton BBuscador;
        private RJControls.RJTextBox_radio_ TBFiltro;
        private System.Windows.Forms.DataGridView DGListaUsInactivos;
        private RJButton BSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PBackSwitch;
        private System.Windows.Forms.Timer MovSwich;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UsuarioIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUILIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_UsuarioIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewButtonColumn CModificarUsIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewButtonColumn CModificarUs;
    }
}