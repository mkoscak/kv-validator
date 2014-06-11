using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Tovaren na sady validacnych pravidiel
    /// </summary>
    public interface IValidationSetFactory
    {
        /// <summary>
        /// Vytvori a vrati mnozinu validacnych pravidiel
        /// </summary>
        IValidationSet ValidationSet { get; }
    }
}
