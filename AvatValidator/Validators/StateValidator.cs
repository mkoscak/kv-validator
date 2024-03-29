﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Implementation;
using AvatValidator.Interface;

namespace AvatValidator.Validators
{
    /// <summary>
    /// Validator vyplnenosti pola Stat v hlavicke, pripadne dalsie validacie tohto pola
    /// </summary>
    public class StateValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Kontroluje, či je v hlavičke vyplnený štát subjektu."; }
        }

        public override string RuleName
        {
            get { return "Validátor vyplnenosti štátu subjektu"; }
        }

        protected override IList<IValidationItemResult> Validate(Identifikacia input)
        {
            var ret = new List<IValidationItemResult>();

            if (string.IsNullOrEmpty(input.Stat))
                ret.Add(ValidationFailed("<stat>"));

            return ret;
        }

        private ValidationItemResult ValidationFailed(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je vyplnený štát subjektu v hlavičke!");
            ret.ResultTooltip = "Vyplňte štát v sekcii '<Identifikacia>/<Stat>'!";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 11;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
