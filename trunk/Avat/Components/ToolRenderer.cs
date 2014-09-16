﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Avat.Components
{
    class ToolRenderer : ToolStripSystemRenderer
    {
        Pen borderPen = new Pen(Color.FromArgb(229,229,229));
        bool border;
        
        public ToolRenderer(bool border)
        {
            this.border = border;
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (border)
                e.Graphics.DrawLine(borderPen, e.AffectedBounds.Right - 1, e.AffectedBounds.Top, e.AffectedBounds.Right - 1, e.AffectedBounds.Bottom);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            var p = new SolidBrush(MyColors.MenuBackColor);
            var isHover = (e.Item as ToolStripButton).Checked || e.Item.Bounds.Contains(e.ToolStrip.PointToClient(Cursor.Position));
            if ((e.Item as ToolStripButton).Checked)
                p = new SolidBrush(Color.Black);

            e.Graphics.FillRectangle(p, 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
            if (isHover)
                e.Graphics.DrawRectangle(new Pen(Color.Black), 0, 0, e.Item.Bounds.Width - 1, e.Item.Bounds.Height - 1);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
        }

        /*protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            base.OnRenderItemImage(e);
        }*/

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item is ToolStripLabel)
            {
                e.TextRectangle = new Rectangle(e.TextRectangle.X + 5, e.TextRectangle.Y, e.Item.Bounds.Width - 5, e.TextRectangle.Height);
                base.OnRenderItemText(e);
                return;
            }

            var text = e.Text;
            var font = e.TextFont;
            var rect = e.TextRectangle;
            var format = e.TextFormat;

            // symbol 0x25CF
            e.TextColor = MyColors.LeftToolGray;
            e.TextFont = new Font(e.TextFont.FontFamily, 18);
            e.Text = " \u25CF ";
            e.TextFormat = TextFormatFlags.NoPadding | TextFormatFlags.Left;
            e.TextRectangle = new Rectangle(e.TextRectangle.X, 2, 40, 40);
            base.OnRenderItemText(e);

            e.Text = text;
            e.TextFont = font;
            e.TextRectangle = rect;
            e.TextFormat = format;
            e.TextColor = Color.White;
            e.TextRectangle = new Rectangle(e.TextRectangle.X + 25, e.TextRectangle.Y, e.Item.Bounds.Width - 25, e.TextRectangle.Height);
            var index = text.LastIndexOf('.');
            if (index == -1)
            {
                // polozka bez poctu..
                base.OnRenderItemText(e);
                return;
            }

            // text polozky
            var title = text.Substring(0, index + 1);
            e.TextColor = Color.White;
            e.Text = title;
            base.OnRenderItemText(e);

            // pocet poloziek
            var count = "0";
            if (text.Contains(' '))
                count = text.Substring(text.IndexOf(' ') + 1).Trim('(', ')');
            e.Text = count;
            e.TextColor = MyColors.LeftToolGray;
            e.TextFormat = TextFormatFlags.NoPadding | TextFormatFlags.Right;
            e.TextRectangle = new Rectangle(e.TextRectangle.X, e.TextRectangle.Y, e.Item.Bounds.Width - e.TextRectangle.X - 4, e.TextRectangle.Height);
            base.OnRenderItemText(e);
        }
    }
}
