using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Sql;

namespace AvatValidator.Validators.TaxPayerValidator.Entities
{
    /// <summary>
    /// Entita registrovaneho platitela DPH
    /// </summary>
    public class TaxPayerEntity : BaseEntity<TaxPayerEntity>
    {
        public static string TABLE_NAME = "T_TAX_PAYER";

        public string IcDph { get; set; }
        public string Nazov{ get; set; }
        public string Obec { get; set; }
        public string Psc { get; set; }
        public string Adresa { get; set; }
        public string PodlaParagrafu { get; set; }

        public static string IC_DPH = "IC_DPH";
        public static string NAZOV = "NAZOV";
        public static string OBEC = "OBEC";
        public static string PSC = "PSC";
        public static string ADRESA = "ADRESA";
        public static string PODLA_PARAGRAFU = "PODLA_PARAGRAFU";

        public TaxPayerEntity(DbProvider db)
            : base(db)
        {
            Clear();
        }

        public TaxPayerEntity()
            : this(DbProvider.Instance)
        {
        }

        public override void Clear()
        {
            base.Clear();

            IcDph = string.Empty;
            Nazov = string.Empty;
            Obec = string.Empty;
            Psc = string.Empty;
            Adresa = string.Empty;
            PodlaParagrafu = string.Empty;
        }

        public static List<TaxPayerEntity> LoadAll()
        {
            return BaseEntity<TaxPayerEntity>.LoadAll(TABLE_NAME);
        }

        public static List<TaxPayerEntity> Load(string where)
        {
            return Load(where, null);
        }

        public static List<TaxPayerEntity> Load(string where, string order)
        {
            return BaseEntity<TaxPayerEntity>.Load(TABLE_NAME, where, order);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                ID, IC_DPH, NAZOV, OBEC, PSC, ADRESA, PODLA_PARAGRAFU, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",{8}",
                NullableLong(Id), IcDph, Nazov, Obec, Psc, Adresa, PodlaParagrafu, Comment, Valid ? 1 : 0
                ));
        }

        public void Save(System.Data.SQLite.SQLiteConnection connection, System.Data.SQLite.SQLiteTransaction transaction)
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                ID, IC_DPH, NAZOV, OBEC, PSC, ADRESA, PODLA_PARAGRAFU, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\",\"{7}\",{8}",
                NullableLong(Id), IcDph, Nazov, Obec, Psc, Adresa, PodlaParagrafu, Comment, Valid ? 1 : 0
                ),
                connection, transaction);
        }

        internal override void ParseFromRow(System.Data.DataRow row)
        {
            base.ParseFromRow(row);

            IcDph = row[IC_DPH].ToString();
            Nazov = row[NAZOV].ToString();
            Obec = row[OBEC].ToString();
            Psc = row[PSC].ToString();
            Adresa = row[ADRESA].ToString();
            PodlaParagrafu = row[PODLA_PARAGRAFU].ToString();
        }

        public override string ToString()
        {
            return IcDph;
        }

        public override string GetTableName()
        {
            return TABLE_NAME;
        }

        public override string GetCreationScript()
        {
            return @"DROP TABLE IF EXISTS T_TAX_PAYER;
                    CREATE TABLE T_TAX_PAYER ( 
	                    ""ID"" INTEGER PRIMARY KEY AUTOINCREMENT,
	                    ""IC_DPH"" TEXT,
	                    ""NAZOV"" TEXT,
	                    ""OBEC"" TEXT,
	                    ""PSC"" TEXT,
	                    ""ADRESA"" TEXT,
	                    ""PODLA_PARAGRAFU"" TEXT,
	                    ""COMMENT"" TEXT,
	                    ""VALID"" INTEGER DEFAULT 1 );
                    CREATE INDEX IF NOT EXISTS IDX_IC_DPH_TAX_PAYER ON T_TAX_PAYER (IC_DPH);";
        }
    }
}
