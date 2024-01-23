using System;
using System.Data;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;

namespace Beverage_Shop_System.OrderForms
{
    public partial class OrderForm : Form
    {
        public OrderForm(DataRow staff_info)
        {
            InitializeComponent();
            btn_small.Hide();
            btn_medium.Hide();
            btn_large.Hide();
            displayDrinkInfo();

            current_staff_info = staff_info;
        }

        private DataRow current_staff_info;

        private void displayDrinkInfo()
        {
            //清除原listView
            drinkInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery("SELECT * FROM drink_info WHERE status = 0"); //显示在售的饮品
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                ListViewItem item = new ListViewItem(row["drink_name"].ToString());
                item.SubItems.Add(row["drink_id"].ToString());
                item.SubItems.Add(row["drink_image"].ToString()); // 2
                item.SubItems.Add(row["price_small"].ToString()); // 3
                item.SubItems.Add(row["price_medium"].ToString()); // 4
                item.SubItems.Add(row["price_large"].ToString()); // 5
                
                // 图片
                if (row["drink_image"].ToString() != "")
                {
                    Image image = Image.FromFile(row["drink_image"].ToString());
                    imageList.Images.Add(image);
                }

                item.ImageIndex = i;

                drinkInfoListView.Items.Add(item);
            }
            
        }

        private void drinkInfoListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (drinkInfoListView.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = drinkInfoListView.SelectedItems[0];
                string drink_name = selected_item.SubItems[0].Text;
                string drink_image = selected_item.SubItems[2].Text;
                string price_small = selected_item.SubItems[3].Text;
                string price_medium = selected_item.SubItems[4].Text;
                string price_large = selected_item.SubItems[5].Text;
                
                pictureBox.ImageLocation = drink_image;
                label_drinkName.Text = drink_name;
                label_price_small.Text = price_small;
                label_price_medium.Text = price_medium;
                label_price_large.Text = price_large;

                if (price_small == "") btn_small.Hide();
                else btn_small.Show();

                if (price_medium == "") btn_medium.Hide();
                else btn_medium.Show();
                
                if (price_large == "") btn_large.Hide();
                else btn_large.Show();

                resetInput();
            }
            
        }

        private void btn_AddToOrder_Click(object sender, EventArgs e)
        {
            if (drinkInfoListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择饮品!");
                return;
            }
            
            if (!btn_small.Checked && !btn_medium.Checked && !btn_large.Checked)
            {
                MessageBox.Show("请选择饮品规格!");
                return;
            }
            
            ListViewItem selected_item = drinkInfoListView.SelectedItems[0];
            string drink_name = selected_item.SubItems[0].Text;
            string drink_id = selected_item.SubItems[1].Text;
            string portion = "";
            string price = "";

            ListViewItem item = new ListViewItem(drink_id);
            item.SubItems.Add(drink_name);

            if (btn_small.Checked)
            {
                portion = "小杯";
                price = selected_item.SubItems[3].Text;
            }else if (btn_medium.Checked)
            {
                portion = "中杯";
                price = selected_item.SubItems[4].Text;
            }else if (btn_large.Checked)
            {
                portion = "大杯";
                price = selected_item.SubItems[5].Text;
            }
            
            item.SubItems.Add(portion);
            item.SubItems.Add(price);
            item.SubItems.Add(numBox_count.Text);
            item.SubItems.Add(txtBox_comment.Text);

            orderInfoListView.Items.Add(item);

            updateAmount();
        }

        private void resetInput()
        {
            btn_small.Checked = false;
            btn_medium.Checked = false;
            btn_large.Checked = false;

            numBox_count.Text = "1";
            txtBox_comment.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            orderInfoListView.SelectedItems[0].SubItems[4].Text = 
                (Convert.ToInt32(orderInfoListView.SelectedItems[0].SubItems[4].Text) + 1).ToString();
            
            updateAmount();
        }

        private void btn_reduce_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(orderInfoListView.SelectedItems[0].SubItems[4].Text) > 1)
            {
                orderInfoListView.SelectedItems[0].SubItems[4].Text = 
                    (Convert.ToInt32(orderInfoListView.SelectedItems[0].SubItems[4].Text) - 1).ToString();
                
                updateAmount();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            orderInfoListView.Items.Remove(orderInfoListView.SelectedItems[0]);
            orderInfoListView.SelectedItems.Clear();
            
            updateAmount();
        }

        private void updateAmount()
        {
            double amount = 0;
            //3price * 4count
            foreach (ListViewItem item in orderInfoListView.Items)
            {
                double price = Convert.ToDouble(item.SubItems[3].Text);
                int count = Convert.ToInt32(item.SubItems[4].Text);

                amount += price * count;
            }

            double discount_rate = Convert.ToInt32(numBox_discountRate.Text) / 100.0;
            double amount_rate = 1 - discount_rate;

            double discount_amount = amount * discount_rate;
            double paid_amouont = amount * amount_rate;
            
            txtBox_orderAmount.Text = amount.ToString();
            txtBox_discountAmount.Text = discount_amount.ToString();
            txtBox_paidAmount.Text = paid_amouont.ToString();
        }

        private void numBox_discountRate_ValueChanged(object sender, EventArgs e)
        {
            updateAmount();
        }

        private void addOrder()
        {
            double order_amount = Convert.ToDouble(txtBox_orderAmount.Text);
            double amount_rate = 1 - Convert.ToDouble(numBox_discountRate.Text);
            double discount_amount = Convert.ToDouble(txtBox_discountAmount.Text);
            double paid_amount = Convert.ToDouble(txtBox_paidAmount.Text);

            int pay_method = 0;
            if (btn_payMethod_cash.Checked) pay_method = 0;
            else if (btn_payMethod_card.Checked) pay_method = 1;
            else if (btn_payMethod_Wechat.Checked) pay_method = 2;
            else if (btn_payMethod_Alipay.Checked) pay_method = 3;
            
            DateTime order_time = DateTime.Now;

            string member_id = txtBox_memberID.Text != "" ? txtBox_memberID.Text : "NULL";

            string staff_name = current_staff_info["real_name"].ToString();

            DBOperator dbOperator = DBOperator.Instance;
            
            /*order_info表*/
            
            dbOperator.TableExecute(
                $"INSERT INTO order_info (order_amount, amount_rate, discount_amount, paid_amount, pay_method, order_time, member_id, staff_name) " +
                $"VALUES ({order_amount}, {amount_rate}, {discount_amount}, {paid_amount}, {pay_method}, '{order_time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"{member_id}, '{staff_name}')");
            
            //查order_info的最后一行，得到该订单的order_id
            DataTable dt = dbOperator.TableQuery("SELECT * FROM order_info ORDER BY order_id DESC LIMIT 1");
            DataRow row = dt.Rows[0];
            string order_id = row[0].ToString();

            /*order_items表*/
            foreach (ListViewItem item in orderInfoListView.Items)
            {
                string size_str = item.SubItems[2].Text.ToString();
                int size = 0;
                switch (size_str)
                {
                    case "小杯":
                        size = 0;
                        break;
                    case "中杯":
                        size = 1;
                        break;
                    case "大杯":
                        size = 2;
                        break;
                }

                string sql_str = "INSERT INTO order_item_info (order_id, drink_id, size, count) VALUES" +
                                   $"({order_id}, {item.SubItems[0].Text.ToString()}, {size}, {item.SubItems[4].Text.ToString()})";
                
                dbOperator.TableExecute(sql_str);
            }
            
        }

        private void resetOrderDisplay()
        {
            orderInfoListView.Items.Clear();
            txtBox_memberID.Clear();
            txtBox_orderAmount.Clear();
            numBox_discountRate.Text = "0";
            txtBox_discountAmount.Clear();
            txtBox_paidAmount.Clear();

            btn_payMethod_card.Checked = false;
            btn_payMethod_cash.Checked = false;
            btn_payMethod_Alipay.Checked = false;
            btn_payMethod_Wechat.Checked = false;
        }
        
        private void btn_confirmPayment_Click(object sender, EventArgs e)
        {
            if (!btn_payMethod_card.Checked && !btn_payMethod_cash.Checked && !btn_payMethod_Alipay.Checked &&
                !btn_payMethod_Wechat.Checked)
            {
                MessageBox.Show("请选择付款方式!");
                return;
            }

            addOrder();

            MessageBox.Show("支付成功!");

            resetOrderDisplay();
        }

        private void btn_cancelOrder_Click(object sender, EventArgs e)
        {
            resetOrderDisplay();
        }
    }
}