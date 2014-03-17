using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppPlatform.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult SystemFunction(int ID)
        {
            ViewBag.ID = ID;
            return View();
        }

        public ActionResult AppEntrance()
        {
            ViewBag.URL = "http://jeasyui.com/";
            return View();
        }

    }
}
