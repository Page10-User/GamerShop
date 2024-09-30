using Gamer_Shop2._0.RJControls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gamer_Shop2._0.Formularios.Gestion_Compra
{
    public partial class AltaCompra : Form
    {
        private int borderRadius = 100; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }

        public AltaCompra()
        {
            InitializeComponent();
            this.Padding = new Padding(borderWidth); // Añade un relleno para el borde redondeado
            this.Load += new EventHandler(EditarPerfil_Load);
            PContAltaCompra.Paint += new PaintEventHandler(PContAltaCompra_Paint);
            PContAltaListaCompra.Paint += new PaintEventHandler(PContAltaCompra_Paint);
            PListaPrCompra.Paint += new PaintEventHandler(PListaPrCompra_Paint);
        }

        private void PContAltaCompra_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 60;
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

        private void PListaPrCompra_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                GraphicsPath path = new GraphicsPath();
                int borderRadius = 1;
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90);
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90);
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90);
                path.CloseFigure();


                panel.Region = new Region(path);
                using (Pen pen = new Pen(Color.LightGreen, 4))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void EditarPerfil_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();
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
            using (Pen pen = new Pen(Color.LightGreen, borderWidth))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void BListaDeCompras_Click(object sender, EventArgs e)
        {
            // Mostrar form
            ListaCompra formListCo = new ListaCompra();
            formListCo.TopLevel = false;
            formListCo.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formListCo);
            PanelContainer.BringToFront();

            formListCo.Show();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }

        //Validaciones

        //Validación Inicio NombrePrCompra
        private void TBNombrePrCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBNombrePrCompra.Texts.Trim().Length < 35;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBNombrePrCompra_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (TBNombrePrCompra.Texts.Length >= 35)
                {
                    e.Cancel = true;
                    TBValidacion.Visible = true;

                }
                else
                {
                    TBValidacion.Visible = false;
                }
            }
        }
        //Validación Fin NombrePrCompra

        //Validación Inicio CantidadPrCompra
        private void TBCantidadPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                long number;
                if (!long.TryParse(TBCantidadPrCompra.Texts, out number))
                {
                    e.Cancel = true;
                    TBValidacion2.Visible = true;
                }
                else
                {
                    TBValidacion2.Visible = false;
                }
            }
        }
        //Validación Fin CantidadPrCompra

        //Validación Inicio PrecioPrCompra
        private void TBPrecioPrCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as RJTextBox;
            bool escontrol = Char.IsControl(e.KeyChar);
            bool longitud = TBPrecioPrCompra.Texts.Trim().Length < 25;

            if (longitud || escontrol)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TBNumberPrCompra_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                float number;
                if (!float.TryParse(TBPrecioPrCompra.Texts, out number))
                {
                    e.Cancel = true;
                    TBValidacion3.Visible = true;
                }
                else
                {
                    TBValidacion3.Visible = false;
                }
            }
        }
        //Validacion Fin precioPrCompra

        //Validación Inicio CategoriaProveedor
        private void CBCategoriaPr_Validating(object sender, CancelEventArgs e)
        {
            if (this != null)
            {
                if (CBCategoriaPr.SelectedIndex == -1)
                {
                    e.Cancel = true;
                    TBValidacion4.Visible = true;
                }
                else
                {
                    TBValidacion4.Visible = false;
                }
            }
        }
        //Validación Fin CategoriaProveedor

        private void BComprar_Click(object sender, EventArgs e)
        {
            if (DGListaPrCompra.Rows.Count == 0 || DGListaPrCompra.Rows.Count == 1 && DGListaPrCompra.Rows[0].IsNewRow)
            {
                MessageBox.Show("Debe cargar por lo menos 1 producto", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CBCategoriaPr.SelectedIndex != -1)
                {
                    MessageBox.Show("Compra registrada con éxito", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGListaPrCompra.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un proveedor para registrar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //Validación Fin PrecioPrCompra
        private void BAgregarPrLista_Click(object sender, EventArgs e)
        {
            if (TBNombrePrCompra.Texts != string.Empty && TBPrecioPrCompra.Texts != string.Empty && TBCantidadPrCompra.Texts != string.Empty)
            {
                // Leer los valores de los TextBox
                string nombre = TBNombrePrCompra.Texts;
                int cantidad;
                decimal precio;

                // Validar que los campos de cantidad y precio son válidos
                if (int.TryParse(TBCantidadPrCompra.Texts, out cantidad) && decimal.TryParse(TBPrecioPrCompra.Texts, out precio))
                {
                    // Calcular el total
                    decimal total = cantidad * precio;

                    // Agregar los valores al DataGridView
                    DGListaPrCompra.Rows.Add(nombre, cantidad, precio, total);

                    // Limpiar los TextBox después de agregar el producto
                    TBNombrePrCompra.Texts = "";
                    TBCantidadPrCompra.Texts = "";
                    TBPrecioPrCompra.Texts = "";
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para cargar un producto", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGListaPr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGListaPrCompra.Columns["CEliminarPr"].Index && e.RowIndex >= 0)
            {
                DialogResult = MessageBox.Show("Está seguro que desea eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.Yes)
                {
                    DGListaPrCompra.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}