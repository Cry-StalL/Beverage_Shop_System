﻿using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        
        /**查数据库*/
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
                switch (status)
                {
                    case 0:
                        item.SubItems.Add("在售");
                        break;
                    case 1:
                        item.SubItems.Add("售完");
                        break;
                    case 2:
                        item.SubItems.Add("停售");
                        break;
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
            
            drinkInfoListView.SelectedItems.Clear();
            
            //隐藏图片
            pictureBox.Hide();
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
            
            string drink_image = pictureBox.ImageLocation;
            if (drink_image != null)
            {
                drink_image = drink_image.Replace(@"\",@"\\"); //将文件路径中的一个反斜杠替换为两个反斜杠
            }
            
            
            int status = comboBox_status.SelectedIndex;
            
            DBOperator dbOperator = DBOperator.Instance;

            try
            {
                dbOperator.TableExecute($"INSERT INTO drink_info " +
                                        $"(drink_id, drink_name, drink_image, price_small, price_medium, price_large, status) " +
                                        $"VALUES (NULL, '{drink_name}', '{drink_image}', {price_small}, {price_medium}, {price_large}, {status})");
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.Message);
                if (ex.Message.Contains("Duplicate"))
                {
                    //饮品名称重复
                    MessageBox.Show("饮品名称重复!");
                }
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //检查输入是否为空
            if (txtBox_drink_name.Text == "")
            {
                MessageBox.Show("请输入饮品名称!");
                return;
            }
            
            if (comboBox_status.SelectedIndex == -1)
            {
                MessageBox.Show("请选择饮品销售状态!");
                return;
            }
            
            if (!checkBox_small.Checked && !checkBox_medium.Checked && !checkBox_large.Checked)
            {
                MessageBox.Show("请设置饮品价格!");
                return;
            }
            
            if (op == Operation.ADD) //新增模式
            {
                addDrinkInfo();
                displayDrinkInfo();
                resetInput();
            }else if (op == Operation.MODIFY) //修改模式
            {
                modifySelectedDrinkInfo();
                displayDrinkInfo();
                resetInput();
                drinkInfoListView.SelectedItems.Clear();
                changeOperationToAdd();
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

        /**将选中的饮品信息显示到输入控件中*/
        private void displaySelectedDrinkInfo()
        {
            ListViewItem selected_item = drinkInfoListView.SelectedItems[0];
            int drink_id = Convert.ToInt32(selected_item.SubItems[0].Text);

            string drink_name = selected_item.SubItems[1].Text;
            txtBox_drink_name.Text = drink_name;

            string price_small = selected_item.SubItems[2].Text;
            string price_medium = selected_item.SubItems[3].Text;
            string price_large = selected_item.SubItems[4].Text;

            if (price_small != "")
            {
                checkBox_small.Checked = true;
                numBox_price_small.Value = Convert.ToInt32(price_small);
            }
            else
            {
                checkBox_small.Checked = false;
            }

            if (price_medium != "")
            {
                checkBox_medium.Checked = true;
                numBox_price_medium.Value = Convert.ToInt32(price_medium);
            }
            else
            {
                checkBox_medium.Checked = false;
            }

            if (price_large != "")
            {
                checkBox_large.Checked = true;
                numBox_price_large.Value = Convert.ToInt32(price_large);
            }
            else
            {
                checkBox_large.Checked = false;
            }

            string status = selected_item.SubItems[5].Text;
            if (status == "在售")
            {
                comboBox_status.SelectedIndex = 0;
            }
            else if (status == "售完")
            {
                comboBox_status.SelectedIndex = 1;
            }
            else if (status == "停售")
            {
                comboBox_status.SelectedIndex = 2;
            }

            //显示饮品图片
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery($"SELECT * FROM drink_info WHERE drink_id = {drink_id}");
            DataRow row = dt.Rows[0];
            pictureBox.ImageLocation = row["drink_image"].ToString();
            pictureBox.Show();
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
                displaySelectedDrinkInfo();
            }
        }

        private void btn_cancel_select_Click(object sender, EventArgs e)
        {
            drinkInfoListView.SelectedItems.Clear();
            resetInput();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (op == Operation.MODIFY)
            {
                ListViewItem selected_item = drinkInfoListView.SelectedItems[0];
                int drink_id = Convert.ToInt32(selected_item.SubItems[0].Text);
                
                DBOperator dbOperator = DBOperator.Instance;
                dbOperator.TableExecute($"DELETE FROM drink_info WHERE drink_id = {drink_id}");
                resetInput();
                displayDrinkInfo();
                changeOperationToAdd();
            }
        }
    
        /**在数据库中修改选中的饮品信息*/
        private void modifySelectedDrinkInfo()
        {
            if (drinkInfoListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择需要修改的饮品!");
            }
            else
            {
                ListViewItem selected_item = drinkInfoListView.SelectedItems[0];
                int drink_id = Convert.ToInt32(selected_item.SubItems[0].Text);
                
                string drink_name = txtBox_drink_name.Text;
                
                string price_small = checkBox_small.Checked ? numBox_price_small.Value.ToString() : "NULL";
                string price_medium = checkBox_medium.Checked ? numBox_price_medium.Value.ToString() : "NULL";
                string price_large = checkBox_large.Checked ? numBox_price_large.Value.ToString() : "NULL";
                
                string drink_image = pictureBox.ImageLocation;
                drink_image = drink_image.Replace(@"\",@"\\"); //将文件路径中的一个反斜杠替换为两个反斜杠
                
                int status = comboBox_status.SelectedIndex;
                
                DBOperator dbOperator = DBOperator.Instance;
                try
                {
                    dbOperator.TableExecute($"UPDATE drink_info SET drink_name = '{drink_name}', price_small = {price_small}," +
                                                        $"price_medium = {price_medium}, price_large = {price_large}, " +
                                                        $"drink_image = '{drink_image}', status = {status} " +
                                                        $"WHERE drink_id = {drink_id}");
                }
                catch (MySqlException ex)
                {
                    Debug.WriteLine(ex.Message);
                    if (ex.Message.Contains("Duplicate"))
                    {
                        //饮品名称重复
                        MessageBox.Show("饮品名称重复!");
                    }
    
                    return;
                }
                
                MessageBox.Show("修改成功!");
            }
            
        }

        private void btn_selectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "./";
            openFileDialog.Filter = "图片文件|*.jpg;*.jpeg;*.png|所有文件|*.*";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = @openFileDialog.FileName;
                pictureBox.ImageLocation = selectedFile;
                pictureBox.Show();
            }
        }

        private void btn_resetPicture_Click(object sender, EventArgs e)
        {
            ListViewItem selected_item = drinkInfoListView.SelectedItems[0];
            int drink_id = Convert.ToInt32(selected_item.SubItems[0].Text);
                
            DBOperator dbOperator = DBOperator.Instance;
            dbOperator.TableExecute($"UPDATE drink_info SET drink_image = NULL WHERE drink_id = {drink_id}");
            
            displaySelectedDrinkInfo();
        }
    }
}