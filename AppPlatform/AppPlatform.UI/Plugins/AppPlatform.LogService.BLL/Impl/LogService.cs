using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.LogService.BLL
{
    public class LogService : ILogService
    {

        public bool EventLogWrite(object UserID, string UserName, string Message, object OperateObject, object LogType, object OperateType)
        {
            throw new NotImplementedException();
        }

        public bool SystemLogWrite(object UserID, string Message, Exception e)
        {
            throw new NotImplementedException();
        }

        public string EnventLogGet()
        {
            return "rrrr";
        }

        public string SystemLogGet()
        {
            throw new NotImplementedException();
        }

        public bool EnventLogDelete()
        {
            throw new NotImplementedException();
        }

        public bool SystemLogDelete()
        {
            throw new NotImplementedException();
        }
    }
}
