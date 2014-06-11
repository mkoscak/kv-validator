using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;

namespace KVValidator.Implementation
{
    /// <summary>
    /// Vysledok validacie - zoznam validacnych vysledkov pre kazde pravidlo
    /// </summary>
    public class ValidationResult 
        : List<IValidationItemResult>, IValidationResult
    {
    }
}
