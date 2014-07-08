using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvatValidator.Interface
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
        IValidationResult Validate(KVDPH input, IValidationSet rules);

        /// <summary>
        /// Prida observera udalosti
        /// </summary>
        /// <param name="observer"></param>
        void AddObserver(IValidationObserver observer);

        /// <summary>
        /// Odstrani observera udalosti
        /// </summary>
        /// <param name="observer"></param>
        void RemoveObserver(IValidationObserver observer);
    }
}
