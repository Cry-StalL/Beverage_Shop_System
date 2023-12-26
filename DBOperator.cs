using System;
using System.Configuration;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace Beverage_Shop_System
{
    public sealed class DBOperator
    {
        private static readonly Lazy<DBOperator> lazy =
            new Lazy<DBOperator>(() => new DBOperator());

        public static DBOperator Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private DBOperator()
        {
            conn = new MySqlConnection(connString);
        }

        ~DBOperator()
        {
            CloseDB();
        }
        
        private string connString = ConfigurationManager.AppSettings["ConnString"];

        private MySqlConnection conn;

        public void ConnectDB()
        {
            conn.Open();
            Debug.WriteLine("DB Opened");
        }

        public void CloseDB()
        {
            conn.Close();
            Debug.WriteLine("DB Closed");
        }
    }
}
