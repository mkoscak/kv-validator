using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AvatValidator.Interface;
using AvatValidator.Validators;
using AvatValidator.Validators.BlackListValidator;
using AvatValidator.Validators.TaxPayerValidator;
using AvatValidator;
using OfficeOpenXml;
using Avat.Forms;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace Avat.Components
{
    public partial class FrmBiznisReport : Form
    {
        BiznisReport br;

        public FrmBiznisReport(BiznisReport report)
        {
            InitializeComponent();

            this.br = report;
            ShowResult();
        }

        private void ShowResult()
        {
            if (br == null)
                return;

            var culture = CultureInfo.CreateSpecificCulture("sk-SK");

            lblpPocPrij.Text = br.PocPrij.ToString("n0", culture);
            lblpSumaPrij.Text = br.SumaPrij.ToString("n", culture);
            lblpDanPrij.Text = br.DanePrij.ToString("n", culture);

            lblpPocVyst.Text = br.PocVyst.ToString("n0", culture);
            lblpSumaVyst.Text = br.SumaVyst.ToString("n", culture);
            lblpDanVyst.Text = br.DaneVyst.ToString("n", culture);

            lblpBilancia.Text = br.Balance.ToString("n", culture);
            if (br.Balance < 0)
                lblpBilancia.ForeColor = Color.Red;

            lblpOdb.Text = br.PocetBlacklistOdb.ToString("n0", culture);
            lblpDod.Text = br.PocetBlacklistDod.ToString("n0", culture);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmValidationResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        
        private void btnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveReport();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Pri ukladaní reportu došlo k neočakávanej výnimke, kontaktujte administrátora!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReport()
        {
            var fname = FrmAvat.GetOutXlsxFileName();
            if (string.IsNullOrEmpty(fname))
                return;

            using (var pck = new ExcelPackage())
            {
                var ws = pck.Workbook.Worksheets.Add("Biznis report");

                int r = 1;
                ws.Cells[r, 1].Value = "Počet prijatých faktúr:";
                ws.Cells[r++, 2].Value = br.PocPrij;
                ws.Cells[r, 1].Value = "Suma prijatých faktúr:";
                ws.Cells[r++, 2].Value = br.SumaPrij;
                ws.Cells[r, 1].Value = "Suma dane prijatých faktúr:";
                ws.Cells[r++, 2].Value = br.DanePrij;
                ws.Cells[r, 1].Value = "Počet odoslaných faktúr:";
                ws.Cells[r++, 2].Value = br.PocVyst;
                ws.Cells[r, 1].Value = "Suma odoslaných faktúr:";
                ws.Cells[r++, 2].Value = br.SumaVyst;
                ws.Cells[r, 1].Value = "Suma dane odoslaných faktúr:";
                ws.Cells[r++, 2].Value = br.DaneVyst;
                ws.Cells[r, 1].Value = "Bilancia:";
                ws.Cells[r++, 2].Value = br.Balance;
                ws.Cells[r, 1].Value = "Počet odberateľov z black-listu:";
                ws.Cells[r++, 2].Value = br.PocetBlacklistOdb;
                ws.Cells[r, 1].Value = "Počet dodávateľov z black-listu:";
                ws.Cells[r++, 2].Value = br.PocetBlacklistDod;

                ws.Column(1).AutoFit();
                ws.Column(2).AutoFit();
                ws.Cells[1, 1, r - 1, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[1, 1, r - 1, 1].Style.Fill.BackgroundColor.SetColor(Color.Wheat);
                ws.Cells[1, 2, r - 1, 2].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[1, 2, r - 1, 2].Style.Fill.BackgroundColor.SetColor(Color.WhiteSmoke);

                pck.SaveAs(new FileInfo(fname));
            }

            // skusime otvorit ulozeny subor, ak sa nepodari, nic sa neudeje..
            try
            {
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(fname);
                p.Start();
            }
            catch (Exception)
            {
            }
        }
    }
}
