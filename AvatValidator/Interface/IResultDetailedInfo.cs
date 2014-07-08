using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvatValidator.Interface
{
    /// <summary>
    /// Detail vysledku validacie, napr. info o cisle riadku, na ktorom je problem a pod.
    /// </summary>
    public interface IDetailedResultInfo
    {
        /// <summary>
        /// Cislo riadku
        /// </summary>
        int? LineNumber { get; set; }

        // TODO dalsie informacie?
    }
}
