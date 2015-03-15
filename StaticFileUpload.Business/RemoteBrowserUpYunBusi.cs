using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using StaticFileUpload.Interface;
using StaticFileUpload.Model;
using StaticFileUpload.Log;
using StaticFileUpload.Common;
using Library.UpYun;

namespace StaticFileUpload.Business
{
    public class RemoteBrowserUpYunBusi : IRemoteBrowser
    {
        private UpYun upYun = null;

        public void CheckLoginInfo(OperatorInfo optorInfo)
        {
            upYun = new UpYun(optorInfo.bucketName, optorInfo.operatorName, optorInfo.operatorPwd);
            upYun.setApiDomain(StrFormatUtil.FormatNetStr(optorInfo.netSelection));
            try
            {
                double useSpace = upYun.getBucketUsage();
                SFUSetting.Save();
                SFULogger.DEFAULT.InfoFormat("操作员[{0}]登录成功.BucketName=[{1}],APINet=[{2}],BucketUsage=[{3}]", optorInfo.operatorName, optorInfo.bucketName, optorInfo.netSelection, useSpace);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("401"))
                {
                    string exceptionMsg = String.Format("操作员[{0}]登录失败.原因:登录信息填写有误,BucketName=[{1}],APINet=[{2}],ExceptionMsg=[{3}]", optorInfo.operatorName, optorInfo.bucketName, optorInfo.netSelection, ex.Message);
                    LoginException loginException = new LoginException(401, exceptionMsg);
                    SFULogger.DEFAULT.Error(loginException.Message);
                    throw loginException;
                }
                else
                {
                    string exceptionMsg = String.Format("操作员[{0}]登录失败.原因:未知,BucketName=[{1}],APINet=[{2}],ExceptionMsg=[{3}]", optorInfo.operatorName, optorInfo.bucketName, optorInfo.netSelection, ex.Message);
                    LoginException loginException = new LoginException(0, exceptionMsg);
                    SFULogger.DEFAULT.Error(loginException.Message);
                    throw loginException;
                }
            }
        }

        public string GetSpaceUsage()
        {
            return SFUCommon.GetCommonSize(upYun.getBucketUsage());
        }
    }
}
