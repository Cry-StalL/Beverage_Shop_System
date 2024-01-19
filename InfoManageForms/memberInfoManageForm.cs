using System;
using System.Data;
using System.Numerics;
using System.Windows.Forms;

namespace Beverage_Shop_System.ManageForms
{
    public partial class memberInfoManageForm : Form
    {
        public memberInfoManageForm()
        {
            InitializeComponent();
            changeOperationToAdd(); //初始化为"增添"模式
            displayMemberInfo();
        }
        
        private enum Operation
        {
            ADD, //增加
            MODIFY //修改
        }
        
        private Operation op;
        
        private void changeOperationToAdd()
        {
            op = Operation.ADD;
            opLabel.Text = "增加";
        }

        private void changeOperationToModify()
        {
            op = Operation.MODIFY;
            opLabel.Text = "修改";
        }

        /**查数据库*/
        private void displayMemberInfo()
        {
            //清空原ListView
            memberInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery("SELECT * FROM user_info WHERE user_type = 0");
            
            //dt中的每一行
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["user_id"].ToString());
                item.SubItems.Add(row["real_name"].ToString());
                
                int gender = Convert.ToInt32(row["gender"]);
                switch (gender)
                {
                    case 0:
                        item.SubItems.Add("男");
                        break;
                    case 1:
                        item.SubItems.Add("女");
                        break;
                }
                
                item.SubItems.Add(row["telephone"].ToString());
                item.SubItems.Add(row["member_id"].ToString());
                
                memberInfoListView.Items.Add(item);
            }

            
        }

        /**增加会员信息到数据库*/
        private void addMemberInfo()
        {
            string name = txtBox_name.Text;
            int gender = btn_male.Checked ? 0 : 1;
            long telephone = Convert.ToInt64(txtBox_telephone.Text);
            long member_id = Convert.ToInt64(txtBox_member_id.Text);
            
            DBOperator dbOperator = DBOperator.Instance;

            dbOperator.TableExecute("INSERT INTO user_info " +
                                    "(real_name, gender, telephone, delete_flag, username, password, member_id, user_type)" +
                                    $"VALUES ('{name}', {gender}, {telephone}, 0, NULL, NULL, {member_id}, 0)");
        }

        /**清空*/
        private void resetInput()
        {
            txtBox_name.Text = "";

            btn_male.Checked = false;
            btn_female.Checked = false;

            txtBox_telephone.Text = "";
            txtBox_member_id.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //检查输入是否为空
            if (txtBox_name.Text == "")
            {
                MessageBox.Show("请输入姓名!");
                return;
            }

            if (!btn_male.Checked && !btn_female.Checked)
            {
                MessageBox.Show("请选择性别!");
                return;
            }

            if (txtBox_telephone.Text == "")
            {
                MessageBox.Show("请输入电话号码!");
                return;
            }

            if (txtBox_member_id.Text == "")
            {
                MessageBox.Show("请输入会员卡号!");
                return;
            }
            
            if (op == Operation.ADD) //新增模式
            {
                addMemberInfo();
                displayMemberInfo();
                resetInput();
            }else if (op == Operation.MODIFY) //修改模式
            {
                // modifySelectedDrinkInfo();
                // displayDrinkInfo();
            }
        }
    }
}