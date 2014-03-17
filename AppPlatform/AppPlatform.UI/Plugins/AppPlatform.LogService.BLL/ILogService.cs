using AppPlatform.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Appplatform.LogService.BLL
{
    public interface ILogService
    {
        bool LogWrite(Log a);
        List<Log> LogGet(DateTime StartTime, DateTime EndTime);
        List<Log> LogGet(String LogClass, DateTime StartTime, DateTime EndTime);
        bool LogDelete(Log a);

    }
}
