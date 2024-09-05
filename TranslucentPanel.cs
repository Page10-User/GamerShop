using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyApp

public class TranslucentPanel : Panel
{
    public TranslucentPanel()
    {
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.FromArgb(128, Color.Gray);
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
