using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KVValidator.Validators
{
    /// <summary>
    /// Validator vyplnenosti pola IcDphPlatitela v hlavicke, pripadne dalsie validacie tohto pola
    /// </summary>
    class IcDphValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnené IČ platiteľa DPH."; }
        }

        public override string RuleName
        {
            get { return "Validátor vyplnenosti IČ platiteľa DPH"; }
        }

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (string.IsNullOrEmpty(input.IcDphPlatitela))
                ret = ValidationFailed();

            return ret;
        }

        private ValidationItemResult ValidationFailed()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je vyplnené IČ platiteľa DPH v hlavičke!");
            ret.ResultTooltip = "Vyplňte IČ platiteľa DPH v sekcii '<Identifikacia>/<IcDphPlatitela>'!";
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 4;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
