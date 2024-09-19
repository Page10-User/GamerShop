namespace Gamer_Shop2._0.Formularios.GestionProducto
{
    partial class ModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.PContModificarPr = new System.Windows.Forms.Panel();
            this.TPrecioPr = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TDescripcionPr = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TNombrePr = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TBValidacion4 = new System.Windows.Forms.Label();
            this.TBValidacion3 = new System.Windows.Forms.Label();
            this.TBValidacion2 = new System.Windows.Forms.Label();
            this.TBValidacion = new System.Windows.Forms.Label();
            this.CBCategoriaPr = new Gamer_Shop2._0.RJControls.RJComboBox();
            this.TStockPr = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.LCategoriaPr = new System.Windows.Forms.Label();
            this.LStockPr = new System.Windows.Forms.Label();
            this.LDescripcionPr = new System.Windows.Forms.Label();
            this.LPrecioPr = new System.Windows.Forms.Label();
            this.LNombrePr = new System.Windows.Forms.Label();
            this.LTituloModificarPr = new System.Windows.Forms.Label();
            this.PBImgModificarPr = new System.Windows.Forms.PictureBox();
            this.BReturnToBack = new Gamer_Shop2._0.RJButton();
            this.BModificarPr = new Gamer_Shop2._0.RJButton();
            this.PContModificarPr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgModificarPr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(514, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modificar";
            // 
            // PContModificarPr
            // 
            this.PContModificarPr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContModificarPr.Controls.Add(this.TStockPr);
            this.PContModificarPr.Controls.Add(this.TPrecioPr);
            this.PContModificarPr.Controls.Add(this.TDescripcionPr);
            this.PContModificarPr.Controls.Add(this.TNombrePr);
            this.PContModificarPr.Controls.Add(this.TBValidacion4);
            this.PContModificarPr.Controls.Add(this.TBValidacion3);
            this.PContModificarPr.Controls.Add(this.TBValidacion2);
            this.PContModificarPr.Controls.Add(this.TBValidacion);
            this.PContModificarPr.Controls.Add(this.CBCategoriaPr);
            this.PContModificarPr.Controls.Add(this.LCategoriaPr);
            this.PContModificarPr.Controls.Add(this.LStockPr);
            this.PContModificarPr.Controls.Add(this.LDescripcionPr);
            this.PContModificarPr.Controls.Add(this.LPrecioPr);
            this.PContModificarPr.Controls.Add(this.LNombrePr);
            this.PContModificarPr.Location = new System.Drawing.Point(111, 110);
            this.PContModificarPr.Name = "PContModificarPr";
            this.PContModificarPr.Size = new System.Drawing.Size(315, 290);
            this.PContModificarPr.TabIndex = 9;
            // 
            // TPrecioPr
            // 
            this.TPrecioPr.BackColor = System.Drawing.Color.Black;
            this.TPrecioPr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TPrecioPr.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TPrecioPr.BorderSize = 2;
            this.TPrecioPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPrecioPr.ForeColor = System.Drawing.Color.White;
            this.TPrecioPr.Location = new System.Drawing.Point(128, 103);
            this.TPrecioPr.Margin = new System.Windows.Forms.Padding(4);
            this.TPrecioPr.Multiline = false;
            this.TPrecioPr.Name = "TPrecioPr";
            this.TPrecioPr.Padding = new System.Windows.Forms.Padding(7);
            this.TPrecioPr.PasswordChar = false;
            this.TPrecioPr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TPrecioPr.PlaceholderText = "";
            this.TPrecioPr.Size = new System.Drawing.Size(172, 31);
            this.TPrecioPr.TabIndex = 14;
            this.TPrecioPr.Texts = "";
            this.TPrecioPr.UnderlinedStyle = true;
            this.TPrecioPr._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TPrecioPr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNumberPr_KeyPress);
            this.TPrecioPr.Validating += new System.ComponentModel.CancelEventHandler(this.TPrecioPr_Validating);
            // 
            // TDescripcionPr
            // 
            this.TDescripcionPr.BackColor = System.Drawing.Color.Black;
            this.TDescripcionPr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TDescripcionPr.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TDescripcionPr.BorderSize = 2;
            this.TDescripcionPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDescripcionPr.ForeColor = System.Drawing.Color.White;
            this.TDescripcionPr.Location = new System.Drawing.Point(128, 62);
            this.TDescripcionPr.Margin = new System.Windows.Forms.Padding(4);
            this.TDescripcionPr.Multiline = true;
            this.TDescripcionPr.Name = "TDescripcionPr";
            this.TDescripcionPr.Padding = new System.Windows.Forms.Padding(7);
            this.TDescripcionPr.PasswordChar = false;
            this.TDescripcionPr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TDescripcionPr.PlaceholderText = "";
            this.TDescripcionPr.Size = new System.Drawing.Size(172, 31);
            this.TDescripcionPr.TabIndex = 13;
            this.TDescripcionPr.Texts = "";
            this.TDescripcionPr.UnderlinedStyle = true;
            this.TDescripcionPr._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TDescripcionPr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDescripcionPr_KeyPress);
            this.TDescripcionPr.Validating += new System.ComponentModel.CancelEventHandler(this.TDescripcionPr_Validating);
            // 
            // TNombrePr
            // 
            this.TNombrePr.BackColor = System.Drawing.Color.Black;
            this.TNombrePr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TNombrePr.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TNombrePr.BorderSize = 2;
            this.TNombrePr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombrePr.ForeColor = System.Drawing.Color.White;
            this.TNombrePr.Location = new System.Drawing.Point(128, 21);
            this.TNombrePr.Margin = new System.Windows.Forms.Padding(4);
            this.TNombrePr.Multiline = false;
            this.TNombrePr.Name = "TNombrePr";
            this.TNombrePr.Padding = new System.Windows.Forms.Padding(7);
            this.TNombrePr.PasswordChar = false;
            this.TNombrePr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TNombrePr.PlaceholderText = "";
            this.TNombrePr.Size = new System.Drawing.Size(172, 31);
            this.TNombrePr.TabIndex = 12;
            this.TNombrePr.Texts = "";
            this.TNombrePr.UnderlinedStyle = true;
            this.TNombrePr._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TNombrePr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombrePr_KeyPress);
            this.TNombrePr.Validating += new System.ComponentModel.CancelEventHandler(this.TNombrePr_Validating);
            // 
            // TBValidacion4
            // 
            this.TBValidacion4.AutoSize = true;
            this.TBValidacion4.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TBValidacion4.Location = new System.Drawing.Point(63, 177);
            this.TBValidacion4.Name = "TBValidacion4";
            this.TBValidacion4.Size = new System.Drawing.Size(237, 14);
            this.TBValidacion4.TabIndex = 25;
            this.TBValidacion4.Text = "Ingrese únicamente carácteres numéricos exactos.";
            this.TBValidacion4.Visible = false;
            // 
            // TBValidacion3
            // 
            this.TBValidacion3.AutoSize = true;
            this.TBValidacion3.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TBValidacion3.Location = new System.Drawing.Point(100, 133);
            this.TBValidacion3.Name = "TBValidacion3";
            this.TBValidacion3.Size = new System.Drawing.Size(200, 14);
            this.TBValidacion3.TabIndex = 24;
            this.TBValidacion3.Text = "Ingrese únicamente carácteres numéricos.";
            this.TBValidacion3.Visible = false;
            // 
            // TBValidacion2
            // 
            this.TBValidacion2.AutoSize = true;
            this.TBValidacion2.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TBValidacion2.Location = new System.Drawing.Point(61, 92);
            this.TBValidacion2.Name = "TBValidacion2";
            this.TBValidacion2.Size = new System.Drawing.Size(239, 14);
            this.TBValidacion2.TabIndex = 23;
            this.TBValidacion2.Text = "La descripción no debe superar los 200 carácteres.";
            this.TBValidacion2.Visible = false;
            // 
            // TBValidacion
            // 
            this.TBValidacion.AutoSize = true;
            this.TBValidacion.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TBValidacion.Location = new System.Drawing.Point(86, 51);
            this.TBValidacion.Name = "TBValidacion";
            this.TBValidacion.Size = new System.Drawing.Size(214, 14);
            this.TBValidacion.TabIndex = 22;
            this.TBValidacion.Text = "El nombre no debe superar los 50 carácteres.";
            this.TBValidacion.Visible = false;
            // 
            // CBCategoriaPr
            // 
            this.CBCategoriaPr.BackColor = System.Drawing.Color.Black;
            this.CBCategoriaPr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CBCategoriaPr.BorderSize = 1;
            this.CBCategoriaPr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CBCategoriaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBCategoriaPr.ForeColor = System.Drawing.Color.DimGray;
            this.CBCategoriaPr.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CBCategoriaPr.Items.AddRange(new object[] {
            "xd",
            "procesador",
            "ola",
            "a"});
            this.CBCategoriaPr.ListBackColor = System.Drawing.Color.Black;
            this.CBCategoriaPr.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CBCategoriaPr.Location = new System.Drawing.Point(128, 203);
            this.CBCategoriaPr.MinimumSize = new System.Drawing.Size(30, 30);
            this.CBCategoriaPr.Name = "CBCategoriaPr";
            this.CBCategoriaPr.Padding = new System.Windows.Forms.Padding(1);
            this.CBCategoriaPr.Size = new System.Drawing.Size(172, 30);
            this.CBCategoriaPr.TabIndex = 21;
            this.CBCategoriaPr.Texts = "";
            this.CBCategoriaPr.Validating += new System.ComponentModel.CancelEventHandler(this.CBCategoriaPr_Validating);
            // 
            // TStockPr
            // 
            this.TStockPr.BackColor = System.Drawing.Color.Black;
            this.TStockPr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TStockPr.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TStockPr.BorderSize = 2;
            this.TStockPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TStockPr.ForeColor = System.Drawing.Color.White;
            this.TStockPr.Location = new System.Drawing.Point(128, 148);
            this.TStockPr.Margin = new System.Windows.Forms.Padding(4);
            this.TStockPr.Multiline = false;
            this.TStockPr.Name = "TStockPr";
            this.TStockPr.Padding = new System.Windows.Forms.Padding(7);
            this.TStockPr.PasswordChar = false;
            this.TStockPr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TStockPr.PlaceholderText = "";
            this.TStockPr.Size = new System.Drawing.Size(172, 31);
            this.TStockPr.TabIndex = 15;
            this.TStockPr.Texts = "";
            this.TStockPr.UnderlinedStyle = true;
            this.TStockPr._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TStockPr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNumberPr_KeyPress);
            this.TStockPr.Validating += new System.ComponentModel.CancelEventHandler(this.TStockPr_Validating);
            // 
            // LCategoriaPr
            // 
            this.LCategoriaPr.AutoSize = true;
            this.LCategoriaPr.BackColor = System.Drawing.Color.Transparent;
            this.LCategoriaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoriaPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCategoriaPr.Location = new System.Drawing.Point(15, 210);
            this.LCategoriaPr.Name = "LCategoriaPr";
            this.LCategoriaPr.Size = new System.Drawing.Size(72, 18);
            this.LCategoriaPr.TabIndex = 11;
            this.LCategoriaPr.Text = "Categoría";
            // 
            // LStockPr
            // 
            this.LStockPr.AutoSize = true;
            this.LStockPr.BackColor = System.Drawing.Color.Transparent;
            this.LStockPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStockPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LStockPr.Location = new System.Drawing.Point(15, 161);
            this.LStockPr.Name = "LStockPr";
            this.LStockPr.Size = new System.Drawing.Size(47, 18);
            this.LStockPr.TabIndex = 10;
            this.LStockPr.Text = "Stock";
            // 
            // LDescripcionPr
            // 
            this.LDescripcionPr.AutoSize = true;
            this.LDescripcionPr.BackColor = System.Drawing.Color.Transparent;
            this.LDescripcionPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescripcionPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LDescripcionPr.Location = new System.Drawing.Point(15, 75);
            this.LDescripcionPr.Name = "LDescripcionPr";
            this.LDescripcionPr.Size = new System.Drawing.Size(87, 18);
            this.LDescripcionPr.TabIndex = 9;
            this.LDescripcionPr.Text = "Descripción";
            // 
            // LPrecioPr
            // 
            this.LPrecioPr.AutoSize = true;
            this.LPrecioPr.BackColor = System.Drawing.Color.Transparent;
            this.LPrecioPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LPrecioPr.Location = new System.Drawing.Point(15, 116);
            this.LPrecioPr.Name = "LPrecioPr";
            this.LPrecioPr.Size = new System.Drawing.Size(51, 18);
            this.LPrecioPr.TabIndex = 8;
            this.LPrecioPr.Text = "Precio";
            // 
            // LNombrePr
            // 
            this.LNombrePr.AutoSize = true;
            this.LNombrePr.BackColor = System.Drawing.Color.Transparent;
            this.LNombrePr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombrePr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombrePr.Location = new System.Drawing.Point(15, 34);
            this.LNombrePr.Name = "LNombrePr";
            this.LNombrePr.Size = new System.Drawing.Size(62, 18);
            this.LNombrePr.TabIndex = 7;
            this.LNombrePr.Text = "Nombre";
            // 
            // LTituloModificarPr
            // 
            this.LTituloModificarPr.AutoSize = true;
            this.LTituloModificarPr.BackColor = System.Drawing.Color.Transparent;
            this.LTituloModificarPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloModificarPr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloModificarPr.Location = new System.Drawing.Point(161, 33);
            this.LTituloModificarPr.Name = "LTituloModificarPr";
            this.LTituloModificarPr.Size = new System.Drawing.Size(347, 42);
            this.LTituloModificarPr.TabIndex = 8;
            this.LTituloModificarPr.Text = "Modificar Producto";
            // 
            // PBImgModificarPr
            // 
            this.PBImgModificarPr.BackColor = System.Drawing.Color.Transparent;
            this.PBImgModificarPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgModificarPr.BackgroundImage")));
            this.PBImgModificarPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgModificarPr.Location = new System.Drawing.Point(108, 33);
            this.PBImgModificarPr.Name = "PBImgModificarPr";
            this.PBImgModificarPr.Size = new System.Drawing.Size(47, 41);
            this.PBImgModificarPr.TabIndex = 7;
            this.PBImgModificarPr.TabStop = false;
            // 
            // BReturnToBack
            // 
            this.BReturnToBack.BackColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BReturnToBack.BackgroundImage")));
            this.BReturnToBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BReturnToBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BReturnToBack.BorderRadius = 17;
            this.BReturnToBack.BorderSize = 1;
            this.BReturnToBack.CausesValidation = false;
            this.BReturnToBack.FlatAppearance.BorderSize = 0;
            this.BReturnToBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReturnToBack.ForeColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.Location = new System.Drawing.Point(628, 12);
            this.BReturnToBack.Name = "BReturnToBack";
            this.BReturnToBack.Size = new System.Drawing.Size(34, 34);
            this.BReturnToBack.TabIndex = 13;
            this.BReturnToBack.TextColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.UseVisualStyleBackColor = false;
            this.BReturnToBack.Click += new System.EventHandler(this.BReturnToBack_Click);
            // 
            // BModificarPr
            // 
            this.BModificarPr.BackColor = System.Drawing.Color.Black;
            this.BModificarPr.BackgroundColor = System.Drawing.Color.Black;
            this.BModificarPr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModificarPr.BackgroundImage")));
            this.BModificarPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BModificarPr.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BModificarPr.BorderRadius = 20;
            this.BModificarPr.BorderSize = 1;
            this.BModificarPr.FlatAppearance.BorderSize = 0;
            this.BModificarPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificarPr.ForeColor = System.Drawing.Color.White;
            this.BModificarPr.Location = new System.Drawing.Point(510, 198);
            this.BModificarPr.Name = "BModificarPr";
            this.BModificarPr.Size = new System.Drawing.Size(84, 76);
            this.BModificarPr.TabIndex = 10;
            this.BModificarPr.TextColor = System.Drawing.Color.White;
            this.BModificarPr.UseVisualStyleBackColor = false;
            this.BModificarPr.Click += new System.EventHandler(this.BModificarPr_Click);
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BReturnToBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BModificarPr);
            this.Controls.Add(this.PContModificarPr);
            this.Controls.Add(this.LTituloModificarPr);
            this.Controls.Add(this.PBImgModificarPr);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.PContModificarPr.ResumeLayout(false);
            this.PContModificarPr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgModificarPr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJButton BModificarPr;
        private System.Windows.Forms.Panel PContModificarPr;
        private RJControls.RJTextBox TStockPr;
        private RJControls.RJTextBox TPrecioPr;
        private RJControls.RJTextBox TDescripcionPr;
        private RJControls.RJTextBox TNombrePr;
        private System.Windows.Forms.Label LCategoriaPr;
        private System.Windows.Forms.Label LStockPr;
        private System.Windows.Forms.Label LDescripcionPr;
        private System.Windows.Forms.Label LPrecioPr;
        private System.Windows.Forms.Label LNombrePr;
        private System.Windows.Forms.Label LTituloModificarPr;
        private System.Windows.Forms.PictureBox PBImgModificarPr;
        private RJButton BReturnToBack;
        private RJControls.RJComboBox CBCategoriaPr;
        private System.Windows.Forms.Label TBValidacion;
        private System.Windows.Forms.Label TBValidacion2;
        private System.Windows.Forms.Label TBValidacion3;
        private System.Windows.Forms.Label TBValidacion4;
    }
}