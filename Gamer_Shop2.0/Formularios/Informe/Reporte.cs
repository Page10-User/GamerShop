using Gamer_Shop2._0.Formularios.BorderClasss;
using Gamer_Shop2._0.Formularios.MSGPersonalizado;
using Gamer_Shop2._0.Negocio;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gamer_Shop2._0.Formularios.Informe
{
    public partial class Reporte : Form
    {
        private int borderRadius = 20; // Radio del borde redondeado
        private int borderWidth = 5; // Grosor del borde

        public Panel PanelContainer { get; set; }

        public Reporte()
        {
            InitializeComponent();
            DateTime fechainicio = dateTimePicker1.MinDate;
            DateTime fechafinal = DateTime.Now;
            dateTimePicker1.Value = fechainicio;
            dateTimePicker2.Value = fechafinal;
            CrearGrafico(fechainicio, fechafinal);
            ConfigurarGraficoPie(fechainicio, fechafinal);
            ConfigurarGraficoPieCC(fechainicio, fechafinal);
        }

        public Reporte(DateTime fechainicio, DateTime fechafinal)
        {
            InitializeComponent();
            dateTimePicker1.Value = fechainicio;
            dateTimePicker2.Value = fechafinal;
            CrearGrafico(fechainicio,fechafinal);
            ConfigurarGraficoPie(fechainicio,fechafinal);
            ConfigurarGraficoPieCC(fechainicio, fechafinal);
        }
        private void PTituloReport_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {

                GraphicsPath path = new GraphicsPath();
                int borderRadius = 20;
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

        private void Panel_Paint(object sender, PaintEventArgs e)
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


                using (Pen pen = new Pen(Color.LightGreen, 3))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void BordePanel(Panel panel, Color borderColor, int borderWidth)
        {
            panel.Paint += Panel_Paint;
            panel.Invalidate(); // Forzar repintado
        }

        private void Informe_Load(object sender, EventArgs e)
        {
            // Aplicar la forma redondeada al cargar el formulario
            this.Region = CreateRoundedRegion();

            //Cambiar el color del borde de los páneles restantes.
            BordePanel(panel1, Color.LightGreen, 3);
            BordePanel(panel2, Color.LightGreen, 3);
            BordePanel(panel3, Color.LightGreen, 3);
            BordePanel(panel4, Color.LightGreen, 3);
            BordePanel(panel5, Color.LightGreen, 3);
            BordePanel(panel6, Color.LightGreen, 3);
            BordePanel(panel7, Color.LightGreen, 3);
            BordePanel(panel8, Color.LightGreen, 3);
            BordePanel(panel9, Color.LightGreen, 3);
            BordePanel(panel10, Color.LightGreen, 3);
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

        private void CrearGrafico(DateTime fechainicio, DateTime fechafinal)
        {
            CGraficoVent.Series.Clear();
            Series series = CGraficoVent.Series.Add("Ventas");
            series.ChartType = SeriesChartType.Column;

            NVenta nventa = new NVenta();
            DataTable dataTable = nventa.getVentasUltimaSemana(fechainicio,fechafinal);

            // Colores personalizados para cada barra
            Color[] colores = { Color.Salmon, Color.Khaki, Color.LightGreen, Color.Lime, Color.Cyan, Color.DeepSkyBlue, Color.MediumPurple };

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                
                series.Points.AddXY(dataTable.Rows[i]["Fecha"], dataTable.Rows[i]["TotalVentas"]);
                series.Points[i].Color = colores[i % colores.Length]; // Rotar colores si hay más días que colores

                // Mostrar los valores sobre cada barra
                series.Points[i].Label = dataTable.Rows[i]["TotalVentas"].ToString();
                series.Points[i].LabelForeColor = Color.White;
            }

            // Personalizar el gráfico
            CGraficoVent.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            CGraficoVent.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            CGraficoVent.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            CGraficoVent.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;
            series["PointWidth"] = "0.8";
            CGraficoVent.BackColor = Color.Black;
            CGraficoVent.ChartAreas[0].BackColor = Color.Black;
            CGraficoVent.Legends.Clear();
        }

        private void ConfigurarGraficoPie(DateTime fechainicio, DateTime fechafinal)
        {
            try
            {
                CGraficoPie5P.Series.Clear();
                Series series = CGraficoPie5P.Series.Add("Productos");
                series.ChartType = SeriesChartType.Pie;

                NDetalleVenta nDetalleVenta = new NDetalleVenta();
                DataTable dataTable = nDetalleVenta.getProductosMasVendidos(fechainicio, fechafinal);

                // Agregar datos al gráfico
                foreach (DataRow row in dataTable.Rows)
                {
                    string producto = row["Nombre"].ToString();
                    double totalVendidos = Convert.ToDouble(row["TotalVendidos"]);

                    // Agregar el punto al gráfico
                    int index = series.Points.AddXY(producto, totalVendidos);
                    DataPoint punto = series.Points[index]; // Obtener el punto recién agregado

                    // Configurar etiqueta dentro de la porción del gráfico
                    punto.Label = "#VALY"; // Muestra el valor numérico
                    punto.Font = new Font("Arial", 10, FontStyle.Bold);
                    punto.LabelForeColor = Color.White; // Texto blanco para mayor contraste
                }

                // Configuración para etiquetas dentro del gráfico
                series["PieLabelStyle"] = "Inside"; // Coloca las etiquetas dentro de cada porción
                series["CollectedLabel"] = "Otros";
                series.IsValueShownAsLabel = true; // Muestra los valores en el gráfico
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ConfigurarGraficoPieCC(DateTime fechainicio, DateTime fechafinal)
        {
            try
            {
                CGraficoPieCC.Series.Clear();
                Series series = CGraficoPieCC.Series.Add("Categorías");
                series.ChartType = SeriesChartType.Pie;

                NDetalleVenta nDetalle = new NDetalleVenta();

                // Obtener cantidad de productos por categoría en función del periodo
                DataTable dataTable = nDetalle.getTotalVendidosPorCategoria(fechainicio, fechafinal);

                // Agregar datos al gráfico
                foreach (DataRow row in dataTable.Rows)
                {
                    string categoria = row["Nombre_categoria"].ToString();
                    double totalCantidad = Convert.ToDouble(row["TotalCantidad"]);

                    // Agregar el punto al gráfico
                    int index = series.Points.AddXY(categoria, totalCantidad);
                    DataPoint punto = series.Points[index]; // Obtener el punto recién agregado

                    // Configurar etiqueta dentro de la porción del gráfico
                    punto.Label = "#VALY"; // Muestra el valor numérico
                    punto.Font = new Font("Arial", 10, FontStyle.Bold);
                    punto.LabelForeColor = Color.White; // Texto blanco para mejor visibilidad
                }

                // Configuración para etiquetas dentro del gráfico
                series["PieLabelStyle"] = "Inside"; // Ubicar etiquetas dentro de cada porción
                series["CollectedLabel"] = "Otros";
                series.IsValueShownAsLabel = true; // Muestra los valores en el gráfico
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public new void Dispose()
        {
            // Desuscribirse de eventos

            // Liberar los recursos
            base.Dispose();
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            Reporte formReporte = new Reporte(dateTimePicker1.Value, dateTimePicker2.Value);
            formReporte.TopLevel = false;
            formReporte.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formReporte);
            PanelContainer.BringToFront();
            formReporte.Show();
            this.Dispose();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            using (var context = new ProyectoTallerIIEntities1())
            {
                var totalProductosVendidos = context.Detalle_venta.Sum(d => d.Cantidad);
                LCantidadVendidos.Text = totalProductosVendidos.ToString();

                var ventas = context.Venta.ToList();
                LCantidadVentas.Text = ventas.Count.ToString();

                var compras = context.Compra.ToList();
                LCantidadCompras.Text = compras.Count.ToString();

                var totalGanado = context.Venta.Sum(v => v.Total);
                LCantidadGanado.Text = totalGanado.ToString("C");

                var ventasPorDia = context.Venta
                    .GroupBy(v => v.Fecha)
                    .Select(g => g.Count())
                    .ToList();

                double promedioVentasPorDia = ventasPorDia.Any() ? ventasPorDia.Average() : 0;
                LPromedioVentas.Text = promedioVentasPorDia.ToString("F2");
            }
        }

        
        
    }
}
