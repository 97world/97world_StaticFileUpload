using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFileUpload.Log
{
    public interface ISFULog
    {
        void Debug(object msg);
        void Debug(object msg, Exception ex);
        void DebugFormat(object msg, params object[] args);
        void Info(object msg);
        void Info(object msg, Exception ex);
        void InfoFormat(object msg, params object[] args);
        void Warn(object msg);
        void Warn(object msg, Exception ex);
        void WarnFormat(object msg, params object[] args);
        void Error(object msg);
        void Error(object msg, Exception ex);
        void ErrorFormat(object msg, params object[] args);
        void Fatal(object msg);
        void Fatal(object msg, Exception ex);
        void FatalFormat(object msg, params object[] args);
    }
}
