using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StaticFileUpload.Common;
using StaticFileUpload.Model;
using StaticFileUpload.Interface;
using StaticFileUpload.Business;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadLogin : StaticFileUploadBase
    {
        private SFUConfigInfo tempSFUConfigInfo;
        private IRemoteBrowser remoteBrowserBusi = new RemoteBrowserUpYunBusi();

        public StaticFileUploadLogin()
        {
            InitializeComponent();

            InitStaticFileUploadLogin();
        }

        private void InitStaticFileUploadLogin()
        {
            tempSFUConfigInfo = SFUSetting.GetInstance();
            if (tempSFUConfigInfo.loginInfo.rememberPwd == true)
            {
                textBoxBucketName.Text = tempSFUConfigInfo.operatorInfo.bucketName;
                textBoxOperatorName.Text = tempSFUConfigInfo.operatorInfo.operatorName;
                textBoxOperatorPwd.Text = tempSFUConfigInfo.operatorInfo.operatorPwd;
                textBoxDomain.Text = tempSFUConfigInfo.operatorInfo.bindDomain;
                comboBoxInternet.Text = tempSFUConfigInfo.operatorInfo.netSelection;
                checkBoxAutoLogin.Checked = tempSFUConfigInfo.loginInfo.autoLogin;
                checkBoxRememberPwd.Checked = tempSFUConfigInfo.loginInfo.rememberPwd;
            }
            else
            {
                // 设置默认网络选择为“自动选择网络”
                comboBoxInternet.SelectedIndex = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxBucketName.Text = "";
            textBoxOperatorName.Text = "";
            textBoxOperatorPwd.Text = "";
            textBoxDomain.Text = "";
            comboBoxInternet.SelectedIndex = 0;

            checkBoxRememberPwd.Checked = checkBoxAutoLogin.Checked = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tempSFUConfigInfo.operatorInfo.bucketName = textBoxBucketName.Text.Trim();
            tempSFUConfigInfo.operatorInfo.operatorName = textBoxOperatorName.Text.Trim();
            tempSFUConfigInfo.operatorInfo.operatorPwd = textBoxOperatorPwd.Text.Trim();
            tempSFUConfigInfo.operatorInfo.bindDomain = textBoxDomain.Text.Trim();
            tempSFUConfigInfo.operatorInfo.netSelection = comboBoxInternet.Text.Trim();
            tempSFUConfigInfo.loginInfo.autoLogin = checkBoxAutoLogin.Checked;
            tempSFUConfigInfo.loginInfo.rememberPwd = checkBoxRememberPwd.Checked;
            try
            {
                remoteBrowserBusi.CheckLoginInfo(tempSFUConfigInfo.operatorInfo);
            }
            catch (LoginException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            sfuConfigInfo = tempSFUConfigInfo;
            StaticFileUploadMain staticFileUploadMain = (StaticFileUploadMain)this.Owner;
            staticFileUploadMain.InitStaticFileUploadMain();
            this.Close();
        }
    }
}
