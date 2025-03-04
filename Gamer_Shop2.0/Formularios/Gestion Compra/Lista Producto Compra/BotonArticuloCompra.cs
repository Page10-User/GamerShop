﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Comercio
{
    public partial class BotonArticuloCompra : UserControl
    {

        private int borderRadius = 1; // Radio del borde redondeado
        private int borderWidth = 2; // Grosor del borde
        private int serial = 0;
        private string descripcion = "Descripción del Producto";
        private string photoFilePath;

        public Panel PanelContainer { get; set; }
        public Catalogo MainCatalogo { get; set; }
        public Bienvenida MainForm { get; set; }

        public BotonArticuloCompra()
        {
            InitializeComponent();
            PBfotoPr.Paint += new PaintEventHandler(PFotoPr_Paint);
            this.Load += new EventHandler(BotonArticuloCompra_Load);
        }

        private void BotonArticuloCompra_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            //Aplicamos la imagen (si tiene)
            if (PhotoFilePath is null || PhotoFilePath == string.Empty)
            {
                PBfotoPr.Image = Image.FromFile(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\imagen_default.png")));
                PBfotoPr.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\uploads\" + photoFilePath);
                PBfotoPr.Image = Image.FromFile(imagePath);
                PBfotoPr.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private GraphicsPath CreateRoundedPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Agregar los arcos para las esquinas redondeadas
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
            path.AddArc(new Rectangle(this.ClientSize.Width - borderRadius, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.ClientSize.Height - borderRadius, borderRadius, borderRadius), 90, 90);

            path.CloseFigure();

            return path;
        }

        private Region CreateRoundedRegion()
        {
            GraphicsPath path = CreateRoundedPath();
            return new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // dibujar el borde redondeado
            GraphicsPath path = CreateRoundedPath();
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(Color.Transparent, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        //Methots
        public int Serial
        {
            get { return serial; }
            set { serial = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string NombreProducto
        {
            get { return LNombreProducto.Text; }
            set { LNombreProducto.Text = value; }
        }

        public string Categoria
        {
            get { return LCategoria.Text; }
            set { LCategoria.Text = value; }
        }

        public Image ImgProducto
        {
            get { return PBfotoPr.Image; }
            set { PBfotoPr.Image = value; }
        }

        public string Precio
        {
            get { return LPrecio.Text; }
            set { LPrecio.Text = value; }
        }

        public string PhotoFilePath
        {
            get { return photoFilePath; }
            set { photoFilePath = value; }
        }
        //End Methot

        private void PFotoPr_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 10;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public event EventHandler<int> AgregarAlDataGrid;

        private void BCompra_Click(object sender, EventArgs e)
        {
            AgregarAlDataGrid?.Invoke(this, Serial);
        }
    }
}