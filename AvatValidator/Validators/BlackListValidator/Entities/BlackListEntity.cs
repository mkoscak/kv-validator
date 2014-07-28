using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AvatValidator.Sql;

namespace AvatValidator.Validators.BlackListValidator.Entities
{
    /// <summary>
    /// Entita reprezentujuca neplatica..
    /// </summary>
    class BlackListEntity : BaseEntity<BlackListEntity>
    {
        public static string TABLE_NAME = "T_BLACKLIST";

        public string IcDph { get; set; }
        public string Nazov{ get; set; }
        public string Obec { get; set; }
        public string Psc { get; set; }
        public string Adresa { get; set; }
        public string DatumZverejnenia { get; set; }
        public int    RokPorusenia { get; set; }

        static string IC_DPH = "IC_DPH";
        static string NAZOV = "NAZOV";
        static string OBEC = "OBEC";
        static string PSC = "PSC";
        static string ADRESA = "ADRESA";
        static string ROK_PORUSENIA = "ROK_PORUSENIA";
        static string DAT_ZVEREJNENIA = "DAT_ZVEREJNENIA";

        public BlackListEntity(DbProvider db)
            : base(db)
        {
            Clear();
        }

        public BlackListEntity()
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
            DatumZverejnenia = string.Empty;
            RokPorusenia = 0;
        }

        public static List<BlackListEntity> LoadAll()
        {
            return BaseEntity<BlackListEntity>.LoadAll(TABLE_NAME);
        }

        public static List<BlackListEntity> Load(string where)
        {
            return Load(where, null);
        }

        public static List<BlackListEntity> Load(string where, string order)
        {
            return BaseEntity<BlackListEntity>.Load(TABLE_NAME, where, order);
        }

        public void Save()
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", 
                ID, IC_DPH, NAZOV, OBEC, PSC, ADRESA, ROK_PORUSENIA, DAT_ZVEREJNENIA, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},\"{7}\",\"{8}\",{9}",
                NullableLong(Id), IcDph, Nazov, Obec, Psc, Adresa, RokPorusenia, DatumZverejnenia, Comment, Valid ? 1 : 0
                ));
        }

        public void Save(System.Data.SQLite.SQLiteConnection connection, System.Data.SQLite.SQLiteTransaction transaction)
        {
            Save(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                ID, IC_DPH, NAZOV, OBEC, PSC, ADRESA, ROK_PORUSENIA, DAT_ZVEREJNENIA, COMMENT, VALID),
                string.Format("{0},\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",{6},\"{7}\",\"{8}\",{9}",
                NullableLong(Id), IcDph, Nazov, Obec, Psc, Adresa, RokPorusenia, DatumZverejnenia, Comment, Valid ? 1 : 0
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
            DatumZverejnenia = row[DAT_ZVEREJNENIA].ToString();
            RokPorusenia = Convert.ToInt32(row[ROK_PORUSENIA].ToString());
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
            return @"DROP TABLE IF EXISTS T_BLACKLIST;
                    CREATE TABLE T_BLACKLIST ( 
	                    ""ID"" INTEGER PRIMARY KEY AUTOINCREMENT,
	                    ""IC_DPH"" TEXT,
	                    ""NAZOV"" TEXT,
	                    ""OBEC"" TEXT,
	                    ""PSC"" TEXT,
	                    ""ADRESA"" TEXT,
	                    ""ROK_PORUSENIA"" INTEGER,
	                    ""DAT_ZVEREJNENIA"" TEXT,
	                    ""COMMENT"" TEXT,
	                    ""VALID"" INTEGER DEFAULT 1 );
                    CREATE INDEX IF NOT EXISTS IDX_IC_DPH_BLACKLIST ON T_BLACKLIST (IC_DPH);";
        }
    }
}
