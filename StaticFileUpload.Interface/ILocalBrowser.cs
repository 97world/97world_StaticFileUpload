using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace StaticFileUpload.Interface
{
    public interface ILocalBrowser
    {
        void LoadListView(ListView.ListViewItemCollection listViewItems, ImageList.ImageCollection imageListItems, string lcoalPath);
    }
}
