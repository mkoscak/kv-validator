using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KVValidator.Validators
{
    /// <summary>
    /// Validator sadzby dane
    /// </summary>
    class TaxRateValidator : IValidationRule
    {
        public RuleType RuleType
        {
            get { return RuleType.GeneralItemChecker; }
        }

        public string RuleDescription
        {
            get { return "Kontroluje zadanú sadzbu DPH."; }
        }

        public string RuleName
        {
            get { return "Validátor sadzby DPH"; }
        }

        public IValidationItemResult Validate(object input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (input is A1 && (input as A1).S != SadzbaDaneType.Item10 && (input as A1).S != SadzbaDaneType.Item20)
                ret = ValidationFailed(input);
            if (input is B1 && (input as B1).S != SadzbaDaneType.Item10 && (input as B1).S != SadzbaDaneType.Item20)
                ret = ValidationFailed(input);
            if (input is B2 && (input as B2).S != SadzbaDaneType.Item10 && (input as B2).S != SadzbaDaneType.Item20)
                ret = ValidationFailed(input);
            if (input is C1 && (input as C1).S != SadzbaDaneType.Item10 && (input as C1).S != SadzbaDaneType.Item20)
                ret = ValidationFailed(input);
            if (input is C2 && (input as C2).S != SadzbaDaneType.Item10 && (input as C2).S != SadzbaDaneType.Item20)
                ret = ValidationFailed(input);

            return ret;
        }

        private ValidationItemResult ValidationFailed(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Sadzba dane môže byť 20% (základná sadzba dane) alebo 10% (znížená sadzba dane).");
            ret.ResultTooltip = string.Format("Opravte sadzbu dane na povolené hodnoty 10% resp. 20%'!");
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
