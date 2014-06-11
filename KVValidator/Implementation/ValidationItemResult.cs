using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;

namespace KVValidator.Implementation
{
    public class ValidationItemResult : IValidationItemResult
    {
        #region IValidationItemResult Members

        public IValidationRule FromRule { get; set; }

        public ResultState ValidationResultState { get; set; }

        public string ResultMessage { get; set; }

        public string ResultTooltip { get; set; }

        public IResultDetailedInfo Details { get; set; }

        #endregion
    }
}
