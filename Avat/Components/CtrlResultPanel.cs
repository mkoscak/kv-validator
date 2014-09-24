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
    public partial class CtrlResultPanel : UserControl
    {

        public CtrlResultPanel()
        {
            InitializeComponent();
        }

        public CtrlResultPanel(string name, int errorCount, string text, bool warning)
            : this()
        {
            SetInfo(name, errorCount, text, warning);
        }

        public void SetInfo(string name, int errorCount, string text, bool warning)
        {
            lblName.Text = name;
            lblErrorCount.Text = Common.theSign + Common.FormatErrCount(errorCount);
            txtError.Text = text;

            if (errorCount == 0)
                lblErrorCount.ForeColor = Color.Green;
            else if (warning)
                lblErrorCount.ForeColor = MyColors.Yellow;
        }
    }
}
