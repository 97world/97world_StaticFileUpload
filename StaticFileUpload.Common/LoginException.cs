using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticFileUpload.Common
{
    public class LoginException : System.Exception
    {
        public int statusCode = 1;
        public LoginException(int statusCode, string msg) : base(msg)
        {
            this.statusCode = statusCode;
        }
    }
}
