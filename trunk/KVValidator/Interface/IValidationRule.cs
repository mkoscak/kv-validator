using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Validacne pravidlo, napr. rok musi byt vacsi ako 2014 a pod.
    /// </summary>
    /// <typeparam name="T">Typ parametra pre validaciu</typeparam>
    public interface IValidationRule<T>
    {
        /// <summary>
        /// Proces validacie
        /// </summary>
        /// <param name="param">Objekt pre validaciu</param>
        /// <returns></returns>
        ValidationRuleResult Validate(T param);

        /// <summary>
        /// Validacna hlaska v pripade, ze validacia nepresla
        /// </summary>
        string ValidationFailedMessage { get; }

        /// <summary>
        /// Validacna hlaska v pripade, ze validacia presla s varovanim
        /// </summary>
        string ValidationWarningMessage { get; }
    }

    /// <summary>
    /// Vysledok validacie
    /// </summary>
    public enum ValidationRuleResult
    {
        Unknown,
        Ok,
        OkWithWarning,
        Failed,
    }
}
