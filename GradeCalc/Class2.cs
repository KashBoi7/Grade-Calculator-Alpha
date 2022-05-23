﻿/*using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace GradeCalc { 

	public class Class2 : Button
	{
		private int borderSize = 0;
		private int borderRadius = 40;
		private Color borderColor = Color.Green;
	}
	public Class2()
	{
		this.FlatStyle = FlatStyle.Flat;
        this.FlatApperance.BorderSize = 0;
	}
    private GraphicsPath GetFigurePath(RectangleF rect, float radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, radius, radius, 270, 290);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }
    protected override void OnPaint (PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
        RectangleF rectBorder = new RectangleF(1, 1, this.Width-0.8F, this.Height-1);
        if (borderRadius > 2)
        {
            using (GraphicsPath pathSurface= GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius))
            using (Pen penSurface=new Pen(this.Parent.BackColor,2))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(pathSurface, pathSurface);
                if (borderSize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }

            }
        }
        else
        {
            this.Region = new Region(rectSurface);
            if (borderSize >= 1) 
            {
                using(Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    pevent.Graphics.DrawRectangle(penBorder, 0,0,this.Width-1,this.Height-1);
                }
            }


;       }
    }
    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);
        this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
    }
    private void Container_BackColorChanged(object sender, EventArgs e)
    {
        if (this.DesignMode)
        {
            this.Invalidate();
        }
    }
}

*/