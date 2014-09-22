using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Avat.Components
{
    class OpsToolRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            e.Graphics.DrawLine(p, 0, 0, e.AffectedBounds.Right, 0);
            e.Graphics.DrawLine(p2, 0, 1, e.AffectedBounds.Right, 1);
        }

        Color c = Color.White; 
        Pen white = new Pen(Color.White);
        Pen p = new Pen(MyColors.ToolstripColor1);
        Pen p2 = new Pen(MyColors.ToolstripColor2);
        SolidBrush buttonBack = new SolidBrush(MyColors.ButtonBackColor);
        SolidBrush buttonHover = new SolidBrush(MyColors.ButtonHover);
        SolidBrush buttonInact = new SolidBrush(MyColors.ButtonInactive);

        public static void DrawRoundedRectangleFill(Graphics g, Rectangle r, int d, Brush b)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);
            g.FillPath(b, gp);
            gp.Dispose();
        }

        public static void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Pen b)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            gp.AddLine(r.X, r.Y + r.Height - d, r.X, r.Y + d / 2);
            g.DrawPath(b, gp);
            gp.Dispose();
        }

        int rund = 7;
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Enabled)
            {
                DrawRoundedRectangleFill(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonInact);
                return;
            }

            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                DrawRoundedRectangleFill(e.Graphics, new Rectangle( 0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonHover);
            else
                DrawRoundedRectangleFill(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonBack);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Enabled)
            {
                DrawRoundedRectangleFill(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonInact);
                return;
            }

            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                DrawRoundedRectangleFill(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonHover);
            else
                DrawRoundedRectangleFill(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonBack);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                e.TextColor = c;

            base.OnRenderItemText(e);
        }
    }
}
