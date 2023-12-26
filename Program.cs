using System;
using System.Windows.Forms;

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
            
            DBOperator dbOperator = DBOperator.Instance;
            dbOperator.ConnectDB();

            Application.Run(new loginForm());
        }
    }
}
