using System;
using System.Data;
using System.Windows.Forms;

namespace Beverage_Shop_System.QueryForms
{
    public partial class OrderInfoQueryForm : Form
    {
        public OrderInfoQueryForm()
        {
            InitializeComponent();
            displayQueryResult();
            initializeComboBoxes();
        }
        
        private void initializeComboBoxes()
        {
            comboBox_payMethod.SelectedIndex = 0;
        }

        private void displayQueryResult(string queryStr = "SELECT * FROM order_info")
        {
            //清空原ListView
            orderInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery(queryStr);
            
            //dt中的每一行
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["order_id"].ToString());
                item.SubItems.Add(row["member_id"].ToString());
                
                //订单内容
                string order_items = "";
                item.SubItems.Add(order_items);
                
                //订单金额
                item.SubItems.Add(row["order_amount"].ToString());
                
                //折扣比例
                double amount_rate = Convert.ToDouble(row["amount_rate"]);
                double discount_rate = 1 - amount_rate;
                item.SubItems.Add(discount_rate.ToString());
                
                //折扣金额
                item.SubItems.Add(row["discount_amount"].ToString());

                //实收金额
                item.SubItems.Add(row["paid_amount"].ToString());

                //支付方式
                switch (row["pay_method"].ToString())
                {
                    case "0":
                        item.SubItems.Add("现金");
                        break;
                    case "1":
                        item.SubItems.Add("银行卡");
                        break;
                    case "2":
                        item.SubItems.Add("微信");
                        break;
                    case "3":
                        item.SubItems.Add("支付宝");
                        break;
                }

                //销售日期
                item.SubItems.Add(row["order_time"].ToString());

                //操作员
                item.SubItems.Add(row["staff_name"].ToString());

                orderInfoListView.Items.Add(item);
            }
        }

        private string getQueryStr()
        {
            if (!btn_orderDate.Checked && !btn_payMethod.Checked && !btn_drinkName.Checked && !btn_memberID.Checked)
            {
                 return "SELECT * FROM order_info";
            }
            
            string query_str = "SELECT * FROM order_info WHERE";
            
            if (btn_orderDate.Checked)
            {
                
            }

            if (btn_payMethod.Checked)
            {
                if (comboBox_payMethod.SelectedIndex != 0)
                {
                    query_str += $" pay_method = {comboBox_payMethod.SelectedIndex - 1} AND";
                }
            }

            if (btn_drinkName.Checked)
            {
                
            }

            if (btn_memberID.Checked)
            {
                query_str += $" member_id LIKE '%{txtBox_memberID.Text}%' AND";
            }
            
            if (query_str.EndsWith(" AND"))
            {
                query_str = query_str.Substring(0, query_str.Length - 4);
            }
            
            if (query_str.EndsWith(" WHERE"))
            {
                query_str = query_str.Substring(0, query_str.Length - 6);
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
            btn_orderDate.Checked = false;
            btn_payMethod.Checked = false;
            btn_drinkName.Checked = false;
            btn_memberID.Checked = false;
            
            txtBox_drinkName.Clear();
            txtBox_memberID.Clear();
        }

        private void debug_getQueryStr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getQueryStr());
        }
    }
}