using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticFileUpload.Common
{
    public class StrFormatUtil
    {
        public static string FormatNetStr (string netStr) 
        {
            string retVal = "";
            switch (netStr)
            {
                case "中国电信网络":
                    retVal = "v1.api.upyun.com";
                    break;
                case "中国联通网络":
                    retVal = "v2.api.upyun.com";
                    break;
                case "中国移动网络":
                    retVal = "v3.api.upyun.com";
                    break;
                case "自动选择网络":
                default:
                    retVal = "v0.api.upyun.com";
                    break;
            }
            return retVal;
        }
    }
}
