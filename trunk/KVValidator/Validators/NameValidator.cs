using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KVValidator.Validators
{
    /// <summary>
    /// Validacia nazvu v hlavicke
    /// </summary>
    class NameValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnený názov subjektu."; }
        }

        public override string RuleName
        {
            get { return "Validátor vyplnenosti názvu subjektu"; }
        }

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (string.IsNullOrEmpty(input.Nazov))
                ret = ValidationFailed();

            return ret;
        }

        private ValidationItemResult ValidationFailed()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je vyplnený názov subjektu v hlavičke!");
            ret.ResultTooltip = "Vyplňte názov subjektu v sekcii '<Identifikacia>/<Nazov>'!";
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 10;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
