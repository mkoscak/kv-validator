using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Avat.Components
{
    class OpsToolRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
        }

        Color c = Color.FromArgb(111, 125, 140);
        Pen p = new Pen(Color.FromArgb(111, 125, 140));
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                e.Graphics.DrawRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                e.Graphics.DrawRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                e.TextColor = c;

            base.OnRenderItemText(e);
        }
    }
}
