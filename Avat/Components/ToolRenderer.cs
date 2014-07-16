using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Avat.Components
{
    class ToolRenderer : ToolStripSystemRenderer
    {
        Brush hoverBrush = new SolidBrush(Color.FromArgb(235, 240, 245));
        Color hoverTextColor = Color.White;

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Gray, e.AffectedBounds.Right - 1, e.AffectedBounds.Top, e.AffectedBounds.Right - 1, e.AffectedBounds.Bottom);
            //base.OnRenderToolStripBorder(e);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var p = Brushes.White;
            if ((e.Item as ToolStripButton).Checked || e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                p = hoverBrush;

            e.Graphics.FillRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
            //base.OnRenderButtonBackground(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            //base.OnRenderSeparator(e);
        }
    }
}
