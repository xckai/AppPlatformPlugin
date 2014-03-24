using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogManagerPlugin.Models
{
    public class LogView
    {
        public int LogView_Log_ID { get; set; }
        public String LogView_Log_Name { get; set; }
        public String LogView_Log_Content { get; set; }
        public int LogView_User_ID { get; set; }
        public String LogView_Log_Time { get; set; }
        public String LogView_Log_Class { get; set; }
        public String LogView_Log_Note { get; set; }
    }
}