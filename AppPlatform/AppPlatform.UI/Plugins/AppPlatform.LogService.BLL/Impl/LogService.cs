using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.LogService.BLL
{
    public class LogService : ILogService
    {
        public bool LogWrite(object Log)
        {
            throw new NotImplementedException();
        }

        public string LogGet(object LogType)
        {
            return "日志获取成功";
        }

        public string LogGet(object StartTime, object EndTime)
        {
            throw new NotImplementedException();
        }

        public bool LogDelete(object LogID)
        {
            throw new NotImplementedException();
        }
    }
}
