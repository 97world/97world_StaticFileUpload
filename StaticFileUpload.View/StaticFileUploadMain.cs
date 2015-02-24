using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StaticFileUpload.Interface;
using StaticFileUpload.Business;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadMain : StaticFileUploadBase
    {
        private ILocalBrowser localBrowserBusi = new LocalBrowserBusi();

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
            localBrowserBusi.LoadListView(listView4Local.Items, imageListLocalListViewIcon.Images, localPath);
        }

        public void LocalListViewByRemotePath()
        {

        }

    }
}
