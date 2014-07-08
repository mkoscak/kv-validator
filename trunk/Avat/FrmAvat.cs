using System;
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

        private void btnA1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA1);
            gridData.DataSource = new BindingList<A1>();

            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A1 != null)
            {
                gridData.DataSource = new BindingList<A1>(kvDph.Transakcie.A1);
                var ds = gridData.DataSource as BindingList<A1>;
                CheckSetErrors<A1>(ds);
            }
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

        private void btnA2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnA2);
            gridData.DataSource = new BindingList<A2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.A2 != null)
            {
                gridData.DataSource = new BindingList<A2>(kvDph.Transakcie.A2);
                var ds = gridData.DataSource as BindingList<A2>;
                CheckSetErrors<A2>(ds);
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB1);
            gridData.DataSource = new BindingList<B1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B1 != null)
            {
                gridData.DataSource = new BindingList<B1>(kvDph.Transakcie.B1);
                var ds = gridData.DataSource as BindingList<B1>;
                CheckSetErrors<B1>(ds);
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB2);
            gridData.DataSource = new BindingList<B2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B2 != null)
            {
                gridData.DataSource = new BindingList<B2>(kvDph.Transakcie.B2);
                var ds = gridData.DataSource as BindingList<B2>;
                CheckSetErrors<B2>(ds);
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnB3);
            gridData.DataSource = new BindingList<B3>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.B3 != null)
            {
                gridData.DataSource = new BindingList<B3>(kvDph.Transakcie.B3);
                var ds = gridData.DataSource as BindingList<B3>;
                CheckSetErrors<B3>(ds);
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC1);
            gridData.DataSource = new BindingList<C1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C1 != null)
            {
                gridData.DataSource = new BindingList<C1>(kvDph.Transakcie.C1);
                var ds = gridData.DataSource as BindingList<C1>;
                CheckSetErrors<C1>(ds);
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnC2);
            gridData.DataSource = new BindingList<C2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.C2!= null)
            {
                gridData.DataSource = new BindingList<C2>(kvDph.Transakcie.C2);
                var ds = gridData.DataSource as BindingList<C2>;
                CheckSetErrors<C2>(ds);
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD1);
            gridData.DataSource = new BindingList<D1>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D1 != null)
            {
                gridData.DataSource = new BindingList<D1>(kvDph.Transakcie.D1);
                var ds = gridData.DataSource as BindingList<D1>;
                CheckSetErrors<D1>(ds);
            }
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            DisableAllButtons(btnD2);
            gridData.DataSource = new BindingList<D2>();
            if (kvDph != null && kvDph.Transakcie != null && kvDph.Transakcie.D2 != null)
            {
                gridData.DataSource = new BindingList<D2>(kvDph.Transakcie.D2);
                var ds = gridData.DataSource as BindingList<D2>;
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
            string fName = GetOutFileName();
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

        private string GetOutFileName()
        {
            var curDir = Environment.CurrentDirectory;

            var ofd = new SaveFileDialog();
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.CreatePrompt = false;
            ofd.AddExtension = true;
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML files|*.xml";
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
    }
}
