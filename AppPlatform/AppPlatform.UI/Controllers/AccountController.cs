using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppplatformCommon;
using AppPlatform.LoginService.BLL;
using AppPlatform.DAL;

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
            var enterPriseID=Convert.ToInt32(Request["EnterpriseID"]);
            var userID = Convert.ToInt32(Request["UserID"]);
            var passWord = Request["Password"];
            ILoginService _loginService = new AppPlatform.LoginService.BLL.LoginService();
            UserLoginInfo userLoginInfo = _loginService.LoginAuthen(enterPriseID,userID,passWord);
            if (userLoginInfo.loginResult == LoginResult.userNoExist)
            {
                return View();
                //return RedirectToAction("Login");
            }
            else if (userLoginInfo.loginResult==LoginResult.pwdError)
            {
                return RedirectToAction("Login");
            }
            else if (userLoginInfo.loginResult == LoginResult.ok)
            {
               return View();
            }
            return new EmptyResult();
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
