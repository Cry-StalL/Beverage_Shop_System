using System;
using System.Data;
using System.Windows.Forms;

namespace Beverage_Shop_System.QueryForms
{
    public partial class DrinkInfoQueryForm : Form
    {
        public DrinkInfoQueryForm()
        {
            InitializeComponent();
            displayQueryResult();
            initializeComboBoxes();
        }

        private void initializeComboBoxes()
        {
            comboBox_price_small.SelectedIndex = 0;
            comboBox_price_medium.SelectedIndex = 0;
            comboBox_price_large.SelectedIndex = 0;
            comboBox_status.SelectedIndex = 0;
        }

        private void displayQueryResult(string queryStr = "SELECT * FROM drink_info")
        {
            //清空原ListView
            drinkInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery(queryStr);
            
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

                item.SubItems.Add(row["drink_image"].ToString());

                drinkInfoListView.Items.Add(item);
            }
        }

        private string getQueryStr()
        {
            string query_str = "SELECT * FROM drink_info";

            if (btn_price_small.Checked || btn_price_medium.Checked || btn_price_large.Checked || btn_status.Checked)
            {
                query_str += " WHERE";
            }
        
            if (btn_price_small.Checked)
            {
                string op = comboBox_price_small.SelectedItem.ToString();
                query_str += $" price_small {op} {numBox_price_small.Text} AND";
            }
            
            if (btn_price_medium.Checked)
            {
                string op = comboBox_price_medium.SelectedItem.ToString();
                query_str += $" price_medium {op} {numBox_price_medium.Text} AND";
            }
            
            if (btn_price_large.Checked)
            {
                string op = comboBox_price_large.SelectedItem.ToString();
                query_str += $" price_large {op} {numBox_price_large.Text} AND";
            }

            if (btn_status.Checked)
            {
                query_str += $" status = {comboBox_status.SelectedIndex}";
            }

            if (query_str.EndsWith(" AND"))
            {
                query_str = query_str.Substring(0, query_str.Length - 4);
            }

            return query_str;
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            displayQueryResult(getQueryStr());
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //重置comboBox
            initializeComboBoxes();
            
            //重置按钮和numBox
            btn_price_small.Checked = false;
            btn_price_medium.Checked = false;
            btn_price_large.Checked = false;
            btn_status.Checked = false;

            numBox_price_small.Text = "0";
            numBox_price_medium.Text = "0";
            numBox_price_large.Text = "0";
            
            //重置搜索结果
            displayQueryResult();
        }

        private void debug_getQueryStr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getQueryStr());
        }
    }
}