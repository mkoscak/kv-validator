using System.Collections.Generic;
using AvatValidator.Sql;
using System.Xml;
using System.ComponentModel;

namespace AvatValidator.Validators.TaxPayerValidator.Entities
{
    /// <summary>
    /// Manazer registrovanych platitelov DPH
    /// </summary>
    public class TaxPayersManager
    {
        /// <summary>
        /// Import dat z XML 'ds_dphs.xml'
        /// </summary>
        /// <param name="path"></param>
        public static int ImportDataFromXml(string path, string dbName, BackgroundWorker bw)
        {
            var entities = new List<TaxPayerEntity>();

            bw.ReportProgress(0, "Čítanie vstupného súboru..");
            // nacitanie entit z xml
            LoadEntitiesFromXml(path, entities);

            // zmazanie starych zaznamov
            var db = DbProvider.CreateProvider(dbName);
            new TaxPayerEntity(db);//init tabuliek
            db.ExecuteNonQuery(string.Format("delete from {0}", TaxPayerEntity.TABLE_NAME));

            // ulozenie novych
            using (var con = db.GetConnection())
            {
                con.Open();
                using (var tr = con.BeginTransaction())
                {
                    for (int i = 0; i < entities.Count; i++)
                    {
                        entities[i].Save(con, tr);
                        bw.ReportProgress((int)((double)(i + 1) / entities.Count * 100), "Aktualizácia databázy DIČ..");
                    }
                    tr.Commit();
                }
                con.Close();
            }

            return entities.Count;
        }

        private static void LoadEntitiesFromXml(string path, List<TaxPayerEntity> entities)
        {
            var doc = new XmlDocument();
            doc.Load(path);
            var dsDph = doc["ZoznamSubjektovRegistrovanychKDPH"]["DS_DPHS"];
            foreach (XmlElement el in dsDph)
            {
                var ble = new TaxPayerEntity();
                ble.IcDph = el["IC_DPH"].InnerText;
                ble.Nazov = el["NAZOV"].InnerText.Replace('"', ' ');
                ble.Obec = el["OBEC"].InnerText.Replace('"', ' ');
                ble.Psc = el["PSC"].InnerText.Replace('"', ' ');
                ble.Adresa = el["ADRESA"].InnerText.Replace('"', ' ');
                if (el["PODLA_PARAGRAFU"] != null)
                    ble.PodlaParagrafu = el["PODLA_PARAGRAFU"].InnerText;

                entities.Add(ble);
            }
        }
    }
}
