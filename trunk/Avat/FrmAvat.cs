﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AvatValidator;
using AvatValidator.Implementation;
using AvatValidator.Interface;
using Avat.Components;
using System.Threading;
using OfficeOpenXml;
using System.IO;

namespace Avat.Forms
{
    public partial class FrmAvat : Form, IValidationObserver
    {
        string FormTitle;
        string ActualFileName;

        KVDPH kvDph = new KVDPH();

        IValidationResult lastValidationResult;
        DataGridViewCellStyle errorStyle;
        CtrlIdentification identification;

        public FrmAvat()
        {
            InitializeComponent();

            identification = new CtrlIdentification();
            identification.BorderStyle = BorderStyle.None;
            identification.Dock = DockStyle.Fill;
            panelContent.Controls.Add(identification);
        }

        private void FrmDesignOne_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 54, 54);

            this.menuXml.Renderer = new ToolRenderer();
            this.menuXml.BackColor = this.BackColor;

            this.menuOps.Renderer = new ToolRenderer();
            this.menuOps.BackColor = this.BackColor;

            var tmp = new BindingList<A1>();
            for (int i = 0; i < 10; i++)
                tmp.Add(new A1());
            this.gridData.DataSource = tmp;

            this.gridData.BackgroundColor = this.BackColor;

            this.btnIdentification.PerformClick();
            UpdateButtonTexts();

            // inicializacia hlavickoveho textu
            this.FormTitle = this.Text;

            errorStyle = new DataGridViewCellStyle(gridData.DefaultCellStyle);
            errorStyle.ForeColor = Color.Red;

            NewAvat();
        }

        private void NewAvat()
        {
            kvDph = new KVDPH();
            ShowIdentification();
            UpdateButtonTexts();
            SetFileName("nový.xml");
        }

        private void SetFileName(string name)
        {
            this.Text = string.Format("{0} - {1}", FormTitle, name);
        }

        void DisableAllButtons(ToolStripButton except)
        {
            btnIdentification.Checked = false;
            btnA1.Checked = false;
            btnA2.Checked = false;
            btnB1.Checked = false;
            btnB2.Checked = false;
            btnB3.Checked = false;
            btnC1.Checked = false;
            btnC2.Checked = false;
            btnD1.Checked = false;
            btnD2.Checked = false;
            except.Checked = true;

            lblTitle.Text = except.ToolTipText;

            if (except == btnIdentification)
            {
                gridData.Visible = false;
                identification.Visible = true;
            }
            else if (!gridData.Visible)
            {
                gridData.Visible = true;
                identification.Visible = false;
            }
        }

        private void btnIdentification_Click(object sender, EventArgs e)
        {
            ShowIdentification();
        }

        private void ShowIdentification()
        {
            DisableAllButtons(btnIdentification);
            identification.SetData(kvDph.Identifikacia);
            gridData.DataSource = null;

            /*gridData.Visible = false;
            this.panelContent.Controls.Remove(gridData);
            this.panelContent.Controls.Add(*/
        }

        void CheckSetErrors<T>(BindingList<T> ds)
            where T : class
        {
            if (lastValidationResult != null)
            {
                for (int i = 0; i < ds.Count; i++)
                {
                    var problems = lastValidationResult.Where(r => r.ProblemObject == ds[i]).ToList();
                    if (problems.Count > 0)
                    {
                        gridData.Rows[i].DefaultCellStyle = errorStyle;
                        gridData.Rows[i].Tag = problems;
                    }
                }
            }
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA1);
            gridData.DataSource = new BindingList<A1>();

            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A1 != null)
            {
                var ds = new BindingList<A1>(kvDph.Transakcie.A1);
                gridData.DataSource = ds;
                CheckSetErrors<A1>(ds);
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA2);
            gridData.DataSource = new BindingList<A2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A2 != null)
            {
                var ds = new BindingList<A2>(kvDph.Transakcie.A2);
                gridData.DataSource = ds;
                CheckSetErrors<A2>(ds);
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB1);
            gridData.DataSource = new BindingList<B1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B1 != null)
            {
                var ds = new BindingList<B1>(kvDph.Transakcie.B1);
                gridData.DataSource = ds;
                CheckSetErrors<B1>(ds);
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB2);
            gridData.DataSource = new BindingList<B2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B2 != null)
            {
                var ds = new BindingList<B2>(kvDph.Transakcie.B2);
                gridData.DataSource = ds;
                CheckSetErrors<B2>(ds);
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB3);
            gridData.DataSource = new BindingList<B3>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B3 != null)
            {
                var ds = new BindingList<B3>(kvDph.Transakcie.B3);
                gridData.DataSource = ds;
                CheckSetErrors<B3>(ds);
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC1);
            gridData.DataSource = new BindingList<C1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C1 != null)
            {
                var ds = new BindingList<C1>(kvDph.Transakcie.C1);
                gridData.DataSource = ds;
                CheckSetErrors<C1>(ds);
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC2);
            gridData.DataSource = new BindingList<C2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C2 != null)
            {
                var ds = new BindingList<C2>(kvDph.Transakcie.C2);
                gridData.DataSource = ds;
                CheckSetErrors<C2>(ds);
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD1);
            gridData.DataSource = new BindingList<D1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D1 != null)
            {
                var ds = new BindingList<D1>(kvDph.Transakcie.D1);
                gridData.DataSource = ds;
                CheckSetErrors<D1>(ds);
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD2);
            gridData.DataSource = new BindingList<D2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D2 != null)
            {
                var ds = new BindingList<D2>(kvDph.Transakcie.D2);
                gridData.DataSource = ds;
                CheckSetErrors<D2>(ds);
            }
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            try
            {
                string path = GetXmlPath();
                if (string.IsNullOrEmpty(path))
                    return;

                var p = new Progress(0, 100, "Načítanie vstupného súboru", "Načítavam..", ReadXmlProc, XmlRead, path, false, false);
                p.StartWorker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Načítanie vstupného súboru neprebehlo úspešne: {0}{0}{1}", Environment.NewLine, ex.Message), "Načítanie xml", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void ReadXmlProc(BackgroundWorker bw, DoWorkEventArgs e, object userData)
        {
            ReadXml(userData.ToString());
            bw.ReportProgress(100);
        }

        /// <summary>
        /// po nacitani XML
        /// </summary>
        void XmlRead()
        {
            if (kvDph != null)
            {
                identification.SetData(kvDph.Identifikacia);
                UpdateButtonTexts();
                ShowIdentification();
                SetFileName(ActualFileName);
            }
        }

        private void UpdateButtonTexts()
        {
            btnA1.Text = string.Format("A1 ({0})", kvDph.Transakcie.A1.Count);
            btnA2.Text = string.Format("A2 ({0})", kvDph.Transakcie.A2.Count);
            btnB1.Text = string.Format("B1 ({0})", kvDph.Transakcie.B1.Count);
            btnB2.Text = string.Format("B2 ({0})", kvDph.Transakcie.B2.Count);
            btnB3.Text = string.Format("B3 ({0})", kvDph.Transakcie.B3.Count);
            btnC1.Text = string.Format("C1 ({0})", kvDph.Transakcie.C1.Count);
            btnC2.Text = string.Format("C2 ({0})", kvDph.Transakcie.C2.Count);
            btnD1.Text = string.Format("D1 ({0})", kvDph.Transakcie.D1.Count);
            btnD2.Text = string.Format("D2 ({0})", kvDph.Transakcie.D2.Count);
        }

        private bool ReadXml(string path)
        {
            this.kvDph = KVDPH.LoadFromFile(path);

            var found = path.LastIndexOf('\\');
            if (found >= 0)
                ActualFileName = path.Substring(found + 1);
            else
                ActualFileName = path;

            return true;
        }

        private string GetXmlPath()
        {
            var curDir = Environment.CurrentDirectory;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML files|*.xml";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;

            Environment.CurrentDirectory = curDir;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        /// <summary>
        /// Samotna validacia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var p = new Progress(0, 100, "Kontrola kontrolného výkazu", "Validujem..", ValidationProc, ValidationDone, null, true, false);
                p.StartWorker();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        BackgroundWorker ValidationWorker;
        int counter;
        int total;
        void ValidationProc(BackgroundWorker bw, DoWorkEventArgs e, object userData)
        {
            ValidationWorker = bw;
            counter = 0;

            var rules = new DefaultValidationSetFactory().ValidationSet;
            var validator = new DefaultValidator();

            // c je pocet validatorov poloziek
            var c = rules.Count(r => r.RuleType == RuleType.A1ItemChecker || r.RuleType == RuleType.A2ItemChecker || r.RuleType == RuleType.B1ItemChecker || r.RuleType == RuleType.B2ItemChecker ||
                r.RuleType == RuleType.B3ItemChecker || r.RuleType == RuleType.C1ItemChecker || r.RuleType == RuleType.C2ItemChecker || r.RuleType == RuleType.D1ItemChecker || r.RuleType == RuleType.D2ItemChecker ||
                r.RuleType == RuleType.GeneralItemChecker);
            // total je celkovy pocet validacii poloziek, ostatne zanedbavame..
            total = c * (kvDph.Transakcie.A1.Count + kvDph.Transakcie.A2.Count + kvDph.Transakcie.B1.Count + kvDph.Transakcie.B2.Count + kvDph.Transakcie.B3.Count +
                kvDph.Transakcie.C1.Count + kvDph.Transakcie.C2.Count + kvDph.Transakcie.D1.Count + kvDph.Transakcie.D2.Count);
            // aktualna validacia
            counter = 0;

            validator.AddObserver(this);
            lastValidationResult = validator.Validate(kvDph, rules);

            ValidationWorker = null;
            bw.ReportProgress(100);
        }

        void ValidationDone()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ValidationDone));
                return;
            }

            if (lastValidationResult.Count == 0)
            {
                ValidationPassed();
            }
            else
            {
                ValidationFailed(lastValidationResult);
                identification.SetProblems(lastValidationResult);
            }
        }

        private void ValidationFailed(IValidationResult lastValidationResult)
        {
            MessageBox.Show(this, string.Format("Validácia neprebehla v poriadku, bolo zistených {0} problémov..", lastValidationResult.Count), "Validácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ValidationPassed()
        {
            MessageBox.Show(this, "Validácia prebehla v poriadku, nenašiel sa žiadny problém!", "Validácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            string fName = GetOutXmlFileName();
            if (string.IsNullOrEmpty(fName))
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                kvDph.SaveToFile(fName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Počas ukladania súboru došlo k nasledujúcej chybe: " + ex.Message, "Uložiť", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private string GetOutXmlFileName()
        {
            return GetOutFileName("xml", "XML files|*.xml");
        }

        private string GetOutXlsxFileName()
        {
            return GetOutFileName("xlsx", "Excel 2007 files|*.xlsx");
        }

        private string GetOutFileName(string defExt, string filter)
        {
            var curDir = Environment.CurrentDirectory;

            var ofd = new SaveFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.CreatePrompt = false;
            ofd.AddExtension = true;
            ofd.DefaultExt = defExt;
            ofd.Filter = filter;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.RestoreDirectory = true;

            Environment.CurrentDirectory = curDir;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        private void gridData_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = gridData.Rows[e.RowIndex];
            if (row.Tag == null)
                return;

            var problems = row.Tag as List<IValidationItemResult>;
            if (problems.Count == 0)
                return;

            e.ToolTipText = BuildErrorTooltip(problems);
        }

        private string BuildErrorTooltip(List<IValidationItemResult> problems)
        {
            var sb = new StringBuilder();

            foreach (var p in problems)
            {
                sb.AppendLine(p.ResultMessage);
            }

            return sb.ToString().Trim();
        }

        #region IValidationObserver Members

        public ObserverResult NextRule(IValidationRule rule)
        {
            counter++;
            return HandleObserverEvent();
        }

        public ObserverResult OnOk(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        public ObserverResult OnWarning(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        public ObserverResult OnError(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        public ObserverResult OnCriticalError(IValidationItemResult result)
        {
            return ObserverResult.Continue;
        }

        private ObserverResult HandleObserverEvent()
        {

            if (ValidationWorker != null)
            {
                ValidationWorker.ReportProgress(Convert.ToInt32(((double)counter / total) * 100.0));
                if (ValidationWorker.CancellationPending)
                    return ObserverResult.StopValidation;
            }

            return ObserverResult.Continue;
        }

        #endregion

        private void btnNewAvat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Naozaj si prajete začať nový kontrolný výkaz? Všetky neuložené zmeny budú stratené!", "Nový výkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            NewAvat();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var fname = GetOutXlsxFileName();
                if (string.IsNullOrEmpty(fname))
                    return;

                var p = new Progress(0, 100, "Export kontrolného výkazu do programu Excel", "Exportujem..", ExportKvProc, ExportDone, fname, true, true);
                p.StartWorker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Export kontrolného výkazu do programu Excel neprebehol úspešne: {0}{0}{1}", Environment.NewLine, ex.Message), "Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        void ExportDone()
        {
            this.BringToFront();
            this.Focus();
        }

        void ExportKvProc(BackgroundWorker bw, DoWorkEventArgs e, object userData)
        {
            var path = userData.ToString();

            using (var excel = new ExcelPackage(/*new FileInfo(path)*/))
            {
                var wsIdent = excel.Workbook.Worksheets.Add("Identifikácia");

                // stlpec A - nazvy poloziek
                wsIdent.Cells[1, 1].Value = identification.lblIcDph.Text;
                wsIdent.Cells[2, 1].Value = identification.lblDruh.Text;
                wsIdent.Cells[3, 1].Value = identification.lblObdobie.Text;
                wsIdent.Cells[4, 1].Value = identification.lblNazov.Text;
                wsIdent.Cells[5, 1].Value = identification.lblStat.Text;
                wsIdent.Cells[6, 1].Value = identification.lblObec.Text;
                wsIdent.Cells[7, 1].Value = identification.lblPsc.Text;
                wsIdent.Cells[8, 1].Value = identification.lblUlica.Text;
                wsIdent.Cells[9, 1].Value = identification.lblTelefon.Text;
                wsIdent.Cells[10, 1].Value = identification.lblEmail.Text;
                wsIdent.Column(1).AutoFit();
                var headerCol = wsIdent.Cells[1, 1, 10, 1];
                headerCol.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                headerCol.Style.Fill.BackgroundColor.SetColor(Color.Silver);
                headerCol.Style.Font.Bold = true;

                // stlpec A - nazvy poloziek
                wsIdent.Cells[1, 2].Value = identification.txtIcDph.Text;
                wsIdent.Cells[2, 2].Value = identification.txtKind.Text;
                wsIdent.Cells[3, 2].Value = identification.txtPeriod.Text;
                wsIdent.Cells[4, 2].Value = identification.txtName.Text;
                wsIdent.Cells[5, 2].Value = identification.txtState.Text;
                wsIdent.Cells[6, 2].Value = identification.txtCity.Text;
                wsIdent.Cells[7, 2].Value = identification.txtPsc.Text;
                wsIdent.Cells[8, 2].Value = identification.txtAddress.Text;
                wsIdent.Cells[9, 2].Value = identification.txtPhone.Text;
                wsIdent.Cells[10, 2].Value = identification.txteMail.Text;
                wsIdent.Column(2).AutoFit();
                var dataCol = wsIdent.Cells[1, 2, 10, 2];
                dataCol.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                dataCol.Style.Fill.BackgroundColor.SetColor(Color.Silver);
                dataCol.Style.Font.Color.SetColor(Color.DimGray);

                var ws = excel.Workbook.Worksheets.Add("A1");
                ExportList<A1>(ws, kvDph.Transakcie.A1, bw);
                ws = excel.Workbook.Worksheets.Add("A2");
                ExportList<A2>(ws, kvDph.Transakcie.A2, bw);
                ws = excel.Workbook.Worksheets.Add("B1");
                ExportList<B1>(ws, kvDph.Transakcie.B1, bw);
                ws = excel.Workbook.Worksheets.Add("B2");
                ExportList<B2>(ws, kvDph.Transakcie.B2, bw);
                ws = excel.Workbook.Worksheets.Add("B3");
                ExportList<B3>(ws, kvDph.Transakcie.B3, bw);
                ws = excel.Workbook.Worksheets.Add("C1");
                ExportList<C1>(ws, kvDph.Transakcie.C1, bw);
                ws = excel.Workbook.Worksheets.Add("C2");
                ExportList<C2>(ws, kvDph.Transakcie.C2, bw);
                ws = excel.Workbook.Worksheets.Add("D1");
                ExportList<D1>(ws, kvDph.Transakcie.D1, bw);
                ws = excel.Workbook.Worksheets.Add("D2");
                ExportList<D2>(ws, kvDph.Transakcie.D2, bw);

                excel.SaveAs(new FileInfo(path));
            }
        }

        void ExportList<T>(ExcelWorksheet ws, IList<T> data, BackgroundWorker bw)
            where T : class
        {
            bw.ReportProgress(0, "Export položiek " + ws.Name);

            var tmp = ConvertToDatatable<T>(data);
            for (int i = 0; i < tmp.Rows.Count; i++)
            {
                for (int j = 0; j < tmp.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1].Value = (tmp.Rows[i][j] ?? string.Empty).ToString();
                }

                var progres = (((double)i + 1) / (double)tmp.Rows.Count) * 100.0;
                bw.ReportProgress(Convert.ToInt32(progres));
            }

            // header
            bw.ReportProgress(100, "Nastavujem šírku stĺpcov " + ws.Name);
            for (int i = 0; i < tmp.Columns.Count; i++)
            {
                ws.Cells[1, i + 1].Value = tmp.Columns[i].Caption;
                ws.Column(i + 1).AutoFit();
            }

            var headerRow = ws.Cells[1, 1, 1, tmp.Columns.Count];
            headerRow.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            headerRow.Style.Fill.BackgroundColor.SetColor(Color.Silver);
            headerRow.Style.Font.Bold = true;
        }

        public static DataTable ConvertToDatatable<T>(IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }

            return table;
        }
    }
}
