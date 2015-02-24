using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using StaticFileUpload.Interface;
using StaticFileUpload.Business;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadInput : StaticFileUploadBase
    {
        public StaticFileUploadInput()
        {
            InitializeComponent();
        }

        private ILocalBrowser localBrowserBusi = new LocalBrowserBusi();

        public string inputAddOrRename = "ADD";
        public string inputFileOrFolder = "FILE";
        public string inputOriName = "";
        public string inputCurrPath = "";

        private void StaticFileUploadInput_Load(object sender, EventArgs e)
        {
            if (inputFileOrFolder.Equals("FILE"))
            {
                labelFolderName.Text = "文件名称：";
                if (inputAddOrRename.Equals("ADD"))
                    this.Text = "新建文件";
                else
                    this.Text = "重命名文件";
            }
            else
            {
                labelFolderName.Text = "文件夹名称：";
                if (inputAddOrRename.Equals("ADD"))
                    this.Text = "新建文件夹：";
                else
                    this.Text = "重命名文件夹：";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string inputNewName = textBoxName.Text.Trim();
            bool retVal = false;
            if (inputNewName.Length <= 0) return;
            if (inputFileOrFolder.Equals("FILE"))
            {
                if (inputAddOrRename.Equals("ADD"))
                    retVal = localBrowserBusi.NewFile(inputCurrPath, inputNewName);
                else
                    retVal = localBrowserBusi.RenameFile(inputCurrPath, inputOriName, inputNewName);
            }
            else
            {
                if (inputAddOrRename.Equals("ADD"))
                    retVal = localBrowserBusi.NewFolder(inputCurrPath, inputNewName);
                else
                    retVal = localBrowserBusi.RenameFolder(inputCurrPath, inputOriName, inputNewName);
            }
            if (retVal == true) this.Close();
        }
    }
}
