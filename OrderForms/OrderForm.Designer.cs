using System.ComponentModel;

namespace Beverage_Shop_System.OrderForms
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.drinkInfoListView = new System.Windows.Forms.ListView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orderInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label_drinkName = new System.Windows.Forms.Label();
            this.btn_small = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_medium = new System.Windows.Forms.RadioButton();
            this.label_price_small = new System.Windows.Forms.Label();
            this.label_price_medium = new System.Windows.Forms.Label();
            this.label_price_large = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numBox_count = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_comment = new System.Windows.Forms.TextBox();
            this.btn_AddToOrder = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reduce = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_memberID = new System.Windows.Forms.TextBox();
            this.txtBox_orderAmount = new System.Windows.Forms.TextBox();
            this.txtBox_discountAmount = new System.Windows.Forms.TextBox();
            this.txtBox_paidAmount = new System.Windows.Forms.TextBox();
            this.btn_payMethod_cash = new System.Windows.Forms.RadioButton();
            this.btn_payMethod_card = new System.Windows.Forms.RadioButton();
            this.btn_payMethod_Alipay = new System.Windows.Forms.RadioButton();
            this.btn_payMethod_Wechat = new System.Windows.Forms.RadioButton();
            this.btn_confirmPayment = new System.Windows.Forms.Button();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_large = new System.Windows.Forms.RadioButton();
            this.numBox_discountRate = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_count)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_discountRate)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择饮品";
            // 
            // drinkInfoListView
            // 
            this.drinkInfoListView.HideSelection = false;
            this.drinkInfoListView.LargeImageList = this.imageList;
            this.drinkInfoListView.Location = new System.Drawing.Point(16, 34);
            this.drinkInfoListView.MultiSelect = false;
            this.drinkInfoListView.Name = "drinkInfoListView";
            this.drinkInfoListView.Size = new System.Drawing.Size(612, 434);
            this.drinkInfoListView.TabIndex = 1;
            this.drinkInfoListView.UseCompatibleStateImageBehavior = false;
            this.drinkInfoListView.SelectedIndexChanged += new System.EventHandler(this.drinkInfoListView_SelectedIndexChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 474);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(170, 170);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "订单信息";
            // 
            // orderInfoListView
            // 
            this.orderInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4, this.columnHeader5, this.columnHeader6 });
            this.orderInfoListView.FullRowSelect = true;
            this.orderInfoListView.GridLines = true;
            this.orderInfoListView.HideSelection = false;
            this.orderInfoListView.Location = new System.Drawing.Point(646, 35);
            this.orderInfoListView.MultiSelect = false;
            this.orderInfoListView.Name = "orderInfoListView";
            this.orderInfoListView.Size = new System.Drawing.Size(324, 199);
            this.orderInfoListView.TabIndex = 4;
            this.orderInfoListView.UseCompatibleStateImageBehavior = false;
            this.orderInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名称";
            this.columnHeader2.Width = 44;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "规格";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "数量";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "饮品名称：";
            // 
            // label_drinkName
            // 
            this.label_drinkName.AutoSize = true;
            this.label_drinkName.Location = new System.Drawing.Point(280, 484);
            this.label_drinkName.Name = "label_drinkName";
            this.label_drinkName.Size = new System.Drawing.Size(0, 15);
            this.label_drinkName.TabIndex = 6;
            // 
            // btn_small
            // 
            this.btn_small.AutoSize = true;
            this.btn_small.Location = new System.Drawing.Point(11, 10);
            this.btn_small.Name = "btn_small";
            this.btn_small.Size = new System.Drawing.Size(58, 19);
            this.btn_small.TabIndex = 7;
            this.btn_small.TabStop = true;
            this.btn_small.Text = "小杯";
            this.btn_small.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "价格：";
            // 
            // btn_medium
            // 
            this.btn_medium.AutoSize = true;
            this.btn_medium.Location = new System.Drawing.Point(109, 10);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(58, 19);
            this.btn_medium.TabIndex = 9;
            this.btn_medium.TabStop = true;
            this.btn_medium.Text = "中杯";
            this.btn_medium.UseVisualStyleBackColor = true;
            // 
            // label_price_small
            // 
            this.label_price_small.AutoSize = true;
            this.label_price_small.Location = new System.Drawing.Point(262, 539);
            this.label_price_small.Name = "label_price_small";
            this.label_price_small.Size = new System.Drawing.Size(0, 15);
            this.label_price_small.TabIndex = 11;
            // 
            // label_price_medium
            // 
            this.label_price_medium.AutoSize = true;
            this.label_price_medium.Location = new System.Drawing.Point(360, 542);
            this.label_price_medium.Name = "label_price_medium";
            this.label_price_medium.Size = new System.Drawing.Size(0, 15);
            this.label_price_medium.TabIndex = 12;
            // 
            // label_price_large
            // 
            this.label_price_large.AutoSize = true;
            this.label_price_large.Location = new System.Drawing.Point(463, 542);
            this.label_price_large.Name = "label_price_large";
            this.label_price_large.Size = new System.Drawing.Size(0, 15);
            this.label_price_large.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "数量：";
            // 
            // numBox_count
            // 
            this.numBox_count.Location = new System.Drawing.Point(260, 572);
            this.numBox_count.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numBox_count.Name = "numBox_count";
            this.numBox_count.Size = new System.Drawing.Size(77, 25);
            this.numBox_count.TabIndex = 15;
            this.numBox_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBox_count.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 615);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "备注：";
            // 
            // txtBox_comment
            // 
            this.txtBox_comment.Location = new System.Drawing.Point(260, 612);
            this.txtBox_comment.Name = "txtBox_comment";
            this.txtBox_comment.Size = new System.Drawing.Size(163, 25);
            this.txtBox_comment.TabIndex = 17;
            // 
            // btn_AddToOrder
            // 
            this.btn_AddToOrder.Location = new System.Drawing.Point(534, 560);
            this.btn_AddToOrder.Name = "btn_AddToOrder";
            this.btn_AddToOrder.Size = new System.Drawing.Size(83, 46);
            this.btn_AddToOrder.TabIndex = 18;
            this.btn_AddToOrder.Text = "加入订单";
            this.btn_AddToOrder.UseVisualStyleBackColor = true;
            this.btn_AddToOrder.Click += new System.EventHandler(this.btn_AddToOrder_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(681, 239);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 30);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "加1杯";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_reduce
            // 
            this.btn_reduce.Location = new System.Drawing.Point(785, 241);
            this.btn_reduce.Name = "btn_reduce";
            this.btn_reduce.Size = new System.Drawing.Size(57, 28);
            this.btn_reduce.TabIndex = 20;
            this.btn_reduce.Text = "减1杯";
            this.btn_reduce.UseVisualStyleBackColor = true;
            this.btn_reduce.Click += new System.EventHandler(this.btn_reduce_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(887, 240);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(57, 28);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "移除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "会员卡号：";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(646, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "订单金额：";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(646, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "折扣比例：";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(646, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "折扣金额：";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(646, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "实收金额：";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(646, 531);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "付款方式：";
            // 
            // txtBox_memberID
            // 
            this.txtBox_memberID.Location = new System.Drawing.Point(734, 286);
            this.txtBox_memberID.Name = "txtBox_memberID";
            this.txtBox_memberID.Size = new System.Drawing.Size(222, 25);
            this.txtBox_memberID.TabIndex = 28;
            // 
            // txtBox_orderAmount
            // 
            this.txtBox_orderAmount.Location = new System.Drawing.Point(734, 337);
            this.txtBox_orderAmount.Name = "txtBox_orderAmount";
            this.txtBox_orderAmount.ReadOnly = true;
            this.txtBox_orderAmount.Size = new System.Drawing.Size(222, 25);
            this.txtBox_orderAmount.TabIndex = 29;
            // 
            // txtBox_discountAmount
            // 
            this.txtBox_discountAmount.Location = new System.Drawing.Point(734, 433);
            this.txtBox_discountAmount.Name = "txtBox_discountAmount";
            this.txtBox_discountAmount.ReadOnly = true;
            this.txtBox_discountAmount.Size = new System.Drawing.Size(222, 25);
            this.txtBox_discountAmount.TabIndex = 31;
            // 
            // txtBox_paidAmount
            // 
            this.txtBox_paidAmount.Location = new System.Drawing.Point(734, 481);
            this.txtBox_paidAmount.Name = "txtBox_paidAmount";
            this.txtBox_paidAmount.ReadOnly = true;
            this.txtBox_paidAmount.Size = new System.Drawing.Size(222, 25);
            this.txtBox_paidAmount.TabIndex = 32;
            // 
            // btn_payMethod_cash
            // 
            this.btn_payMethod_cash.AutoSize = true;
            this.btn_payMethod_cash.Location = new System.Drawing.Point(734, 531);
            this.btn_payMethod_cash.Name = "btn_payMethod_cash";
            this.btn_payMethod_cash.Size = new System.Drawing.Size(58, 19);
            this.btn_payMethod_cash.TabIndex = 33;
            this.btn_payMethod_cash.TabStop = true;
            this.btn_payMethod_cash.Text = "现金";
            this.btn_payMethod_cash.UseVisualStyleBackColor = true;
            // 
            // btn_payMethod_card
            // 
            this.btn_payMethod_card.Location = new System.Drawing.Point(852, 528);
            this.btn_payMethod_card.Name = "btn_payMethod_card";
            this.btn_payMethod_card.Size = new System.Drawing.Size(104, 24);
            this.btn_payMethod_card.TabIndex = 34;
            this.btn_payMethod_card.TabStop = true;
            this.btn_payMethod_card.Text = "银行卡";
            this.btn_payMethod_card.UseVisualStyleBackColor = true;
            // 
            // btn_payMethod_Alipay
            // 
            this.btn_payMethod_Alipay.Location = new System.Drawing.Point(734, 560);
            this.btn_payMethod_Alipay.Name = "btn_payMethod_Alipay";
            this.btn_payMethod_Alipay.Size = new System.Drawing.Size(104, 24);
            this.btn_payMethod_Alipay.TabIndex = 35;
            this.btn_payMethod_Alipay.TabStop = true;
            this.btn_payMethod_Alipay.Text = "支付宝";
            this.btn_payMethod_Alipay.UseVisualStyleBackColor = true;
            // 
            // btn_payMethod_Wechat
            // 
            this.btn_payMethod_Wechat.Location = new System.Drawing.Point(852, 561);
            this.btn_payMethod_Wechat.Name = "btn_payMethod_Wechat";
            this.btn_payMethod_Wechat.Size = new System.Drawing.Size(104, 24);
            this.btn_payMethod_Wechat.TabIndex = 36;
            this.btn_payMethod_Wechat.TabStop = true;
            this.btn_payMethod_Wechat.Text = "微信";
            this.btn_payMethod_Wechat.UseVisualStyleBackColor = true;
            // 
            // btn_confirmPayment
            // 
            this.btn_confirmPayment.AutoSize = true;
            this.btn_confirmPayment.Location = new System.Drawing.Point(717, 607);
            this.btn_confirmPayment.Name = "btn_confirmPayment";
            this.btn_confirmPayment.Size = new System.Drawing.Size(77, 34);
            this.btn_confirmPayment.TabIndex = 37;
            this.btn_confirmPayment.Text = "确定支付";
            this.btn_confirmPayment.UseVisualStyleBackColor = true;
            this.btn_confirmPayment.Click += new System.EventHandler(this.btn_confirmPayment_Click);
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.AutoSize = true;
            this.btn_cancelOrder.Location = new System.Drawing.Point(835, 607);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(77, 34);
            this.btn_cancelOrder.TabIndex = 38;
            this.btn_cancelOrder.Text = "取消订单";
            this.btn_cancelOrder.UseVisualStyleBackColor = true;
            this.btn_cancelOrder.Click += new System.EventHandler(this.btn_cancelOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_large);
            this.panel1.Controls.Add(this.btn_medium);
            this.panel1.Controls.Add(this.btn_small);
            this.panel1.Location = new System.Drawing.Point(251, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 37);
            this.panel1.TabIndex = 39;
            // 
            // btn_large
            // 
            this.btn_large.AutoSize = true;
            this.btn_large.Location = new System.Drawing.Point(212, 10);
            this.btn_large.Name = "btn_large";
            this.btn_large.Size = new System.Drawing.Size(58, 19);
            this.btn_large.TabIndex = 10;
            this.btn_large.TabStop = true;
            this.btn_large.Text = "大杯";
            this.btn_large.UseVisualStyleBackColor = true;
            // 
            // numBox_discountRate
            // 
            this.numBox_discountRate.Location = new System.Drawing.Point(734, 387);
            this.numBox_discountRate.Name = "numBox_discountRate";
            this.numBox_discountRate.Size = new System.Drawing.Size(210, 25);
            this.numBox_discountRate.TabIndex = 40;
            this.numBox_discountRate.ValueChanged += new System.EventHandler(this.numBox_discountRate_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(950, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "%";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numBox_discountRate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.btn_confirmPayment);
            this.Controls.Add(this.btn_payMethod_Wechat);
            this.Controls.Add(this.btn_payMethod_Alipay);
            this.Controls.Add(this.btn_payMethod_card);
            this.Controls.Add(this.btn_payMethod_cash);
            this.Controls.Add(this.txtBox_paidAmount);
            this.Controls.Add(this.txtBox_discountAmount);
            this.Controls.Add(this.txtBox_orderAmount);
            this.Controls.Add(this.txtBox_memberID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_reduce);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_AddToOrder);
            this.Controls.Add(this.txtBox_comment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numBox_count);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_price_large);
            this.Controls.Add(this.label_price_medium);
            this.Controls.Add(this.label_price_small);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_drinkName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderInfoListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.drinkInfoListView);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "点餐收银";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_count)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_discountRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numBox_discountRate;
        private System.Windows.Forms.Label label13;

        private System.Windows.Forms.TextBox txtBox_discountAmount;
        private System.Windows.Forms.TextBox txtBox_paidAmount;
        private System.Windows.Forms.RadioButton btn_payMethod_cash;
        private System.Windows.Forms.RadioButton btn_payMethod_card;
        private System.Windows.Forms.RadioButton btn_payMethod_Alipay;
        private System.Windows.Forms.RadioButton btn_payMethod_Wechat;
        private System.Windows.Forms.Button btn_confirmPayment;
        private System.Windows.Forms.Button btn_cancelOrder;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_memberID;
        private System.Windows.Forms.TextBox txtBox_orderAmount;

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_reduce;
        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;

        private System.Windows.Forms.Button btn_AddToOrder;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_comment;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBox_count;

        private System.Windows.Forms.RadioButton btn_small;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton btn_medium;
        private System.Windows.Forms.RadioButton btn_large;
        private System.Windows.Forms.Label label_price_small;
        private System.Windows.Forms.Label label_price_medium;
        private System.Windows.Forms.Label label_price_large;

        private System.Windows.Forms.Label label_drinkName;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView orderInfoListView;

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView drinkInfoListView;

        private System.Windows.Forms.ImageList imageList;

        #endregion
    }
}