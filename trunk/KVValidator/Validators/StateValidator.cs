using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KVValidator.Validators
{
    /// <summary>
    /// Validator vyplnenosti pola Stat v hlavicke, pripadne dalsie validacie tohto pola
    /// </summary>
    class StateValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnený štát subjektu."; }
        }

        public override string RuleName
        {
            get { return "Validátor vyplnenosti štátu subjektu"; }
        }

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (string.IsNullOrEmpty(input.Stat))
                ret = ValidationFailed();

            return ret;
        }

        private ValidationItemResult ValidationFailed()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je vyplnený štát subjektu v hlavičke!");
            ret.ResultTooltip = "Vyplňte štát v sekcii '<Identifikacia>/<Stat>'!";
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 11;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
