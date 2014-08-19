using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;
using AvatValidator.Exceptions;

namespace AvatValidator.Implementation
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
                if (HandleBeforeObservers(genCheck))
                    continue;

                var retCheck = genCheck.Validate(input);
                if (retCheck.Count(r => r.ValidationResultState != ResultState.Ok) > 0)
                    ret.AddRange(retCheck);

                HandleObservers(retCheck);
            }

            // validacia xml ako celku
            var xmlCheckers = rules.Where(r => r.RuleType == RuleType.WholeXml).ToList();
            foreach (var xmlCheck in xmlCheckers)
            {
                if (HandleBeforeObservers(xmlCheck))
                    continue;

                var retCheck = xmlCheck.Validate(input);
                if (retCheck.Count(r => r.ValidationResultState != ResultState.Ok) > 0)
                    ret.AddRange(retCheck);

                HandleObservers(retCheck);
            }

            // validacia hlaviciek
            var headerCheckers = rules.Where(r => r.RuleType == RuleType.HeaderChecker).ToList();
            foreach (var headCheck in headerCheckers)
            {
                if (HandleBeforeObservers(headCheck))
                    continue;

                var retCheck = headCheck.Validate(input.Identifikacia);
                if (retCheck.Count(r => r.ValidationResultState != ResultState.Ok) > 0)
                    ret.AddRange(retCheck);

                HandleObservers(retCheck);
            }

            // validacia poloziek
            ValidateItems<A1>(input.Transakcie.A1, ret,
                rules.Where(r => r.RuleType == RuleType.A1ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<A2>(input.Transakcie.A2, ret,
                rules.Where(r => r.RuleType == RuleType.A2ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<B1>(input.Transakcie.B1, ret,
                rules.Where(r => r.RuleType == RuleType.B2ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<B2>(input.Transakcie.B2, ret,
                rules.Where(r => r.RuleType == RuleType.B2ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<B3>(input.Transakcie.B3, ret,
                rules.Where(r => r.RuleType == RuleType.B3ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<C1>(input.Transakcie.C1, ret,
                rules.Where(r => r.RuleType == RuleType.C1ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<C2>(input.Transakcie.C2, ret,
                rules.Where(r => r.RuleType == RuleType.C2ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<D1>(input.Transakcie.D1, ret,
                rules.Where(r => r.RuleType == RuleType.D1ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());
            ValidateItems<D2>(input.Transakcie.D2, ret,
                rules.Where(r => r.RuleType == RuleType.D2ItemChecker || r.RuleType == RuleType.GeneralItemChecker).Where(r => r.CheckHeaderCondition(input.Identifikacia)).ToList());

            return ret;
        }

        private bool HandleBeforeObservers(IValidationRule genCheck)
        {
            foreach (var obs in Observers)
            {
                var ret = obs.NextRule(genCheck);
                if (ret == ObserverResult.StopValidation)
                    throw new ValidationCancelled();

                if (ret != ObserverResult.Continue)
                    return true;
            }

            return false;
        }

        private void HandleObservers(IList<IValidationItemResult> retChecks)
        {
            foreach (var obs in Observers)
            {
                foreach (var retCheck in retChecks)
                {
                    switch (retCheck.ValidationResultState)
                    {
                        case ResultState.Unknown:
                            break;
                        case ResultState.Ok:
                            if (obs.OnOk(retCheck) == ObserverResult.StopValidation)
                                throw new ValidationCancelled();
                            break;
                        case ResultState.OkWithWarning:
                            if (obs.OnWarning(retCheck) == ObserverResult.StopValidation)
                                throw new ValidationCancelled();
                            break;
                        case ResultState.Error:
                            if (obs.OnError(retCheck) == ObserverResult.StopValidation)
                                throw new ValidationCancelled();
                            break;
                        case ResultState.CriticalError:
                            if (obs.OnCriticalError(retCheck) == ObserverResult.StopValidation)
                                throw new ValidationCancelled();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Genericka validacia poloziek daneho typu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="ret"></param>
        /// <param name="checkers"></param>
        private void ValidateItems<T>(IList<T> items, ValidationResult ret, List<IValidationRule> checkers)
        {
            foreach (var item in items)
            {
                foreach (var itemCheck in checkers)
                {
                    if (HandleBeforeObservers(itemCheck))
                        continue;

                    var retCheck = itemCheck.Validate(item);
                    if (retCheck.Count(r => r.ValidationResultState != ResultState.Ok) > 0)
                        ret.AddRange(retCheck);

                    HandleObservers(retCheck);
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
