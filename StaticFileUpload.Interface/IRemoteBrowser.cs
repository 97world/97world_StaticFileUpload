using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Collections;
using StaticFileUpload.Model;

namespace StaticFileUpload.Interface
{
    public interface IRemoteBrowser
    {
        void CheckLoginInfo(OperatorInfo operatorInfo);

        void Logout();

        string GetSpaceUsage();

        void SetNetLine(string netLine);

        void LoadListView(ListView listView, ImageList imageList, string remotePath);

        bool NewFolder(string remotePath, bool isRecursive);

        void DeleteFileAndDirectory(ArrayList deleteFileNameList, string remotePath);

        void DeleteDirectory(string directoryName, string remotePath);

        void UploadFile(ArrayList uploadFileNameList, string localPath, string remotePath, bool isRecursive);

        void DownloadFile(ArrayList downloadFileNameList, string localPath, string remotePath);
    }
}
