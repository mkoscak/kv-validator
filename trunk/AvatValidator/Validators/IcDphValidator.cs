using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Implementation;
using AvatValidator.Interface;
using AvatValidator.Validators.TaxPayerValidator.Entities;

namespace AvatValidator.Validators
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
            get { return "Kontroluje IČ platiteľa DPH v hlavičke."; }
        }

        public override string RuleName
        {
            get { return "Validátor IČ platiteľa DPH"; }
        }

        protected override IList<IValidationItemResult> Validate(Identifikacia input)
        {
            var ret = new List<IValidationItemResult>();

            if (string.IsNullOrEmpty(input.IcDphPlatitela))
                ret.Add(ValidationFailedNullIc("<icdph>"));
            else
            {
                // kontrola na existujuce IC DPH
                var found = TaxPayerEntity.Load(string.Format("IC_DPH = \"{0}\"", input.IcDphPlatitela));
                if (found != null && found.Count == 0)
                    ret.Add(ValidationFailedNoExistPayer(input.IcDphPlatitela));
            }

            return ret;
        }

        private ValidationItemResult ValidationFailedNoExistPayer(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = "IČ platiteľa DPH sa nenachádza medzi registrovanými platcami!";
            ret.ResultTooltip = string.Format("Preverte, či je zoznam platiteľov DPH aktuálny a či je zadané IČ '{0}' v sekcii <Identifikacia> správne!", problemItem.ToString());
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 4;

            return ret;
        }

        private ValidationItemResult ValidationFailedNullIc(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je vyplnené IČ platiteľa DPH v hlavičke!");
            ret.ResultTooltip = "Vyplňte IČ platiteľa DPH v sekcii '<Identifikacia>/<IcDphPlatitela>'!";
            ret.ProblemObject = problemItem;
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
