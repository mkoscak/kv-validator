using System;
using System.Text;
using System.Windows.Forms;
using KVValidator;
using System.Linq;
using System.IO;
using KVValidator.Implementation;
using KVValidator.Interface;
using KVValidator.Sql;
using VAToo;
using System.Diagnostics;

namespace KontrolnyVykaz
{
    public partial class frmVatChecker : Form, IValidationObserver
    {
        public frmVatChecker()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                LogLn("----------------------------------------------------------------------------", false);
                LogLn("Validation started..");

                string path = GetXmlPath();
                if (string.IsNullOrEmpty(path))
                    return;

                LogLn(string.Format("File {0} selected..", path));
                Cursor = Cursors.WaitCursor;

                var sw = new Stopwatch();
                sw.Start();
                Validate(path);
                sw.Stop();
                LogLn(string.Format("Duration {0} seconds..", sw.ElapsedMilliseconds / 1000));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
                LogLn("Validation finished.." + Environment.NewLine);
            }
        }

        /// <summary>
        /// Validacia s default validatorom a defaultnym setom pravidiel
        /// </summary>
        /// <param name="path"></param>
        private void Validate(string path)
        {
            Log("Reading input file.. ");
            var kv = KVDPH.LoadFromFile(path);
            LogLn("OK", false);

            Log("Creating validation rules set.. ");
            var rules = new DefaultValidationSetFactory().ValidationSet;
            LogLn("OK", false);
            LogLn("Number of rules: " + rules.Count);

            LogLn("Validating..");
            var validator = new DefaultValidator();
            validator.AddObserver(this);
            var result = validator.Validate(kv, rules);
            LogLn("Validating completed.");
            if (result.Count == 0)
            {
                LogLn("Validation passed with no problems or warnings.");
                return;
            }
            else
            {
                LogLn("Number of problems: " + result.Count);
                foreach (var problem in result)
                    HandleProblem(problem);
                Log(Environment.NewLine, false);
            }
        }

        private void HandleProblem(KVValidator.Interface.IValidationItemResult problem)
        {
            Log(Environment.NewLine, false);
            LogLn("Result: " + problem.ValidationResultState);
            LogLn("Message: " + problem.ResultMessage);
            LogLn("Tooltip: " + problem.ResultTooltip);
            LogLn("Problem line number: " + problem.Details.LineNumber);
        }

        void Log(string what)
        {
            Log(what, true);
        }

        void Log(string what, bool withTime)
        {
            if (withTime)
                txtLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + "\t");

            txtLog.AppendText(what);
        }

        void LogLn(string what)
        {
            LogLn(what, true);
        }

        void LogLn(string what, bool withTime)
        {
            if (withTime)
                txtLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + "\t");

            txtLog.AppendText(what + Environment.NewLine);
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

        private void btnBlacklistImport_Click(object sender, EventArgs e)
        {
            try
            {

                LogLn("----------------------------------------------------------------------------", false);
                LogLn("Import blacklist started..");

                var xml = GetXmlPath();
                if (string.IsNullOrEmpty(xml))
                    return;

                LogLn(string.Format("File {0} selected..", xml));
                Cursor = Cursors.WaitCursor;

                var count = KVValidator.Validators.BlackListValidator.Entities.BlackListManager.ImportDataFromXml(xml);

                LogLn("Import success! " + count + " items..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
                LogLn("Import finished.." + Environment.NewLine);
            }

        }

        #region IValidationObserver Members

        public ObserverResult OnOk(IValidationItemResult result)
        {
            LogLn(result.ValidationResultState.ToString(), false);

            return ObserverResult.Continue;
        }

        public ObserverResult OnWarning(IValidationItemResult result)
        {
            LogLn(result.ValidationResultState.ToString(), false);

            return ObserverResult.Continue;
        }

        public ObserverResult OnError(IValidationItemResult result)
        {
            LogLn(result.ValidationResultState.ToString(), false);

            return ObserverResult.Continue;
        }

        public ObserverResult OnCriticalError(IValidationItemResult result)
        {
            LogLn(result.ValidationResultState.ToString(), false);

            return ObserverResult.Continue;
        }

        public ObserverResult NextRule(IValidationRule rule)
        {
            Log("\tNext rule: " + rule.ToString() + ".. ");

            return ObserverResult.Continue;
        }

        #endregion

        #region DB helper

        DbProvider db = DbProvider.Instance;

        private void btnExecQuery_Click(object sender, EventArgs e)
        {
            try
            {
                var res = db.ExecuteQuery(txtQuery.SelectedText);
                if (res != null && res.Tables.Count > 0)
                    gridResults.DataSource = res.Tables[0];
            }
            catch (Exception ex)
            {
                txtQuery.AppendText(Environment.NewLine + ex.Message);
            }
        }

        private void btnExecNonQ_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExecuteNonQuery(txtQuery.SelectedText);
                txtQuery.AppendText(Environment.NewLine + "Command executed!");
            }
            catch (Exception ex)
            {
                txtQuery.AppendText(Environment.NewLine + ex.Message);
            }
        }

        private void btnClearWin_Click(object sender, EventArgs e)
        {
            txtQuery.Clear();
        }

        #endregion

        private void btnVatoo_Click(object sender, EventArgs e)
        {
            FrmVatoo form = new FrmVatoo();
            form.Show();
        }
    }
}
