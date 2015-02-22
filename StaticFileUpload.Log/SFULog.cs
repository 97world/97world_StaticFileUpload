using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;
using log4net;

namespace StaticFileUpload.Log
{
    public class SFULog : ISFULog
    {
        private ILog log = null;
        private string logConfigFilePath = "";

        //public ILog getIns() 
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    FileInfo dllFile = new FileInfo(myAssembly.Location);
        //    string path = dllFile.Directory.FullName;
        //    string testStr = Path.Combine(path, "log.config");
        //    string testStr2 = AppDomain.CurrentDomain.BaseDirectory;
        //    log4Net = LogManager.GetLogger("testApp.Logging");
        //    return log4Net;
        //}

        public SFULog(string loogerName)
        {
            if (AppDomain.CurrentDomain.SetupInformation.PrivateBinPath != null)
                logConfigFilePath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.PrivateBinPath, "log.config");
            else
                logConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.config");
            if (!File.Exists(logConfigFilePath))
            {
                throw new NotSupportedException(string.Format("No existing config file. ConfigFilePath=[{0}]", logConfigFilePath));
            }
            log4net.Config.XmlConfigurator.Configure(new FileInfo(logConfigFilePath));
            log = GetLogger(loogerName);
        }
        public SFULog(string configFileParrentPath, string loggerName)
        {
            logConfigFilePath = Path.Combine(configFileParrentPath, "Log.config");
            if (!File.Exists(configFileParrentPath))
                throw new NotSupportedException(string.Format("No existing config file. ConfigFilePath=[{0}]", logConfigFilePath));
            log4net.Config.XmlConfigurator.Configure(new FileInfo(logConfigFilePath));
            log = GetLogger(loggerName);
        }

        private ILog GetLogger(string loggerName)
        {
            ILog log = LogManager.Exists(loggerName);
            if (log == null)
                throw new NotSupportedException(string.Format("No existing loggerName. LoggerName=[{0}],ConfigFilePath=[{1}].", loggerName, logConfigFilePath));
            else return log;

        }

        public void Debug(object msg)
        {
            log.Debug(msg);
        }
        public void Debug(object msg, Exception ex)
        {
            log.Debug(msg, ex);
        }
        public void DebugFormat(object msg, params object[] args)
        {
            log.DebugFormat(msg.ToString(), args);
        }

        public void Info(object msg)
        {
            log.Info(msg);
        }
        public void Info(object msg, Exception ex)
        {
            log.Info(msg, ex);
        }
        public void InfoFormat(object msg, params object[] args)
        {
            log.InfoFormat(msg.ToString(), args);
        }

        public void Warn(object msg)
        {
            log.Warn(msg);
        }
        public void Warn(object msg, Exception ex)
        {
            log.Warn(msg, ex);
        }
        public void WarnFormat(object msg, params object[] args)
        {
            log.WarnFormat(msg.ToString(), args);
        }

        public void Error(object msg)
        {
            log.Error(msg);
        }
        public void Error(object msg, Exception ex)
        {
            log.Error(msg, ex);
        }
        public void ErrorFormat(object msg, params object[] args)
        {
            log.ErrorFormat(msg.ToString(), args);
        }

        public void Fatal(object msg)
        {
            log.Fatal(msg);
        }
        public void Fatal(object msg, Exception ex)
        {
            log.Fatal(msg, ex);
        }
        public void FatalFormat(object msg, params object[] args)
        {
            log.FatalFormat(msg.ToString(), args);
        }
    }
}
