using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;

namespace AvatValidator.Implementation
{
    public class ValidationItemResult : IValidationItemResult
    {
        /// <summary>
        /// Konstruktor vysledku validacie jedneho pravidla
        /// </summary>
        /// <param name="fromRule"></param>
        public ValidationItemResult(IValidationRule fromRule)
        {
            this.FromRule = fromRule;
            // dafult je vsetko ok
            this.ValidationResultState = ResultState.Ok;
        }

        #region IValidationItemResult Members

        public IValidationRule FromRule { get; set; }

        public ResultState ValidationResultState { get; set; }

        public string ResultMessage { get; set; }

        public string ResultTooltip { get; set; }

        public object ProblemObject { get; set; }

        public IDetailedResultInfo Details { get; set; }

        #endregion

        /// <summary>
        /// Staticka metoda na vytvorenie default vysledku so stavom OK
        /// </summary>
        /// <param name="fromRule"></param>
        /// <returns></returns>
        public static ValidationItemResult CreateDefaultOk(IValidationRule fromRule)
        {
            var ret = new ValidationItemResult(fromRule);
            ret.ValidationResultState = ResultState.Ok;
            ret.ResultTooltip = string.Empty;
            ret.ResultMessage = string.Empty;
            ret.Details = new DetailedResultInfo() { LineNumber = null };

            return ret;
        }
    }
}
