using System.Collections.Generic;
using System.IO;
using System.Linq;
using KVValidator.Properties;
using System;
using System.Xml;
using System.Xml.Schema;
using KVValidator.Interface;
using KVValidator.Implementation;

namespace KVValidator
{
    /// <summary>
    /// Validator kontrolnych vykazov
    /// </summary>
    public class KvValidator
    {
        /// <summary>
        /// Validacne pravidla
        /// </summary>
        internal ValidationSet Rules { get; set; }

        /// <summary>
        /// Konstruktor s validacnymi pravidlami
        /// </summary>
        /// <param name="rules"></param>
        public KvValidator(ValidationSet rules)
        {
            this.Rules = rules;
        }

        /// <summary>
        /// Validacia XML kontrolneho vykazu na zadanej ceste
        /// </summary>
        /// <param name="filePath">Cesta k suboru</param>
        /// <returns>Zoznam chyb/problemov alebo prazdny list ak je vsetko ok</returns>
        public IList<string> Validate(string filePath)
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

        private void Validate(IList<string> ret, string filePath)
        {
            // existencia suboru
            if (!File.Exists(filePath))
            {
                ret.Add(string.Format("{0} ('{1}')", Resources.InputFileDoesntExists, filePath));
                return;
            }

            // validacia voci XSD
            try
            {
                ValidateXML(filePath);
            }
            catch (Exception ex)
            {
                ret.Add(string.Format("{0} ({1})", Resources.XsdValidationFailed, ex.Message));
            }

            // nacitanie XML
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
            /*if (kv.Identifikacia.Druh == null)
                ret.Add(Resources.DocumentKindMissing);*/
        }

        /// <summary>
        /// Validacia XML voci XSD
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        private static void ValidateXML(string xml)
        {
            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);

            // schema na validaciu
            settings.Schemas.Add(@"https://ekr.financnasprava.sk/Formulare/XSD/kv_dph_2014.xsd", @".\XSD\kv_dph_2014.xsd");

            // Create the XmlReader object.
            var reader = XmlReader.Create(xml, settings);

            // Parse the file. 
            while (reader.Read())
                ;
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity != XmlSeverityType.Warning)
                throw new Exception(args.Message);
        }
    }
}
