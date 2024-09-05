using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gamer_Shop2._0
{
    internal class ColorTransition
    {
        public class ColorAnimator
        {
            private Control _control;
            private Timer _timer;
            private Color _startColor;
            private Color _endColor;
            private float _colorFactor;
            private float _speed;

            public ColorAnimator(Control control, Color startColor, Color endColor, float speed)
            {
                _control = control;
                _startColor = startColor;
                _endColor = endColor;
                _colorFactor = 0;
                _speed = speed;

                _timer = new Timer();
                _timer.Interval = 50; // Intervalo en milisegundos
                _timer.Tick += OnTick;
            }

            public void Start()
            {
                _timer.Start();
            }

            public void Stop()
            {
                _timer.Stop();
            }

            private void OnTick(object sender, EventArgs e)
            {
                _colorFactor += _speed;

                if (_colorFactor > 1)
                {
                    _colorFactor = 0;
                    // Alternar colores si se desea
                    // Color temp = _startColor;
                    // _startColor = _endColor;
                    // _endColor = temp;
                }

                _control.BackColor = InterpolateColor(_startColor, _endColor, _colorFactor);
            }

            private Color InterpolateColor(Color color1, Color color2, float factor)
            {
                int r = (int)(color1.R + (color2.R - color1.R) * factor);
                int g = (int)(color1.G + (color2.G - color1.G) * factor);
                int b = (int)(color1.B + (color2.B - color1.B) * factor);

                return Color.FromArgb(r, g, b);
            }
        }
    }
}
