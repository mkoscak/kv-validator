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
    public partial class CtrlFirstRun : UserControl
    {
        public CtrlFirstRun()
        {
            InitializeComponent();

            textBox1.SelectedText = null;
            progress.Focus();
        }
    }
}
