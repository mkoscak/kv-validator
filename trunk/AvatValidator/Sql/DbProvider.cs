using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.IO.IsolatedStorage;
using System.Reflection;

namespace AvatValidator.Sql
{
    /// <summary>
    /// Spostredkuvava zakladne operacie s databazou Sqlite
    /// </summary>
    public class DbProvider
    {
        string DataSource;

        static string DefDBName = "vatfix.db";
        static string DefDataSource;

        public static bool DefDataSourceExist
        {
            get
            {
                if (string.IsNullOrEmpty(DefDataSource))
                {
                    var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                    var found = isoStore.GetFileNames(DefDBName);
                    foreach (var f in found)
                    {
                        if (f == DefDBName)
                            return true;
                    }
                }
                 
                return false;
            }
        }

        public static string DefaultDataSource
        {
            get
            {
                if (string.IsNullOrEmpty(DefDataSource))
                {
                    var isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Assembly, null, null);
                    using (var f = new IsolatedStorageFileStream(DefDBName, FileMode.OpenOrCreate, isoStore))
                    {
                        DefDataSource = f.GetType().GetField("m_FullPath", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(f).ToString();
                        f.Close();
                    }
                }

                return DefDataSource;
                //return @".\kvalidator.db";
            }
        }

        /// <summary>
        /// Singleton..
        /// </summary>
        private DbProvider(string dataSource)
        {
            this.DataSource = dataSource;
            // vytvorenie DB suboru
            if (!File.Exists(dataSource))
            {
                SQLiteConnection.CreateFile(dataSource);
            }
        }

        private DbProvider()
            :this(DefaultDataSource)
        {
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

        public static DbProvider CreateProvider(string name)
        {
            return new DbProvider(name);
        }

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

        public void ExecuteNonQuery(string txtQuery, SQLiteConnection sql_con, SQLiteTransaction trans)
        {
            //using (var sql_con = GetConnection())
            {
                //sql_con.Open();
                var sql_cmd = sql_con.CreateCommand();
                sql_cmd.Transaction = trans;
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                //sql_con.Close();
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
