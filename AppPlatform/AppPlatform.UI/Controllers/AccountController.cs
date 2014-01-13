using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppPlatform.UI.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult LoginSuccess()
        {
            ViewBag.UserName = Request["UserID"];
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        public ActionResult SystemManager()
        {
            return View();
        }

    }
}
