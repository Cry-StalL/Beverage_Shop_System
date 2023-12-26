using System;
using System.Windows.Forms;

namespace Beverage_Shop_System
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            //检测输入是否为空
            if (txtBox_username.Text == "")
            {
                MessageBox.Show("用户名不能为空!");
            }else if (txtBox_password.Text == "")
            {
                MessageBox.Show("密码不能为空!");
            }else if (txtBox_name.Text == "")
            {
                MessageBox.Show("姓名不能为空!");
            }else if (!btn_male.Checked && !btn_female.Checked)
            {
                MessageBox.Show("请选择性别!");
            }else if (txtBox_telephone.Text == "")
            {
                MessageBox.Show("电话号码不能为空!");
            }
        }
        
    }
}