using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Implementation;
using AvatValidator.Interface;

namespace AvatValidator.Validators
{
    /// <summary>
    /// Validator poloziek z pola Obdobie
    /// </summary>
    class PeriodValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje zadané hodnoty v sekcii Obdobie."; }
        }

        public override string RuleName
        {
            get { return "Validátor obdobia"; }
        }

        protected override IList<IValidationItemResult> Validate(Identifikacia input)
        {
            var ret = new List<IValidationItemResult>();

            if (input.Obdobie == null)
                ret.Add(ValidationFailedPeriodMissing("<obdobie>"));
            else if (input.Obdobie.ItemElementName == ItemChoiceType.___)
                ret.Add(ValidationFailedSubPeriodMissing(input.Obdobie.ItemElementName));
            else
            {
                if ( (input.Obdobie.Item < 1))
                    ret.Add(ValidationFailedPeriod("<period>"));
                else if (
                    (input.Obdobie.ItemElementName == ItemChoiceType.Stvrtrok && input.Obdobie.Item > 4) ||
                    (input.Obdobie.ItemElementName == ItemChoiceType.Mesiac && input.Obdobie.Item > 12)
                   )
                    ret.Add(ValidationFailedPeriod(input.Obdobie.Item));
            }

            return ret;
        }

        private ValidationItemResult ValidationFailedPeriod(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Obdobie je mimo povolený rozsah!");
            ret.ResultTooltip = "Obdobie musí byť pre možnosť Mesiac od 1 do 12 a pre možnosť štvrťrok od 1 do 4.";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 7;

            return ret;
        }

        private ValidationItemResult ValidationFailedSubPeriodMissing(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Jedna z možností Mesiac alebo Štvrťrok musí byť zadaná!");
            ret.ResultTooltip = "V sekcii '<Identifikacia>/<Obdobie>' doplňte položku Mesiac alebo Štvrťrok.";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 8;

            return ret;
        }

        private ValidationItemResult ValidationFailedPeriodMissing(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Chýba povinná sekcia Obdobie!");
            ret.ResultTooltip = "Vyplňte sekciu Obdobie do sekcie '<Identifikacia>/<Obdobie>'!";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 6;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
