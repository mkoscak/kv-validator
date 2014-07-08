using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;

namespace AvatValidator.Implementation
{
    /// <summary>
    /// Validacna mnozina - zoznam validacnych pravidiel
    /// </summary>
    public class ValidationSet 
        : List<IValidationRule>, IValidationSet
    {
    }
}
