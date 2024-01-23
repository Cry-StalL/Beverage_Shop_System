using System.ComponentModel;

namespace Beverage_Shop_System
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkInfoManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInfoManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInfoManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitLoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMusicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkInfoQueryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberInfoQueryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInfoQueryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleStatsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripStaffLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Timers.Timer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.manageToolStripMenuItem, this.orderToolStripMenuItem, this.查询中心ToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.drinkInfoManageMenuItem, this.memberInfoManageMenuItem, this.staffInfoManageMenuItem, this.toolStripSeparator, this.exitLoginMenuItem, this.exitMenuItem });
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.manageToolStripMenuItem.Text = "系统管理";
            // 
            // drinkInfoManageMenuItem
            // 
            this.drinkInfoManageMenuItem.Name = "drinkInfoManageMenuItem";
            this.drinkInfoManageMenuItem.Size = new System.Drawing.Size(168, 24);
            this.drinkInfoManageMenuItem.Text = "饮品信息管理";
            this.drinkInfoManageMenuItem.Click += new System.EventHandler(this.drinkInfoManageMenuItem_Click);
            // 
            // memberInfoManageMenuItem
            // 
            this.memberInfoManageMenuItem.Name = "memberInfoManageMenuItem";
            this.memberInfoManageMenuItem.Size = new System.Drawing.Size(168, 24);
            this.memberInfoManageMenuItem.Text = "会员信息管理";
            this.memberInfoManageMenuItem.Click += new System.EventHandler(this.memberInfoManageMenuItem_Click);
            // 
            // staffInfoManageMenuItem
            // 
            this.staffInfoManageMenuItem.Name = "staffInfoManageMenuItem";
            this.staffInfoManageMenuItem.Size = new System.Drawing.Size(168, 24);
            this.staffInfoManageMenuItem.Text = "员工信息管理";
            this.staffInfoManageMenuItem.Click += new System.EventHandler(this.staffInfoManageMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(165, 6);
            // 
            // exitLoginMenuItem
            // 
            this.exitLoginMenuItem.Name = "exitLoginMenuItem";
            this.exitLoginMenuItem.Size = new System.Drawing.Size(168, 24);
            this.exitLoginMenuItem.Text = "退出登录";
            this.exitLoginMenuItem.Click += new System.EventHandler(this.exitLoginMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(168, 24);
            this.exitMenuItem.Text = "退出系统";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.orderMenuItem, this.playMusicMenuItem });
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.orderToolStripMenuItem.Text = "点餐服务";
            // 
            // orderMenuItem
            // 
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Size = new System.Drawing.Size(138, 24);
            this.orderMenuItem.Text = "点餐收银";
            this.orderMenuItem.Click += new System.EventHandler(this.orderMenuItem_Click);
            // 
            // playMusicMenuItem
            // 
            this.playMusicMenuItem.Name = "playMusicMenuItem";
            this.playMusicMenuItem.Size = new System.Drawing.Size(138, 24);
            this.playMusicMenuItem.Text = "音乐播放";
            this.playMusicMenuItem.Click += new System.EventHandler(this.playMusicMenuItem_Click);
            // 
            // 查询中心ToolStripMenuItem
            // 
            this.查询中心ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.drinkInfoQueryMenuItem, this.memberInfoQueryMenuItem, this.orderInfoQueryMenuItem, this.saleStatsMenuItem });
            this.查询中心ToolStripMenuItem.Name = "查询中心ToolStripMenuItem";
            this.查询中心ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.查询中心ToolStripMenuItem.Text = "查询中心";
            // 
            // drinkInfoQueryMenuItem
            // 
            this.drinkInfoQueryMenuItem.Name = "drinkInfoQueryMenuItem";
            this.drinkInfoQueryMenuItem.Size = new System.Drawing.Size(168, 24);
            this.drinkInfoQueryMenuItem.Text = "饮品信息查询";
            this.drinkInfoQueryMenuItem.Click += new System.EventHandler(this.drinkInfoQueryMenuItem_Click);
            // 
            // memberInfoQueryMenuItem
            // 
            this.memberInfoQueryMenuItem.Name = "memberInfoQueryMenuItem";
            this.memberInfoQueryMenuItem.Size = new System.Drawing.Size(168, 24);
            this.memberInfoQueryMenuItem.Text = "会员信息查询";
            this.memberInfoQueryMenuItem.Click += new System.EventHandler(this.memberInfoQueryMenuItem_Click);
            // 
            // orderInfoQueryMenuItem
            // 
            this.orderInfoQueryMenuItem.Name = "orderInfoQueryMenuItem";
            this.orderInfoQueryMenuItem.Size = new System.Drawing.Size(168, 24);
            this.orderInfoQueryMenuItem.Text = "营业信息查询";
            this.orderInfoQueryMenuItem.Click += new System.EventHandler(this.orderInfoQueryMenuItem_Click);
            // 
            // saleStatsMenuItem
            // 
            this.saleStatsMenuItem.Name = "saleStatsMenuItem";
            this.saleStatsMenuItem.Size = new System.Drawing.Size(168, 24);
            this.saleStatsMenuItem.Text = "业绩统计分析";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1109, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusStripLabel1, this.statusStripStaffLabel, this.toolStripStatusLabel1, this.toolStripStatusLabel2, this.statusStripTimeLabel });
            this.statusStrip.Location = new System.Drawing.Point(0, 677);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip.Size = new System.Drawing.Size(1109, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(88, 20);
            this.statusStripLabel1.Text = "当前操作员:";
            // 
            // statusStripStaffLabel
            // 
            this.statusStripStaffLabel.Name = "statusStripStaffLabel";
            this.statusStripStaffLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(250, 20);
            this.toolStripStatusLabel1.Text = "          ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(73, 20);
            this.toolStripStatusLabel2.Text = "当前时间:";
            // 
            // statusStripTimeLabel
            // 
            this.statusStripTimeLabel.AutoSize = false;
            this.statusStripTimeLabel.Name = "statusStripTimeLabel";
            this.statusStripTimeLabel.Size = new System.Drawing.Size(300, 20);
            this.statusStripTimeLabel.Text = "    ";
            this.statusStripTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 632);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1109, 45);
            this.player.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 702);
            this.Controls.Add(this.player);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "饮品店点餐收银系统";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private AxWMPLib.AxWindowsMediaPlayer player;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.ToolStripMenuItem playMusicMenuItem;

        private System.Windows.Forms.ToolStripMenuItem exitLoginMenuItem;

        private System.Timers.Timer timer;

        private System.Windows.Forms.ToolStripStatusLabel statusStripTimeLabel;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.ToolStripStatusLabel statusStripStaffLabel;

        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel1;

        private System.Windows.Forms.StatusStrip statusStrip;

        private System.Windows.Forms.ToolStrip toolStrip;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkInfoQueryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInfoQueryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInfoQueryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleStatsMenuItem;

        private System.Windows.Forms.ToolStripMenuItem drinkInfoManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberInfoManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInfoManageMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;

        #endregion
    }
}