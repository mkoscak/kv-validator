using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Object reprezentujuci vysledok validacie
    /// </summary>
    public interface IValidationItemResult
    {
        /// <summary>
        /// Vysledok z akeho pravidla to je
        /// </summary>
        IValidationRule FromRule { get; }

        /// <summary>
        /// Vysledok validacie
        /// </summary>
        ResultState ValidationResultState { get; }

        /// <summary>
        /// Sprava ako vysledok validacie pre uzivatela
        /// </summary>
        string ResultMessage { get; }

        /// <summary>
        /// Pomocny text resp navod alebo detail problemu, aby sa lahsie opravil
        /// </summary>
        string ResultTooltip { get; }

        /// <summary>
        /// Objekt ktory obsahuje problemovy prvok/polozku, napr. A1
        /// </summary>
        object ProblemObject { get; set; }

        /// <summary>
        /// Detail vysledku, napr. v pripade problemu cislo riadku a pod.
        /// </summary>
        IDetailedResultInfo Details { get; }
    }

    /// <summary>
    /// Stav resp. vysledok validacneho pravidla
    /// </summary>
    public enum ResultState
    {
        Unknown,
        Ok,
        OkWithWarning,
        Error,
        CriticalError,
    }
}
