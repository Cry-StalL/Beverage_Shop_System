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
            this.col_drink_image = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_price_small = new System.Windows.Forms.CheckBox();
            this.comboBox_price_small = new System.Windows.Forms.ComboBox();
            this.numBox_price_small = new System.Windows.Forms.NumericUpDown();
            this.numBox_price_medium = new System.Windows.Forms.NumericUpDown();
            this.comboBox_price_medium = new System.Windows.Forms.ComboBox();
            this.btn_price_medium = new System.Windows.Forms.CheckBox();
            this.numBox_price_large = new System.Windows.Forms.NumericUpDown();
            this.comboBox_price_large = new System.Windows.Forms.ComboBox();
            this.btn_price_large = new System.Windows.Forms.CheckBox();
            this.btn_status = new System.Windows.Forms.CheckBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.debug_getQueryStr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_large)).BeginInit();
            this.SuspendLayout();
            // 
            // drinkInfoListView
            // 
            this.drinkInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.col_drink_id, this.col_drink_name, this.col_price_small, this.col_price_medium, this.col_price_large, this.col_status, this.col_drink_image });
            this.drinkInfoListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drinkInfoListView.FullRowSelect = true;
            this.drinkInfoListView.GridLines = true;
            this.drinkInfoListView.HideSelection = false;
            this.drinkInfoListView.Location = new System.Drawing.Point(0, 112);
            this.drinkInfoListView.MultiSelect = false;
            this.drinkInfoListView.Name = "drinkInfoListView";
            this.drinkInfoListView.Size = new System.Drawing.Size(782, 491);
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
            // col_drink_image
            // 
            this.col_drink_image.Text = "图片路径";
            this.col_drink_image.Width = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询条件";
            // 
            // btn_price_small
            // 
            this.btn_price_small.AutoSize = true;
            this.btn_price_small.Location = new System.Drawing.Point(12, 36);
            this.btn_price_small.Name = "btn_price_small";
            this.btn_price_small.Size = new System.Drawing.Size(105, 19);
            this.btn_price_small.TabIndex = 3;
            this.btn_price_small.Text = "价格(小杯)";
            this.btn_price_small.UseVisualStyleBackColor = true;
            // 
            // comboBox_price_small
            // 
            this.comboBox_price_small.FormattingEnabled = true;
            this.comboBox_price_small.Items.AddRange(new object[] { "<", "=", ">" });
            this.comboBox_price_small.Location = new System.Drawing.Point(113, 32);
            this.comboBox_price_small.Name = "comboBox_price_small";
            this.comboBox_price_small.Size = new System.Drawing.Size(47, 23);
            this.comboBox_price_small.TabIndex = 4;
            // 
            // numBox_price_small
            // 
            this.numBox_price_small.DecimalPlaces = 2;
            this.numBox_price_small.Location = new System.Drawing.Point(166, 30);
            this.numBox_price_small.Name = "numBox_price_small";
            this.numBox_price_small.Size = new System.Drawing.Size(81, 25);
            this.numBox_price_small.TabIndex = 5;
            // 
            // numBox_price_medium
            // 
            this.numBox_price_medium.DecimalPlaces = 2;
            this.numBox_price_medium.Location = new System.Drawing.Point(447, 27);
            this.numBox_price_medium.Name = "numBox_price_medium";
            this.numBox_price_medium.Size = new System.Drawing.Size(81, 25);
            this.numBox_price_medium.TabIndex = 8;
            // 
            // comboBox_price_medium
            // 
            this.comboBox_price_medium.FormattingEnabled = true;
            this.comboBox_price_medium.Items.AddRange(new object[] { "<", "=", ">" });
            this.comboBox_price_medium.Location = new System.Drawing.Point(394, 29);
            this.comboBox_price_medium.Name = "comboBox_price_medium";
            this.comboBox_price_medium.Size = new System.Drawing.Size(47, 23);
            this.comboBox_price_medium.TabIndex = 7;
            // 
            // btn_price_medium
            // 
            this.btn_price_medium.AutoSize = true;
            this.btn_price_medium.Location = new System.Drawing.Point(293, 33);
            this.btn_price_medium.Name = "btn_price_medium";
            this.btn_price_medium.Size = new System.Drawing.Size(105, 19);
            this.btn_price_medium.TabIndex = 6;
            this.btn_price_medium.Text = "价格(中杯)";
            this.btn_price_medium.UseVisualStyleBackColor = true;
            // 
            // numBox_price_large
            // 
            this.numBox_price_large.DecimalPlaces = 2;
            this.numBox_price_large.Location = new System.Drawing.Point(166, 70);
            this.numBox_price_large.Name = "numBox_price_large";
            this.numBox_price_large.Size = new System.Drawing.Size(81, 25);
            this.numBox_price_large.TabIndex = 11;
            // 
            // comboBox_price_large
            // 
            this.comboBox_price_large.FormattingEnabled = true;
            this.comboBox_price_large.Items.AddRange(new object[] { "<", "=", ">" });
            this.comboBox_price_large.Location = new System.Drawing.Point(113, 72);
            this.comboBox_price_large.Name = "comboBox_price_large";
            this.comboBox_price_large.Size = new System.Drawing.Size(47, 23);
            this.comboBox_price_large.TabIndex = 10;
            // 
            // btn_price_large
            // 
            this.btn_price_large.AutoSize = true;
            this.btn_price_large.Location = new System.Drawing.Point(12, 76);
            this.btn_price_large.Name = "btn_price_large";
            this.btn_price_large.Size = new System.Drawing.Size(105, 19);
            this.btn_price_large.TabIndex = 9;
            this.btn_price_large.Text = "价格(大杯)";
            this.btn_price_large.UseVisualStyleBackColor = true;
            // 
            // btn_status
            // 
            this.btn_status.AutoSize = true;
            this.btn_status.Location = new System.Drawing.Point(293, 76);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(59, 19);
            this.btn_status.TabIndex = 12;
            this.btn_status.Text = "状态";
            this.btn_status.UseVisualStyleBackColor = true;
            // 
            // comboBox_status
            // 
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] { "在售", "售完", "停售" });
            this.comboBox_status.Location = new System.Drawing.Point(358, 72);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(105, 23);
            this.comboBox_status.TabIndex = 13;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(569, 36);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 47);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "查 询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(674, 36);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(73, 47);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "重 置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // debug_getQueryStr
            // 
            this.debug_getQueryStr.Location = new System.Drawing.Point(493, 69);
            this.debug_getQueryStr.Name = "debug_getQueryStr";
            this.debug_getQueryStr.Size = new System.Drawing.Size(52, 26);
            this.debug_getQueryStr.TabIndex = 16;
            this.debug_getQueryStr.Text = "test";
            this.debug_getQueryStr.UseVisualStyleBackColor = true;
            this.debug_getQueryStr.Visible = false;
            this.debug_getQueryStr.Click += new System.EventHandler(this.debug_getQueryStr_Click);
            // 
            // DrinkInfoQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.debug_getQueryStr);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.numBox_price_large);
            this.Controls.Add(this.comboBox_price_large);
            this.Controls.Add(this.btn_price_large);
            this.Controls.Add(this.numBox_price_medium);
            this.Controls.Add(this.comboBox_price_medium);
            this.Controls.Add(this.btn_price_medium);
            this.Controls.Add(this.numBox_price_small);
            this.Controls.Add(this.comboBox_price_small);
            this.Controls.Add(this.btn_price_small);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drinkInfoListView);
            this.Name = "DrinkInfoQueryForm";
            this.Text = "饮品信息查询";
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox_price_large)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button debug_getQueryStr;

        private System.Windows.Forms.ColumnHeader col_drink_image;

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_reset;

        private System.Windows.Forms.NumericUpDown numBox_price_large;
        private System.Windows.Forms.ComboBox comboBox_price_large;
        private System.Windows.Forms.CheckBox btn_price_large;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.CheckBox btn_status;

        private System.Windows.Forms.NumericUpDown numBox_price_small;

        private System.Windows.Forms.ComboBox comboBox_price_medium;
        private System.Windows.Forms.CheckBox btn_price_medium;

        private System.Windows.Forms.NumericUpDown numBox_price_medium;

        private System.Windows.Forms.CheckBox btn_price_small;
        private System.Windows.Forms.ComboBox comboBox_price_small;

        private System.Windows.Forms.Label label1;

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