using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VAToo
{
    public partial class FrmVatoo : Form
    {
        public FrmVatoo()
        {
            InitializeComponent();
        }

        private void FrmVatoo_Load(object sender, EventArgs e)
        {
            var path = Application.StartupPath + @"\logo.png";
            if (File.Exists(path))
                picLogo.Image = Image.FromFile(path);
        }
    }
}
