using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Collections;
using System.IO;
using StaticFileUpload.Interface;
using StaticFileUpload.Model;
using StaticFileUpload.Log;
using StaticFileUpload.Common;
using Library.UpYun;

namespace StaticFileUpload.Business
{
    public class RemoteBrowserUpYunBusi : IRemoteBrowser
    {
        /// <summary>
        /// UpYun SDK 提供的操作对象，如果登录成功此对象将不为空，作为登录是否成功的标志
        /// </summary>
        private static UpYun upYun = null;

        public void CheckLoginInfo(OperatorInfo optorInfo)
        {
            upYun = new UpYun(optorInfo.bucketName, optorInfo.operatorName, optorInfo.operatorPwd);
            upYun.setApiDomain(StrFormatUtil.FormatNetStr(optorInfo.netSelection));
            try
            {
                double useSpace = upYun.getBucketUsage();
                SFUSetting.Save();
                SFULogger.DEFAULT.InfoFormat("操作员[{0}]登录成功.BucketName=[{1}],APINet=[{2}],BucketUsage=[{3}]", optorInfo.operatorName, optorInfo.bucketName, optorInfo.netSelection, useSpace);
            }
            catch (Exception ex)
            {
                upYun = null;
                if (ex.Message.Contains("401"))
                {
                    string exceptionMsg = String.Format("操作员[{0}]登录失败.原因:登录信息填写有误,BucketName=[{1}],APINet=[{2}],ExceptionMsg=[{3}]", optorInfo.operatorName, optorInfo.bucketName, optorInfo.netSelection, ex);
                    LoginException loginException = new LoginException(401, exceptionMsg);
                    SFULogger.DEFAULT.Error(loginException.Message);
                    throw loginException;
                }
                else
                {
                    string exceptionMsg = String.Format("操作员[{0}]登录失败.原因:未知,BucketName=[{1}],APINet=[{2}],ExceptionMsg=[{3}]", optorInfo.operatorName, optorInfo.bucketName, optorInfo.netSelection, ex);
                    LoginException loginException = new LoginException(0, exceptionMsg);
                    SFULogger.DEFAULT.Error(loginException.Message);
                    throw loginException;
                }
            }
        }

        public void Logout()
        {
            upYun = null;
        }

        public void SetNetLine(string netLine)
        {
            upYun.setApiDomain(StrFormatUtil.FormatNetStr(netLine));
        }

        public string GetSpaceUsage()
        {
            return SFUCommon.GetCommonSize(upYun.getBucketUsage());
        }

        public void LoadListView(ListView listView, ImageList imageList, string remotePath)
        {
            if (upYun == null) return;
            Cursor.Current = Cursors.WaitCursor;
            List<FolderItem> itemsArray = new List<FolderItem>();
            try {itemsArray = upYun.readDir(remotePath).Cast<FolderItem>().ToList();}
            catch { } // UpYun SDK BUG: 调用readDir方法时，如果该目录下没有任何文件或目录，会有数组越界的问题
            try
            {
                ListView.ListViewItemCollection listViewItems = listView.Items;
                int imageIndex = 0;
                string programPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                ImageList.ImageCollection imageItems = imageList.Images;
                listViewItems.Clear(); imageItems.Clear();
                if (!remotePath.Equals("/"))
                {
                    string[] itemInfo = new string[4];
                    itemInfo[0] = "上级目录";
                    itemInfo[3] = "ParentDir";
                    ListViewItem parentDirItem = new ListViewItem(itemInfo, 0);
                    listViewItems.Add(parentDirItem);
                    imageItems.Add(StaticFileUpload.Business.Properties.Resources.up_16x16);
                    imageIndex++;
                }
                imageItems.Add(IconUtil.GetDirectoryIcon(programPath));
                imageIndex++;
                foreach (FolderItem item in itemsArray)
                {
                    ListViewItem listViewItem = null;
                    string[] itemInfo = new string[4];
                    itemInfo[0] = item.filename;
                    itemInfo[1] = SFUCommon.GetCommonSize(item.size);
                    itemInfo[2] = SFUCommon.GetCommonTime(item.number).ToString();
                    if (item.filetype.Equals("N"))
                    {
                        itemInfo[3] = "N";
                        listViewItem = new ListViewItem(itemInfo, imageIndex);
                        imageItems.Add(IconUtil.GetFileIcon(item.filename, false));
                        imageIndex++;
                    }
                    else
                    {
                        itemInfo[3] = "F";
                        listViewItem = new ListViewItem(itemInfo, remotePath.Equals("/") ? 0 : 1);
                    }
                    listViewItems.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                SFULogger.DEFAULT.Error(ex);
                throw;
            }
            Cursor.Current = Cursors.Default;
        }

        public bool NewFolder(string remotePath, bool isRecursive)
        {
            return upYun.mkDir(remotePath, isRecursive);
        }

        public void DeleteFileAndDirectory(ArrayList deleteFileNameList, string remotePath)
        {
            foreach(string fileName in deleteFileNameList)
            {
                string fileRemotePath = SFUCommon.CombinePath4Web(remotePath, fileName);
                upYun.deleteFile(fileRemotePath);
            }
        }

        public void DeleteDirectory(string directoryName, string remotePath)
        {

        }

        public void UploadFile(ArrayList uploadFileNameList, string localPath, string remotePath, bool isRecursive)
        {
            foreach(string fileName in uploadFileNameList)
            {
                string fileLocalPath = Path.Combine(localPath, fileName);
                string fileRemotePath = SFUCommon.CombinePath4Web(remotePath, fileName);
                bool isDirectory = Directory.Exists(fileLocalPath);
                if (isDirectory)
                {
                    // TODO: If the item is folder, need to traverse folder recursively(Get all file path in the folder).
                }
                else
                {
                    FileStream fileStream = new FileStream(fileLocalPath, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    byte[] postByte = binaryReader.ReadBytes((int)fileStream.Length);
                    upYun.writeFile(fileRemotePath, postByte, isRecursive);
                }
            }
        }

        public void DownloadFile(ArrayList downloadFileNameList, string localPath, string remotePath)
        {

        }

        
    }
}
