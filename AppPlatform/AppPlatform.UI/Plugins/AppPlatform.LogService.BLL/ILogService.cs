using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.LogService.BLL
{
    public interface ILogService
    {
        void LogInfoWrite();
        void LogerroWrite();
        void logFatalWrite();
        string LogGet();
        void LogDelete();
    }
}
