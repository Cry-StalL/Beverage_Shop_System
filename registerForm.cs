using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySqlConnector;
using MySqlException = MySql.Data.MySqlClient.MySqlException;

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
            else
            {
                //输入不为空
                int gender = btn_male.Checked ? 0 : 1;
                DBOperator dbOperator = DBOperator.Instance;
                string queryStr = $"INSERT INTO user_info(user_id, real_name, gender, telephone, delete_flag, username, password, user_type) VALUES (NULL, '{txtBox_name.Text}', {gender}, '{txtBox_telephone.Text}', 0, " +
                                  $"'{txtBox_username.Text}', '{txtBox_password.Text}', 1)";
                try
                {
                    dbOperator.TableExecute(queryStr);
                }
                catch (MySqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                    if (ex.Message.Contains("Duplicate"))
                    {
                        //用户名已被注册
                        MessageBox.Show("用户名已被注册!");
                    }else if (ex.Message.Contains("for column 'telephone'"))
                    {
                        //电话号码无效
                        MessageBox.Show("电话号码无效!");
                    }

                    return;
                }
                
                MessageBox.Show("注册成功!");
            }
        }
    }
}