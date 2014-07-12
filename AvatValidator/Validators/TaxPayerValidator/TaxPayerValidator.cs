using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;
using AvatValidator.Validators.TaxPayerValidator.Entities;

namespace AvatValidator.Validators.TaxPayerValidator
{
    class TaxPayerValidator : IValidationRule
    {
        public RuleType RuleType
        {
            get { return RuleType.GeneralItemChecker; }
        }

        public string RuleDescription
        {
            get { return "Kontroluje, či je daný subjekt na zozname registrovaných platiteľov DPH."; }
        }

        public string RuleName
        {
            get { return "Validátor aktuálnych platiteľov DPH"; }
        }

        public IList<IValidationItemResult> Validate(object input)
        {
            var ret = new List<IValidationItemResult>();

            string icDphOdb = null;
            string icDphDod = null;

            if (input is A1)
                icDphOdb = (input as A1).Odb;
            if (input is A2)
                icDphOdb = (input as A2).Odb;
            if (input is C1)
                icDphOdb = (input as C1).Odb;

            if (input is B1)
                icDphDod = (input as B1).Dod;
            if (input is B2)
                icDphDod = (input as B2).Dod;
            if (input is C2)
                icDphDod = (input as C2).Dod;

            if (icDphOdb != null || icDphDod != null)
            {
                var icDph = icDphOdb ?? icDphDod;
                
                var found = TaxPayerEntity.Load(string.Format("IC_DPH = \"{0}\"", icDph));
                if (found != null && found.Count == 0)
                    ret.Add(icDphOdb == null ? ValidationFailedDod(input, icDph) : ValidationFailedOdb(input, icDph));
            }

            return ret;
        }

        private ValidationItemResult ValidationFailedDod(object problemItem, string icDph)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = "IČ DPH dodávateľa sa nenachádza medzi registrovanými platcami!";
            ret.ResultTooltip = string.Format("Preverte, či je zoznam platiteľov DPH aktuálny a či je zadané IČ dodávateľa '{0}' správne!", icDph);
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        private ValidationItemResult ValidationFailedOdb(object problemItem, string icDph)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = "IČ DPH odberateľa sa nenachádza medzi registrovanými platcami!";
            ret.ResultTooltip = string.Format("Preverte, či je zoznam platiteľov DPH aktuálny a či je zadané IČ odberateľa '{0}' správne!", icDph);
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        public bool CheckHeaderCondition(object header)
        {
            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
