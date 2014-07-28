using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AvatValidator.Interface;

namespace Avat.Components
{
    public partial class FrmValidationResult : Form
    {
        IValidationResult Result;

        public FrmValidationResult(IValidationResult result)
        {
            InitializeComponent();

            this.Result = result;
            ShowResult();
        }

        private void ShowResult()
        {
        }
    }
}
