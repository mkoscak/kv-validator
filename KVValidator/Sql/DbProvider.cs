using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace KVValidator.Sql
{
    /// <summary>
    /// Spostredkuvava zakladne operacie s databazou Sqlite
    /// </summary>
    public class DbProvider
    {
        public static string DataSource
        {
            get
            {
                return @".\kvalidator.db";
            }
        }

        /// <summary>
        /// Singleton..
        /// </summary>
        private DbProvider()
        {
            // vytvorenie DB suboru
            if (!File.Exists(DataSource))
            {
                SQLiteConnection.CreateFile(DataSource);
            }
        }
        private static DbProvider db;
        public static DbProvider Instance
        {
            get
            {
                if (db == null)
                    db = new DbProvider();

                return db;
            }
        }
        /// <summary>
        /// End of singleton
        /// </summary>
        /// <returns></returns>

        public SQLiteConnection GetConnection()
        {
            var sql_con = new SQLiteConnection(@"Data Source=" + DataSource + "; Version=3;");
            return sql_con;
        }

        public void ExecuteNonQuery(string txtQuery)
        {
            using (var sql_con = GetConnection())
            {
                sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
        }

        public DataSet ExecuteQuery(string query)
        {
            DataSet DS = new DataSet();

            using (var sql_con = GetConnection())
            {
                sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                var DB = new SQLiteDataAdapter(query, sql_con);
                DS.Reset();
                DB.Fill(DS);
                sql_con.Close();
            }
            return DS;
        }

        public DataSet ExecuteQuery(string tableName, string where, string order)
        {
            DataSet DS = new DataSet();

            using (var sql_con = GetConnection())
            {
                sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                string CommandText = "select * from " + tableName + " A " + where + " " + order;
                var DB = new SQLiteDataAdapter(CommandText, sql_con);
                DS.Reset();
                DB.Fill(DS);
                sql_con.Close();
            }
            return DS;
        }

        static string DBPrice(double price)
        {
            return price.ToString().Replace(',','.');
        }
    }
}
