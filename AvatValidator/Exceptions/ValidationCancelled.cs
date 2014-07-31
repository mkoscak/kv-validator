using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvatValidator.Exceptions
{
    public class ValidationCancelled : Exception
    {
        public ValidationCancelled()
            : base("Validácia prerušená používateľom!")
        {
        }
    }
}
