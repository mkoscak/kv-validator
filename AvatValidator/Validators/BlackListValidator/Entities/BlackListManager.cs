﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Sql;
using System.Xml.Linq;
using System.Xml;
using System.ComponentModel;

namespace AvatValidator.Validators.BlackListValidator.Entities
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
        public static int ImportDataFromXml(string path, string dbName, BackgroundWorker bw)
        {
            var entities = new List<BlackListEntity>();

            bw.ReportProgress(0, "Čítanie vstupného súboru..");
            // nacitanie entit z xml
            LoadEntitiesFromXml(path, entities);

            // zmazanie starych zaznamov
            var db = DbProvider.CreateProvider(dbName);
            new BlackListEntity(db);//init tabuliek
            db.ExecuteNonQuery(string.Format("delete from {0}", BlackListEntity.TABLE_NAME));

            // ulozenie novych
            using (var con = db.GetConnection())
            {
                con.Open();
                using (var tr = con.BeginTransaction())
                {
                    for (int i = 0; i < entities.Count; i++)
                    {
                        entities[i].Save(con, tr);
                        bw.ReportProgress((int)((double)(i + 1) / entities.Count * 100), "Aktualizácia databázy DIČ (black-list)..");
                    }
                    tr.Commit();
                }
                con.Close();
            }

            return entities.Count;
        }

        private static void LoadEntitiesFromXml(string path, List<BlackListEntity> entities)
        {
            var doc = new XmlDocument();
            doc.Load(path);
            var dsDph = doc["ZoznamPlatitelovDPHsDovodomNaZrusenieRegistracie"]["DS_DPHZ"];
            foreach (XmlElement el in dsDph)
            {
                var ble = new BlackListEntity();
                ble.IcDph = el["IC_DPH"].InnerText;
                ble.Nazov = el["NAZOV"].InnerText.Replace('"', ' ');
                ble.Obec = el["OBEC"].InnerText.Replace('"', ' ');
                ble.Psc = el["PSC"].InnerText.Replace('"', ' ');
                ble.Adresa = el["ADRESA"].InnerText.Replace('"', ' ');
                ble.RokPorusenia = Convert.ToInt32(el["ROK_PORUSENIA"].InnerText);
                ble.DatumZverejnenia = el["DAT_ZVEREJNENIA"].InnerText;

                entities.Add(ble);
            }
        }
    }
}
