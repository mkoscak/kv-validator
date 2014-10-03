using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Avat.Components
{
    public partial class CtrlResultPanel2 : UserControl
    {
        public CtrlResultPanel2()
        {
            InitializeComponent();
        }

        public CtrlResultPanel2(string name)
            : this()
        {
            lblText.Text = name;
            lblcount.Visible = false;
        }

        public CtrlResultPanel2(string name, int count)
            : this()
        {
            lblText.Text = name;
            lblText.ForeColor = Color.Black;

            lblcount.Text = string.Format("{0} {1}x", Common.theSign, count);
            lblcount.ForeColor = Color.Red;
        }
    }
}
