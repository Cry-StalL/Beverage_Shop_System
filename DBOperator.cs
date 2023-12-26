using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
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
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("connection open failed!");
            }
            
            // Debug.WriteLine("DB Opened");
        }

        public void CloseDB()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("connection close failed!");
            }
            
            // Debug.WriteLine("DB Closed");
        }
        
        //数据查找
        public DataTable TableQuery(string queryStr)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(queryStr, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        //数据操作
        public int TableExecute(string queryStr)
        {
            MySqlCommand cmd = new MySqlCommand(queryStr, conn);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}
