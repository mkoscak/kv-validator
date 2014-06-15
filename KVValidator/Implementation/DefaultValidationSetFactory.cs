using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;
using KVValidator.Validators;

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

            Rules.Add(new YearValidator());
        }

        #endregion
    }
}
