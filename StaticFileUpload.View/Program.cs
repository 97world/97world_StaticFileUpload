using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text;
using System.IO;
using StaticFileUpload.Common;
using System.Xml.Serialization;

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
            TestClass testClass = new TestClass();
            testClass.testA = 123;
            testClass.testB = 123;
            string path = "D:\\GitHub\\97world_UpYun\\StaticFileUpload.View\\bin\\Debug";
            //string testSTr = XmlUtil.Serializer(typeof(TestClass), testClass);
            //XmlUtil.SaveToXml(path,testClass,typeof(TestClass)," ");
            string testStr = XmlHelper.Serialize(testClass);
            string test = "";
        }

        [Serializable] 
        public class TestClass
        {
            [XmlElement("testA")]
            public int testA { get; set; }
            [XmlElement("testB")]
            public int testB { get; set; }
        }

    }
}
