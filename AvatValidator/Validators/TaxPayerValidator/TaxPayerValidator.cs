using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;
using AvatValidator.Validators.TaxPayerValidator.Entities;

namespace AvatValidator.Validators.TaxPayerValidator
{
    public class TaxPayerValidator : IValidationRule
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

        Type[] relevant = new Type[] { typeof(A1), typeof(A2), typeof(C1), typeof(B1), typeof(B2), typeof(C2) };
        Type[] relevantOdb = new Type[] { typeof(A1), typeof(A2), typeof(C1) };
        Type[] relevantDod = new Type[] { typeof(B1), typeof(B2), typeof(C2) };

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

            string icDph = icDphOdb ?? icDphDod;
            if (icDph != null && icDph.Trim().Length == 0)
                icDph = null;

            if (icDph != null)
            {
                //var icDph = icDphOdb ?? icDphDod;

                if (icDph.Trim().Substring(0, 2).ToUpper() != "SK") // mame DB len slovenskych podnikatelov
                    return ret;
                
                var found = TaxPayerEntity.Load(string.Format("IC_DPH = \"{0}\"", icDph));
                if (found != null && found.Count == 0)
                    ret.Add(icDphOdb == null ? ValidationFailedDod(input, icDph) : ValidationFailedOdb(input, icDph));
            }
                // typ vstupu je medzi relevantnymi triedami -> IC nesmie byt null
            else if (relevant.Contains(input.GetType()))
            {
                // nevyplnene IC DPH
                ret.Add(MissingIcDph(input, GetSubjectType(input)));
            }

            return ret;
        }

        private string GetSubjectType(object input)
        {
            if (input == null)
                return null;

            if (relevantOdb.Contains(input.GetType()))
                return "odberateľa";

            if (relevantDod.Contains(input.GetType()))
                return "dodávateľa";

            return null;
        }

        private IValidationItemResult MissingIcDph(object problemItem, string odbDod)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je vyplnené IČ {0}!", (odbDod ?? "DPH"));
            ret.ResultTooltip = string.Format("Vyplňte povinné pole IČ {0}!", (odbDod ?? "DPH"));
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        private ValidationItemResult ValidationFailedDod(object problemItem, string icDph)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = "IČ dodávateľa sa nenachádza medzi registrovanými platcami!";
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
            ret.ResultMessage = "IČ odberateľa sa nenachádza medzi registrovanými platcami!";
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
