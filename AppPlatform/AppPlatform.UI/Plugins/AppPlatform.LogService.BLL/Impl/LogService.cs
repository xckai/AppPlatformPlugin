using AppPlatform.DAL;
using AppPlatform.IDAL;
using AppPlatform.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Linq;
using System.Linq;

namespace Appplatform.LogService.BLL
{
    public class LogService : ILogService
    {

        bool ILogService.LogWrite(Log a)
        {
            ILogRepository _logRepository = RepositoryFactory.LogRepository;
            try
            {
                _logRepository.AddEntity(a);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;

            }
        }
        List<Log> ILogService.LogGetAll()
        {
            ILogRepository _logRepository = RepositoryFactory.LogRepository;
            List<Log> t = _logRepository.LoadEntities(Log => Log.Log_ID > 0).ToList<Log>();
            return t;
        }
        List<Log> ILogService.LogGet(DateTime StartTime, DateTime EndTime)
        {
            ILogRepository _logRepository = RepositoryFactory.LogRepository;
            List<Log> t = _logRepository.LoadEntities(Log => (Log.Log_Time >= StartTime && Log.Log_Time <= EndTime)).ToList<Log>();
            return t;
        }

        List<Log> ILogService.LogGet(Log.t LogClass, DateTime StartTime, DateTime EndTime)
        {
            ILogRepository _logRepository = RepositoryFactory.LogRepository;
            List<Log> t = _logRepository.LoadEntities(Log => (Log.Log_Time >= StartTime && Log.Log_Time <= EndTime && Log.Log_Class == LogClass)).ToList<Log>();
            return t;
        }

        bool ILogService.LogDelete(int id)
        {
            ILogRepository _logRepository = RepositoryFactory.LogRepository;

            Log log = _logRepository.LoadEntities(Log => Log.Log_ID == id).FirstOrDefault();
            return _logRepository.DeleteEntity(log);

        }
    }
}
