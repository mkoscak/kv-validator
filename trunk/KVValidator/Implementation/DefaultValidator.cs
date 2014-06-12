using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;

namespace KVValidator.Implementation
{
    public class DefaultValidator : IValidator
    {
        protected List<IValidationObserver> Observers = new List<IValidationObserver>();

        #region IValidator Members

        /// <summary>
        /// Validacia vstupnej struktury
        /// </summary>
        /// <param name="input"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        public IValidationResult Validate(KVDPH input, IValidationSet rules)
        {
            var ret = new ValidationResult();

            // generalna validacia - napr. na null hodnoty a pod.
            var generalCheckers = rules.Where(r => r.RuleType == RuleType.General).ToList();
            foreach (var genCheck in generalCheckers)
            {
                var retCheck = genCheck.Validate(input);
                if (retCheck.ValidationResultState != ResultState.Ok)
                    ret.Add(retCheck);
            }

            // validacia xml ako celku
            var xmlCheckers = rules.Where(r => r.RuleType == RuleType.WholeXml).ToList();
            foreach (var xmlCheck in xmlCheckers)
            {
                var retCheck = xmlCheck.Validate(input);
                if (retCheck.ValidationResultState != ResultState.Ok)
                    ret.Add(retCheck);
            }

            // validacia hlaviciek
            var headerCheckers = rules.Where(r => r.RuleType == RuleType.HeaderChecker).ToList();
            foreach (var headCheck in headerCheckers)
            {
                var retCheck = headCheck.Validate(input.Identifikacia);
                if (retCheck.ValidationResultState != ResultState.Ok)
                    ret.Add(retCheck);
            }

            // validacia poloziek
            ValidateItems<A1>(input.Transakcie.A1, ret,
                rules.Where(r => r.RuleType == RuleType.A1ItemChecker).ToList());
            ValidateItems<A2>(input.Transakcie.A2, ret,
                rules.Where(r => r.RuleType == RuleType.A2ItemChecker).ToList());
            ValidateItems<B1>(input.Transakcie.B1, ret,
                rules.Where(r => r.RuleType == RuleType.B2ItemChecker).ToList());
            ValidateItems<B2>(input.Transakcie.B2, ret,
                rules.Where(r => r.RuleType == RuleType.B2ItemChecker).ToList());
            ValidateItems<B3>(input.Transakcie.B3, ret,
                rules.Where(r => r.RuleType == RuleType.B3ItemChecker).ToList());
            ValidateItems<C1>(input.Transakcie.C1, ret,
                rules.Where(r => r.RuleType == RuleType.C1ItemChecker).ToList());
            ValidateItems<C2>(input.Transakcie.C2, ret,
                rules.Where(r => r.RuleType == RuleType.C2ItemChecker).ToList());
            ValidateItems<D1>(input.Transakcie.D1, ret,
                rules.Where(r => r.RuleType == RuleType.D1ItemChecker).ToList());
            ValidateItems<D2>(input.Transakcie.D2, ret,
                rules.Where(r => r.RuleType == RuleType.D2ItemChecker).ToList());

            return ret;
        }

        /// <summary>
        /// Genericka validacia poloziek daneho typu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="ret"></param>
        /// <param name="checkers"></param>
        private static void ValidateItems<T>(IList<T> items, ValidationResult ret, List<IValidationRule> checkers)
        {
            foreach (var item in items)
            {
                foreach (var itemCheck in checkers)
                {
                    var retCheck = itemCheck.Validate(item);
                    if (retCheck.ValidationResultState != ResultState.Ok)
                        ret.Add(retCheck);
                }
            }
        }

        public void AddObserver(IValidationObserver observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);
        }

        public void RemoveObserver(IValidationObserver observer)
        {
            if (Observers.Contains(observer))
                Observers.Remove(observer);
        }

        #endregion
    }
}
