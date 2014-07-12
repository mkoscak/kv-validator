using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;

namespace AvatValidator.Validators
{
    class GoodsValidator : IValidationRule
    {
        public RuleType RuleType
        {
            get { return RuleType.GeneralItemChecker; }
        }

        public string RuleDescription
        {
            get { return "Kontroluje tovary v sekciách A2 a C1."; }
        }

        public string RuleName
        {
            get { return "Validátor tovarov"; }
        }

        public IList<IValidationItemResult> Validate(object input)
        {
            var ret = new List<IValidationItemResult>();

            // 3001
            ret.AddRange(Check3001(input));
            // 3002
            ret.AddRange(Check3002(input));
            // 3003
            ret.AddRange(Check3003(input));
            // 3004
            ret.AddRange(Check3004(input));
            // 3005
            ret.AddRange(Check3005(input));
            // 3006
            ret.AddRange(Check3006(input));
            // 3007
            ret.AddRange(Check3007(input));

            return ret;
        }

        private IList<IValidationItemResult> Check3001(object input)
        {
            // TODO?
            var ret = new ValidationItemResult[0];
            if (!(input is A2 || input is C1))
                return ret;

            return ret;
        }

        private IList<IValidationItemResult> Check3002(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (input is A2)
                ret.AddRange(Check3002(input as A2));
            if (input is C1)
                ret.AddRange(Check3002(input as C1));

            return ret;
        }
        private IList<IValidationItemResult> Check3002(A2 a2)
        {
            if (a2.MJSpecified || a2.MnSpecified)
                if (string.IsNullOrEmpty(a2.TK) && !a2.TDSpecified)
                    return new ValidationItemResult[] { Validation3002Failed(a2) };

            return new ValidationItemResult[0];
        }
        private IList<IValidationItemResult> Check3002(C1 c1)
        {
            if (c1.MJSpecified || c1.MnSpecified)
                if (string.IsNullOrEmpty(c1.TK) && !c1.TDSpecified)
                    return new ValidationItemResult[] { Validation3002Failed(c1) };

            return new ValidationItemResult[0];
        }

        private IList<IValidationItemResult> Check3003(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (input is A2)
                ret.AddRange(Check3003(input as A2));
            if (input is C1)
                ret.AddRange(Check3003(input as C1));

            return ret;
        }
        private IList<IValidationItemResult> Check3003(A2 a2)
        {
            if (!string.IsNullOrEmpty(a2.TK) && a2.TDSpecified)
                return new ValidationItemResult[] { Validation3003Failed(a2) };

            return new ValidationItemResult[0];
        }
        private IList<IValidationItemResult> Check3003(C1 c1)
        {
            if (!string.IsNullOrEmpty(c1.TK) && c1.TDSpecified)
                return new ValidationItemResult[] { Validation3003Failed(c1) };

            return new ValidationItemResult[0];
        }

        private IList<IValidationItemResult> Check3004(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (input is A2)
                ret.AddRange(Check3004(input as A2));
            if (input is C1)
                ret.AddRange(Check3004(input as C1));

            return ret;
        }
        private IList<IValidationItemResult> Check3004(A2 a2)
        {
            if (!string.IsNullOrEmpty(a2.TK) || a2.TDSpecified)
                if (!a2.MnSpecified)
                    return new ValidationItemResult[] { Validation3004Failed(a2) };

            return new ValidationItemResult[0];
        }
        private IList<IValidationItemResult> Check3004(C1 c1)
        {
            if (!string.IsNullOrEmpty(c1.TK) || c1.TDSpecified)
                if (!c1.MnSpecified)
                    return new ValidationItemResult[] { Validation3004Failed(c1) };

            return new ValidationItemResult[0];
        }

        private IList<IValidationItemResult> Check3005(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (input is A2)
                ret.AddRange(Check3005(input as A2));
            if (input is C1)
                ret.AddRange(Check3005(input as C1));

            return ret;
        }
        bool isInt32(decimal d)
        {
            try { int res; Int32.TryParse(d.ToString(), out res); }
            catch (Exception) { return false; }
            return true;
        }
        private IList<IValidationItemResult> Check3005(A2 a2)
        {
            if (a2.MJSpecified && a2.MJ == MJType.ks && a2.MnSpecified && !isInt32(a2.Mn))
                return new ValidationItemResult[] { Validation3005Failed(a2) };

            return new ValidationItemResult[0];
        }
        private IList<IValidationItemResult> Check3005(C1 c1)
        {
            if (c1.MJSpecified && c1.MJ == MJType.ks && c1.MnSpecified && !isInt32(c1.Mn))
                return new ValidationItemResult[] { Validation3005Failed(c1) };

            return new ValidationItemResult[0];
        }

        private IList<IValidationItemResult> Check3006(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (input is A2)
                ret.AddRange(Check3006(input as A2));
            if (input is C1)
                ret.AddRange(Check3006(input as C1));

            return ret;
        }
        private IList<IValidationItemResult> Check3006(A2 a2)
        {
            if (!a2.MJSpecified && (!string.IsNullOrEmpty(a2.TK) || a2.TDSpecified || a2.MnSpecified))
                return new ValidationItemResult[] { Validation3006Failed(a2) };

            return new ValidationItemResult[0];
        }
        private IList<IValidationItemResult> Check3006(C1 c1)
        {
            if (!c1.MJSpecified && (!string.IsNullOrEmpty(c1.TK) || c1.TDSpecified || c1.MnSpecified))
                return new ValidationItemResult[] { Validation3006Failed(c1) };

            return new ValidationItemResult[0];
        }

        private IList<IValidationItemResult> Check3007(object input)
        {
            var ret = new List<IValidationItemResult>();

            if (input is A2)
                ret.AddRange(Check3007(input as A2));
            if (input is C1)
                ret.AddRange(Check3007(input as C1));

            return ret;
        }
        private IList<IValidationItemResult> Check3007(A2 a2)
        {
            if ( (a2.MJSpecified && a2.MJ == MJType.ks && !string.IsNullOrEmpty(a2.TK)) ||
                 (a2.MJSpecified && a2.MJ != MJType.ks && a2.TDSpecified))
                return new ValidationItemResult[] { Validation3007Failed(a2) };

            return new ValidationItemResult[0];
        }
        private IList<IValidationItemResult> Check3007(C1 c1)
        {
            if ((c1.MJSpecified && c1.MJ == MJType.ks && !string.IsNullOrEmpty(c1.TK)) ||
                 (c1.MJSpecified && c1.MJ != MJType.ks && c1.TDSpecified))
                return new ValidationItemResult[] { Validation3007Failed(c1) };

            return new ValidationItemResult[0];
        }

        private ValidationItemResult Validation3001Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Kód tovaru je chybný!", "Opravte kód tovaru!");
        }
        private ValidationItemResult Validation3002Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Nie je vyplnený kód ani druh tovaru!", "Doplňte kód alebo druh tovaru!");
        }
        private ValidationItemResult Validation3003Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Je vyplnený kód aj druh tovaru!", "Vymažte kód alebo druh tovaru!");
        }
        private ValidationItemResult Validation3004Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Množstvo nie je vyplnené!", "Doplňte množstvo tovaru!");
        }
        private ValidationItemResult Validation3005Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "Množstvo je chybné!", "Opravte množstvo tovaru!");
        }
        private ValidationItemResult Validation3006Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "MJ nie je vyplnená!", "Doplňte mernú jednotku!");
        }
        private ValidationItemResult Validation3007Failed(object problemItem)
        {
            return CreateFailedResult(problemItem, "MJ je chybná!", "Opravte mernú jednotku!");
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
