using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.LogService.BLL
{
    public interface ILogService
    {
        bool EventLogWrite(object UserID,string UserName,string Message,object OperateObject,object LogType,Object OperateType);
        bool SystemLogWrite(object UserID,string Message,Exception e);
        string EnventLogGet();
        string SystemLogGet();
        bool EnventLogDelete();
        bool SystemLogDelete();
    }
}
