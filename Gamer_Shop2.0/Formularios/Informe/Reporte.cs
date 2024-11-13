using Gamer_Shop2._0.Formularios.BorderClasss;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            CrearGrafico();
            ConfigurarGraficoPie();
            ConfigurarGraficoPieCC();
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

        private void CrearGrafico()
        {
            CGraficoVent.Series.Clear();
            Series series = CGraficoVent.Series.Add("Ventas");
            series.ChartType = SeriesChartType.Column;

            NVenta nventa = new NVenta();
            DataTable dataTable = nventa.getTotalVentasPorPeriodo(periodo);

            // Colores personalizados para cada barra
            Color[] colores = { Color.Salmon, Color.Khaki, Color.LightGreen, Color.Lime, Color.Cyan, Color.DeepSkyBlue, Color.MediumPurple };

            for (int i = 0; i < dias.Length; i++)
            {
                series.Points.AddXY(dias[i], valores[i]);
                series.Points[i].Color = colores[i];

                // Mostrar los valores sobre cada barra
                series.Points[i].Label = valores[i].ToString();
                series.Points[i].LabelForeColor = Color.White;
            }

            // Personalizar el gráfico
            CGraficoVent.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            CGraficoVent.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            CGraficoVent.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            // Evitar que las etiquetas del eje X se alternen
            CGraficoVent.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;

            // Separar las barras para mejorar la visibilidad
            series["PointWidth"] = "0.8";

            // Cambiar el fondo del gráfico
            CGraficoVent.BackColor = Color.Black; // Fondo del gráfico
            CGraficoVent.ChartAreas[0].BackColor = Color.Black;

            // Eliminar la leyenda (quitar el cuadro "Series")
            CGraficoVent.Legends.Clear();
        }
        private void ConfigurarGraficoPie()
        {
            // Limpiar series anteriores
            CGraficoPie5P.Series.Clear();

            // Crear una nueva serie de tipo "Pie"
            Series series = CGraficoPie5P.Series.Add("Productos");
            series.ChartType = SeriesChartType.Pie;

            // Datos de ejemplo
            string[] categorias = { "Producto (1)", "Producto (2)", "Producto (3)", "Producto (4)", "Producto (5)" };
            double[] valores = { 30, 20, 15, 25, 10 };

            // Agregar datos a la serie
            for (int i = 0; i < categorias.Length; i++)
            {
                series.Points.AddXY(categorias[i], valores[i]);
            }

            // Cambiar el estilo de las etiquetas
            series["PieLabelStyle"] = "Disabled"; // No mostrar etiquetas
            series["CollectedLabel"] = "Otros";
        }
        private void ConfigurarGraficoPieCC()
        {
            // Limpiar series anteriores
            CGraficoPieCC.Series.Clear();

            // Crear una nueva serie de tipo "Pie"
            Series series = CGraficoPieCC.Series.Add("Productos");
            series.ChartType = SeriesChartType.Pie;

            // Datos de ejemplo
            string[] categorias = { "Procesador", "Placa Madre", "Tarjeta Grafica", "Monitor", "Accesorio", "Fuente", "Ram"};
            double[] valores = { 30, 20, 15, 25, 10, 43, 19};

            // Agregar datos a la serie
            for (int i = 0; i < categorias.Length; i++)
            {
                series.Points.AddXY(categorias[i], valores[i]);
            }

            // Cambiar el estilo de las etiquetas
            series["PieLabelStyle"] = "Disabled";
            series["CollectedLabel"] = "Otros";
        }

        public new void Dispose()
        {
            // Desuscribirse de eventos

            // Liberar los recursos
            base.Dispose();
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            Reporte formReporte = new Reporte();
            formReporte.TopLevel = false;
            formReporte.PanelContainer = PanelContainer;
            PanelContainer.Controls.Clear(); // Limpia el panel antes de agregar el nuevo formulario
            PanelContainer.Controls.Add(formReporte);
            PanelContainer.BringToFront();
            formReporte.Show();
            this.Dispose();
        }
    }
}
