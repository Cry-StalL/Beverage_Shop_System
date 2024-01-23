using System;
using System.Data;
using System.Timers;
using System.Windows.Forms;
using Beverage_Shop_System.ManageForms;
using Beverage_Shop_System.OrderForms;
using Beverage_Shop_System.QueryForms;

namespace Beverage_Shop_System
{
    public partial class mainForm : Form
    {
        public mainForm(DataRow staff_info, loginForm login_form)
        {
            InitializeComponent();
            
            //存储登入操作员的信息
            current_staff_info = staff_info;
            this.login_form = login_form;
            
            //初始化状态栏
            initialize_status_strip();
        }

        private DataRow current_staff_info;
        private loginForm login_form;

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

        private void playMusic()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "音频文件|*.mp3;*.wav;*.flac;*.aac;*.m4a;*.mid;*.rmi;*.midi|所有文件|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                player.URL = selectedFile;
            }
        }

        private void drinkInfoManageMenuItem_Click(object sender, EventArgs e)
        {
            drinkInfoManageForm drink_info_manage_form = new drinkInfoManageForm();
            drink_info_manage_form.Show();
        }

        private void memberInfoManageMenuItem_Click(object sender, EventArgs e)
        {
            memberInfoManageForm member_info_manage_form = new memberInfoManageForm();
            member_info_manage_form.Show();
        }

        private void staffInfoManageMenuItem_Click(object sender, EventArgs e)
        {
            staffInfoManageForm staff_info_manage_form = new staffInfoManageForm();
            staff_info_manage_form.Show();
        }
        private void exitLoginMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            login_form.reShow();
        }
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void playMusicMenuItem_Click(object sender, EventArgs e)
        {
            playMusic();
        }

        private void orderMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(current_staff_info);
            orderForm.Show();
        }

        private void drinkInfoQueryMenuItem_Click(object sender, EventArgs e)
        {
            DrinkInfoQueryForm drinkInfoQueryForm = new DrinkInfoQueryForm();
            drinkInfoQueryForm.Show();
        }

        private void memberInfoQueryMenuItem_Click(object sender, EventArgs e)
        {
            MemberInfoQueryForm memberInfoQueryForm = new MemberInfoQueryForm();
            memberInfoQueryForm.Show();
        }

        private void orderInfoQueryMenuItem_Click(object sender, EventArgs e)
        {
            OrderInfoQueryForm orderInfoQueryForm = new OrderInfoQueryForm();
            orderInfoQueryForm.Show();
        }

        private void saleStatsMenuItem_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}