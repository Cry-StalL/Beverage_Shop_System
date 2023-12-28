using System;
using System.Data;
using System.Windows.Forms;

namespace Beverage_Shop_System.ManageForms
{
    public partial class drinkInfoManageForm : Form
    {
        public drinkInfoManageForm()
        {
            InitializeComponent();
            changeOperationToAdd(); //初始化为"增添"模式
            displayDrinkInfo();
            
            label_price_small.Hide();
            numBox_price_small.Hide();
            label_price_medium.Hide();
            numBox_price_medium.Hide();
            label_price_large.Hide();
            numBox_price_large.Hide();
        }

        /* current operation */
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
        
        /* 查数据库 */
        private void displayDrinkInfo()
        {
            //清空原ListView
            drinkInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery("SELECT * FROM drink_info");
            
            //dt中的每一行
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["drink_id"].ToString());
                item.SubItems.Add(row["drink_name"].ToString());
                item.SubItems.Add(row["price_small"].ToString());
                item.SubItems.Add(row["price_medium"].ToString());
                item.SubItems.Add(row["price_large"].ToString());

                int status = Convert.ToInt32(row["status"]);
                if (status == 0)
                {
                    item.SubItems.Add("在售");
                }
                else if(status == 1)
                {
                    item.SubItems.Add("售完");
                }else if(status == 2)
                {
                    item.SubItems.Add("停售");
                }

                drinkInfoListView.Items.Add(item);
            }
        }

        /**清空*/
        private void resetInput()
        {
            txtBox_drink_name.Text = "";

            checkBox_small.Checked = false;
            checkBox_medium.Checked = false;
            checkBox_large.Checked = false;
            numBox_price_small.Value = 0;
            numBox_price_medium.Value = 0;
            numBox_price_large.Value = 0;

            comboBox_status.SelectedIndex = -1;
        }
        
        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetInput();
        }
        
        /**增加饮品数据到数据库*/
        private void addDrinkInfo()
        {
            string drink_name = txtBox_drink_name.Text;

            string price_small = checkBox_small.Checked ? numBox_price_small.Value.ToString() : "NULL";
            string price_medium = checkBox_medium.Checked ? numBox_price_medium.Value.ToString() : "NULL";
            string price_large = checkBox_large.Checked ? numBox_price_large.Value.ToString() : "NULL";
            
            int status = comboBox_status.SelectedIndex;
            
            DBOperator dbOperator = DBOperator.Instance;
            dbOperator.TableExecute($"INSERT INTO drink_info " +
                                    $"(drink_id, drink_name, drink_image, price_small, price_medium, price_large, status) " +
                                    $"VALUES (NULL, '{drink_name}', NULL, {price_small}, {price_medium}, {price_large}, {status})");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //检查输入是否为空、是否重复
            
            //新增模式
            if (op == Operation.ADD)
            {
                addDrinkInfo();
                displayDrinkInfo();
            }
        }


        private void checkBox_small_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_small.Checked)
            {
                label_price_small.Show();
                numBox_price_small.Show();
            }
            else
            {
                label_price_small.Hide();
                numBox_price_small.Hide();
            }
        }

        private void checkBox_medium_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_medium.Checked)
            {
                label_price_medium.Show();
                numBox_price_medium.Show();
            }
            else
            {
                label_price_medium.Hide();
                numBox_price_medium.Hide();
            }
        }

        private void checkBox_large_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_large.Checked)
            {
                label_price_large.Show();
                numBox_price_large.Show();
            }
            else
            {
                label_price_large.Hide();
                numBox_price_large.Hide();
            }
        }

        private void drinkInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drinkInfoListView.SelectedItems.Count == 0)
            {
                changeOperationToAdd();
            }
            else
            {
                changeOperationToModify();
            }
        }

        private void btn_cancel_select_Click(object sender, EventArgs e)
        {
            drinkInfoListView.SelectedItems.Clear();
        }
    }
}