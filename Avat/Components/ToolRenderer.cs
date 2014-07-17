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
        Pen p = new Pen(Color.FromArgb(111, 125, 140));
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            e.Graphics.DrawLine(p, e.AffectedBounds.Right - 1, e.AffectedBounds.Top, e.AffectedBounds.Right - 1, e.AffectedBounds.Bottom);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var p = Brushes.White;
            var isHover = (e.Item as ToolStripButton).Checked || e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position));
            if ((e.Item as ToolStripButton).Checked)
                p = Brushes.GhostWhite;

            e.Graphics.FillRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
            if (isHover)
                e.Graphics.DrawRectangle(Pens.LightBlue, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
        }
    }
}
