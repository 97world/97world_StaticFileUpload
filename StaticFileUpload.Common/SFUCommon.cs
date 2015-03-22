using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Security.Cryptography;

namespace StaticFileUpload.Common
{
    public class SFUCommon
    {
        /// <summary>
        /// 字节容量单位转换为易读的容量单位
        /// </summary>
        /// <param name="bytes">字节</param>
        /// <returns></returns>
        public static string GetCommonSize(double bytes)
        {
            int unit = 1024;
            if (bytes < unit) return bytes + " B";
            int exp = (int)(Math.Log(bytes) / Math.Log(unit));
            return String.Format("{0:F1} {1}B", bytes / Math.Pow(unit, exp), "KMGTPE"[exp - 1]);
        }

        /// <summary>
        /// 时间戳转换
        /// </summary>
        /// <param name="num">时间戳</param>
        /// <returns></returns>
        public static DateTime GetCommonTime(double num)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddSeconds(num);
            return time;
        }

        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }

        /// <summary>
        /// 根据传入的Web路径获取父目录的路径（通过路径分隔符'/'）
        /// </summary>
        /// <param name="currentPath">当前路径</param>
        /// <returns>父目录路径</returns>
        public static string GetParentPath4Web(string currentPath)
        {
            string[] pathArray = currentPath.Split('/');
            int pathArrayLength = pathArray.Length - 1; string retPath = "";
            for (int i = 0; i < pathArrayLength; i++)
            {
                retPath = Path.Combine(retPath, pathArray[i]).Replace('\\', '/');
            }
            return '/' + retPath;
        }

        /// <summary>
        /// 为传入的Web当前路径拼接一个目录（通过路径分隔符'/'）
        /// </summary>
        /// <param name="currentPath">当前路径</param>
        /// <param name="folder">目录名称</param>
        /// <returns>拼接后的路径</returns>
        public static string CombinePath4Web(string currentPath, string folder)
        {
            if (currentPath.LastIndexOf('/') == (currentPath.Length - 1))
            {
                return currentPath + folder.Replace("/", "");
            }
            else
            {
                return currentPath + '/' + folder.Replace("/", "");
            }
        }
    }
}
