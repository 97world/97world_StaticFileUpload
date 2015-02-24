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
        public void LoadListView(ListView.ListViewItemCollection listViewItems, ImageList.ImageCollection imageListItems, string localPath)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] filesArray, dirsArray; int imageIndex = 0;
            try
            {
                dirsArray = Directory.GetDirectories(localPath);
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
            listViewItems.Add("上级目录");

            // 遍历 localPath 目录下的子文件夹
            for (int i = 0; i < dirsArray.Length; i++)
            {
                string[] dirInfoArray = new string[3];
                DirectoryInfo directoryInfo = new DirectoryInfo(dirsArray[i]);
                if (true)
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
                if (true)
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

        public void LoadListView()
        {

        }
    }
}
