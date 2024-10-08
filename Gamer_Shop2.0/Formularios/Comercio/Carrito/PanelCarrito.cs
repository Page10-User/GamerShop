﻿using Gamer_Shop2._0.Formularios.GestionCliente;
using Gamer_Shop2._0.Formularios.GestionVenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamer_Shop2._0.Formularios.Comercio.Carrito
{
    public partial class PanelCarrito : Form
    {
        private int borderRadius = 5; // Radio del borde redondeado
        private int borderWidth = 3; // Grosor del borde

        public List<int> idPrCr { get; set; }

        public Panel PanelContainerCr { get; set; }
        public Panel PanelContainer {  get; set; }
        public Catalogo MainCatalogo { get; set; }
        public Form FondoOscuro { get; set; }

        public Bienvenida MainForm {  get; set; }
        public PanelCarrito()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(PanelCarrito_Load);
        }

        private void PanelCarrito_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
            FLPContenidoPrCarrito.Controls.Clear();

            //Cargar productos al carrito.
            for (int i = 0;  i < idPrCr.Count; i++)
            {
                BotonesArticuloCr ArticuloCr = new BotonesArticuloCr();
                ArticuloCr.EliminarDelCarritoClick += BEliminarPrCarrito_Click;
                FLPContenidoPrCarrito.Controls.Add(ArticuloCr);
                ArticuloCr.TBCantidadPr.Text = "1";
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
            using (Pen pen = new Pen(Color.SpringGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BExitCarrito_Click(object sender, EventArgs e)
        {
            PanelContainerCr.Controls.Clear();
            PanelContainerCr.SendToBack();
            FondoOscuro.Close();
            MainForm.FondoOscuroCatalogo = null;
            this.Close();
        }

        public event EventHandler<int> EliminarPrCarritoClick;
        private void BEliminarPrCarrito_Click(object sender, int num)
        {
            //Pasamos el id del producto al catálogo.
            EliminarPrCarritoClick?.Invoke(this, num);
        }

        private void BRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (VerificarSiHayProductosCargados() == 0)
            {
                MessageBox.Show(new Form { TopMost = true }, "Debe cargar como mínimo un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show(new Form { TopMost = true }, "Está seguro que quiere realizar la venta?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InstanciarYMostrarAltaVenta();
                }
            }
        }

        private void InstanciarYMostrarAltaVenta()
        {
            AltaVenta AltaVn = new AltaVenta();
            AltaVn.TopLevel = false;

            // Limpiar el panel actual y añadir el nuevo formulario
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(AltaVn);
            AltaVn.PanelContainer = PanelContainer;
            AltaVn.MainForm = MainForm;
            AltaVn.Show();
            FondoOscuro.Close();
            MainForm.FondoOscuroCatalogo = null;
            MainCatalogo.Close();
        }

        private int VerificarSiHayProductosCargados()
        {
            int contador = 0;

            // Recorremos todos los controles del FlowLayoutPanel
            foreach (Control control in FLPContenidoPrCarrito.Controls)
            {
                if (control is BotonesArticuloCr)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
