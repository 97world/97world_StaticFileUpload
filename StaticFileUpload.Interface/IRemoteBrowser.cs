using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StaticFileUpload.Model;

namespace StaticFileUpload.Interface
{
    public interface IRemoteBrowser
    {
        void CheckLoginInfo(OperatorInfo operatorInfo);

        string GetSpaceUsage();
    }
}
