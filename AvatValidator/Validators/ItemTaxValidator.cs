using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;

namespace AvatValidator.Validators
{
    class ItemTaxValidator : IValidationRule
    {
        public RuleType RuleType
        {
            get { return RuleType.GeneralItemChecker; }
        }

        public string RuleDescription
        {
            get { return "Kontroluje dane a odpočty."; }
        }

        public string RuleName
        {
            get { return "Validátor daní a odpočtov"; }
        }

        public IList<IValidationItemResult> Validate(object input)
        {
            var ret = new List<IValidationItemResult>();

            // kontrola 2001
            var zaklad = GetZaklad(input);
            if (zaklad != null && zaklad < 0)
                ret.Add(Validation2001Failed(input));

            // 2002
            IValidationItemResult res2002 = Check2002(input);
            if (res2002 != null)
                ret.Add(res2002);

            // 2003
            IValidationItemResult res2003 = Check2003(input);
            if (res2003 != null)
                ret.Add(res2003);

            return ret;
        }

        private IValidationItemResult Check2003(object input)
        {
            var o = GetOdpocet2003(input);
            if (o == null)
                return null;

            var d = GetDan2003(input);
            if (d == null)
                return null;

            if (o.Value > d.Value)
                return Validation2003Failed(input);

            return null;
        }

        private decimal? GetOdpocet2003(object input)
        {
            if (input is B1)
                return (input as B1).O;
            if (input is B2)
                return (input as B2).O;
            /*if (input is C1)
                return (input as C1).D;
            if (input is C2)
                return (input as C2).D;*/

            return null;
        }

        private decimal? GetDan2003(object input)
        {
            if (input is B1)
                return (input as B1).D;
            if (input is B2)
                return (input as B2).D;
            /*if (input is C1)
                return (input as C1).D;
            if (input is C2)
                return (input as C2).D;*/

            return null;
        }

        private IValidationItemResult Check2002(object input)
        {
            var z = GetZaklad2(input);
            if (z == null)
                return null;

            var s = GetSadzba(input);
            if (s == null)
                return null;

            var d = GetDan(input);
            if (d == null)
                return null;

            var dest = Math.Round( (z.Value * 100 * s.Value) / 10000, 2, MidpointRounding.AwayFromZero);
            if (dest != d)
                return Validation2002Failed(input);

            return null;
        }

        private decimal? GetDan(object input)
        {
            if (input is A1)
                return (input as A1).D;
            if (input is B1)
                return (input as B1).D;
            if (input is B2)
                return (input as B2).D;
            /*if (input is C1)
                return (input as C1).D;
            if (input is C2)
                return (input as C2).D;*/
            if (input is D1)
                return (input as D1).D;
            if (input is D2)
                return (input as D2).D;

            return null;
        }

        private decimal? GetSadzba(object input)
        {
            SadzbaDaneType S = SadzbaDaneType.Missing;

            if (input is A1)
                S = (input as A1).S;
            if (input is B1)
                S = (input as B1).S;
            if (input is B2)
                S = (input as B2).S;
            /*if (input is C1)
                S = (input as C1).S;
            if (input is C2)
                S = (input as C2).S;*/
            /*if (input is D1)
                S = (input as D1).S;
            if (input is D2)
                S = (input as D2).S;*/

            if (S == SadzbaDaneType.Item10)
                return 10;
            if (S == SadzbaDaneType.Item20)
                return 20;

            return null;
        }

        private decimal? GetZaklad2(object input)
        {
            if (input is A1)
                return (input as A1).Z;
            if (input is B1)
                return (input as B1).Z;
            if (input is B2)
                return (input as B2).Z;
            /*if (input is C1)
                return (input as C1).Z;
            if (input is C2)
                return (input as C2).Z;*/
            if (input is D1)
                return (input as D1).Z;
            if (input is D2)
                return (input as D2).Z;

            return null;
        }

        private decimal? GetZaklad(object input)
        {
            if (input is A1)
                return (input as A1).Z;
            if (input is A2)
                return (input as A2).Z;
            if (input is B1)
                return (input as B1).Z;
            if (input is B2)
                return (input as B2).Z;
            if (input is B3)
                return (input as B3).Z;

            return null;
        }

        private ValidationItemResult Validation2002Failed(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Daň je chybná!");
            ret.ResultTooltip = string.Format("Základ dane * sadzba dane sa nerovná výslednej dani!");
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        private IValidationItemResult Validation2003Failed(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Odpočet je chybný!");
            ret.ResultTooltip = string.Format("Odpočet je vyšší ako Daň!");
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 0;

            return ret;
        }

        private ValidationItemResult Validation2001Failed(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Základ dane nesmie byť záporný!");
            ret.ResultTooltip = string.Format("Opravte základ dane na nezápornú hodnotu!");
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
