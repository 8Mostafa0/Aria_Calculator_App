using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundPanel : Panel
{
    private int cornerRadius = 30;

    [Category("Appearance")]
    [Description("Sets how round the panel corners are. 0 is square corners, higher values are more rounded.")]
    public int CornerRadius
    {
        get => cornerRadius;
        set
        {
            cornerRadius = Math.Max(0, value);
            UpdateRegion();
            Invalidate();
        }
    }

    public RoundPanel()
    {
        this.DoubleBuffered = true;
        this.Resize += (s, e) => UpdateRegion();
        UpdateRegion();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        using (GraphicsPath path = CreateRoundedRectanglePath(this.ClientRectangle, cornerRadius))
        {
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }
    }

    private void UpdateRegion()
    {
        using (GraphicsPath path = CreateRoundedRectanglePath(this.ClientRectangle, cornerRadius))
        {
            this.Region = new Region(path);
        }
    }

    private GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
    {
        int r = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2);
        GraphicsPath path = new GraphicsPath();

        if (r <= 0)
        {
            path.AddRectangle(rect);
            return path;
        }

        int diameter = r * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);                            // Top Left
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);            // Top Right
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);  // Bottom Right
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);            // Bottom Left
        path.CloseFigure();

        return path;
    }
}
