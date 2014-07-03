using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KVValidator;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KontrolnyVykaz
{
    public partial class FrmDesignOne : Form
    {
        string FormTitle;

        KVDPH kvDph = new KVDPH();

        IValidationResult lastValidationResult;
        DataGridViewCellStyle errorStyle;
        CtrlIdentification identification;

        public FrmDesignOne()
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
            SetFileName("nový.xml");

            errorStyle = new DataGridViewCellStyle(gridData.DefaultCellStyle);
            errorStyle.ForeColor = Color.Red;
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
            DisableAllButtons(btnIdentification);
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
                Cursor = Cursors.WaitCursor;
                if (!ReadXml())
                    return;

                //MessageBox.Show(this, "Načítanie vstupného súboru prebehlo úspešne!", "Načítanie xml", MessageBoxButtons.OK, MessageBoxIcon.Information);
                identification.SetData(kvDph.Identifikacia);
                btnIdentification.PerformClick();
                UpdateButtonTexts();
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

        private bool ReadXml()
        {
            string path = GetXmlPath();
            if (string.IsNullOrEmpty(path))
                return false;

            this.kvDph = KVDPH.LoadFromFile(path);

            var found = path.LastIndexOf('\\');
            if (found >= 0)
                SetFileName(path.Substring(found + 1));
            else
                SetFileName(path);

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
            var rules = new DefaultValidationSetFactory().ValidationSet;
            var validator = new DefaultValidator();

            try
            {
                Cursor = Cursors.WaitCursor;
                var result = validator.Validate(kvDph, rules);

                if (result.Count == 0)
                {
                    ValidationPassed();
                    return;
                }
                else
                {
                    lastValidationResult = result;
                    ValidationFailed(lastValidationResult);
                    
                    identification.SetProblems(result);
                    return;
                }
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

            kvDph.SaveToFile(fName);
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
    }
}
