using System.ComponentModel;

namespace Beverage_Shop_System.QueryForms
{
    partial class OrderInfoQueryForm
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
            this.orderInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_orderDate = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.btn_payMethod = new System.Windows.Forms.CheckBox();
            this.comboBox_payMethod = new System.Windows.Forms.ComboBox();
            this.btn_drinkName = new System.Windows.Forms.CheckBox();
            this.txtBox_drinkName = new System.Windows.Forms.TextBox();
            this.btn_memberID = new System.Windows.Forms.CheckBox();
            this.txtBox_memberID = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.debug_getQueryStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderInfoListView
            // 
            this.orderInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4, this.columnHeader5, this.columnHeader11, this.columnHeader12, this.columnHeader13, this.columnHeader14, this.columnHeader15 });
            this.orderInfoListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orderInfoListView.FullRowSelect = true;
            this.orderInfoListView.GridLines = true;
            this.orderInfoListView.HideSelection = false;
            this.orderInfoListView.Location = new System.Drawing.Point(0, 111);
            this.orderInfoListView.MultiSelect = false;
            this.orderInfoListView.Name = "orderInfoListView";
            this.orderInfoListView.Size = new System.Drawing.Size(882, 492);
            this.orderInfoListView.TabIndex = 14;
            this.orderInfoListView.UseCompatibleStateImageBehavior = false;
            this.orderInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "订单编号";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "会员卡号";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "订单内容";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "订单金额";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "折扣比例";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "折扣金额";
            this.columnHeader11.Width = 86;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "实收金额";
            this.columnHeader12.Width = 96;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "支付方式";
            this.columnHeader13.Width = 85;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "销售日期";
            this.columnHeader14.Width = 81;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "操作员";
            this.columnHeader15.Width = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "查询条件";
            // 
            // btn_orderDate
            // 
            this.btn_orderDate.AutoSize = true;
            this.btn_orderDate.Location = new System.Drawing.Point(12, 37);
            this.btn_orderDate.Name = "btn_orderDate";
            this.btn_orderDate.Size = new System.Drawing.Size(89, 19);
            this.btn_orderDate.TabIndex = 16;
            this.btn_orderDate.Text = "销售日期";
            this.btn_orderDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(107, 31);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(135, 25);
            this.dateTimePicker_start.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "至";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(276, 31);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(135, 25);
            this.dateTimePicker_end.TabIndex = 19;
            // 
            // btn_payMethod
            // 
            this.btn_payMethod.AutoSize = true;
            this.btn_payMethod.Location = new System.Drawing.Point(440, 32);
            this.btn_payMethod.Name = "btn_payMethod";
            this.btn_payMethod.Size = new System.Drawing.Size(89, 19);
            this.btn_payMethod.TabIndex = 20;
            this.btn_payMethod.Text = "付款方式";
            this.btn_payMethod.UseVisualStyleBackColor = true;
            // 
            // comboBox_payMethod
            // 
            this.comboBox_payMethod.FormattingEnabled = true;
            this.comboBox_payMethod.Items.AddRange(new object[] { "全部", "现金", "银行卡", "微信", "支付宝" });
            this.comboBox_payMethod.Location = new System.Drawing.Point(535, 30);
            this.comboBox_payMethod.Name = "comboBox_payMethod";
            this.comboBox_payMethod.Size = new System.Drawing.Size(121, 23);
            this.comboBox_payMethod.TabIndex = 21;
            // 
            // btn_drinkName
            // 
            this.btn_drinkName.AutoSize = true;
            this.btn_drinkName.Location = new System.Drawing.Point(12, 72);
            this.btn_drinkName.Name = "btn_drinkName";
            this.btn_drinkName.Size = new System.Drawing.Size(89, 19);
            this.btn_drinkName.TabIndex = 22;
            this.btn_drinkName.Text = "饮品名称";
            this.btn_drinkName.UseVisualStyleBackColor = true;
            // 
            // txtBox_drinkName
            // 
            this.txtBox_drinkName.Location = new System.Drawing.Point(107, 70);
            this.txtBox_drinkName.Name = "txtBox_drinkName";
            this.txtBox_drinkName.Size = new System.Drawing.Size(304, 25);
            this.txtBox_drinkName.TabIndex = 23;
            // 
            // btn_memberID
            // 
            this.btn_memberID.AutoSize = true;
            this.btn_memberID.Location = new System.Drawing.Point(440, 72);
            this.btn_memberID.Name = "btn_memberID";
            this.btn_memberID.Size = new System.Drawing.Size(89, 19);
            this.btn_memberID.TabIndex = 24;
            this.btn_memberID.Text = "会员卡号";
            this.btn_memberID.UseVisualStyleBackColor = true;
            // 
            // txtBox_memberID
            // 
            this.txtBox_memberID.Location = new System.Drawing.Point(535, 72);
            this.txtBox_memberID.Name = "txtBox_memberID";
            this.txtBox_memberID.Size = new System.Drawing.Size(121, 25);
            this.txtBox_memberID.TabIndex = 25;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(786, 37);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(73, 47);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "重 置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(681, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 47);
            this.btn_search.TabIndex = 26;
            this.btn_search.Text = "查 询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // debug_getQueryStr
            // 
            this.debug_getQueryStr.Location = new System.Drawing.Point(818, 140);
            this.debug_getQueryStr.Name = "debug_getQueryStr";
            this.debug_getQueryStr.Size = new System.Drawing.Size(52, 26);
            this.debug_getQueryStr.TabIndex = 28;
            this.debug_getQueryStr.Text = "test";
            this.debug_getQueryStr.UseVisualStyleBackColor = true;
            this.debug_getQueryStr.Visible = false;
            this.debug_getQueryStr.Click += new System.EventHandler(this.debug_getQueryStr_Click);
            // 
            // OrderInfoQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.debug_getQueryStr);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtBox_memberID);
            this.Controls.Add(this.btn_memberID);
            this.Controls.Add(this.txtBox_drinkName);
            this.Controls.Add(this.btn_drinkName);
            this.Controls.Add(this.comboBox_payMethod);
            this.Controls.Add(this.btn_payMethod);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.btn_orderDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderInfoListView);
            this.Name = "OrderInfoQueryForm";
            this.Text = "营业信息查询";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button debug_getQueryStr;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;

        private System.Windows.Forms.CheckBox btn_drinkName;
        private System.Windows.Forms.TextBox txtBox_drinkName;
        private System.Windows.Forms.CheckBox btn_memberID;
        private System.Windows.Forms.TextBox txtBox_memberID;

        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_payMethod;
        private System.Windows.Forms.CheckBox btn_orderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.CheckBox btn_payMethod;

        private System.Windows.Forms.ListView orderInfoListView;

        #endregion
    }
}