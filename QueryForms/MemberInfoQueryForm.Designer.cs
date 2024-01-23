using System.ComponentModel;

namespace Beverage_Shop_System.QueryForms
{
    partial class MemberInfoQueryForm
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
            this.memberInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_name = new System.Windows.Forms.CheckBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.btn_memberID = new System.Windows.Forms.CheckBox();
            this.txtBox_memberID = new System.Windows.Forms.TextBox();
            this.btn_telephone = new System.Windows.Forms.CheckBox();
            this.txtBox_telephone = new System.Windows.Forms.TextBox();
            this.btn_gender = new System.Windows.Forms.CheckBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.debug_getQueryStr = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberInfoListView
            // 
            this.memberInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader6, this.columnHeader7, this.columnHeader8, this.columnHeader9, this.columnHeader10 });
            this.memberInfoListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.memberInfoListView.FullRowSelect = true;
            this.memberInfoListView.GridLines = true;
            this.memberInfoListView.HideSelection = false;
            this.memberInfoListView.Location = new System.Drawing.Point(0, 111);
            this.memberInfoListView.MultiSelect = false;
            this.memberInfoListView.Name = "memberInfoListView";
            this.memberInfoListView.Size = new System.Drawing.Size(782, 492);
            this.memberInfoListView.TabIndex = 13;
            this.memberInfoListView.UseCompatibleStateImageBehavior = false;
            this.memberInfoListView.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "查询条件";
            // 
            // btn_name
            // 
            this.btn_name.AutoSize = true;
            this.btn_name.Location = new System.Drawing.Point(12, 36);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(89, 19);
            this.btn_name.TabIndex = 15;
            this.btn_name.Text = "会员姓名";
            this.btn_name.UseVisualStyleBackColor = true;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(107, 30);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(149, 25);
            this.txtBox_name.TabIndex = 16;
            // 
            // btn_memberID
            // 
            this.btn_memberID.AutoSize = true;
            this.btn_memberID.Location = new System.Drawing.Point(296, 33);
            this.btn_memberID.Name = "btn_memberID";
            this.btn_memberID.Size = new System.Drawing.Size(89, 19);
            this.btn_memberID.TabIndex = 17;
            this.btn_memberID.Text = "会员卡号";
            this.btn_memberID.UseVisualStyleBackColor = true;
            // 
            // txtBox_memberID
            // 
            this.txtBox_memberID.Location = new System.Drawing.Point(391, 30);
            this.txtBox_memberID.Name = "txtBox_memberID";
            this.txtBox_memberID.Size = new System.Drawing.Size(128, 25);
            this.txtBox_memberID.TabIndex = 18;
            // 
            // btn_telephone
            // 
            this.btn_telephone.AutoSize = true;
            this.btn_telephone.Location = new System.Drawing.Point(12, 71);
            this.btn_telephone.Name = "btn_telephone";
            this.btn_telephone.Size = new System.Drawing.Size(89, 19);
            this.btn_telephone.TabIndex = 19;
            this.btn_telephone.Text = "电话号码";
            this.btn_telephone.UseVisualStyleBackColor = true;
            // 
            // txtBox_telephone
            // 
            this.txtBox_telephone.Location = new System.Drawing.Point(107, 69);
            this.txtBox_telephone.Name = "txtBox_telephone";
            this.txtBox_telephone.Size = new System.Drawing.Size(149, 25);
            this.txtBox_telephone.TabIndex = 20;
            // 
            // btn_gender
            // 
            this.btn_gender.AutoSize = true;
            this.btn_gender.Location = new System.Drawing.Point(296, 71);
            this.btn_gender.Name = "btn_gender";
            this.btn_gender.Size = new System.Drawing.Size(59, 19);
            this.btn_gender.TabIndex = 21;
            this.btn_gender.Text = "性别";
            this.btn_gender.UseVisualStyleBackColor = true;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] { "全部", "男", "女" });
            this.comboBox_gender.Location = new System.Drawing.Point(361, 69);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(158, 23);
            this.comboBox_gender.TabIndex = 22;
            // 
            // debug_getQueryStr
            // 
            this.debug_getQueryStr.Location = new System.Drawing.Point(525, 79);
            this.debug_getQueryStr.Name = "debug_getQueryStr";
            this.debug_getQueryStr.Size = new System.Drawing.Size(52, 26);
            this.debug_getQueryStr.TabIndex = 23;
            this.debug_getQueryStr.Text = "test";
            this.debug_getQueryStr.UseVisualStyleBackColor = true;
            this.debug_getQueryStr.Visible = false;
            this.debug_getQueryStr.Click += new System.EventHandler(this.debug_getQueryStr_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(685, 33);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(73, 47);
            this.btn_reset.TabIndex = 25;
            this.btn_reset.Text = "重 置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(580, 33);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 47);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "查 询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "重 置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "查 询";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MemberInfoQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.debug_getQueryStr);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.btn_gender);
            this.Controls.Add(this.txtBox_telephone);
            this.Controls.Add(this.btn_telephone);
            this.Controls.Add(this.txtBox_memberID);
            this.Controls.Add(this.btn_memberID);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberInfoListView);
            this.Name = "MemberInfoQueryForm";
            this.Text = "会员信息查询";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_search;

        private System.Windows.Forms.Button debug_getQueryStr;

        private System.Windows.Forms.CheckBox btn_name;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.CheckBox btn_memberID;
        private System.Windows.Forms.TextBox txtBox_memberID;
        private System.Windows.Forms.CheckBox btn_telephone;
        private System.Windows.Forms.TextBox txtBox_telephone;
        private System.Windows.Forms.CheckBox btn_gender;
        private System.Windows.Forms.ComboBox comboBox_gender;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListView memberInfoListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;

        #endregion
    }
}