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
        Pen p = new Pen(Color.FromArgb(229,229,229));
        bool border;
        
        public ToolRenderer(bool border)
        {
            this.border = border;
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (border)
                e.Graphics.DrawLine(p, e.AffectedBounds.Right - 1, e.AffectedBounds.Top, e.AffectedBounds.Right - 1, e.AffectedBounds.Bottom);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var p = new SolidBrush(Color.FromArgb(239, 239, 239));
            var isHover = (e.Item as ToolStripButton).Checked || e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position));
            if ((e.Item as ToolStripButton).Checked)
                p = new SolidBrush(Color.FromArgb(0, 115, 195));

            e.Graphics.FillRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
            if (isHover)
                e.Graphics.DrawRectangle(Pens.LightBlue, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if ((e.Item is ToolStripButton && (e.Item as ToolStripButton).Checked) /*|| e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position))*/)
                e.TextColor = Color.White;

            var text = e.Text;
            var title = text.Substring(0, 2);
            var count = "0";
            if (text.Contains(' '))
                count = text.Substring(text.IndexOf(' ')+1).Trim('(', ')');
            
            e.Text = title;
            base.OnRenderItemText(e);

            e.Text = count;
            e.TextColor = Color.FromArgb(199,199,199);
            e.TextFormat = TextFormatFlags.NoPadding | TextFormatFlags.Right;
            base.OnRenderItemText(e);
        }
    }
}
