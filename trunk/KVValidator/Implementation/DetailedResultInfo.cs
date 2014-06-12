using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;

namespace KVValidator.Implementation
{
    /// <summary>
    /// Default implementacia triedy s detailnymi informacia o vysledku validacie
    /// </summary>
    public class DetailedResultInfo : IDetailedResultInfo
    {
        #region IDetailedResultInfo Members

        public int? LineNumber { get; set; }

        #endregion
    }
}
