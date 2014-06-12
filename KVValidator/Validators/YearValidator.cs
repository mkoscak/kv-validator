using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;
using KVValidator.Implementation;

namespace KVValidator.Validators
{
    /// <summary>
    /// Implementacia pravidla na validaciu roku
    /// </summary>
    class YearValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Validuje rok kontrolného výkazu. Musí byť väčší alebo rovný roku 2014!"; }
        }

        public override string RuleName
        {
            get { return "Validátor roku"; }
        }

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (input.Obdobie.Rok != 2014)
                ret = ValidationFailed();

            return ret;
        }

        private ValidationItemResult ValidationFailed()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = "Rok musí byť väčší alebo rovný 2014!";
            ret.ResultTooltip = "Upravte rok v sekcii '<Identifikacia>/<Obdobie>/<Rok>' na hodnotu väčšiu alebo rovnú 2014!";
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 7;

            return ret;
        }
    }
}
