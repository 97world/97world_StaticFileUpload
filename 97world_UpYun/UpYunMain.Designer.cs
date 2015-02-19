namespace _97world_UpYun
{
    partial class UpYunMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.mainMenuBar = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemOperator = new System.Windows.Forms.MenuItem();
            this.menuItemNetLine = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemLogin = new System.Windows.Forms.MenuItem();
            this.menuItemLogout = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItemNetAuto = new System.Windows.Forms.MenuItem();
            this.menuItemNetTel = new System.Windows.Forms.MenuItem();
            this.menuItemNetUni = new System.Windows.Forms.MenuItem();
            this.menuItemNetMob = new System.Windows.Forms.MenuItem();
            this.menuItemOfficialSite = new System.Windows.Forms.MenuItem();
            this.menuItemAuthorSite = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelOperatorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelOperatorName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelDelimiter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelUseSpaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelUseSpaceValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelBlank = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOperator,
            this.menuItemNetLine,
            this.menuItemHelp});
            // 
            // menuItemOperator
            // 
            this.menuItemOperator.Index = 0;
            this.menuItemOperator.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemLogin,
            this.menuItemLogout,
            this.menuItem7,
            this.menuItemExit});
            this.menuItemOperator.Text = "操作员(&U)";
            // 
            // menuItemNetLine
            // 
            this.menuItemNetLine.Index = 1;
            this.menuItemNetLine.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNetAuto,
            this.menuItemNetTel,
            this.menuItemNetUni,
            this.menuItemNetMob});
            this.menuItemNetLine.Text = "网络(&I)";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 2;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemOfficialSite,
            this.menuItemAuthorSite,
            this.menuItem15,
            this.menuItemAbout});
            this.menuItemHelp.Text = "帮助(&H)";
            // 
            // menuItemLogin
            // 
            this.menuItemLogin.Index = 0;
            this.menuItemLogin.Shortcut = System.Windows.Forms.Shortcut.F8;
            this.menuItemLogin.Text = "操作员登录(&L)";
            // 
            // menuItemLogout
            // 
            this.menuItemLogout.Index = 1;
            this.menuItemLogout.Text = "操作员注销(C)";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 3;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "退出(&X)";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "-";
            // 
            // menuItemNetAuto
            // 
            this.menuItemNetAuto.Index = 0;
            this.menuItemNetAuto.Text = "自动识别网络(&A)";
            // 
            // menuItemNetTel
            // 
            this.menuItemNetTel.Index = 1;
            this.menuItemNetTel.Text = "中国电信网络(&D)";
            // 
            // menuItemNetUni
            // 
            this.menuItemNetUni.Index = 2;
            this.menuItemNetUni.Text = "中国联通网络(&L)";
            // 
            // menuItemNetMob
            // 
            this.menuItemNetMob.Index = 3;
            this.menuItemNetMob.Text = "中国移动网络(&Y)";
            // 
            // menuItemOfficialSite
            // 
            this.menuItemOfficialSite.Index = 0;
            this.menuItemOfficialSite.Text = "访问又拍云官网...";
            // 
            // menuItemAuthorSite
            // 
            this.menuItemAuthorSite.Index = 1;
            this.menuItemAuthorSite.Text = "访问作者的BLOG...";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 3;
            this.menuItemAbout.Text = "关于(&A)";
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 2;
            this.menuItem15.Text = "-";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelOperatorLabel,
            this.statusLabelOperatorName,
            this.statusLabelDelimiter,
            this.statusLabelUseSpaceLabel,
            this.statusLabelUseSpaceValue,
            this.statusLabelBlank,
            this.toolStripProgressBar1});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 472);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(806, 22);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusLabelOperatorLabel
            // 
            this.statusLabelOperatorLabel.Name = "statusLabelOperatorLabel";
            this.statusLabelOperatorLabel.Size = new System.Drawing.Size(47, 17);
            this.statusLabelOperatorLabel.Text = "操作员:";
            // 
            // statusLabelOperatorName
            // 
            this.statusLabelOperatorName.Name = "statusLabelOperatorName";
            this.statusLabelOperatorName.Size = new System.Drawing.Size(44, 17);
            this.statusLabelOperatorName.Text = "未登录";
            // 
            // statusLabelDelimiter
            // 
            this.statusLabelDelimiter.Name = "statusLabelDelimiter";
            this.statusLabelDelimiter.Size = new System.Drawing.Size(11, 17);
            this.statusLabelDelimiter.Text = "|";
            // 
            // statusLabelUseSpaceLabel
            // 
            this.statusLabelUseSpaceLabel.Name = "statusLabelUseSpaceLabel";
            this.statusLabelUseSpaceLabel.Size = new System.Drawing.Size(71, 17);
            this.statusLabelUseSpaceLabel.Text = "空间已使用:";
            // 
            // statusLabelUseSpaceValue
            // 
            this.statusLabelUseSpaceValue.Name = "statusLabelUseSpaceValue";
            this.statusLabelUseSpaceValue.Size = new System.Drawing.Size(44, 17);
            this.statusLabelUseSpaceValue.Text = "未登录";
            // 
            // statusLabelBlank
            // 
            this.statusLabelBlank.Name = "statusLabelBlank";
            this.statusLabelBlank.Size = new System.Drawing.Size(391, 17);
            this.statusLabelBlank.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar1.Value = 10;
            // 
            // UpYunMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.Controls.Add(this.mainStatusStrip);
            this.Menu = this.mainMenuBar;
            this.Name = "UpYunMain";
            this.Text = "又拍云客户端 Ver.1.0.1";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenuBar;
        private System.Windows.Forms.MenuItem menuItemOperator;
        private System.Windows.Forms.MenuItem menuItemLogin;
        private System.Windows.Forms.MenuItem menuItemLogout;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemNetLine;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItemNetAuto;
        private System.Windows.Forms.MenuItem menuItemNetTel;
        private System.Windows.Forms.MenuItem menuItemNetUni;
        private System.Windows.Forms.MenuItem menuItemNetMob;
        private System.Windows.Forms.MenuItem menuItemOfficialSite;
        private System.Windows.Forms.MenuItem menuItemAuthorSite;
        private System.Windows.Forms.MenuItem menuItem15;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelOperatorLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelOperatorName;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDelimiter;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUseSpaceLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUseSpaceValue;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelBlank;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}