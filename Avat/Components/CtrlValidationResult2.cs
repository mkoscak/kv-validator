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
    public partial class CtrlValidationResult2 : UserControl
    {
        CtrlResultPanel okPanel;
        CtrlResultPanel notRunPanel;

        public CtrlValidationResult2()
        {
            InitializeComponent();

            okPanel = new CtrlResultPanel("Výborne! Váš kontrolný výkaz je v poriadku!", 0, "V kontrolnom výkaze sa nenašli žiadne chyby, tento výkaz je možné uložiť cez hornú ponuku.", false);
            notRunPanel = new CtrlResultPanel("Spustite kontrolu", -1, "Kontrola výkazu ešte nebola spustená, pokračujte načítaním a/alebo spustením kontroly v hornom menu.", true);
            Clear();
        }

        public void AddProblem(string name, int count, string text, bool warning)
        {
            CtrlResultPanel p = new CtrlResultPanel(name, count, text, warning);

            flowContent.SuspendLayout();
            flowContent.Controls.Add(p);
            flowContent.ResumeLayout(false);
        }

        public void Clear()
        {
            flowContent.SuspendLayout();
            flowContent.Controls.Clear();
            flowContent.Controls.Add(notRunPanel);
            flowContent.ResumeLayout(true);
        }

        public void ShowResult(IValidationResult Result)
        {
            Clear();

            if (Result == null)
                Result = new ValidationResult();

            List<IValidationItemResult> found;

            found = Result.Where(r => r.FromRule is IcDphValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is KvKindValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is PeriodValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is YearValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is NameValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is StateValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is CityValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is BlackListValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is TaxPayerValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is CorrectionValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is GoodsValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is TaxRateValidator).ToList();
            CheckFound(found);
            found = Result.Where(r => r.FromRule is ItemTaxValidator).ToList();
            CheckFound(found);

            found = Result.Where(r => r.ProblemObject is A1).ToList();
            if (found.Count > 0)
                AddProblem("A1", found.Count, "Problémové položky typu A1.", false);

            found = Result.Where(r => r.ProblemObject is A2).ToList();
            if (found.Count > 0)
                AddProblem("A2", found.Count, "Problémové položky typu A2.", false);

            found = Result.Where(r => r.ProblemObject is B1).ToList();
            if (found.Count > 0)
                AddProblem("B1", found.Count, "Problémové položky typu B1.", false);

            found = Result.Where(r => r.ProblemObject is B2).ToList();
            if (found.Count > 0)
                AddProblem("B2", found.Count, "Problémové položky typu B2.", false);

            found = Result.Where(r => r.ProblemObject is B3).ToList();
            if (found.Count > 0)
                AddProblem("B3", found.Count, "Problémové položky typu B3.", false);

            found = Result.Where(r => r.ProblemObject is C1).ToList();
            if (found.Count > 0)
                AddProblem("C1", found.Count, "Problémové položky typu C1.", false);

            found = Result.Where(r => r.ProblemObject is C2).ToList();
            if (found.Count > 0)
                AddProblem("C2", found.Count, "Problémové položky typu C2.", false);

            found = Result.Where(r => r.ProblemObject is D1).ToList();
            if (found.Count > 0)
                AddProblem("D1", found.Count, "Problémové položky typu D1.", false);

            found = Result.Where(r => r.ProblemObject is D2).ToList();
            if (found.Count > 0)
                AddProblem("D2", found.Count, "Problémové položky typu D2.", false);

            flowContent.SuspendLayout();
            flowContent.Controls.Remove(notRunPanel);
            // pridame ok panel - vsetko je v poriadku
            if (flowContent.Controls.Count == 0)
                flowContent.Controls.Add(okPanel);
            flowContent.ResumeLayout();
        }

        private void CheckFound(List<IValidationItemResult> found)
        {
            var err = found.Where(r => r.ValidationResultState == ResultState.Error).ToList();
            if (err.Count > 0)
                AddProblem(err[0].FromRule.RuleName, err.Count, err[0].FromRule.RuleDescription, false);
            var warn = found.Where(r => r.ValidationResultState == ResultState.OkWithWarning).ToList();
            if (warn.Count > 0)
                AddProblem(warn[0].FromRule.RuleName, warn.Count, warn[0].FromRule.RuleDescription, true);
        }
    }
}
