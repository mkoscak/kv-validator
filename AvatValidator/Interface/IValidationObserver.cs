﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvatValidator.Interface
{
    /// <summary>
    /// Vzor observer na parcialne spracovanie problemov
    /// </summary>
    public interface IValidationObserver
    {
        /// <summary>
        /// Metoda volana pred validacnym pravidlom, klient moze vyziadat preskocenie validacie vratenim SkipRule
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        ObserverResult NextRule(IValidationRule rule);
 
        /// <summary>
        /// Validacia skoncila uspechom.. mozeme napr. zalogovat alebo nereagovat
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        ObserverResult OnOk(IValidationItemResult result);

        /// <summary>
        /// Metoda volana pri zlyhani validacie do stavu varovania
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        ObserverResult OnWarning(IValidationItemResult result);
        
        /// <summary>
        /// Metoda volana pri zlyhani validacie do stavu chyby
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        ObserverResult OnError(IValidationItemResult result);

        /// <summary>
        /// Metoda volana ak validacia skonci v stave kriticka chyba
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        ObserverResult OnCriticalError(IValidationItemResult result);
    }

    /// <summary>
    /// Definuje co sa ma udiat po volani metody observera
    /// </summary>
    public enum ObserverResult
    {
        Continue,
        StopValidation,
        SkipRule,
    }
}
