using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Rozhranie generickeho validatora
    /// </summary>
    public interface IValidator
    {
        /// <summary>
        /// Validacia vstupu vo forme suboru, streamu a pod.
        /// </summary>
        /// <typeparam name="T">Typ vstupu</typeparam>
        /// <param name="input">Vstupne data na validaciu</param>
        /// <param name="rules">Zoznam pravidiel</param>
        /// <returns></returns>
        IValidationResult Validate<T>(T input, IValidationSet rules);
    }
}
