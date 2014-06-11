using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Detail vysledku validacie, napr. info o cisle riadku, na ktorom je problem a pod.
    /// </summary>
    public interface IResultDetailedInfo
    {
        /// <summary>
        /// Cislo riadku
        /// </summary>
        int? LineNumber { get; }

        // TODO dalsie informacie?
    }
}
