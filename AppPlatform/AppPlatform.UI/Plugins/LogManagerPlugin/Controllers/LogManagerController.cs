using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppPlatform.Model.Models;
using Appplatform.LogService.BLL;
using LogManagerPlugin.Models;

namespace EnterpriseManagerPlugin.Controllers
{
    public class LogManagerController : Controller
    {
        //
        // GET: /LogManager/


        public ActionResult Index()
        {

            return View();
        }

        public JsonResult GetLogJson()
        {

            ILogService _logService = new LogService();
            var LogList = _logService.LogGetAll();

            var LogViewList = new List<LogView>();

            foreach (Log x in LogList)
            {
                var logview = new LogView();
                logview.LogView_Log_ID = x.Log_ID;
                logview.LogView_Log_Name = x.Log_Name;
                logview.LogView_Log_Note = x.Log_Note;
                logview.LogView_Log_Content = x.Log_Content;
                logview.LogView_Log_Time = x.Log_Time.ToString();
                logview.LogView_User_ID = x.User_ID;
                if (x.Log_Class == Log.t.SystemLog)
                {
                    logview.LogView_Log_Class = "系统日志";
                }
                else
                    logview.LogView_Log_Class = "操作日志";
                LogViewList.Add(logview);
            }

            var jsonResult = new { total = LogViewList.Count(), rows = LogViewList };
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }

        public bool DeleteLog(int id)
        {
            int logid = id;
            ILogService _logService = new LogService();
            return _logService.LogDelete(logid);
        }
        public JsonResult SearchLog(string Type, DateTime Start, DateTime End)
        {
            ILogService _logService = new LogService();
            List<Log> LogList = null;
            if (Type.Equals("all"))
            {
                LogList = _logService.LogGet(Start, End);
            }
            else if (Type.Equals("system"))
            {
                LogList = _logService.LogGet(Log.t.SystemLog, Start, End);
            }
            else
                LogList = _logService.LogGet(Log.t.OperationLog, Start, End);

            var LogViewList = new List<LogView>();

            foreach (Log x in LogList)
            {
                var logview = new LogView();
                logview.LogView_Log_ID = x.Log_ID;
                logview.LogView_Log_Name = x.Log_Name;
                logview.LogView_Log_Note = x.Log_Note;
                logview.LogView_Log_Content = x.Log_Content;
                logview.LogView_Log_Time = x.Log_Time.ToString();
                logview.LogView_User_ID = x.User_ID;
                if (x.Log_Class == Log.t.SystemLog)
                {
                    logview.LogView_Log_Class = "系统日志";
                }
                else
                    logview.LogView_Log_Class = "操作日志";

                LogViewList.Add(logview);
            }

            var jsonResult = new { total = LogViewList.Count(), rows = LogViewList };
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }
    }
}
