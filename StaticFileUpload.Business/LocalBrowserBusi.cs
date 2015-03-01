using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using StaticFileUpload.Interface;
using StaticFileUpload.Log;
using StaticFileUpload.Common;

namespace StaticFileUpload.Business
{
    public class LocalBrowserBusi : ILocalBrowser
    {
        public void LoadListView(ListView listView, ImageList imageList, string localPath)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] filesArray, diresArray; int imageIndex = 1;
            ListView.ListViewItemCollection listViewItems = listView.Items;
            ImageList.ImageCollection imageListItems = imageList.Images;
            try
            {
                diresArray = Directory.GetDirectories(localPath);
                filesArray = Directory.GetFiles(localPath);
            }
            catch (Exception ex)
            {
                SFULogger.DEFAULT.Error("该目录不存在！", ex);
                MessageBox.Show("该目录不存在！");
                return;
            }
            // 清空 ListView & ImageList 控件条目集合
            listViewItems.Clear(); imageListItems.Clear();
            listViewItems.Add("上级目录", 0);
            imageListItems.Add(StaticFileUpload.Business.Properties.Resources.up_16x16);

            // 遍历 localPath 目录下的子文件夹
            for (int i = 0; i < diresArray.Length; i++)
            {
                string[] dirInfoArray = new string[3];
                DirectoryInfo directoryInfo = new DirectoryInfo(diresArray[i]);
                if ((directoryInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    dirInfoArray[0] = directoryInfo.Name;
                    dirInfoArray[1] = "      ";
                    dirInfoArray[2] = directoryInfo.LastWriteTime.ToString();
                    ListViewItem listViewItem = new ListViewItem(dirInfoArray, imageIndex);
                    listViewItems.Add(listViewItem);
                    imageListItems.Add(dirInfoArray[0], IconUtil.GetDirectoryIcon(directoryInfo.FullName));
                    imageIndex++;
                }
            }
            // 遍历 localPath 目录下的子文件
            for (int i = 0; i < filesArray.Length; i++)
            {
                string[] fileInfoArray = new string[3];
                FileInfo fileInfo = new FileInfo(filesArray[i]);
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    fileInfoArray[0] = fileInfo.Name;
                    fileInfoArray[1] = SFUCommon.GetCommonSize(fileInfo.Length);
                    fileInfoArray[2] = fileInfo.LastWriteTime.ToString();
                    ListViewItem listViewItem = new ListViewItem(fileInfoArray, imageIndex);
                    listViewItems.Add(listViewItem);
                    imageListItems.Add(fileInfo.Name, IconUtil.GetFileIcon(fileInfo.FullName, false));
                    imageIndex++;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        public void LoadListViewByMyPcPath(ListView listView, ImageList imageList, string myPcPath)
        {
            Cursor.Current = Cursors.WaitCursor;
            ListView.ListViewItemCollection listViewItems = listView.Items;
            ImageList.ImageCollection imageListItems = imageList.Images;
            listViewItems.Clear(); imageListItems.Clear();
            string[] dirsArray; int imageIndex = 0;
            try
            {
                dirsArray = Directory.GetLogicalDrives();
                for (int i = 0; i < dirsArray.Length; i++)
                {
                    DriveInfo driInfo = new DriveInfo(dirsArray[i]);
                    string[] driInfoArray = new string[4];
                    driInfoArray[0] = string.Format("{0}({1})", driInfo.VolumeLabel, driInfo.Name);
                    driInfoArray[1] = SFUCommon.GetCommonSize(driInfo.TotalSize);
                    driInfoArray[2] = SFUCommon.GetCommonSize(driInfo.TotalFreeSpace);
                    driInfoArray[3] = driInfo.Name;
                    ListViewItem listViewItem = new ListViewItem(driInfoArray, imageIndex);
                    listViewItems.Add(listViewItem);
                    imageListItems.Add(IconUtil.GetDirectoryIcon(driInfo.Name));
                    imageIndex++;
                }
            }
            catch (Exception)
            {
                //如果不使用try catch抓取错误并以此跳过错误，在添加没有放入光盘的光驱Items时会提示错误
            }
            Cursor.Current = Cursors.Default;
        }

        public bool DeleteFolderOrFile(ListView.SelectedListViewItemCollection selectedItems, string parentPath)
        {
            StringBuilder pathSb = new StringBuilder();
            foreach (ListViewItem item in selectedItems)
            {
                pathSb.Append(Path.Combine(parentPath, item.Text) + "\0");
            }
            int retVal = SysFileOrDirActionUtil.DeleteFileOrDirectory(pathSb);
            if (retVal >= 0)
            {
                SFULogger.DEFAULT.InfoFormat("删除文件/文件夹成功.pathSb=[{0}]", pathSb.ToString().Replace("\0", ";"));
                return true;
            }
            else
            {
                SFULogger.DEFAULT.InfoFormat("删除文件/文件夹失败.retVal=[{0}],pathSb=[{1}]", retVal, pathSb.ToString().Replace("\0", ";"));
                return false;
            }
        }

        public bool NewFolder(string parentPath, string folderName)
        {
            string path = Path.Combine(parentPath, folderName);
            if (Directory.Exists(path))
            {
                MessageBox.Show("存在相同名称的文件夹！");
                SFULogger.DEFAULT.InfoFormat("存在相同名称的文件夹,parentPath=[{0}],folderName=[{1}]", parentPath, folderName);
                return false;
            }
            else
            {
                Directory.CreateDirectory(path);
                SFULogger.DEFAULT.InfoFormat("创建文件夹[{0}]成功.", path);
                return true;
            }
        }

        public bool NewFile(string parentPath, string fileName)
        {
            string path = Path.Combine(parentPath, fileName);
            if (File.Exists(path))
            {
                MessageBox.Show("该目录下存在相同名称的文件！");
                SFULogger.DEFAULT.InfoFormat("该目录下存在相同名称的文件！parentPath=[{0}],fileName=[{1}]", parentPath, fileName);
                return false;
            }
            else
            {
                using (File.CreateText(path)) { };
                SFULogger.DEFAULT.InfoFormat("新建文件[{0}]成功.", path);
                return true;
            }
        }

        public bool RenameFolder(string parentPath, string oriName, string newName)
        {
            string oriPath = Path.Combine(parentPath, oriName);
            string newPath = Path.Combine(parentPath, newName);
            if (Directory.Exists(newPath))
            {
                MessageBox.Show("存在相同名称的文件夹");
                SFULogger.DEFAULT.InfoFormat("存在相同名称的文件夹,oriPath=[{0}],newPath=[{1}]", oriPath, newPath);
                return false;
            }
            else
            {
                Directory.Move(oriPath, newPath);
                SFULogger.DEFAULT.InfoFormat("文件夹重命名成功.oriPath=[{0}],newPath=[{1}]", oriPath, newPath);
                return true;
            }
        }

        public bool RenameFile(string parentPath, string oriName, string newName)
        {
            string oriPath = Path.Combine(parentPath, oriName);
            string newPath = Path.Combine(parentPath, newName);
            if (File.Exists(newPath))
            {
                MessageBox.Show("存在相同名称的文件");
                SFULogger.DEFAULT.InfoFormat("存在相同名称的文件,oriPath=[{0}],newPath=[{1}]", oriPath, newPath);
                return false;
            }
            else
            {
                File.Move(oriPath, newPath);
                SFULogger.DEFAULT.InfoFormat("文件重命名成功.oriPath=[{0}],newPath=[{1}]", oriPath, newPath);
                return true;
            }
        }
    }
}
