using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Object reprezentujuci vysledok validacie
    /// </summary>
    public interface IValidationResult
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
        /// Detail vysledku, napr. v pripade problemu cislo riadku a pod.
        /// </summary>
        IResultDetailedInfo Details { get; }
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
