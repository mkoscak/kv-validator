using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KVValidator.Sql;
using System.Xml.Linq;
using System.Xml;

namespace KVValidator.Validators.BlackListValidator.Entities
{
    /// <summary>
    /// Spravuje polozky v tabule T_BLACKLIST
    /// </summary>
    public class BlackListManager
    {
        /// <summary>
        /// Import dat z XML 'ds_dphz.xml'
        /// </summary>
        /// <param name="path"></param>
        public static int ImportDataFromXml(string path)
        {
            var entities = new List<BlackListEntity>();

            // nacitanie entit z xml
            LoadEntitiesFromXml(path, entities);

            // zmazanie starych zaznamov
            var db = DbProvider.Instance;
            db.ExecuteNonQuery(string.Format("delete from {0}", BlackListEntity.TABLE_NAME));

            // ulozenie novych
            entities.ForEach(e => e.Save());

            return entities.Count;
        }

        private static void LoadEntitiesFromXml(string path, List<BlackListEntity> entities)
        {
            //var doc = XDocument.Load(path);
            var doc = new XmlDocument();
            doc.Load(path);
            var dsDph = doc["ZoznamPlatitelovDPHsDovodomNaZrusenieRegistracie"]["DS_DPHZ"];
            foreach (XmlElement el in dsDph)
            {
                var ble = new BlackListEntity();
                ble.IcDph = el["IC_DPH"].InnerText;
                ble.Nazov = el["NAZOV"].InnerText.Replace('"', ' ');
                ble.Obec = el["OBEC"].InnerText;
                ble.Psc = el["PSC"].InnerText;
                ble.Adresa = el["ADRESA"].InnerText;
                ble.RokPorusenia = Convert.ToInt32(el["ROK_PORUSENIA"].InnerText);
                ble.DatumZverejnenia = el["DAT_ZVEREJNENIA"].InnerText;

                entities.Add(ble);
            }
        }
    }
}
