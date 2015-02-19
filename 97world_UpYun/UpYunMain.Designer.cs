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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpYunMain));
            this.mainMenuBar = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemOperator = new System.Windows.Forms.MenuItem();
            this.menuItemLogin = new System.Windows.Forms.MenuItem();
            this.menuItemLogout = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemNetLine = new System.Windows.Forms.MenuItem();
            this.menuItemNetAuto = new System.Windows.Forms.MenuItem();
            this.menuItemNetTel = new System.Windows.Forms.MenuItem();
            this.menuItemNetUni = new System.Windows.Forms.MenuItem();
            this.menuItemNetMob = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemOfficialSite = new System.Windows.Forms.MenuItem();
            this.menuItemAuthorSite = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelOperatorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelOperatorName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelDelimiter = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelUseSpaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelUseSpaceValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelBlank = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mainPanelLeft = new System.Windows.Forms.Panel();
            this.toolStripLeft = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.mainPanelRight = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.mainStatusStrip.SuspendLayout();
            this.mainPanelLeft.SuspendLayout();
            this.toolStripLeft.SuspendLayout();
            this.mainPanelRight.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 3;
            this.menuItemExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.menuItemExit.Text = "退出(&X)";
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
            // menuItem15
            // 
            this.menuItem15.Index = 2;
            this.menuItem15.Text = "-";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 3;
            this.menuItemAbout.Text = "关于(&A)";
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
            this.statusLabelBlank.Size = new System.Drawing.Size(422, 17);
            this.statusLabelBlank.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar1.Value = 10;
            // 
            // mainPanelLeft
            // 
            this.mainPanelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanelLeft.Controls.Add(this.listView1);
            this.mainPanelLeft.Controls.Add(this.panel2);
            this.mainPanelLeft.Controls.Add(this.toolStripLeft);
            this.mainPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.mainPanelLeft.Name = "mainPanelLeft";
            this.mainPanelLeft.Size = new System.Drawing.Size(400, 472);
            this.mainPanelLeft.TabIndex = 1;
            // 
            // toolStripLeft
            // 
            this.toolStripLeft.AutoSize = false;
            this.toolStripLeft.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton5,
            this.toolStripButton4});
            this.toolStripLeft.Location = new System.Drawing.Point(0, 0);
            this.toolStripLeft.Name = "toolStripLeft";
            this.toolStripLeft.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripLeft.Size = new System.Drawing.Size(400, 40);
            this.toolStripLeft.TabIndex = 0;
            this.toolStripLeft.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 37);
            this.toolStripLabel1.Text = "  本地浏览器  ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton3.Text = "toolStripButton1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton6.Text = "toolStripButton1";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton7.Text = "toolStripButton1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton5.Text = "toolStripButton1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton4.Text = "toolStripButton1";
            // 
            // mainPanelRight
            // 
            this.mainPanelRight.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanelRight.Controls.Add(this.listView2);
            this.mainPanelRight.Controls.Add(this.panel1);
            this.mainPanelRight.Controls.Add(this.toolStrip1);
            this.mainPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelRight.Location = new System.Drawing.Point(400, 0);
            this.mainPanelRight.Name = "mainPanelRight";
            this.mainPanelRight.Size = new System.Drawing.Size(406, 472);
            this.mainPanelRight.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripButton13,
            this.toolStripButton8,
            this.toolStripButton14,
            this.toolStripButton11,
            this.toolStripButton10,
            this.toolStripButton12,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(406, 40);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(84, 37);
            this.toolStripLabel2.Text = "  远程浏览器  ";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.AutoSize = false;
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton13.Text = "toolStripButton1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton8.Text = "toolStripButton1";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.AutoSize = false;
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton14.Text = "toolStripButton1";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton11.Text = "toolStripButton1";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton10.Text = "toolStripButton1";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.AutoSize = false;
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton12.Text = "toolStripButton1";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.AutoSize = false;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(37, 37);
            this.toolStripButton9.Text = "toolStripButton1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitter1.Location = new System.Drawing.Point(400, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 472);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 20);
            this.panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(28, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(376, 20);
            this.comboBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Image = global::_97world_UpYun.Properties.Resources.up_16x16;
            this.button2.Location = new System.Drawing.Point(3, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 22);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 60);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(406, 412);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 20);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = global::_97world_UpYun.Properties.Resources.up_16x16;
            this.button1.Location = new System.Drawing.Point(1, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 22);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(372, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 412);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UpYunMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 494);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.mainPanelRight);
            this.Controls.Add(this.mainPanelLeft);
            this.Controls.Add(this.mainStatusStrip);
            this.Menu = this.mainMenuBar;
            this.Name = "UpYunMain";
            this.Text = "又拍云客户端 Ver.1.0.1";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainPanelLeft.ResumeLayout(false);
            this.toolStripLeft.ResumeLayout(false);
            this.toolStripLeft.PerformLayout();
            this.mainPanelRight.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel mainPanelLeft;
        private System.Windows.Forms.Panel mainPanelRight;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStripLeft;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}