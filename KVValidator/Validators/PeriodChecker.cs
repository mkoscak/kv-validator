﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KVValidator.Validators
{
    /// <summary>
    /// Validator poloziek z pola Obdobie
    /// </summary>
    class PeriodChecker : BaseValidationRule<Identifikacia>
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

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (input.Obdobie == null)
                ret = ValidationFailedPeriodMissing();
            else if (input.Obdobie.ItemElementName == ItemChoiceType.Missing)
                ret = ValidationFailedSubPeriodMissing();
            // TODO mala by byt aj validacia, ze nesmu byt zadane sucasne..

            return ret;
        }

        private ValidationItemResult ValidationFailedSubPeriodMissing()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Jedna z možností Mesiac alebo Štvrťrok musí byť zadaná.!");
            ret.ResultTooltip = "V sekcii '<Identifikacia>/<Obdobie>' doplňte položku Mesiac alebo Štvrťrok.";
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 8;

            return ret;
        }

        private ValidationItemResult ValidationFailedPeriodMissing()
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Chýba povinná sekcia Obdobie!");
            ret.ResultTooltip = "Vyplňte sekciu Obdobie do sekcie '<Identifikacia>/<Obdobie>'!";
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
