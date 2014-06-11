using System;
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
        /// Co kontroluje validacne pravidlo, hlavicku, polozku alebo oboje?
        /// </summary>
        RuleType RuleType { get; }

        /// <summary>
        /// Proces validacie
        /// </summary>
        /// <param name="param">Objekt pre validaciu</param>
        /// <returns></returns>
        IValidationItemResult Validate<Tinput>(Tinput param);

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
        ItemChecker,    // validuje polozku vykazu
        WholeXml,       // validuje cele xml, napr. voci XSD scheme
        General,        // genericky validator, napr. kontrola na prazdny vstup a pod.
    }
}
