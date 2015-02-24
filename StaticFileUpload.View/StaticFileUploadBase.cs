using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticFileUpload.View
{
    public partial class StaticFileUploadBase : Form
    {
        public StaticFileUploadBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 本地浏览器地址
        /// </summary>
        //public static string localPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string localPath = Environment.SpecialFolder.MyComputer.ToString();

        /// <summary>
        /// 远程浏览器地址
        /// </summary>
        public static string remotePath = @"/";

        /// <summary>
        /// 复制操作的源地址
        /// </summary>
        public static string copyPath = "";
    }
}
