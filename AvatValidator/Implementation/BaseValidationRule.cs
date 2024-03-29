﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Interface;

namespace AvatValidator.Implementation
{
    /// <summary>
    /// Interna pomocna trieda na kontrolu vstupnych typov
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseValidationRule<T> : IValidationRule
    {
        #region IValidationRule Members

        public IList<IValidationItemResult> Validate(object input)
        {
            if (input.GetType() != typeof(T))
                throw new InvalidOperationException("Nesprávny vstupný typ pre danú validáciu!");

            // vratime vysledok internej implementacie validacneho pravidla
            return Validate((T)input);
        }

        public abstract string RuleName { get; }

        public abstract RuleType RuleType { get; }

        public abstract string RuleDescription { get; }

        public bool CheckHeaderCondition(object header)
        {
            return true;
        }

        #endregion

        /// <summary>
        /// Metodu implementuje odvodena trieda, ktora deklaruje aj typ vstupnej premennej
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        protected abstract IList<IValidationItemResult> Validate(T input);
    }
}
