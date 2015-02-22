using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text;
using System.IO;
using StaticFileUpload.Common;
using System.Xml.Serialization;
using StaticFileUpload.Model;

namespace StaticFileUpload.View
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StaticFileUploadAbout());

            //OperatorInfo operatorInfo = SFUSetting.GetInstance().operatorInfo;
            //LoginInfo loginInfo = SFUSetting.GetInstance().loginInfo;
            //string testStr = "";
            //operatorInfo.netSelection = "中国电信网络";
            //SFUSetting.Save();
            //string testStr2 = "";
        }

    }
}

