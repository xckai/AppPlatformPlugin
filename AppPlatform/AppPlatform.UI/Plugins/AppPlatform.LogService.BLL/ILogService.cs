using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.LogService.BLL
{
    public interface ILogService
    {
        bool   LogWrite(object Log);//log 是一个log对象
        string LogGet(object Object);//返回应该是一个Log的list
        string LogGet(object StartTime, object EndTime);//返回应该是一个Log的list
        bool   LogDelete(object LogID);
    }
}
