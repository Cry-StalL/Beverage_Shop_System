using System.ComponentModel;

namespace Beverage_Shop_System.ManageForms
{
    partial class staffInfoManageForm
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
            this.staffInfoListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_male = new System.Windows.Forms.RadioButton();
            this.btn_female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_telephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staffInfoListView
            // 
            this.staffInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4, this.columnHeader5, this.columnHeader6 });
            this.staffInfoListView.FullRowSelect = true;
            this.staffInfoListView.GridLines = true;
            this.staffInfoListView.HideSelection = false;
            this.staffInfoListView.Location = new System.Drawing.Point(12, 347);
            this.staffInfoListView.MultiSelect = false;
            this.staffInfoListView.Name = "staffInfoListView";
            this.staffInfoListView.Size = new System.Drawing.Size(708, 344);
            this.staffInfoListView.TabIndex = 0;
            this.staffInfoListView.UseCompatibleStateImageBehavior = false;
            this.staffInfoListView.View = System.Windows.Forms.View.Details;
            this.staffInfoListView.SelectedIndexChanged += new System.EventHandler(this.staffInfoListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "用户编号";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "用户名";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "密码";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "性别";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "电话号码";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前操作：";
            // 
            // opLabel
            // 
            this.opLabel.AutoSize = true;
            this.opLabel.Location = new System.Drawing.Point(86, 9);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(0, 15);
            this.opLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(64, 81);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(150, 25);
            this.txtBox_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "性别：";
            // 
            // btn_male
            // 
            this.btn_male.AutoSize = true;
            this.btn_male.Location = new System.Drawing.Point(64, 153);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(43, 19);
            this.btn_male.TabIndex = 6;
            this.btn_male.TabStop = true;
            this.btn_male.Text = "男";
            this.btn_male.UseVisualStyleBackColor = true;
            // 
            // btn_female
            // 
            this.btn_female.AutoSize = true;
            this.btn_female.Location = new System.Drawing.Point(151, 153);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(43, 19);
            this.btn_female.TabIndex = 7;
            this.btn_female.TabStop = true;
            this.btn_female.Text = "女";
            this.btn_female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "用户名：";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "电话：";
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(367, 81);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(150, 25);
            this.txtBox_username.TabIndex = 10;
            // 
            // txtBox_telephone
            // 
            this.txtBox_telephone.Location = new System.Drawing.Point(64, 210);
            this.txtBox_telephone.Name = "txtBox_telephone";
            this.txtBox_telephone.Size = new System.Drawing.Size(150, 25);
            this.txtBox_telephone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(309, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "密码：";
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(367, 152);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(150, 25);
            this.txtBox_password.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 16;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(321, 237);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(72, 40);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "保  存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(445, 237);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(72, 40);
            this.btn_reset.TabIndex = 29;
            this.btn_reset.Text = "重  置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.Location = new System.Drawing.Point(13, 315);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 27);
            this.btn_cancel.TabIndex = 30;
            this.btn_cancel.Text = "取消选择";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(114, 314);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(67, 27);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "删 除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // staffInfoManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBox_telephone);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.btn_male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffInfoListView);
            this.Name = "staffInfoManageForm";
            this.Text = "员工信息管理";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.TextBox txtBox_password;

        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox txtBox_username;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_telephone;

        private System.Windows.Forms.RadioButton btn_male;

        private System.Windows.Forms.RadioButton btn_female;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txtBox_name;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label opLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;

        private System.Windows.Forms.ListView staffInfoListView;

        #endregion
    }
}