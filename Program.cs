using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

using Beverage_Shop_System;

namespace Beverage_Shop_System
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new loginForm());
            
            //测试数据库连接(使用config)
            string connString = ConfigurationManager.AppSettings["ConnString"];
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
