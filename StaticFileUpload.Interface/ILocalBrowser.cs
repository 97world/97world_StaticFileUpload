using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace StaticFileUpload.Interface
{
    public interface ILocalBrowser
    {
        void LoadListView(ListView listView, ImageList imageList, string lcoalPath);

        void LoadListViewByMyPcPath(ListView listView, ImageList imageList, string lcoalPath);

        bool DeleteFolderOrFile(ListView.SelectedListViewItemCollection selectedItems, string parentPath);

        bool NewFolder(string parentPath, string folderName);

        bool NewFile(string parentPath, string fileName);

        bool RenameFolder(string parentPath, string oriName, string newName);

        bool RenameFile(string parentPath, string oriName, string newName);
    }
}
