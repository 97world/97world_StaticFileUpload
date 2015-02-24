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
        public static string localPath = @"C:";

        /// <summary>
        /// 远程浏览器地址
        /// </summary>
        public static string remotePath = @"/";

    }
}
