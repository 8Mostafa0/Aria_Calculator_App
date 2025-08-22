using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

[DesignerCategory("Code")]
public class GlassButton : Control
{
    private bool isHovered = false;
    private bool isPressed = false;
    private int cornerRadius = 20;
    private int backAlpha = 120;

    [Category("Appearance")]
    public int CornerRadius
    {
        get => cornerRadius;
        set
        {
            cornerRadius = Math.Max(0, value);
            if (!DesignMode)
            {
                Invalidate();
                UpdateRegion();
            }
        }
    }

    [Category("Appearance")]
    public int BackAlpha
    {
        get => backAlpha;
        set
        {
            backAlpha = Math.Min(255, Math.Max(0, value));
            if (!DesignMode) Invalidate();
        }
    }

    public override Color BackColor
    {
        get => base.BackColor;
        set
        {
            base.BackColor = value;
            if (!DesignMode) Invalidate();
        }
    }

    public GlassButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.UserPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.SupportsTransparentBackColor, true);

        BackColor = Color.FromArgb(120, 255, 255, 255); // Semi-transparent white
        ForeColor = Color.Black;
        Font = new Font("Segoe UI", 10, FontStyle.Bold);
        Size = new Size(120, 40);

        if (DesignMode)
        {
            cornerRadius = 20;
            backAlpha = 120;
        }

        UpdateRegion();
    }

    private void UpdateRegion()
    {
        try
        {
            if (ClientRectangle.Width > 0 && ClientRectangle.Height > 0)
            {
                using (GraphicsPath path = CreateRoundedPath(ClientRectangle, cornerRadius))
                {
                    Region = new Region(path);
                }
            }
        }
        catch (Exception ex)
        {
            if (DesignMode)
            {
                System.Diagnostics.Debug.WriteLine($"UpdateRegion Error: {ex.Message}");
            }
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        UpdateRegion();
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        if (DesignMode)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, BackColor)))
            {
                pevent.Graphics.FillRectangle(brush, ClientRectangle);
            }
        }
        else
        {
            base.OnPaintBackground(pevent);
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        isHovered = true;
        Invalidate();
        base.OnMouseEnter(e);
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        isHovered = false;
        isPressed = false;
        Invalidate();
        base.OnMouseLeave(e);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isPressed = true;
            Invalidate();
        }
        base.OnMouseDown(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        isPressed = false;
        Invalidate();
        base.OnMouseUp(e);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        try
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = ClientRectangle;
            using (GraphicsPath path = CreateRoundedPath(rect, cornerRadius))
            {
                Color fillColor = Color.FromArgb(backAlpha, BackColor);

                if (isPressed)
                    fillColor = ControlPaint.Dark(fillColor, 0.2f);
                else if (isHovered)
                    fillColor = ControlPaint.Light(fillColor, 0.3f);

                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    g.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.FromArgb(100, 0, 0, 0)))
                {
                    g.DrawPath(pen, path);
                }

                if (!string.IsNullOrEmpty(Text))
                {
                    TextRenderer.DrawText(
                        g,
                        Text,
                        Font ?? SystemFonts.DefaultFont,
                        rect,
                        ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }
        catch (Exception ex)
        {
            if (DesignMode)
            {
                TextRenderer.DrawText(e.Graphics, $"Design Error: {ex.Message}\n{ex.StackTrace}", SystemFonts.DefaultFont, ClientRectangle, Color.Red);
            }
        }
    }

    private GraphicsPath CreateRoundedPath(Rectangle rect, int radius)
    {
        int diameter = Math.Min(radius * 2, Math.Min(rect.Width, rect.Height));
        int r = diameter / 2;
        GraphicsPath path = new GraphicsPath();

        if (r <= 0)
        {
            path.AddRectangle(rect);
            return path;
        }

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        path.AddArc(rect.Right - diameter - 1, rect.Y, diameter, diameter, 270, 90);
        path.AddArc(rect.Right - diameter - 1, rect.Bottom - diameter - 1, diameter, diameter, 0, 90);
        path.AddArc(rect.X, rect.Bottom - diameter - 1, diameter, diameter, 90, 90);
        path.CloseFigure();
        return path;
    }
}