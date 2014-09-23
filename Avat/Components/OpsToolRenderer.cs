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
        public OpsToolRenderer() 
        {
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            e.Graphics.DrawLine(p, 0, 0, e.AffectedBounds.Right, 0);
            e.Graphics.DrawLine(p2, 0, 1, e.AffectedBounds.Right, 1);
        }

        Pen p = new Pen(MyColors.ToolstripColor1);
        Pen p2 = new Pen(MyColors.ToolstripColor2);
        SolidBrush buttonBack = new SolidBrush(MyColors.ButtonBackColor);
        SolidBrush buttonHover = new SolidBrush(MyColors.ButtonHover);
        SolidBrush buttonInact = new SolidBrush(MyColors.ButtonInactive);

        int rund = 4;
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Enabled)
            {
                Common.DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonInact);
                return;
            }

            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                Common.DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonHover);
            else
                Common.DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonBack);
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (!e.Item.Enabled)
            {
                Common.DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonInact);
                return;
            }

            if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
                Common.DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonHover);
            else
                Common.DrawRoundedRectangle(e.Graphics, new Rectangle(0, 0, e.Item.Bounds.Width, e.Item.Bounds.Height), rund, buttonBack);
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            //if (e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position)))
            e.TextColor = Color.White;
            if (e.Item is ToolStripMenuItem)
                e.TextColor = Color.Black;

            base.OnRenderItemText(e);
        }
    }
}
