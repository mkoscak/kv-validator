using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Avat.Components
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            var idx = txtLicence.Text.IndexOf('\n');
            txtLicence.Select(0, idx);
            txtLicence.SelectionFont = new Font(txtLicence.Font, FontStyle.Bold);
            txtLicence.DeselectAll();
        }

        private void picLogo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImage(picLogo.Image, e.ClipRectangle);
        }
    }
}
