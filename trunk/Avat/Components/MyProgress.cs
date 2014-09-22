using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Avat.Components
{
    public class MyProgress : ProgressBar
    {
        Brush back = new SolidBrush(MyColors.ProgressBack);
        Brush val = new SolidBrush(MyColors.ButtonHover);
        int HeightDecrement;
        Brush AroundBack = new SolidBrush(Color.White);

        public MyProgress()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            HeightDecrement = 0;
        }

        public MyProgress(int heightDec, Color aroundBack)
            : this()
        {
            HeightDecrement = heightDec;
            AroundBack = new SolidBrush(aroundBack);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            e.Graphics.FillRectangle(AroundBack, rec);

            e.Graphics.FillRectangle(back, rec.Left, rec.Top + HeightDecrement, rec.Width, rec.Height - 2 * HeightDecrement);
            e.Graphics.FillRectangle(val, 0, HeightDecrement, (int)Math.Round((double)(this.Value / 100.0) * rec.Width), rec.Height - 2 * HeightDecrement);
        }
    }

    public class MyStatusProgress : ToolStripControlHost
    {
        public MyStatusProgress()
            : base(new MyProgress(5, MyColors.HeaderBackColor))
        {
            ((MyProgress)Control).Style = ProgressBarStyle.Continuous;
        }

        public MyProgress ProgressBarControl
        {
            get
            {
                return Control as MyProgress;
            }
        }

        public int Value
        {
            get
            {
                return ProgressBarControl.Value;
            }
            set { ProgressBarControl.Value = value; }
        }
    }
}
