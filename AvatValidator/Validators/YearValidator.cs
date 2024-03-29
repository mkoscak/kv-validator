﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Implementation;

namespace AvatValidator.Validators
{
    /// <summary>
    /// Implementacia pravidla na validaciu roku
    /// </summary>
    public class YearValidator : BaseValidationRule<Identifikacia>
    {
        public override RuleType RuleType
        {
            get { return RuleType.HeaderChecker; }
        }

        public override string RuleDescription
        {
            get { return "Validuje rok kontrolného výkazu. Musí byť väčší alebo rovný roku 2014!"; }
        }

        public override string RuleName
        {
            get { return "Validátor roku"; }
        }

        protected override IList<IValidationItemResult> Validate(Identifikacia input)
        {
            var ret = new List<IValidationItemResult>();

            if (input.Obdobie.Rok == 0)
                ret.Add(ValidationFailedYearMissing("<rok>"));
            else if (input.Obdobie.Rok < 2014)
                ret.Add(ValidationFailed(input.Obdobie.Rok, input.Obdobie.Rok));

            return ret;
        }

        private ValidationItemResult ValidationFailedYearMissing(object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Nie je zadaný rok!");
            ret.ResultTooltip = "Doplňte rok do sekcie '<Identifikacia>/<Obdobie>/<Rok>' s hodnotou väčšou alebo rovnou 2014!";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 7;

            return ret;
        }

        private ValidationItemResult ValidationFailed(int year, object problemItem)
        {
            var ret = new ValidationItemResult(this);

            ret.ValidationResultState = ResultState.Error;
            ret.ResultMessage = string.Format("Rok musí byť väčší alebo rovný 2014 (aktuálne {0})!", year);
            ret.ResultTooltip = "Upravte rok v sekcii '<Identifikacia>/<Obdobie>/<Rok>' na hodnotu väčšiu alebo rovnú 2014!";
            ret.ProblemObject = problemItem;
            ret.Details = new DetailedResultInfo();
            ret.Details.LineNumber = 7;

            return ret;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", this.RuleName, this.RuleType);
        }
    }
}
