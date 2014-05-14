using System.Collections.Generic;
using System.IO;
using System.Linq;
using KVValidator.Properties;
using System;

namespace KVValidator
{
    /// <summary>
    /// Validator kontrolnych vykazov
    /// </summary>
    public class KvValidator
    {
        /// <summary>
        /// Validacia XML kontrolneho vykazu na zadanej ceste
        /// </summary>
        /// <param name="filePath">Cesta k suboru</param>
        /// <returns>Zoznam chyb/problemov alebo prazdny list ak je vsetko ok</returns>
        public static IList<string> Validate(string filePath)
        {
            var ret = new List<string>();

            try
            {
                Validate(ret, filePath);
            }
            catch (Exception ex)
            {
                ret.Add(Resources.ExceptionText + ex.Message);
            }

            return ret;
        }

        private static void Validate(IList<string> ret, string filePath)
        {
            if (!File.Exists(filePath))
            {
                ret.Add(string.Format("{0} ('{1}')", Resources.InputFileDoesntExists, filePath));
                return;
            }

            var kv = KVDPH.LoadFromFile(filePath);

            // validacia sekcii
            if (kv.Identifikacia == null)
                ret.Add(Resources.IdentificationSectionMissing);
            if (kv.Transakcie == null)
                ret.Add(Resources.TransactionSectionMissing);
            if (kv.Identifikacia.Obdobie == null)
                ret.Add(Resources.PeriodSectionMissing);

            // validacia roka
            if (kv.Identifikacia.Obdobie.Rok < 2014)
                ret.Add(Resources.YearNotValid);

            // druh kontrolneho vykazu musi byt vyplneny
            if (kv.Identifikacia.Druh == null)
                ret.Add(Resources.DocumentKindMissing);
        }
    }
}
