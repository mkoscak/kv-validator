using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Implementation;
using AvatValidator.Interface;

namespace AvatValidator.Validators
{
    /// <summary>
    /// Validator vyplnenia druhu kontrolneho vykazu
    /// </summary>
    class KvKindValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnený druh kontrolného výkazu a či je vyplnený korektne."; }
        }

        public override string RuleName
        {
            get { return "Validátor druhu kontrolného výkazu"; }
        }

        protected override IList<IValidationItemResult> Validate(Identifikacia input)
        {
            var ret = new List<IValidationItemResult>();

            if (input.Druh != DruhKvType.R && input.Druh != DruhKvType.O && input.Druh != DruhKvType.D)
                ret.Add(ValidationFailed(input.Druh));

            return ret;
        }

        private ValidationItemResult ValidationFailed(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Druh kontrolného výkazu nie je vyplnený resp. je vyplnený nekorektne!");
            ret.ResultTooltip = "Vyplňte druh kontrolného výkazu v sekcii '<Identifikacia>/<Druh>' na hodnotu 'R', 'O' alebo 'D'!";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 5;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
