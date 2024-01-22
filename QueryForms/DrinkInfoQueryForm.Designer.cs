using System.ComponentModel;

namespace Beverage_Shop_System.QueryForms
{
    partial class DrinkInfoQueryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drinkInfoListView = new System.Windows.Forms.ListView();
            this.col_drink_id = new System.Windows.Forms.ColumnHeader();
            this.col_drink_name = new System.Windows.Forms.ColumnHeader();
            this.col_price_small = new System.Windows.Forms.ColumnHeader();
            this.col_price_medium = new System.Windows.Forms.ColumnHeader();
            this.col_price_large = new System.Windows.Forms.ColumnHeader();
            this.col_status = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // drinkInfoListView
            // 
            this.drinkInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.col_drink_id, this.col_drink_name, this.col_price_small, this.col_price_medium, this.col_price_large, this.col_status });
            this.drinkInfoListView.FullRowSelect = true;
            this.drinkInfoListView.GridLines = true;
            this.drinkInfoListView.HideSelection = false;
            this.drinkInfoListView.Location = new System.Drawing.Point(12, 280);
            this.drinkInfoListView.MultiSelect = false;
            this.drinkInfoListView.Name = "drinkInfoListView";
            this.drinkInfoListView.Size = new System.Drawing.Size(798, 401);
            this.drinkInfoListView.TabIndex = 1;
            this.drinkInfoListView.UseCompatibleStateImageBehavior = false;
            this.drinkInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // col_drink_id
            // 
            this.col_drink_id.Text = "饮品编号";
            this.col_drink_id.Width = 77;
            // 
            // col_drink_name
            // 
            this.col_drink_name.Text = "饮品名称";
            this.col_drink_name.Width = 147;
            // 
            // col_price_small
            // 
            this.col_price_small.Text = "价格(小)";
            this.col_price_small.Width = 87;
            // 
            // col_price_medium
            // 
            this.col_price_medium.Text = "价格(中)";
            this.col_price_medium.Width = 81;
            // 
            // col_price_large
            // 
            this.col_price_large.Text = "价格(大)";
            this.col_price_large.Width = 85;
            // 
            // col_status
            // 
            this.col_status.Text = "状态";
            this.col_status.Width = 83;
            // 
            // DrinkInfoQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 693);
            this.Controls.Add(this.drinkInfoListView);
            this.Name = "DrinkInfoQueryForm";
            this.Text = "饮品信息查询";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView drinkInfoListView;
        private System.Windows.Forms.ColumnHeader col_drink_id;
        private System.Windows.Forms.ColumnHeader col_drink_name;
        private System.Windows.Forms.ColumnHeader col_price_small;
        private System.Windows.Forms.ColumnHeader col_price_medium;
        private System.Windows.Forms.ColumnHeader col_price_large;
        private System.Windows.Forms.ColumnHeader col_status;

        #endregion
    }
}