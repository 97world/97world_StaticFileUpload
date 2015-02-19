namespace _97world_UpYun
{
    partial class UpYunLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxInternet = new System.Windows.Forms.ComboBox();
            this.textBoxDomain = new System.Windows.Forms.TextBox();
            this.textBoxOperatorPwd = new System.Windows.Forms.TextBox();
            this.textBoxOperatorName = new System.Windows.Forms.TextBox();
            this.textBoxBucketName = new System.Windows.Forms.TextBox();
            this.labelInternet = new System.Windows.Forms.Label();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelOperatorPwd = new System.Windows.Forms.Label();
            this.labelOperatorName = new System.Windows.Forms.Label();
            this.labelBucketName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxAutoLogin = new System.Windows.Forms.CheckBox();
            this.checkBoxRememberPwd = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxInternet);
            this.panel1.Controls.Add(this.textBoxDomain);
            this.panel1.Controls.Add(this.textBoxOperatorPwd);
            this.panel1.Controls.Add(this.textBoxOperatorName);
            this.panel1.Controls.Add(this.textBoxBucketName);
            this.panel1.Controls.Add(this.labelInternet);
            this.panel1.Controls.Add(this.labelDomain);
            this.panel1.Controls.Add(this.labelOperatorPwd);
            this.panel1.Controls.Add(this.labelOperatorName);
            this.panel1.Controls.Add(this.labelBucketName);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 203);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxInternet
            // 
            this.comboBoxInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInternet.FormattingEnabled = true;
            this.comboBoxInternet.Location = new System.Drawing.Point(145, 152);
            this.comboBoxInternet.Name = "comboBoxInternet";
            this.comboBoxInternet.Size = new System.Drawing.Size(200, 25);
            this.comboBoxInternet.TabIndex = 9;
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Location = new System.Drawing.Point(145, 118);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(200, 23);
            this.textBoxDomain.TabIndex = 8;
            // 
            // textBoxOperatorPwd
            // 
            this.textBoxOperatorPwd.Location = new System.Drawing.Point(145, 84);
            this.textBoxOperatorPwd.Name = "textBoxOperatorPwd";
            this.textBoxOperatorPwd.PasswordChar = '*';
            this.textBoxOperatorPwd.Size = new System.Drawing.Size(200, 23);
            this.textBoxOperatorPwd.TabIndex = 7;
            // 
            // textBoxOperatorName
            // 
            this.textBoxOperatorName.Location = new System.Drawing.Point(145, 50);
            this.textBoxOperatorName.Name = "textBoxOperatorName";
            this.textBoxOperatorName.Size = new System.Drawing.Size(200, 23);
            this.textBoxOperatorName.TabIndex = 6;
            // 
            // textBoxBucketName
            // 
            this.textBoxBucketName.Location = new System.Drawing.Point(145, 16);
            this.textBoxBucketName.Name = "textBoxBucketName";
            this.textBoxBucketName.Size = new System.Drawing.Size(200, 23);
            this.textBoxBucketName.TabIndex = 5;
            // 
            // labelInternet
            // 
            this.labelInternet.AutoSize = true;
            this.labelInternet.Location = new System.Drawing.Point(60, 155);
            this.labelInternet.Name = "labelInternet";
            this.labelInternet.Size = new System.Drawing.Size(80, 17);
            this.labelInternet.TabIndex = 4;
            this.labelInternet.Text = "网络选择(&I)：";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(58, 121);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(82, 17);
            this.labelDomain.TabIndex = 3;
            this.labelDomain.Text = "绑定域名(&L)：";
            // 
            // labelOperatorPwd
            // 
            this.labelOperatorPwd.AutoSize = true;
            this.labelOperatorPwd.Location = new System.Drawing.Point(40, 87);
            this.labelOperatorPwd.Name = "labelOperatorPwd";
            this.labelOperatorPwd.Size = new System.Drawing.Size(100, 17);
            this.labelOperatorPwd.TabIndex = 2;
            this.labelOperatorPwd.Text = "操作员密码(&W)：";
            // 
            // labelOperatorName
            // 
            this.labelOperatorName.AutoSize = true;
            this.labelOperatorName.Location = new System.Drawing.Point(31, 53);
            this.labelOperatorName.Name = "labelOperatorName";
            this.labelOperatorName.Size = new System.Drawing.Size(109, 17);
            this.labelOperatorName.TabIndex = 1;
            this.labelOperatorName.Text = "操作员用户名(&U)：";
            // 
            // labelBucketName
            // 
            this.labelBucketName.AutoSize = true;
            this.labelBucketName.Location = new System.Drawing.Point(56, 19);
            this.labelBucketName.Name = "labelBucketName";
            this.labelBucketName.Size = new System.Drawing.Size(84, 17);
            this.labelBucketName.TabIndex = 0;
            this.labelBucketName.Text = "空间名称(&B)：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBoxAutoLogin);
            this.panel2.Controls.Add(this.checkBoxRememberPwd);
            this.panel2.Location = new System.Drawing.Point(13, 219);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 40);
            this.panel2.TabIndex = 1;
            // 
            // checkBoxAutoLogin
            // 
            this.checkBoxAutoLogin.AutoSize = true;
            this.checkBoxAutoLogin.Location = new System.Drawing.Point(233, 9);
            this.checkBoxAutoLogin.Name = "checkBoxAutoLogin";
            this.checkBoxAutoLogin.Size = new System.Drawing.Size(75, 21);
            this.checkBoxAutoLogin.TabIndex = 1;
            this.checkBoxAutoLogin.Text = "自动登录";
            this.checkBoxAutoLogin.UseVisualStyleBackColor = true;
            // 
            // checkBoxRememberPwd
            // 
            this.checkBoxRememberPwd.AutoSize = true;
            this.checkBoxRememberPwd.Location = new System.Drawing.Point(81, 9);
            this.checkBoxRememberPwd.Name = "checkBoxRememberPwd";
            this.checkBoxRememberPwd.Size = new System.Drawing.Size(75, 21);
            this.checkBoxRememberPwd.TabIndex = 0;
            this.checkBoxRememberPwd.Text = "记住密码";
            this.checkBoxRememberPwd.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 268);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 268);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(240, 268);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // UpYunLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 301);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpYunLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "操作员登录";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelOperatorPwd;
        private System.Windows.Forms.Label labelOperatorName;
        private System.Windows.Forms.Label labelBucketName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox comboBoxInternet;
        private System.Windows.Forms.TextBox textBoxDomain;
        private System.Windows.Forms.TextBox textBoxOperatorPwd;
        private System.Windows.Forms.TextBox textBoxOperatorName;
        private System.Windows.Forms.TextBox textBoxBucketName;
        private System.Windows.Forms.CheckBox checkBoxAutoLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberPwd;
    }
}