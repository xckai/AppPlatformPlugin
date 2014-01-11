using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.LogService.BLL
{
    public class LogService : ILogService
    {
        public void LogInfoWrite()
        {
            throw new NotImplementedException();
        }

        public void LogerroWrite()
        {
            throw new NotImplementedException();
        }

        public void logFatalWrite()
        {
            throw new NotImplementedException();
        }

        public string LogGet()
        {
            return "日志读取成功";
        }

        public void LogDelete()
        {
            throw new NotImplementedException();
        }
    }
}
