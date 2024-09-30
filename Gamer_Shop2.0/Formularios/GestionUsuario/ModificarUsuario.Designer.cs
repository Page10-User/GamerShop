namespace Gamer_Shop2._0.Formularios.GestionUsuario
{
    partial class ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.PContModificarUs = new System.Windows.Forms.Panel();
            this.TEmailUs = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TNombreUsuario = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TCuilUs = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TApellidoUs = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TNombreUs = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.TBValidacion6 = new System.Windows.Forms.Label();
            this.TBValidacion5 = new System.Windows.Forms.Label();
            this.TBValidacion4 = new System.Windows.Forms.Label();
            this.TBValidacion3 = new System.Windows.Forms.Label();
            this.TBValidacion2 = new System.Windows.Forms.Label();
            this.TBValidacion = new System.Windows.Forms.Label();
            this.TContraseñaUs = new Gamer_Shop2._0.RJControls.RJTextBox();
            this.LContraseñaUs = new System.Windows.Forms.Label();
            this.LEmailUs = new System.Windows.Forms.Label();
            this.LNombreUsuario = new System.Windows.Forms.Label();
            this.LApellidoUs = new System.Windows.Forms.Label();
            this.LCuilUs = new System.Windows.Forms.Label();
            this.LNombreUs = new System.Windows.Forms.Label();
            this.LTituloModificarUs = new System.Windows.Forms.Label();
            this.PBImgModificarUs = new System.Windows.Forms.PictureBox();
            this.BReturnToBack = new Gamer_Shop2._0.RJButton();
            this.BModificarUs = new Gamer_Shop2._0.RJButton();
            this.PContModificarUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgModificarUs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(497, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modificar";
            // 
            // PContModificarUs
            // 
            this.PContModificarUs.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PContModificarUs.Controls.Add(this.TEmailUs);
            this.PContModificarUs.Controls.Add(this.TNombreUsuario);
            this.PContModificarUs.Controls.Add(this.TCuilUs);
            this.PContModificarUs.Controls.Add(this.TApellidoUs);
            this.PContModificarUs.Controls.Add(this.TNombreUs);
            this.PContModificarUs.Controls.Add(this.TBValidacion6);
            this.PContModificarUs.Controls.Add(this.TBValidacion5);
            this.PContModificarUs.Controls.Add(this.TBValidacion4);
            this.PContModificarUs.Controls.Add(this.TBValidacion3);
            this.PContModificarUs.Controls.Add(this.TBValidacion2);
            this.PContModificarUs.Controls.Add(this.TBValidacion);
            this.PContModificarUs.Controls.Add(this.TContraseñaUs);
            this.PContModificarUs.Controls.Add(this.LContraseñaUs);
            this.PContModificarUs.Controls.Add(this.LEmailUs);
            this.PContModificarUs.Controls.Add(this.LNombreUsuario);
            this.PContModificarUs.Controls.Add(this.LApellidoUs);
            this.PContModificarUs.Controls.Add(this.LCuilUs);
            this.PContModificarUs.Controls.Add(this.LNombreUs);
            this.PContModificarUs.Location = new System.Drawing.Point(100, 107);
            this.PContModificarUs.Name = "PContModificarUs";
            this.PContModificarUs.Size = new System.Drawing.Size(315, 297);
            this.PContModificarUs.TabIndex = 23;
            // 
            // TEmailUs
            // 
            this.TEmailUs.BackColor = System.Drawing.Color.Black;
            this.TEmailUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TEmailUs.BorderFocusColor = System.Drawing.Color.Lime;
            this.TEmailUs.BorderSize = 2;
            this.TEmailUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEmailUs.ForeColor = System.Drawing.Color.White;
            this.TEmailUs.Location = new System.Drawing.Point(129, 198);
            this.TEmailUs.Margin = new System.Windows.Forms.Padding(4);
            this.TEmailUs.Multiline = false;
            this.TEmailUs.Name = "TEmailUs";
            this.TEmailUs.Padding = new System.Windows.Forms.Padding(7);
            this.TEmailUs.PasswordChar = false;
            this.TEmailUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TEmailUs.PlaceholderText = "";
            this.TEmailUs.Size = new System.Drawing.Size(172, 31);
            this.TEmailUs.TabIndex = 17;
            this.TEmailUs.Texts = "";
            this.TEmailUs.UnderlinedStyle = true;
            this.TEmailUs._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TEmailUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TEmailUs_KeyPress);
            this.TEmailUs.Validating += new System.ComponentModel.CancelEventHandler(this.TEmailUs_Validating);
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.BackColor = System.Drawing.Color.Black;
            this.TNombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TNombreUsuario.BorderFocusColor = System.Drawing.Color.Lime;
            this.TNombreUsuario.BorderSize = 2;
            this.TNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.TNombreUsuario.Location = new System.Drawing.Point(129, 150);
            this.TNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreUsuario.Multiline = false;
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.TNombreUsuario.PasswordChar = false;
            this.TNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TNombreUsuario.PlaceholderText = "";
            this.TNombreUsuario.Size = new System.Drawing.Size(172, 31);
            this.TNombreUsuario.TabIndex = 15;
            this.TNombreUsuario.Texts = "";
            this.TNombreUsuario.UnderlinedStyle = true;
            this.TNombreUsuario._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TLoginUs_KeyPress);
            this.TNombreUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TUsuarioUs_Validating);
            // 
            // TCuilUs
            // 
            this.TCuilUs.BackColor = System.Drawing.Color.Black;
            this.TCuilUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TCuilUs.BorderFocusColor = System.Drawing.Color.Lime;
            this.TCuilUs.BorderSize = 2;
            this.TCuilUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCuilUs.ForeColor = System.Drawing.Color.White;
            this.TCuilUs.Location = new System.Drawing.Point(129, 103);
            this.TCuilUs.Margin = new System.Windows.Forms.Padding(4);
            this.TCuilUs.Multiline = false;
            this.TCuilUs.Name = "TCuilUs";
            this.TCuilUs.Padding = new System.Windows.Forms.Padding(7);
            this.TCuilUs.PasswordChar = false;
            this.TCuilUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TCuilUs.PlaceholderText = "";
            this.TCuilUs.Size = new System.Drawing.Size(172, 31);
            this.TCuilUs.TabIndex = 14;
            this.TCuilUs.Texts = "";
            this.TCuilUs.UnderlinedStyle = true;
            this.TCuilUs._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TCuilUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCuilUs_KeyPress);
            this.TCuilUs.Validating += new System.ComponentModel.CancelEventHandler(this.TCuilUs_Validating);
            // 
            // TApellidoUs
            // 
            this.TApellidoUs.BackColor = System.Drawing.Color.Black;
            this.TApellidoUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TApellidoUs.BorderFocusColor = System.Drawing.Color.Lime;
            this.TApellidoUs.BorderSize = 2;
            this.TApellidoUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellidoUs.ForeColor = System.Drawing.Color.White;
            this.TApellidoUs.Location = new System.Drawing.Point(129, 57);
            this.TApellidoUs.Margin = new System.Windows.Forms.Padding(4);
            this.TApellidoUs.Multiline = true;
            this.TApellidoUs.Name = "TApellidoUs";
            this.TApellidoUs.Padding = new System.Windows.Forms.Padding(7);
            this.TApellidoUs.PasswordChar = false;
            this.TApellidoUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TApellidoUs.PlaceholderText = "";
            this.TApellidoUs.Size = new System.Drawing.Size(172, 31);
            this.TApellidoUs.TabIndex = 13;
            this.TApellidoUs.Texts = "";
            this.TApellidoUs.UnderlinedStyle = true;
            this.TApellidoUs._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TApellidoUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellidoUs_KeyPress);
            this.TApellidoUs.Validating += new System.ComponentModel.CancelEventHandler(this.TApellidoUs_Validating);
            // 
            // TNombreUs
            // 
            this.TNombreUs.BackColor = System.Drawing.Color.Black;
            this.TNombreUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TNombreUs.BorderFocusColor = System.Drawing.Color.Lime;
            this.TNombreUs.BorderSize = 2;
            this.TNombreUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombreUs.ForeColor = System.Drawing.Color.White;
            this.TNombreUs.Location = new System.Drawing.Point(129, 9);
            this.TNombreUs.Margin = new System.Windows.Forms.Padding(4);
            this.TNombreUs.Multiline = false;
            this.TNombreUs.Name = "TNombreUs";
            this.TNombreUs.Padding = new System.Windows.Forms.Padding(7);
            this.TNombreUs.PasswordChar = false;
            this.TNombreUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TNombreUs.PlaceholderText = "";
            this.TNombreUs.Size = new System.Drawing.Size(172, 31);
            this.TNombreUs.TabIndex = 12;
            this.TNombreUs.Texts = "";
            this.TNombreUs.UnderlinedStyle = true;
            this.TNombreUs._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TNombreUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombreUs_KeyPress);
            this.TNombreUs.Validating += new System.ComponentModel.CancelEventHandler(this.TNombreUs_Validating);
            // 
            // TBValidacion6
            // 
            this.TBValidacion6.AutoSize = true;
            this.TBValidacion6.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion6.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion6.Location = new System.Drawing.Point(82, 273);
            this.TBValidacion6.Name = "TBValidacion6";
            this.TBValidacion6.Size = new System.Drawing.Size(220, 14);
            this.TBValidacion6.TabIndex = 26;
            this.TBValidacion6.Text = "La contraseña debe tener de 7 a 20 carácteres.";
            this.TBValidacion6.Visible = false;
            // 
            // TBValidacion5
            // 
            this.TBValidacion5.AutoSize = true;
            this.TBValidacion5.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion5.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion5.Location = new System.Drawing.Point(180, 229);
            this.TBValidacion5.Name = "TBValidacion5";
            this.TBValidacion5.Size = new System.Drawing.Size(122, 14);
            this.TBValidacion5.TabIndex = 25;
            this.TBValidacion5.Text = "Ingrese un correo válido.";
            this.TBValidacion5.Visible = false;
            // 
            // TBValidacion4
            // 
            this.TBValidacion4.AutoSize = true;
            this.TBValidacion4.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion4.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion4.Location = new System.Drawing.Point(100, 182);
            this.TBValidacion4.Name = "TBValidacion4";
            this.TBValidacion4.Size = new System.Drawing.Size(202, 14);
            this.TBValidacion4.TabIndex = 24;
            this.TBValidacion4.Text = "El usuario debe tener de 7 a 20 carácteres.";
            this.TBValidacion4.Visible = false;
            // 
            // TBValidacion3
            // 
            this.TBValidacion3.AutoSize = true;
            this.TBValidacion3.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion3.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion3.Location = new System.Drawing.Point(136, 134);
            this.TBValidacion3.Name = "TBValidacion3";
            this.TBValidacion3.Size = new System.Drawing.Size(166, 14);
            this.TBValidacion3.TabIndex = 22;
            this.TBValidacion3.Text = "Ingrese un número de CUIL válido.";
            this.TBValidacion3.Visible = false;
            // 
            // TBValidacion2
            // 
            this.TBValidacion2.AutoSize = true;
            this.TBValidacion2.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion2.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion2.Location = new System.Drawing.Point(97, 92);
            this.TBValidacion2.Name = "TBValidacion2";
            this.TBValidacion2.Size = new System.Drawing.Size(215, 14);
            this.TBValidacion2.TabIndex = 21;
            this.TBValidacion2.Text = "El apellido no debe superar los 35 carácteres.";
            this.TBValidacion2.Visible = false;
            // 
            // TBValidacion
            // 
            this.TBValidacion.AutoSize = true;
            this.TBValidacion.Font = new System.Drawing.Font("Microsoft YaHei", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBValidacion.ForeColor = System.Drawing.Color.Lime;
            this.TBValidacion.Location = new System.Drawing.Point(98, 39);
            this.TBValidacion.Name = "TBValidacion";
            this.TBValidacion.Size = new System.Drawing.Size(214, 14);
            this.TBValidacion.TabIndex = 20;
            this.TBValidacion.Text = "El nombre no debe superar los 35 carácteres.";
            this.TBValidacion.Visible = false;
            // 
            // TContraseñaUs
            // 
            this.TContraseñaUs.BackColor = System.Drawing.Color.Black;
            this.TContraseñaUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TContraseñaUs.BorderFocusColor = System.Drawing.Color.Lime;
            this.TContraseñaUs.BorderSize = 2;
            this.TContraseñaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TContraseñaUs.ForeColor = System.Drawing.Color.White;
            this.TContraseñaUs.Location = new System.Drawing.Point(129, 242);
            this.TContraseñaUs.Margin = new System.Windows.Forms.Padding(4);
            this.TContraseñaUs.Multiline = false;
            this.TContraseñaUs.Name = "TContraseñaUs";
            this.TContraseñaUs.Padding = new System.Windows.Forms.Padding(7);
            this.TContraseñaUs.PasswordChar = true;
            this.TContraseñaUs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TContraseñaUs.PlaceholderText = "";
            this.TContraseñaUs.Size = new System.Drawing.Size(172, 31);
            this.TContraseñaUs.TabIndex = 18;
            this.TContraseñaUs.Texts = "";
            this.TContraseñaUs.UnderlinedStyle = true;
            this.TContraseñaUs._TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TContraseñaUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TLoginUs_KeyPress);
            this.TContraseñaUs.Validating += new System.ComponentModel.CancelEventHandler(this.TContraseñaUs_Validating);
            // 
            // LContraseñaUs
            // 
            this.LContraseñaUs.AutoSize = true;
            this.LContraseñaUs.BackColor = System.Drawing.Color.Transparent;
            this.LContraseñaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseñaUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LContraseñaUs.Location = new System.Drawing.Point(13, 255);
            this.LContraseñaUs.Name = "LContraseñaUs";
            this.LContraseñaUs.Size = new System.Drawing.Size(85, 18);
            this.LContraseñaUs.TabIndex = 16;
            this.LContraseñaUs.Text = "Contraseña";
            // 
            // LEmailUs
            // 
            this.LEmailUs.AutoSize = true;
            this.LEmailUs.BackColor = System.Drawing.Color.Transparent;
            this.LEmailUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmailUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LEmailUs.Location = new System.Drawing.Point(13, 211);
            this.LEmailUs.Name = "LEmailUs";
            this.LEmailUs.Size = new System.Drawing.Size(45, 18);
            this.LEmailUs.TabIndex = 11;
            this.LEmailUs.Text = "Email";
            // 
            // LNombreUsuario
            // 
            this.LNombreUsuario.AutoSize = true;
            this.LNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreUsuario.Location = new System.Drawing.Point(13, 163);
            this.LNombreUsuario.Name = "LNombreUsuario";
            this.LNombreUsuario.Size = new System.Drawing.Size(81, 18);
            this.LNombreUsuario.TabIndex = 10;
            this.LNombreUsuario.Text = "NombreUs";
            // 
            // LApellidoUs
            // 
            this.LApellidoUs.AutoSize = true;
            this.LApellidoUs.BackColor = System.Drawing.Color.Transparent;
            this.LApellidoUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LApellidoUs.Location = new System.Drawing.Point(16, 70);
            this.LApellidoUs.Name = "LApellidoUs";
            this.LApellidoUs.Size = new System.Drawing.Size(59, 18);
            this.LApellidoUs.TabIndex = 9;
            this.LApellidoUs.Text = "Apellido";
            // 
            // LCuilUs
            // 
            this.LCuilUs.AutoSize = true;
            this.LCuilUs.BackColor = System.Drawing.Color.Transparent;
            this.LCuilUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCuilUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LCuilUs.Location = new System.Drawing.Point(16, 111);
            this.LCuilUs.Name = "LCuilUs";
            this.LCuilUs.Size = new System.Drawing.Size(33, 18);
            this.LCuilUs.TabIndex = 8;
            this.LCuilUs.Text = "Cuil";
            // 
            // LNombreUs
            // 
            this.LNombreUs.AutoSize = true;
            this.LNombreUs.BackColor = System.Drawing.Color.Transparent;
            this.LNombreUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LNombreUs.Location = new System.Drawing.Point(16, 22);
            this.LNombreUs.Name = "LNombreUs";
            this.LNombreUs.Size = new System.Drawing.Size(62, 18);
            this.LNombreUs.TabIndex = 7;
            this.LNombreUs.Text = "Nombre";
            // 
            // LTituloModificarUs
            // 
            this.LTituloModificarUs.AutoSize = true;
            this.LTituloModificarUs.BackColor = System.Drawing.Color.Transparent;
            this.LTituloModificarUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloModificarUs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTituloModificarUs.Location = new System.Drawing.Point(185, 39);
            this.LTituloModificarUs.Name = "LTituloModificarUs";
            this.LTituloModificarUs.Size = new System.Drawing.Size(325, 42);
            this.LTituloModificarUs.TabIndex = 22;
            this.LTituloModificarUs.Text = "Modificar Usuario";
            // 
            // PBImgModificarUs
            // 
            this.PBImgModificarUs.BackColor = System.Drawing.Color.Transparent;
            this.PBImgModificarUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBImgModificarUs.BackgroundImage")));
            this.PBImgModificarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBImgModificarUs.Location = new System.Drawing.Point(119, 40);
            this.PBImgModificarUs.Name = "PBImgModificarUs";
            this.PBImgModificarUs.Size = new System.Drawing.Size(47, 41);
            this.PBImgModificarUs.TabIndex = 21;
            this.PBImgModificarUs.TabStop = false;
            // 
            // BReturnToBack
            // 
            this.BReturnToBack.BackColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BReturnToBack.BackgroundImage")));
            this.BReturnToBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BReturnToBack.BorderColor = System.Drawing.Color.Lime;
            this.BReturnToBack.BorderRadius = 17;
            this.BReturnToBack.BorderSize = 1;
            this.BReturnToBack.FlatAppearance.BorderSize = 0;
            this.BReturnToBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReturnToBack.ForeColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.Location = new System.Drawing.Point(629, 12);
            this.BReturnToBack.Name = "BReturnToBack";
            this.BReturnToBack.Size = new System.Drawing.Size(34, 34);
            this.BReturnToBack.TabIndex = 27;
            this.BReturnToBack.TextColor = System.Drawing.Color.Transparent;
            this.BReturnToBack.UseVisualStyleBackColor = false;
            this.BReturnToBack.Click += new System.EventHandler(this.BReturnToBack_Click);
            // 
            // BModificarUs
            // 
            this.BModificarUs.BackColor = System.Drawing.Color.Black;
            this.BModificarUs.BackgroundColor = System.Drawing.Color.Black;
            this.BModificarUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BModificarUs.BackgroundImage")));
            this.BModificarUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BModificarUs.BorderColor = System.Drawing.Color.Lime;
            this.BModificarUs.BorderRadius = 20;
            this.BModificarUs.BorderSize = 2;
            this.BModificarUs.FlatAppearance.BorderSize = 0;
            this.BModificarUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BModificarUs.ForeColor = System.Drawing.Color.White;
            this.BModificarUs.Location = new System.Drawing.Point(493, 148);
            this.BModificarUs.Name = "BModificarUs";
            this.BModificarUs.Size = new System.Drawing.Size(84, 76);
            this.BModificarUs.TabIndex = 24;
            this.BModificarUs.TextColor = System.Drawing.Color.White;
            this.BModificarUs.UseVisualStyleBackColor = false;
            this.BModificarUs.Click += new System.EventHandler(this.BModificarUs_Click);
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 436);
            this.Controls.Add(this.BReturnToBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BModificarUs);
            this.Controls.Add(this.PContModificarUs);
            this.Controls.Add(this.LTituloModificarUs);
            this.Controls.Add(this.PBImgModificarUs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarUsuario";
            this.Text = " ";
            this.PContModificarUs.ResumeLayout(false);
            this.PContModificarUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImgModificarUs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJButton BModificarUs;
        private System.Windows.Forms.Panel PContModificarUs;
        private RJControls.RJTextBox TContraseñaUs;
        private RJControls.RJTextBox TEmailUs;
        private System.Windows.Forms.Label LContraseñaUs;
        private RJControls.RJTextBox TNombreUsuario;
        private RJControls.RJTextBox TCuilUs;
        private RJControls.RJTextBox TApellidoUs;
        private RJControls.RJTextBox TNombreUs;
        private System.Windows.Forms.Label LEmailUs;
        private System.Windows.Forms.Label LNombreUsuario;
        private System.Windows.Forms.Label LApellidoUs;
        private System.Windows.Forms.Label LCuilUs;
        private System.Windows.Forms.Label LNombreUs;
        private System.Windows.Forms.Label LTituloModificarUs;
        private System.Windows.Forms.PictureBox PBImgModificarUs;
        private RJButton BReturnToBack;
        private System.Windows.Forms.Label TBValidacion;
        private System.Windows.Forms.Label TBValidacion2;
        private System.Windows.Forms.Label TBValidacion3;
        private System.Windows.Forms.Label TBValidacion4;
        private System.Windows.Forms.Label TBValidacion5;
        private System.Windows.Forms.Label TBValidacion6;
    }
}