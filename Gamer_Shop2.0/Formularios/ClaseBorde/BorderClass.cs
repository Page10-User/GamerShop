using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

// Clase que proporciona métodos para aplicar bordes redondeados a controles de tipo Panel.
namespace Gamer_Shop2._0.Formularios.BorderClasss
{
    public class BorderClass
    {
        //Fields
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        // Crea un camino gráfico que representa un rectángulo con bordes redondeados.
        public GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Aplica un borde redondeado a un control de tipo Panel.
        public void AplicarBordeRedondeado(Control control, float radius, Graphics graph, Color borderColor, float borderSize)
        {
             using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
             using (Pen penBorder = new Pen(borderColor, borderSize))
             using (Matrix transcontrol = new Matrix())
             {
                 graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                 if (borderSize >= 1)
                 {
                     Rectangle rect = control.ClientRectangle;
                     float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                     float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                     
                     transcontrol.Scale(scaleX, scaleY);
                     transcontrol.Translate(borderSize / 1.6F, borderSize / 1.6F);

                     graph.Transform = transcontrol;
                     graph.DrawPath(penBorder, roundPath);
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------\\
        public void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------\\
        public void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------\\
        public struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------\\
        public FormBoundsColors GetFormBoundsColors(Form control)
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);

                //Top Left
                rectBmp.X = control.Bounds.X - 1;
                rectBmp.Y = control.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);

                //Top Right
                rectBmp.X = control.Bounds.Right;
                rectBmp.Y = control.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);

                //Bottom Left
                rectBmp.X = control.Bounds.X;
                rectBmp.Y = control.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);

                //Bottom Right
                rectBmp.X = control.Bounds.Right;
                rectBmp.Y = control.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------\\
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------\\
    }
}
