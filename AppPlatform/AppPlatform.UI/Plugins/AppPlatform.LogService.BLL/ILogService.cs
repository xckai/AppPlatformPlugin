using AppPlatform.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appplatform.LogService.BLL
{
    public interface ILogService
    {
        bool LogWrite(Log a);
        List<Log> LogGetAll();
        List<Log> LogGet(DateTime StartTime, DateTime EndTime);
        List<Log> LogGet(Log.t LogClass, DateTime StartTime, DateTime EndTime);
        bool LogDelete(int id);

    }
}
