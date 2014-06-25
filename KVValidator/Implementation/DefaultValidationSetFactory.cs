using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;
using KVValidator.Validators;
using KVValidator.Validators.BlackListValidator;
using KVValidator.Validators.TaxPayerValidator;

namespace KVValidator.Implementation
{
    public class DefaultValidationSetFactory : IValidationSetFactory
    {
        #region IValidationSetFactory Members

        protected IValidationSet Rules { get; set; }
        
        /// <summary>
        /// Vrati default zoznam validacii
        /// </summary>
        public IValidationSet ValidationSet
        {
            get
            {
                if (Rules == null)
                    BuildRules();

                return Rules;
            }
        }

        /// <summary>
        /// Tu sa vybuduje defaultna sada validacnych pravidiel 
        /// </summary>
        private void BuildRules()
        {
            Rules = new ValidationSet();

            // hlavicka
            Rules.Add(new IcDphValidator());
            Rules.Add(new KvKindValidator());
            Rules.Add(new YearValidator());
            Rules.Add(new PeriodValidator());
            Rules.Add(new NameValidator());
            Rules.Add(new StateValidator());
            Rules.Add(new CityValidator());

            // polozky
            Rules.Add(new BlackListValidator());
            Rules.Add(new TaxRateValidator());
            Rules.Add(new TaxPayerValidator());
        }

        #endregion
    }
}
