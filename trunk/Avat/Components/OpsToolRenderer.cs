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
        Pen hoverPen = Pens.DarkGray;
        Color hoverTextColor = Color.DarkGray;

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var p = Pens.Gray;
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                p = hoverPen;
            
            e.Graphics.DrawRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
            //base.OnRenderButtonBackground(e);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var p = Pens.Gray;
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                p = hoverPen;

            e.Graphics.DrawRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
            //base.OnRenderDropDownButtonBackground(e);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                e.TextColor = hoverTextColor;

            base.OnRenderItemText(e);
        }
    }
}
