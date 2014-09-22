using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Avat.Components
{
    public class RoundedButton : Button
    {
        Brush b = new SolidBrush(MyColors.Yellow);
        Brush hover = new SolidBrush(MyColors.YellowHover);
        StringFormat sf;

        public RoundedButton()
        {
            SetStyle(ControlStyles.UserPaint, true);
            sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
        }

        public RoundedButton(Color col, Color hoverCol)
            : this()
        {
            b = new SolidBrush(col);
            hover = new SolidBrush(hoverCol);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(Brushes.White, pevent.ClipRectangle);
            if (Enabled && Bounds.Contains(Parent.PointToClient(Cursor.Position)))
                Common.DrawRoundedRectangle(pevent.Graphics, pevent.ClipRectangle, 4, hover);
            else
                Common.DrawRoundedRectangle(pevent.Graphics, pevent.ClipRectangle, 4, b);

            // text
            pevent.Graphics.DrawString(this.Text, this.Font, Brushes.White, pevent.ClipRectangle, sf);
        }
    }
}
