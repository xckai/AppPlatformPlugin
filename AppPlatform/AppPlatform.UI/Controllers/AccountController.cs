using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppplatformCommon;
using AppPlatform.LoginService.BLL;
using AppPlatform.DAL;
using AppPlatform.IDAL;
using AppPlatform.Model.Models;
using AppPlatform.RegisterServie.BLL;

namespace AppPlatform.UI.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Login()
        {
            if (Session["LoginError"] != null)
            {
                ViewData["error"] = Session["LoginError"];
            }
            
            return View();
        }
       
       

        public ActionResult Create()//创建用户界面
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register()
        {
            Enterprise enterprise = new Enterprise();
            User user = new User();
            enterprise.Enterprise_Name = Request.Form["Enterprise_Name"];
            user.User_Name = Request.Form["Enterprise_Adm"];
            user.Password = Request.Form["Enterprise_Pas"];
            enterprise.Enterprise_Code = Request.Form["Enterprise_Code"];
            enterprise.Enterprise_Email = Request.Form["Enterprise_Email"];
            var EnterpriseType = "EnterpriseAdmin";
            IRegisterService _registerService = new AppPlatform.RegisterServie.BLL.RegisterService();
            RegisterInfo registerInfo = _registerService.Regiter(enterprise, user, EnterpriseType);
            return RedirectToAction("Login");
        }
        
    }
}
