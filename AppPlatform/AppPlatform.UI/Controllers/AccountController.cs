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
                //ViewData["EnterpriseName"] = enterPriseID+ "企业：";
                //ViewData["userName"] = userID;
                Session["LoginError"] = "登录错误：用户不存在";
                return RedirectToAction("Login");
            }
            else if (userLoginInfo.loginResult==LoginResult.pwdError)
            {
                Session["LoginError"] = "登录错误：密码错误";
                return RedirectToAction("Login");
            }
            else if (userLoginInfo.loginResult==LoginResult.userUnchecked)
            {
                Session["LoginError"] = "登录错误：用户未认证";
                return RedirectToAction("Login");
            }
            else if (userLoginInfo.loginResult == LoginResult.userStop)
            {
                Session["LoginError"] = "登录错误：用户账户停用";
                return RedirectToAction("Login");
            }
            else if (userLoginInfo.loginResult == LoginResult.ok)
            {
                //保存用户账户信息
                Session["EnterpriseAccount"] = enterPriseID;
                Session["UserAccount"] = userID;
                //显示欢迎页面信息
                IEnterpriseRepository _enterPriseRopository = RepositoryFactory.EnterpriseRepository;
                Enterprise enterPrise = _enterPriseRopository.LoadEntities(Enterprise=>Enterprise.Enterprise_ID==enterPriseID).FirstOrDefault();
                ViewData["EnterpriseName"] = enterPrise.Enterprise_Name + "企业：";
                IUserRepository _userRepository = RepositoryFactory.UserRepository;
                User user = _userRepository.LoadEntities(User=>User.Enterprise_ID==enterPrise.Enterprise_ID&&User.User_ID==userID).FirstOrDefault();
                ViewData["userName"] = user.User_Name;
                //根据用户角色，动态加载菜单项

                return View();
            }
            return new EmptyResult();
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
        public ActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}
