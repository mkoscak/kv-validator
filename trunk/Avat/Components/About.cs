using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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

            var ver = typeof(About).Assembly.GetName().Version;
            txtVersion.Text = string.Format("Verzia: {0}", ver);
        }

        private void picLogo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImage(picLogo.Image, e.ClipRectangle);
        }

        private void btnUploadLicence_Click(object sender, EventArgs e)
        {
            var licFile = Common.GetExistingFilePath("lic", "Súbory LIC|*.lic");
            if (string.IsNullOrEmpty(licFile))
                return;

            UploadLicence(licFile);
        }

        private void UploadLicence(string licFile)
        {
            if (!File.Exists(licFile))
                return;

            try
            {
                var destFile = Application.StartupPath + @"\vatfix.lic";
                if (File.Exists(destFile) &&
                    MessageBox.Show(this, "Licenčný súbor už existuje, prajete si ho prepísať?", "Nahrať licenciu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                 
                File.Copy(licFile, destFile, true);
                Application.Restart();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ups pri kopírovaní licencie došlo k neočakávanej chybe, operáciu skúste zopakovať a ak problém pretrvá, kontaktujte podporu.", "Nahrať licenciu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
