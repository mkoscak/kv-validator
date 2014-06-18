﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KVValidator.Interface
{
    /// <summary>
    /// Validacne pravidlo, napr. rok musi byt vacsi ako 2014 a pod.
    /// </summary>
    public interface IValidationRule
    {
        /// <summary>
        /// Nazov pravidla
        /// </summary>
        string RuleName { get; }

        /// <summary>
        /// Co kontroluje validacne pravidlo, hlavicku, polozku alebo oboje?
        /// </summary>
        RuleType RuleType { get; }

        /// <summary>
        /// Proces validacie
        /// </summary>
        /// <typeparam name="Tinput">typ vstupneho objektu</typeparam>
        /// <param name="param">Objekt pre validaciu</param>
        /// <returns></returns>
        IValidationItemResult Validate(object input);

        /// <summary>
        /// Textovy popis pravidla
        /// </summary>
        string RuleDescription { get; }
    }

    /// <summary>
    /// Typ pravidla
    /// </summary>
    public enum RuleType
    {
        Unknown,
        HeaderChecker,  // validuje hlavicku
        GeneralItemChecker, // validuje vsetky typy itemov nizsie
        A1ItemChecker,
        A2ItemChecker,
        B1ItemChecker,
        B2ItemChecker,
        B3ItemChecker,
        C1ItemChecker,
        C2ItemChecker,
        D1ItemChecker,
        D2ItemChecker,
        WholeXml,       // validuje cele xml, napr. voci XSD scheme
        General,        // genericky validator, napr. kontrola na prazdny vstup a pod.
    }
}
