using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Interface;

namespace KVValidator.Implementation
{
    /// <summary>
    /// Validacna mnozina - zoznam validacnych pravidiel
    /// </summary>
    public class ValidationSet 
        : List<IValidationRule>, IValidationSet
    {
    }
}
