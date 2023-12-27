using System;
using System.Data;
using System.Timers;
using System.Windows.Forms;

namespace Beverage_Shop_System
{
    public partial class mainForm : Form
    {
        public mainForm(DataRow staff_info)
        {
            InitializeComponent();
            
            //存储登入操作员的信息
            current_staff_info = staff_info;
            
            //初始化状态栏
            initialize_status_strip();
        }

        private DataRow current_staff_info;

        private void initialize_status_strip()
        {
            //操作员信息 真名 (用户名: ...)
            string real_name = current_staff_info["real_name"].ToString();
            string username = current_staff_info["username"].ToString();
            statusStripStaffLabel.Text = $"{real_name} (用户名: {username})";
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            statusStripTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}