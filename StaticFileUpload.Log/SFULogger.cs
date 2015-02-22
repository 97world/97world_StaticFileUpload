using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFileUpload.Log
{
    public static class SFULogger 
    {
        public static ISFULog DEFAULT = new SFULog("DEFAULT_LOG");

        public static void InitByConfigFileParrentPath(string configFileParrentPath)
        {
            DEFAULT = new SFULog(configFileParrentPath,"DEFAULT_LOG");
        }
    }
}
