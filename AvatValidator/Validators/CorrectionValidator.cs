using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;

namespace AvatValidator.Validators
{
    public class CorrectionValidator : IValidationRule
    {
        public RuleType RuleType
        {
            get { return RuleType.GeneralItemChecker; }
        }

        public string RuleDescription
        {
            get { return "Kontroluje kód opravy."; }
        }

        public string RuleName
        {
            get { return "Validátor kódu opravy"; }
        }

        public IList<IValidationItemResult> Validate(object input)
        {
            var ret = new List<IValidationItemResult>();

            // 4003
            ret.AddRange(Check4003(input));
            // 4004
            ret.AddRange(Check4004(input));

            return ret;
        }
        private IList<IValidationItemResult> Check4003(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (identification.Druh != DruhKvType.D)
                return ret;

            KodOpravyType? KOpr = GetKodOpravy(input);
            if (KOpr == null)
                ret.Add(Validation4003Failed(input));

            return ret;
        }

        private IList<IValidationItemResult> Check4004(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (identification.Druh == DruhKvType.D)
                return ret;

            KodOpravyType? KOpr = GetKodOpravy(input);
            if (KOpr.HasValue)
                ret.Add(Validation4004Failed(input));

            return ret;
        }

        private KodOpravyType? GetKodOpravy(object input)
        {
            if (input is A1 && (input as A1).KOprSpecified)
                return (input as A1).KOpr;
            if (input is A2 && (input as A2).KOprSpecified)
                return (input as A2).KOpr;
            if (input is B1 && (input as B1).KOprSpecified)
                return (input as B1).KOpr;
            if (input is B2 && (input as B2).KOprSpecified)
                return (input as B2).KOpr;
            if (input is B3 && (input as B3).KOprSpecified)
                return (input as B3).KOpr;
            if (input is C1 && (input as C1).KOprSpecified)
                return (input as C1).KOpr;
            if (input is C2 && (input as C2).KOprSpecified)
                return (input as C2).KOpr;
            if (input is D1 && (input as D1).KOprSpecified)
                return (input as D1).KOpr;
            if (input is D2 && (input as D2).KOprSpecified)
                return (input as D2).KOpr;

            return null;
        }

        private ValidationItemResult Validation4003Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Kód opravy nie je zadaný!", "Doplňte kód opravy!");
        }
        private ValidationItemResult Validation4004Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Kód opravy nesmie byt zadaný!", "Odstráňte kód opravy!");
        }

        private ValidationItemResult CreateFailedResult(object problemItem, string msg, string tooltip)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format(msg);
            ret.ResultTooltip = string.Format(tooltip);
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        Identifikacia identification;
        public bool CheckHeaderCondition(object header)
        {
            if (!(header is Identifikacia))
                return false;

            identification = header as Identifikacia;

            return true;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
