using System.ComponentModel;

namespace Beverage_Shop_System.ManageForms
{
    partial class drinkInfoManageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_price_small = new System.Windows.Forms.Label();
            this.label_price_medium = new System.Windows.Forms.Label();
            this.label_price_large = new System.Windows.Forms.Label();
            this.txtBox_drink_name = new System.Windows.Forms.TextBox();
            this.numBox_price_small = new System.Windows.Forms.NumericUpDown();
            this.numBox_price_medium = new System.Windows.Forms.NumericUpDown();
            this.numBox_price_large = new System.Windows.Forms.NumericUpDown();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.checkBox_small = new System.Windows.Forms.CheckBox();
            this.checkBox_medium = new System.Windows.Forms.CheckBox();
            this.checkBox_large = new System.Windows.Forms.CheckBox();
            this.btn_cancel_select = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_selectPicture = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_resetPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_large)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drinkInfoListView
            // 
            this.drinkInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.col_drink_id, this.col_drink_name, this.col_price_small, this.col_price_medium, this.col_price_large, this.col_status });
            this.drinkInfoListView.FullRowSelect = true;
            this.drinkInfoListView.GridLines = true;
            this.drinkInfoListView.HideSelection = false;
            this.drinkInfoListView.Location = new System.Drawing.Point(12, 377);
            this.drinkInfoListView.MultiSelect = false;
            this.drinkInfoListView.Name = "drinkInfoListView";
            this.drinkInfoListView.Size = new System.Drawing.Size(708, 314);
            this.drinkInfoListView.TabIndex = 0;
            this.drinkInfoListView.UseCompatibleStateImageBehavior = false;
            this.drinkInfoListView.View = System.Windows.Forms.View.Details;
            this.drinkInfoListView.SelectedIndexChanged += new System.EventHandler(this.drinkInfoListView_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前操作:";
            // 
            // opLabel
            // 
            this.opLabel.Location = new System.Drawing.Point(101, 18);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(100, 23);
            this.opLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "饮品名称：";
            // 
            // label_price_small
            // 
            this.label_price_small.Location = new System.Drawing.Point(77, 132);
            this.label_price_small.Name = "label_price_small";
            this.label_price_small.Size = new System.Drawing.Size(100, 23);
            this.label_price_small.TabIndex = 4;
            this.label_price_small.Text = "价格：";
            // 
            // label_price_medium
            // 
            this.label_price_medium.Location = new System.Drawing.Point(77, 188);
            this.label_price_medium.Name = "label_price_medium";
            this.label_price_medium.Size = new System.Drawing.Size(100, 23);
            this.label_price_medium.TabIndex = 5;
            this.label_price_medium.Text = "价格：";
            // 
            // label_price_large
            // 
            this.label_price_large.Location = new System.Drawing.Point(77, 244);
            this.label_price_large.Name = "label_price_large";
            this.label_price_large.Size = new System.Drawing.Size(100, 23);
            this.label_price_large.TabIndex = 6;
            this.label_price_large.Text = "价格：";
            // 
            // txtBox_drink_name
            // 
            this.txtBox_drink_name.Location = new System.Drawing.Point(89, 54);
            this.txtBox_drink_name.Name = "txtBox_drink_name";
            this.txtBox_drink_name.Size = new System.Drawing.Size(150, 25);
            this.txtBox_drink_name.TabIndex = 7;
            // 
            // numBox_price_small
            // 
            this.numBox_price_small.DecimalPlaces = 2;
            this.numBox_price_small.Location = new System.Drawing.Point(126, 130);
            this.numBox_price_small.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numBox_price_small.Name = "numBox_price_small";
            this.numBox_price_small.Size = new System.Drawing.Size(120, 25);
            this.numBox_price_small.TabIndex = 8;
            // 
            // numBox_price_medium
            // 
            this.numBox_price_medium.DecimalPlaces = 2;
            this.numBox_price_medium.Location = new System.Drawing.Point(126, 186);
            this.numBox_price_medium.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numBox_price_medium.Name = "numBox_price_medium";
            this.numBox_price_medium.Size = new System.Drawing.Size(120, 25);
            this.numBox_price_medium.TabIndex = 9;
            // 
            // numBox_price_large
            // 
            this.numBox_price_large.DecimalPlaces = 2;
            this.numBox_price_large.Location = new System.Drawing.Point(126, 242);
            this.numBox_price_large.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numBox_price_large.Name = "numBox_price_large";
            this.numBox_price_large.Size = new System.Drawing.Size(120, 25);
            this.numBox_price_large.TabIndex = 10;
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] { "在售", "售完", "停售" });
            this.comboBox_status.Location = new System.Drawing.Point(385, 54);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(121, 23);
            this.comboBox_status.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(335, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "状态:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(348, 297);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 35);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保 存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(491, 297);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 35);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "清  空";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // checkBox_small
            // 
            this.checkBox_small.AutoSize = true;
            this.checkBox_small.Location = new System.Drawing.Point(12, 132);
            this.checkBox_small.Name = "checkBox_small";
            this.checkBox_small.Size = new System.Drawing.Size(59, 19);
            this.checkBox_small.TabIndex = 15;
            this.checkBox_small.Text = "小杯";
            this.checkBox_small.UseVisualStyleBackColor = true;
            this.checkBox_small.CheckedChanged += new System.EventHandler(this.checkBox_small_CheckedChanged);
            // 
            // checkBox_medium
            // 
            this.checkBox_medium.AutoSize = true;
            this.checkBox_medium.Location = new System.Drawing.Point(12, 188);
            this.checkBox_medium.Name = "checkBox_medium";
            this.checkBox_medium.Size = new System.Drawing.Size(59, 19);
            this.checkBox_medium.TabIndex = 16;
            this.checkBox_medium.Text = "中杯";
            this.checkBox_medium.UseVisualStyleBackColor = true;
            this.checkBox_medium.CheckedChanged += new System.EventHandler(this.checkBox_medium_CheckedChanged);
            // 
            // checkBox_large
            // 
            this.checkBox_large.AutoSize = true;
            this.checkBox_large.Location = new System.Drawing.Point(12, 244);
            this.checkBox_large.Name = "checkBox_large";
            this.checkBox_large.Size = new System.Drawing.Size(59, 19);
            this.checkBox_large.TabIndex = 17;
            this.checkBox_large.Text = "大杯";
            this.checkBox_large.UseVisualStyleBackColor = true;
            this.checkBox_large.CheckedChanged += new System.EventHandler(this.checkBox_large_CheckedChanged);
            // 
            // btn_cancel_select
            // 
            this.btn_cancel_select.AutoSize = true;
            this.btn_cancel_select.Location = new System.Drawing.Point(12, 346);
            this.btn_cancel_select.Name = "btn_cancel_select";
            this.btn_cancel_select.Size = new System.Drawing.Size(77, 25);
            this.btn_cancel_select.TabIndex = 18;
            this.btn_cancel_select.Text = "取消选择";
            this.btn_cancel_select.UseVisualStyleBackColor = true;
            this.btn_cancel_select.Click += new System.EventHandler(this.btn_cancel_select_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Location = new System.Drawing.Point(95, 346);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(77, 25);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "删除饮品";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(346, 143);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(220, 148);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // btn_selectPicture
            // 
            this.btn_selectPicture.Location = new System.Drawing.Point(421, 113);
            this.btn_selectPicture.Name = "btn_selectPicture";
            this.btn_selectPicture.Size = new System.Drawing.Size(85, 24);
            this.btn_selectPicture.TabIndex = 21;
            this.btn_selectPicture.Text = "选择图片";
            this.btn_selectPicture.UseVisualStyleBackColor = true;
            this.btn_selectPicture.Click += new System.EventHandler(this.btn_selectPicture_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "饮品图片";
            // 
            // btn_resetPicture
            // 
            this.btn_resetPicture.AutoSize = true;
            this.btn_resetPicture.Location = new System.Drawing.Point(178, 346);
            this.btn_resetPicture.Name = "btn_resetPicture";
            this.btn_resetPicture.Size = new System.Drawing.Size(77, 25);
            this.btn_resetPicture.TabIndex = 23;
            this.btn_resetPicture.Text = "重置图片";
            this.btn_resetPicture.UseVisualStyleBackColor = true;
            this.btn_resetPicture.Click += new System.EventHandler(this.btn_resetPicture_Click);
            // 
            // drinkInfoManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.btn_resetPicture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_selectPicture);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_cancel_select);
            this.Controls.Add(this.checkBox_large);
            this.Controls.Add(this.checkBox_medium);
            this.Controls.Add(this.checkBox_small);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.numBox_price_large);
            this.Controls.Add(this.numBox_price_medium);
            this.Controls.Add(this.numBox_price_small);
            this.Controls.Add(this.txtBox_drink_name);
            this.Controls.Add(this.label_price_large);
            this.Controls.Add(this.label_price_medium);
            this.Controls.Add(this.label_price_small);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drinkInfoListView);
            this.Name = "drinkInfoManageForm";
            this.Text = "饮品信息管理";
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_large)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_resetPicture;

        private System.Windows.Forms.Button btn_selectPicture;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Button btn_delete;

        private System.Windows.Forms.Button btn_cancel_select;

        private System.Windows.Forms.CheckBox checkBox_medium;
        private System.Windows.Forms.CheckBox checkBox_large;

        private System.Windows.Forms.CheckBox checkBox_small;

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;

        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.NumericUpDown numBox_price_small;
        private System.Windows.Forms.NumericUpDown numBox_price_medium;
        private System.Windows.Forms.NumericUpDown numBox_price_large;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_price_small;
        private System.Windows.Forms.Label label_price_medium;
        private System.Windows.Forms.Label label_price_large;
        private System.Windows.Forms.TextBox txtBox_drink_name;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label opLabel;

        private System.Windows.Forms.ColumnHeader col_drink_id;
        private System.Windows.Forms.ColumnHeader col_drink_name;
        private System.Windows.Forms.ColumnHeader col_price_small;
        private System.Windows.Forms.ColumnHeader col_price_medium;
        private System.Windows.Forms.ColumnHeader col_price_large;
        private System.Windows.Forms.ColumnHeader col_status;

        private System.Windows.Forms.ListView drinkInfoListView;

        #endregion
    }
}