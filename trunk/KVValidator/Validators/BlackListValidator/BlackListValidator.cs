using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;
using KVValidator.Implementation;

namespace KVValidator.Validators.BlackListValidator
{
    /// <summary>
    /// Validuje zaznam voci internemu zoznamu v DB
    /// </summary>
    class BlackListValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.A1ItemChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnený druh kontrolného výkazu."; }
        }

        public override string RuleName
        {
            get { return "Validátor vyplnenosti druhu KV"; }
        }

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (input.Druh != DruhKvType.R && input.Druh != DruhKvType.O && input.Druh != DruhKvType.D)
                ret = ValidationFailed();

            return ret;
        }

        private ValidationItemResult ValidationFailed()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Druh kontrolného výkazu nie je vyplnený resp. je vyplnený nekorektne!");
            ret.ResultTooltip = "Vyplnte druh kontrolného výkazu v sekcii '<Identifikacia>/<Druh>' na hodnotu 'R', 'O' alebo 'D'!";
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
