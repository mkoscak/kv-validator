using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AvatValidator.Interface;
using AvatValidator.Implementation;
using AvatValidator.Validators;
using AvatValidator.Validators.BlackListValidator;
using AvatValidator.Validators.TaxPayerValidator;
using AvatValidator;

namespace Avat.Components
{
    public partial class CtrlValidationResult3 : UserControl
    {
        CtrlResultPanel2 podlaTypu;
        CtrlResultPanel2 podlaVyskytu;
        
        public CtrlValidationResult3()
        {
            InitializeComponent();

            /*var bm = SystemIcons.Exclamation.ToBitmap();
            lblWarning.Image = bm;*/
            podlaTypu = new CtrlResultPanel2("Podľa typu");
            podlaVyskytu = new CtrlResultPanel2("Podľa výskytu");

            Clear();
        }

        public void Clear()
        {
            lblErrCount.Text = "-";
            lblBlacklistCount.Text = "-";
            contentLayout.SuspendLayout();
            contentLayout.Controls.Clear();
            contentLayout.Controls.Add(podlaTypu);
            contentLayout.Controls.Add(podlaVyskytu);
            contentLayout.ResumeLayout(true);
        }

        public void AddProblem(string name, int count, string text, bool warning, int row, int col)
        {
            CtrlResultPanel2 p = new CtrlResultPanel2(name, count/*, text, warning*/);

            contentLayout.SuspendLayout();
            contentLayout.Controls.Add(p, col, row);
            contentLayout.ResumeLayout(false);
        }

        public void ShowResult(IValidationResult Result)
        {
            Clear();
            contentLayout.SuspendLayout();

            if (Result == null)
                Result = new ValidationResult();

            lblErrCount.Text = string.Format("{0} {1}", Common.theSign, Result.Count);

            List<IValidationItemResult> found;

            var row = 1;
            found = Result.Where(r => r.FromRule is IcDphValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is KvKindValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is PeriodValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is YearValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is NameValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is StateValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is CityValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is BlackListValidator).ToList();
            CheckFound(found, ref row, 0);
            lblBlacklistCount.Text = string.Format("{0} {1}", Common.theSign, found.Count);

            found = Result.Where(r => r.FromRule is TaxPayerValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is CorrectionValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is GoodsValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is TaxRateValidator).ToList();
            CheckFound(found, ref row, 0);
            found = Result.Where(r => r.FromRule is ItemTaxValidator).ToList();
            CheckFound(found, ref row, 0);

            row = 1;
            found = Result.Where(r => r.ProblemObject is A1).ToList();
            if (found.Count > 0)
                AddProblem("A.1.", found.Count, "Problémové položky typu A1.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is A2).ToList();
            if (found.Count > 0)
                AddProblem("A.2.", found.Count, "Problémové položky typu A2.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is B1).ToList();
            if (found.Count > 0)
                AddProblem("B.1.", found.Count, "Problémové položky typu B1.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is B2).ToList();
            if (found.Count > 0)
                AddProblem("B.2.", found.Count, "Problémové položky typu B2.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is B3).ToList();
            if (found.Count > 0)
                AddProblem("B.3.", found.Count, "Problémové položky typu B3.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is C1).ToList();
            if (found.Count > 0)
                AddProblem("C.1.", found.Count, "Problémové položky typu C1.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is C2).ToList();
            if (found.Count > 0)
                AddProblem("C.2.", found.Count, "Problémové položky typu C2.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is D1).ToList();
            if (found.Count > 0)
                AddProblem("D.1.", found.Count, "Problémové položky typu D1.", false, row++, 1);

            found = Result.Where(r => r.ProblemObject is D2).ToList();
            if (found.Count > 0)
                AddProblem("D.2.", found.Count, "Problémové položky typu D2.", false, row++, 1);

            contentLayout.ResumeLayout(true);
        }

        private void CheckFound(List<IValidationItemResult> found, ref int row, int col)
        {
            var err = found.Where(r => r.ValidationResultState == ResultState.Error).ToList();
            if (err.Count > 0)
                AddProblem(err[0].FromRule.RuleName, err.Count, err[0].FromRule.RuleDescription, false, row++, col);
            var warn = found.Where(r => r.ValidationResultState == ResultState.OkWithWarning).ToList();
            if (warn.Count > 0)
                AddProblem(warn[0].FromRule.RuleName, warn.Count, warn[0].FromRule.RuleDescription, true, row++, col);
        }
    }
}
