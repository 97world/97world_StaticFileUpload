using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using StaticFileUpload.Model;
using StaticFileUpload.Log;

namespace StaticFileUpload.Common
{
    public class SFUSetting
    {
        private static string configFilePath = "";
        private static SFUConfigInfo sfuConfigInfo;
        private static object _lock = new object();

        public static SFUConfigInfo GetInstance()
        {
            if (sfuConfigInfo == null)
            {
                lock (_lock)
                {
                    if (sfuConfigInfo == null) Load();
                }
            }
            return sfuConfigInfo;
        }

        public static void Load()
        {
            configFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SFUSetting.config");
            if (!File.Exists(configFilePath))
            {
                string msg = string.Format("Configuration file does not exist. configFilePath=[{0}]", configFilePath);
                SFULogger.DEFAULT.Error(msg);
                throw new Exception(msg);
            }
            sfuConfigInfo = XmlUtil.XmlDeserializeFromFile<SFUConfigInfo>(configFilePath, Encoding.UTF8);
        }

        public static void Save()
        {
            lock (_lock)
            {
                XmlUtil.XmlSerializeToFile(sfuConfigInfo, configFilePath, Encoding.UTF8);
            }
        }
    }
}
