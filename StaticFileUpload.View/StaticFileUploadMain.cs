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
using System.Collections;
using StaticFileUpload.Interface;
using StaticFileUpload.Business;
using StaticFileUpload.Common;
using StaticFileUpload.Log;
using StaticFileUpload.Model;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadMain : StaticFileUploadBase
    {
        private ILocalBrowser localBrowserBusi = new LocalBrowserBusi();
        private IRemoteBrowser remoteBrowserBusi = new RemoteBrowserUpYunBusi();

        private Point tempPoint = new Point(0, 0);

        public StaticFileUploadMain()
        {
            InitializeComponent();
            InitStaticFileUploadMain();
        }

        public void InitStaticFileUploadMain()
        {
            // 默认设置网络选择为“自动选择”
            menuItemNetAuto.Checked = true;
            // 设置右键菜单状态
            menuItemTrans4Local.Enabled = false;
            menuItemPaste4Local.Enabled = false;
            // 设置操作员信息
            if (sfuConfigInfo != null)
            {
                try
                {
                    remoteBrowserBusi.CheckLoginInfo(sfuConfigInfo.operatorInfo);
                }
                catch (LoginException ex)
                {
                    MessageBox.Show(ex.Message);
                    sfuConfigInfo = null;
                    return;
                }
                statusLabelOperatorName.Text = sfuConfigInfo.operatorInfo.operatorName;
                statusLabelUseSpaceValue.Text = remoteBrowserBusi.GetSpaceUsage();
                toolStripStatusLabelStatus.Text = "登录成功！";
                menuItemTrans4Local.Enabled = true;
            }
            else
            {
                SFUConfigInfo tempSFUConfigInfo = SFUSetting.GetInstance();
                if (tempSFUConfigInfo.loginInfo.autoLogin == true)
                {
                    sfuConfigInfo = tempSFUConfigInfo;
                    try
                    {
                        remoteBrowserBusi.CheckLoginInfo(sfuConfigInfo.operatorInfo);
                    }
                    catch (LoginException ex)
                    {
                        MessageBox.Show(ex.Message);
                        sfuConfigInfo = null;
                        return;
                    }
                    statusLabelOperatorName.Text = sfuConfigInfo.operatorInfo.operatorName;
                    statusLabelUseSpaceValue.Text = remoteBrowserBusi.GetSpaceUsage();
                    toolStripStatusLabelStatus.Text = "登录成功！";
                    menuItemTrans4Local.Enabled = true;
                }
            }
            // 添加 ListView 的数据
            LoadListViewByLocalPath();
            LoadListViewByRemotePath();
        }

        #region LocalBrowser
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

        private void listView4Local_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView4Local.SelectedItems[listView4Local.SelectedItems.Count - 1];
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
            bool retValue = localBrowserBusi.DeleteFolderOrFile(listView4Local.SelectedItems, localPath);
            if (retValue) LoadListViewByLocalPath();
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

        private void menuItemOpen4Local_Click(object sender, EventArgs e)
        {
            listView4Local_DoubleClick(sender, new EventArgs());
        }

        private void menuItemRefresh4Local_Click(object sender, EventArgs e)
        {
            LoadListViewByLocalPath();
        }

        private void menuItemNewFolder4Local_Click(object sender, EventArgs e)
        {
            toolStripBtnNewFolder4Local_Click(sender, new EventArgs());
        }

        private void menuItemNewFile4Local_Click(object sender, EventArgs e)
        {
            toolStripNewFile_Click(sender, new EventArgs());
        }

        private void menuItemDel4Local_Click(object sender, EventArgs e)
        {
            toolStripBtnDel4Local_Click(sender, new EventArgs());
        }

        private void menuItemSysMenu4Local_Click(object sender, EventArgs e)
        {
            ShellContextMenu scmu = new ShellContextMenu();
            Point listViewPoint = listView4Local.PointToClient(tempPoint);
            FileInfo[] fileInfoArr = new FileInfo[1];
            string filePath = "";
            if (localPath.Equals(Environment.SpecialFolder.MyComputer.ToString()))
            {
                filePath = Path.GetFullPath(listView4Local.GetItemAt(listViewPoint.X, listViewPoint.Y).SubItems[3].Text);
                // BUG: Can't get System menu from disk root directory.
            }
            else
            {
                filePath = Path.Combine(localPath, listView4Local.GetItemAt(listViewPoint.X, listViewPoint.Y).Text);
            }
            fileInfoArr[0] = new FileInfo(filePath);
            scmu.ShowContextMenu(fileInfoArr, tempPoint);
        }

        private void menuItemLogin_Click(object sender, EventArgs e)
        {
            StaticFileUploadLogin staticFileUploadLogin = new StaticFileUploadLogin();
            staticFileUploadLogin.Owner = this;
            staticFileUploadLogin.ShowDialog();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemCopy4Local_Click(object sender, EventArgs e)
        {
            int selectedCount = listView4Local.SelectedItems.Count;
            for (int i = 0; i < selectedCount; i++)
            {
                string itemName = listView4Local.SelectedItems[i].Text;
                if (itemName.Equals("上级目录")) continue;
                localCopySourcePath.Append(Path.Combine(localPath, itemName) + "\0");
            }
            menuItemPaste4Local.Enabled = true;
        }

        private void menuItemPaste4Local_Click(object sender, EventArgs e)
        {
            bool retVal = localBrowserBusi.CopyFileOrFolder(localCopySourcePath, localPath);
            if (retVal) LoadListViewByLocalPath();
        }

        private void SingleCheck4MenuItem(object sender)
        {
            menuItemNetAuto.Checked = false;
            menuItemNetTel.Checked = false;
            menuItemNetMob.Checked = false;
            menuItemNetUni.Checked = false;
            ((MenuItem)sender).Checked = true;
        }

        private void menuItemNetAuto_Click(object sender, EventArgs e)
        {
            SingleCheck4MenuItem(sender);
        }

        private void menuItemNetTel_Click(object sender, EventArgs e)
        {
            SingleCheck4MenuItem(sender);
        }

        private void menuItemNetUni_Click(object sender, EventArgs e)
        {
            SingleCheck4MenuItem(sender);
        }

        private void menuItemNetMob_Click(object sender, EventArgs e)
        {
            SingleCheck4MenuItem(sender);
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            StaticFileUploadAbout staticFileUpload = new StaticFileUploadAbout();
            staticFileUpload.Owner = this;
            staticFileUpload.ShowDialog();
        }

        private void menuItemOfficialSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.upyun.com");
        }

        private void menuItemAuthorSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.97world.com");
        }

        private void menuItemGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/97world/97world_StaticFileUpload");
        }
        #endregion

        #region Remote
        public void LoadListViewByRemotePath()
        {
            if (!comboBoxPath4Remote.Items.Contains(remotePath)) comboBoxPath4Remote.Items.Add(remotePath);
            remoteBrowserBusi.LoadListView(listView4Remote, imageListRemoteListViewIcon, remotePath);
            comboBoxPath4Remote.Text = remotePath;
        }

        #endregion

        private void listView4Remote_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView4Remote.SelectedItems[listView4Remote.SelectedItems.Count - 1];
            if (selectedItem.Text.Equals("上级目录"))
            {
                remotePath = SFUCommon.GetParentPath4Web(remotePath);
            }
            else
            {
                remotePath = SFUCommon.CombinePath4Web(remotePath, selectedItem.Text);
            }
            LoadListViewByRemotePath();
        }

        private void menuItemProperty4Local_Click(object sender, EventArgs e)
        {
            Point listViewPoint = listView4Local.PointToClient(tempPoint);
            ListViewItem listViewItem = listView4Local.GetItemAt(listViewPoint.X, listViewPoint.Y);
            string path = Path.Combine(localPath, listViewItem.Text);
            SysFileOrDirActionUtil.PropertyFileOrDirectory(path);
        }

        private void listView4Local_MouseUp(object sender, MouseEventArgs e)
        {
            tempPoint.X = Cursor.Position.X;
            tempPoint.Y = Cursor.Position.Y;
            if (e.Button == MouseButtons.Right)
            {
                Point listView4LocalPoint = listView4Local.PointToClient(tempPoint);
                ListViewItem selectedItem = listView4Local.GetItemAt(listView4LocalPoint.X, listView4LocalPoint.Y);
                if (selectedItem == null) return;
                if (selectedItem.Text != "上级目录" && selectedItem.SubItems.Count == 3)
                {
                    contextMenu4Local.Show(listView4Local, listView4LocalPoint);
                }
            }
        }

        private void menuItemRename4Local_Click(object sender, EventArgs e)
        {
            Point listView4LocalPoint = listView4Local.PointToClient(tempPoint);
            ListViewItem selectedItem = listView4Local.GetItemAt(listView4LocalPoint.X, listView4LocalPoint.Y);
            string selectedItemText = selectedItem.Text;
            bool isFolder = Directory.Exists(Path.Combine(localPath, selectedItemText));

            StaticFileUploadInput staticFileUploadInput = new StaticFileUploadInput();
            staticFileUploadInput.inputAddOrRename = "RENAME";
            staticFileUploadInput.inputFileOrFolder = isFolder ? "FOLDER" : "FILE";
            staticFileUploadInput.inputOriName = selectedItemText;
            staticFileUploadInput.inputCurrPath = localPath;
            staticFileUploadInput.Owner = this;
            staticFileUploadInput.ShowDialog();
            LoadListViewByLocalPath();
        }

        private void menuItemLogout_Click(object sender, EventArgs e)
        {
            sfuConfigInfo = null;
            remoteBrowserBusi.Logout();
            listView4Remote.Items.Clear();
            menuItemTrans4Local.Enabled = false;
            statusLabelUseSpaceValue.Text = "未登录";
            statusLabelOperatorName.Text = "未登录";
            toolStripStatusLabelStatus.Text = "操作员注销成功！";
        }

        private void listView4Remote_MouseUp(object sender, MouseEventArgs e)
        {
            tempPoint.X = Cursor.Position.X;
            tempPoint.Y = Cursor.Position.Y;
            if (e.Button == MouseButtons.Right)
            {
                Point listView4RemotePoint = listView4Remote.PointToClient(tempPoint);
                ListViewItem selectedItem = listView4Remote.GetItemAt(listView4RemotePoint.X, listView4RemotePoint.Y);
                if (selectedItem == null) return;
                if (selectedItem.Text != "上级目录" && selectedItem.SubItems.Count == 3 && sfuConfigInfo != null)
                {
                    contextMenu4Remote.Show(listView4Remote, listView4RemotePoint);
                }
            }
        }

        private void menuItemTrans4Remote_Click(object sender, EventArgs e)
        {
            
        }

        private void menuItemTrans4Local_Click(object sender, EventArgs e)
        {
            ArrayList uploadFileNameList = new ArrayList();
            ListView.SelectedListViewItemCollection selectedItems = listView4Local.SelectedItems;
            foreach(ListViewItem item in selectedItems)
            {
                if (item.Text.Equals("上级目录")) continue;
                uploadFileNameList.Add(item.Text);
            }
            remoteBrowserBusi.UploadFile(uploadFileNameList, localPath, remotePath, true);
            LoadListViewByRemotePath();
        }

        private void menuItemDel4Remote_Click(object sender, EventArgs e)
        {
            ArrayList deleteFileNameList = new ArrayList();
            ListView.SelectedListViewItemCollection selectedItems = listView4Remote.SelectedItems;
            foreach (ListViewItem item in selectedItems)
            {
                if (item.Text.Equals("上级目录")) continue;
                deleteFileNameList.Add(item.Text);
            }
            remoteBrowserBusi.DeleteFileAndDirectory(deleteFileNameList, remotePath);
            LoadListViewByRemotePath();
        }

    }
}
