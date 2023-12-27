using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beverage_Shop_System
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            registerForm register_form = new registerForm();
            register_form.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtBox_username.Text == "")
            {
                MessageBox.Show("用户名不能为空!");
            }else if (txtBox_password.Text == "")
            {
                MessageBox.Show("密码不能为空!");
            }
            else
            {
                //尝试登录
                DBOperator dbOperator = DBOperator.Instance;
                if (!dbOperator.userExists(txtBox_username.Text))
                {
                    //用户不存在
                    MessageBox.Show("用户不存在!");
                    return;
                }
                else
                {
                    //用户存在，检查密码
                    DataTable dt = dbOperator.TableQuery(
                        $"SELECT * FROM user_info WHERE user_type = 1 AND username = '{txtBox_username.Text}' AND password = '{txtBox_password.Text}'");
                    if (dt.Rows.Count == 0)
                    {
                        //密码错误
                        MessageBox.Show("密码错误!");
                        return;
                    }
                    else
                    {
                        //密码正确，成功登录
                        MessageBox.Show("登录成功!");

                        DataRow current_staff_info = dt.Rows[0];
                        
                        this.Hide();
                        mainForm main_form = new mainForm(current_staff_info); //传入查到的dt行
                        main_form.Show();
                    }
                }
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
}
