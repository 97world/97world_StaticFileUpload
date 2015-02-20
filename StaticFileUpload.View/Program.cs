using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaticFileUpload.Log;

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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StaticFileUploadAbout());
            SFULog sfuLog = new SFULog();
            log4net.ILog testLog = sfuLog.GetLogIns();
            testLog.Debug("test11111111");
        }
    }
}
