using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;

namespace Avat.Components
{
    public partial class About : Form
    {
        Vatfix.Licensing.License licence;
        public About(Vatfix.Licensing.License lic)
        {
            InitializeComponent();
            licence = lic;
        }

        private void About_Load(object sender, EventArgs e)
        {
            txtLicence.Text = GetLicenceText();
            var idx = txtLicence.Text.IndexOf('\n');
            txtLicence.Select(0, idx);
            txtLicence.SelectionFont = new Font(txtLicence.Font, FontStyle.Bold);
            txtLicence.DeselectAll();

            var ver = typeof(About).Assembly.GetName().Version;
            txtVersion.Text = string.Format("Verzia: {0}", ver);
        }

        private string GetLicenceText()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Vatfix - kontrolný výkaz DPH 2014");
            sb.AppendLine();
            if (licence == null)
                sb.AppendLine("Nemáte platnú licenciu!");
            else
            {
                sb.AppendLine(string.Format("Používateľ: {0} {1}", licence.User.Name, licence.User.Surname));
                sb.AppendLine(string.Format("e-mail: {0}", licence.User.Email));
                sb.AppendLine(string.Format("Tel.: {0}", licence.User.Telephone));
                sb.AppendLine(string.Format("Licencia platná do: {0}", licence.Expiration.ToString("dd.MM.yyyy")));
                sb.AppendLine();
                sb.AppendLine(string.Format("Licencované spoločnosti:"));
                foreach (var item in licence.DIC)
                {
                    var found = Common.GetTaxPayer(item);
                    if (found != null)
                        sb.AppendLine(string.Format("DIC: {0} - {1}", item, found.Nazov));
                    else
                        sb.AppendLine(string.Format("DIC: {0} - {1}", item, "neznáma"));
                }
            }

            return sb.ToString();
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
                var content = File.ReadAllText(licFile);
                Vatfix.Licensing.LicenseManager.SaveLicense(content);
                Application.Restart();

                /*var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);

                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("vatfix.lic", FileMode.Create, isoStore))
                {
                    using (var writer = new BinaryWriter(isoStream))
                    {
                        writer.Write(File.ReadAllBytes(licFile));
                        Application.Restart();
                    }
                }*/

                /*var destFile = Application.StartupPath + @"\vatfix.lic";
                if (File.Exists(destFile) &&
                    MessageBox.Show(this, "Licenčný súbor už existuje, prajete si ho prepísať?", "Nahrať licenciu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                 
                File.Copy(licFile, destFile, true);
                Application.Restart();*/
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
