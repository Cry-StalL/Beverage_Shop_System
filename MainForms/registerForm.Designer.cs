using System.ComponentModel;

namespace Beverage_Shop_System
{
    partial class registerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.btn_male = new System.Windows.Forms.RadioButton();
            this.btn_female = new System.Windows.Forms.RadioButton();
            this.txtBox_telephone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(115, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(115, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(115, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "性别";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(115, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "电话号码";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(198, 305);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 29);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "注   册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(189, 23);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(158, 25);
            this.txtBox_username.TabIndex = 6;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(189, 76);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.PasswordChar = '•';
            this.txtBox_password.Size = new System.Drawing.Size(158, 25);
            this.txtBox_password.TabIndex = 7;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(189, 137);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(158, 25);
            this.txtBox_name.TabIndex = 8;
            // 
            // btn_male
            // 
            this.btn_male.Location = new System.Drawing.Point(189, 189);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(49, 24);
            this.btn_male.TabIndex = 9;
            this.btn_male.TabStop = true;
            this.btn_male.Text = "男";
            this.btn_male.UseVisualStyleBackColor = true;
            // 
            // btn_female
            // 
            this.btn_female.Location = new System.Drawing.Point(284, 189);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(53, 24);
            this.btn_female.TabIndex = 10;
            this.btn_female.TabStop = true;
            this.btn_female.Text = "女";
            this.btn_female.UseVisualStyleBackColor = true;
            // 
            // txtBox_telephone
            // 
            this.txtBox_telephone.Location = new System.Drawing.Point(189, 245);
            this.txtBox_telephone.Name = "txtBox_telephone";
            this.txtBox_telephone.Size = new System.Drawing.Size(158, 25);
            this.txtBox_telephone.TabIndex = 11;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 366);
            this.Controls.Add(this.txtBox_telephone);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.btn_male);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registerForm";
            this.Text = "操作员注册";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.TextBox txtBox_telephone;
        private System.Windows.Forms.RadioButton btn_male;
        private System.Windows.Forms.RadioButton btn_female;

        private System.Windows.Forms.Button btn_register;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        #endregion
    }
}