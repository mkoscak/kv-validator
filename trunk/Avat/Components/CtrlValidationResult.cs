using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AvatValidator.Interface;
using AvatValidator.Validators;
using AvatValidator.Validators.BlackListValidator;
using AvatValidator.Validators.TaxPayerValidator;
using AvatValidator;
using Avat.Forms;
using OfficeOpenXml;
using System.IO;
using System.Diagnostics;
using AvatValidator.Implementation;

namespace Avat.Components
{
    public partial class CtrlValidationResult : UserControl
    {
        public CtrlValidationResult()
        {
            InitializeComponent();
        }

        public void ShowResult(IValidationResult Result)
        {
            if (Result == null)
                Result = new ValidationResult();

            int c = 0;

            c = Result.Count(r => r.FromRule is IcDphValidator); SetCount(lblpIcDph, c);
            c = Result.Count(r => r.FromRule is KvKindValidator); SetCount(lblpDruh, c);
            c = Result.Count(r => r.FromRule is PeriodValidator || r.FromRule is YearValidator); SetCount(lblpObdobie, c);
            c = Result.Count(r => r.FromRule is NameValidator); SetCount(lblpNazov, c);
            c = Result.Count(r => r.FromRule is StateValidator); SetCount(lblpStat, c);
            c = Result.Count(r => r.FromRule is CityValidator); SetCount(lblpObec, c);
            c = Result.Count(r => r.FromRule is BlackListValidator); SetCount(lblpBlacklist, c);
            c = Result.Count(r => r.FromRule is TaxPayerValidator); SetCount(lblpTaxpayers, c);
            c = Result.Count(r => r.FromRule is CorrectionValidator); SetCount(lblpKodopravy, c);
            c = Result.Count(r => r.FromRule is GoodsValidator); SetCount(lblpTovary, c);
            c = Result.Count(r => r.FromRule is TaxRateValidator || r.FromRule is ItemTaxValidator); SetCount(lblpTaxes, c);
            c = Result.Count(r => r.ProblemObject is A1); SetCount(lblpA1, c);
            c = Result.Count(r => r.ProblemObject is A2); SetCount(lblpA2, c);
            c = Result.Count(r => r.ProblemObject is B1); SetCount(lblpB1, c);
            c = Result.Count(r => r.ProblemObject is B2); SetCount(lblpB2, c);
            c = Result.Count(r => r.ProblemObject is B3); SetCount(lblpB3, c);
            c = Result.Count(r => r.ProblemObject is C1); SetCount(lblpC1, c);
            c = Result.Count(r => r.ProblemObject is C2); SetCount(lblpC2, c);
            c = Result.Count(r => r.ProblemObject is D1); SetCount(lblpD1, c);
            c = Result.Count(r => r.ProblemObject is D2); SetCount(lblpD2, c);
        }

        private void SetCount(Label lblp, int c)
        {
            /*if (c == 0)
                return;*/

            lblp.Text = GetCountText(c);
            lblp.ForeColor = GetColor(c);
        }

        private Color GetColor(int c)
        {
            return c > 0 ? Color.Red : Color.Green;
        }

        private string GetCountText(int c)
        {
            switch (c)
            {
                case 0:
                    return "0 problémov";
                case 1:
                    return "1 problém";
                case 2:
                case 3:
                case 4:
                    return c.ToString() + " problémy";

                default:
                    return c.ToString() + " problémov";
            }
        }
        private void btnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveReport();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ups pri ukladaní reportu došlo k neočakávanej výnimke, reštajtujte prosím aplikáciu. Ak chyba pretrváva kontaktuje podporu.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReport()
        {
            var fname = FrmAvat.GetOutXlsxFileName();
            if (string.IsNullOrEmpty(fname))
                return;

            using (var pck = new ExcelPackage())
            {
                var ws = pck.Workbook.Worksheets.Add("Report");

                int r = 1;
                int s = 1;
                ws.Cells[r++, 1].Value = lblIcDph.Text;
                ws.Cells[s++, 2].Value = lblpIcDph.Text;
                ws.Cells[r++, 1].Value = lblDruh.Text;
                ws.Cells[s++, 2].Value = lblpDruh.Text;
                ws.Cells[r++, 1].Value = lblObdobie.Text;
                ws.Cells[s++, 2].Value = lblpObdobie.Text;
                ws.Cells[r++, 1].Value = lblNazov.Text;
                ws.Cells[s++, 2].Value = lblpNazov.Text;
                ws.Cells[r++, 1].Value = lblStat.Text;
                ws.Cells[s++, 2].Value = lblpStat.Text;
                ws.Cells[r++, 1].Value = lblObec.Text;
                ws.Cells[s++, 2].Value = lblpObec.Text;
                ws.Cells[r++, 1].Value = lblBlacklist.Text;
                ws.Cells[s++, 2].Value = lblpBlacklist.Text;
                ws.Cells[r++, 1].Value = lblTaxpayer.Text;
                ws.Cells[s++, 2].Value = lblpTaxpayers.Text;
                ws.Cells[r++, 1].Value = lblKodopravy.Text;
                ws.Cells[s++, 2].Value = lblpKodopravy.Text;
                ws.Cells[r++, 1].Value = lblTovary.Text;
                ws.Cells[s++, 2].Value = lblpTovary.Text;
                ws.Cells[r++, 1].Value = lblTaxes.Text;
                ws.Cells[s++, 2].Value = lblpTaxes.Text;

                ws.Cells[s++, 2].Value = lblpA1.Text;
                ws.Cells[r++, 1].Value = lblA1.Text;
                ws.Cells[s++, 2].Value = lblpA2.Text;
                ws.Cells[r++, 1].Value = lblA2.Text;
                ws.Cells[s++, 2].Value = lblpB1.Text;
                ws.Cells[r++, 1].Value = lblB1.Text;
                ws.Cells[s++, 2].Value = lblpB2.Text;
                ws.Cells[r++, 1].Value = lblB2.Text;
                ws.Cells[s++, 2].Value = lblpB3.Text;
                ws.Cells[r++, 1].Value = lblB3.Text;
                ws.Cells[s++, 2].Value = lblpC1.Text;
                ws.Cells[r++, 1].Value = lblC1.Text;
                ws.Cells[s++, 2].Value = lblpC2.Text;
                ws.Cells[r++, 1].Value = lblC2.Text;
                ws.Cells[s++, 2].Value = lblpD1.Text;
                ws.Cells[r++, 1].Value = lblD1.Text;
                ws.Cells[s++, 2].Value = lblpD2.Text;
                ws.Cells[r++, 1].Value = lblD2.Text;

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
