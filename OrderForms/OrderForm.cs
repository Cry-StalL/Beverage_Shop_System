using System.Data;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;

namespace Beverage_Shop_System.OrderForms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            displayDrinkInfo();
        }

        private void displayDrinkInfo()
        {
            //清除原listView
            drinkInfoListView.Items.Clear();
            
            DBOperator dbOperator = DBOperator.Instance;
            DataTable dt = dbOperator.TableQuery("SELECT * FROM drink_info");
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                ListViewItem item = new ListViewItem(row["drink_name"].ToString());
                item.SubItems.Add(row["drink_id"].ToString());
                
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
        
    }
}