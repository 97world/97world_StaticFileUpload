using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
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
    }
}
