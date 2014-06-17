using System;
using System.Text;
using System.Windows.Forms;
using KVValidator;
using System.Linq;
using System.IO;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KontrolnyVykaz
{
    public partial class frmVatChecker : Form, IValidationObserver
    {
        public frmVatChecker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                Validate(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
                LogLn("Validation finish.." + Environment.NewLine);
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.DefaultExt = "xml";
            ofd.Filter = "XML files|*.xml";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.CurrentDirectory;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
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

        private void btnExecQuery_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExecNonQ_Click(object sender, EventArgs e)
        {

        }

        private void btnClearWin_Click(object sender, EventArgs e)
        {

        }
    }
}
