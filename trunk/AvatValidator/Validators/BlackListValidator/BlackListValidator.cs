using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;
using AvatValidator.Validators.BlackListValidator.Entities;

namespace AvatValidator.Validators.BlackListValidator
{
    /// <summary>
    /// Validuje zaznam voci internemu zoznamu v DB
    /// </summary>
    class BlackListValidator : IValidationRule
    {
        public RuleType RuleType
        {
            get { return RuleType.GeneralItemChecker; }
        }

        public string RuleDescription
        {
            get { return "Kontroluje, či je daný subjekt na zozname platiteľov DPH s dôvodom na zrušenie registrácie."; }
        }

        public string RuleName
        {
            get { return "Validátor zrušených platiteľov DPH"; }
        }

        public IList<IValidationItemResult> Validate(object input)
        {
            var ret = new List<IValidationItemResult>();
           
            var def = "no_problemo";
            var icDph = def;

            if (input is A1)
                icDph = (input as A1).Odb ?? def;
            if (input is A2)
                icDph = (input as A2).Odb ?? def;
            if (input is B1)
                icDph = (input as B1).Dod ?? def;
            if (input is B2)
                icDph = (input as B2).Dod ?? def;
            /*if (input is B3)
                icDph = (input as B3). ?? def;*/
            if (input is C1)
                icDph = (input as C1).Odb ?? def;
            if (input is C2)
                icDph = (input as C2).Dod ?? def;
            /*if (input is D1)
                icDph = (input as D1). ?? def;*/
            /*if (input is D2)
                icDph = (input as D2). ?? def;*/

            var found = BlackListEntity.Load(string.Format("IC_DPH = \"{0}\"", icDph));
            if (found != null && found.Count > 0)
                ret.Add(ValidationFailed(found[0], input));

            return ret;
        }

        private ValidationItemResult ValidationFailed(BlackListEntity foundEntity, object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Subjekt s IČ DPH {0} sa nachádza na zozname platiteľov DPH s dôvodom na zrušenie registrácie!", foundEntity.IcDph);
            ret.ResultTooltip = string.Format("IČ DPH: {1}{0}Názov: {2}{0}Rok porušenia: {3}{0}Dátum zverejnenia: {4}{0}", Environment.NewLine, foundEntity.IcDph, foundEntity.Nazov, foundEntity.RokPorusenia, foundEntity.DatumZverejnenia);
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
