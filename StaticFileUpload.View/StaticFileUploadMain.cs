using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using StaticFileUpload.Interface;
using StaticFileUpload.Business;
using StaticFileUpload.Common;
using StaticFileUpload.Log;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadMain : StaticFileUploadBase
    {
        private ILocalBrowser localBrowserBusi = new LocalBrowserBusi();
        private IRemoteBrowser remoteBrowserBusi = new RemoteBrowserUpYunBusi();

        public StaticFileUploadMain()
        {
            InitializeComponent();
            InitMain();
        }

        private void InitMain()
        {
            // 绑定 LocalListView & RemoteListView 控件的ContextMenu
            listView4Local.ContextMenu = contextMenu4Local;
            listView4Remote.ContextMenu = contextMenu4Remote;
            // 添加 ListView 的数据
            LoadListViewByLocalPath();
            LocalListViewByRemotePath();
        }

        public void LoadListViewByLocalPath()
        {
            if (localPath.Length == 2) localPath = localPath + "\\";
            if (!comboBoxPath4Local.Items.Contains(localPath)) comboBoxPath4Local.Items.Add(localPath);
            if (localPath.Equals(Environment.SpecialFolder.MyComputer.ToString()))
            {
                columnHeader2.Text = "大小总计"; columnHeader3.Text = "可用数总计";
                localBrowserBusi.LoadListViewByMyPcPath(listView4Local, imageListLocalListViewIcon, localPath);
            }
            else
            {
                columnHeader2.Text = "大小"; columnHeader3.Text = "修改时间";
                localBrowserBusi.LoadListView(listView4Local, imageListLocalListViewIcon, localPath);
            }
            comboBoxPath4Local.Text = localPath;
        }

        public void LocalListViewByRemotePath()
        {

        }

        private void listView4Local_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView4Local.SelectedItems[0];
            if (selectedItem.SubItems.Count == 4)
            {
                localPath = selectedItem.SubItems[3].Text;
            }
            else
            {
                if (selectedItem.Text.Equals("上级目录"))
                {
                    if (localPath.Length == 3) localPath = Environment.SpecialFolder.MyComputer.ToString();
                    else localPath = new DirectoryInfo(localPath).Parent.FullName;
                }
                else if (selectedItem.SubItems[1].Text.Trim().Length == 0)
                {
                    localPath = Path.Combine(localPath, selectedItem.Text);
                }
                else
                {
                    string tempPath = Path.Combine(localPath, selectedItem.Text);
                    if (selectedItem.Text.LastIndexOf(".lnk") >= 0)
                        System.Diagnostics.Process.Start(ShortCutsUtil.GetTarget(tempPath));
                    else
                        System.Diagnostics.Process.Start(tempPath);
                    return;
                }
            }
            LoadListViewByLocalPath();
        }

        private void toolStripBtnComputer_Click(object sender, EventArgs e)
        {
            localPath = Environment.SpecialFolder.MyComputer.ToString();
            LoadListViewByLocalPath();
        }

        private void toolStripBtnMyDocument_Click(object sender, EventArgs e)
        {
            localPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            LoadListViewByLocalPath();
        }

        private void toolStripBtnDesktop_Click(object sender, EventArgs e)
        {
            localPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            LoadListViewByLocalPath();
        }

        private void toolStripBtnTrans4Local_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnNewFolder4Local_Click(object sender, EventArgs e)
        {
            StaticFileUploadInput staticFileUploadInput = new StaticFileUploadInput();
            staticFileUploadInput.inputAddOrRename = "ADD";
            staticFileUploadInput.inputFileOrFolder = "FOLDER";
            staticFileUploadInput.inputCurrPath = localPath;
            staticFileUploadInput.Owner = this;
            staticFileUploadInput.ShowDialog();
            LoadListViewByLocalPath();
        }

        private void toolStripNewFile_Click(object sender, EventArgs e)
        {
            StaticFileUploadInput staticFileUploadInput = new StaticFileUploadInput();
            staticFileUploadInput.inputAddOrRename = "ADD";
            staticFileUploadInput.inputFileOrFolder = "FILE";
            staticFileUploadInput.inputCurrPath = localPath;
            staticFileUploadInput.Owner = this;
            staticFileUploadInput.ShowDialog();
            LoadListViewByLocalPath();
        }

        private void toolStripBtnRefresh4Local_Click(object sender, EventArgs e)
        {
            LoadListViewByLocalPath();
        }

        private void toolStripBtnDel4Local_Click(object sender, EventArgs e)
        {
            localBrowserBusi.DeleteFolderOrFile(listView4Local.SelectedItems, localPath);
            LoadListViewByLocalPath();
        }

        private void btnParentDirectory4Local_Click(object sender, EventArgs e)
        {
            if (localPath.Equals(Environment.SpecialFolder.MyComputer.ToString())) return;
            if (localPath.Length == 3) localPath = Environment.SpecialFolder.MyComputer.ToString();
            else localPath = new DirectoryInfo(localPath).Parent.FullName;
            LoadListViewByLocalPath();
        }

        private void comboBoxPath4Local_SelectedIndexChanged(object sender, EventArgs e)
        {
            localPath = comboBoxPath4Local.Text.Trim();
            LoadListViewByLocalPath();
        }

        private void comboBoxPath4Local_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                localPath = comboBoxPath4Local.Text.Trim();
                LoadListViewByLocalPath();
            }
        }

    }
}
