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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.drinkInfoListView.Size = new System.Drawing.Size(645, 434);
            this.drinkInfoListView.TabIndex = 1;
            this.drinkInfoListView.UseCompatibleStateImageBehavior = false;
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
            this.label2.Location = new System.Drawing.Point(672, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "订单信息";
            // 
            // orderInfoListView
            // 
            this.orderInfoListView.HideSelection = false;
            this.orderInfoListView.Location = new System.Drawing.Point(677, 35);
            this.orderInfoListView.Name = "orderInfoListView";
            this.orderInfoListView.Size = new System.Drawing.Size(293, 199);
            this.orderInfoListView.TabIndex = 4;
            this.orderInfoListView.UseCompatibleStateImageBehavior = false;
            this.orderInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.orderInfoListView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.drinkInfoListView);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "点餐收银";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView orderInfoListView;

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView drinkInfoListView;

        private System.Windows.Forms.ImageList imageList;

        #endregion
    }
}