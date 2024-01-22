using System.ComponentModel;

namespace Beverage_Shop_System.ManageForms
{
    partial class memberInfoManageForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_male = new System.Windows.Forms.RadioButton();
            this.btn_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_member_id = new System.Windows.Forms.TextBox();
            this.txtBox_telephone = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.memberInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4, this.columnHeader5 });
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 300);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(708, 391);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户编号";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "电话号码";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "会员卡号";
            this.columnHeader5.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前操作：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别：";
            // 
            // btn_male
            // 
            this.btn_male.Location = new System.Drawing.Point(66, 157);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(46, 24);
            this.btn_male.TabIndex = 5;
            this.btn_male.TabStop = true;
            this.btn_male.Text = "男";
            this.btn_male.UseVisualStyleBackColor = true;
            // 
            // btn_female
            // 
            this.btn_female.Location = new System.Drawing.Point(142, 157);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(45, 24);
            this.btn_female.TabIndex = 6;
            this.btn_female.TabStop = true;
            this.btn_female.Text = "女";
            this.btn_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(269, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "电话号码：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(269, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "会员卡号：";
            // 
            // opLabel
            // 
            this.opLabel.AutoSize = true;
            this.opLabel.Location = new System.Drawing.Point(85, 9);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(0, 15);
            this.opLabel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 23;
            // 
            // txtBox_member_id
            // 
            this.txtBox_member_id.Location = new System.Drawing.Point(347, 86);
            this.txtBox_member_id.Name = "txtBox_member_id";
            this.txtBox_member_id.Size = new System.Drawing.Size(176, 25);
            this.txtBox_member_id.TabIndex = 22;
            // 
            // txtBox_telephone
            // 
            this.txtBox_telephone.Location = new System.Drawing.Point(347, 156);
            this.txtBox_telephone.Name = "txtBox_telephone";
            this.txtBox_telephone.Size = new System.Drawing.Size(176, 25);
            this.txtBox_telephone.TabIndex = 21;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(57, 86);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(130, 25);
            this.txtBox_name.TabIndex = 15;
            // 
            // memberInfoListView
            // 
            this.memberInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader6, this.columnHeader7, this.columnHeader8, this.columnHeader9, this.columnHeader10 });
            this.memberInfoListView.FullRowSelect = true;
            this.memberInfoListView.GridLines = true;
            this.memberInfoListView.HideSelection = false;
            this.memberInfoListView.Location = new System.Drawing.Point(12, 301);
            this.memberInfoListView.MultiSelect = false;
            this.memberInfoListView.Name = "memberInfoListView";
            this.memberInfoListView.Size = new System.Drawing.Size(708, 391);
            this.memberInfoListView.TabIndex = 12;
            this.memberInfoListView.UseCompatibleStateImageBehavior = false;
            this.memberInfoListView.View = System.Windows.Forms.View.Details;
            this.memberInfoListView.SelectedIndexChanged += new System.EventHandler(this.memberInfoListView_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "用户编号";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "姓名";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 92;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "性别";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "电话号码";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "会员卡号";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 137;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(294, 210);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 40);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "保 存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(422, 210);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 40);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "重 置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(12, 265);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 30);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "取消选择";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Location = new System.Drawing.Point(129, 265);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 29);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "删 除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // memberInfoManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_member_id);
            this.Controls.Add(this.txtBox_telephone);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.memberInfoListView);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.btn_male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "memberInfoManageForm";
            this.Text = "会员信息管理";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Button btn_reset;

        private System.Windows.Forms.Button btn_save;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_member_id;
        private System.Windows.Forms.TextBox txtBox_telephone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView memberInfoListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;

        private System.Windows.Forms.Label opLabel;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btn_male;
        private System.Windows.Forms.RadioButton btn_female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_name;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

        private System.Windows.Forms.ColumnHeader columnHeader2;

        private System.Windows.Forms.ColumnHeader columnHeader1;

        private System.Windows.Forms.ListView listView1;

        #endregion
    }
}