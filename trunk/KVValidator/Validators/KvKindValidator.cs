﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Implementation;
using KVValidator.Interface;

namespace KVValidator.Validators
{
    /// <summary>
    /// Validator vyplnenia druhu kontrolneho vykazu
    /// </summary>
    class KvKindValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnený druh kontrolného výkazu a či je vyplnený korektne."; }
        }

        public override string RuleName
        {
            get { return "Validátor druhu kontrolného výkazu"; }
        }

        protected override IValidationItemResult Validate(Identifikacia input)
        {
            var ret = ValidationItemResult.CreateDefaultOk(this);

            if (input.Druh != DruhKvType.R && input.Druh != DruhKvType.O && input.Druh != DruhKvType.D)
                ret = ValidationFailed(input);

            return ret;
        }

        private ValidationItemResult ValidationFailed(Identifikacia problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Druh kontrolného výkazu nie je vyplnený resp. je vyplnený nekorektne!");
            ret.ResultTooltip = "Vyplňte druh kontrolného výkazu v sekcii '<Identifikacia>/<Druh>' na hodnotu 'R', 'O' alebo 'D'!";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 5;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
