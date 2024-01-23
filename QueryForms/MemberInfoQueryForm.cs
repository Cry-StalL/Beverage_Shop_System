using System;
using System.Data;
using System.Windows.Forms;

namespace Beverage_Shop_System.QueryForms
{
    public partial class MemberInfoQueryForm : Form
    {
        public MemberInfoQueryForm()
        {
            InitializeComponent();
            displayQueryResult();
            initializeComboBoxes();
        }
        
        private void initializeComboBoxes()
        {
            comboBox_gender.SelectedIndex = 0;
        }

        private void displayQueryResult(string queryStr = "SELECT * FROM user_info WHERE user_type = 0")
        {
            //清空原ListView
            memberInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery(queryStr);
            
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

        private string getQueryStr()
        {
            string query_str = "SELECT * FROM user_info WHERE user_type = 0";

            if (btn_name.Checked || btn_memberID.Checked || btn_telephone.Checked || btn_gender.Checked)
            {
                query_str += " AND";
            }

            if (btn_name.Checked)
            {
                query_str += $" real_name LIKE '%{txtBox_name.Text}%' AND";
            }

            if (btn_memberID.Checked)
            {
                query_str += $" member_id LIKE '%{txtBox_memberID.Text}%' AND";
            }
            
            if (btn_telephone.Checked)
            {
                query_str += $" telephone LIKE '%{txtBox_telephone.Text}%' AND";
            }

            if (btn_gender.Checked)
            {
                if (comboBox_gender.SelectedIndex != 0)
                {
                    query_str += $" gender = {comboBox_gender.SelectedIndex - 1}";
                }
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
            
            //重置按钮和txtBox
            btn_name.Checked = false;
            btn_memberID.Checked = false;
            btn_telephone.Checked = false;
            btn_gender.Checked = false;
            txtBox_name.Clear();
            txtBox_memberID.Clear();
            txtBox_telephone.Clear();
            
            //重置搜索结果
            displayQueryResult();
        }

        private void debug_getQueryStr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getQueryStr());
        }
    }
}