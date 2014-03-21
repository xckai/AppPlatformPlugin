using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppPlatform.Contracts.Commands.RegistryService;
using AppPlatform.RegisterServie.BLL;


namespace AppPlatform.UI.Controllers
{
    public class AuthenController : AsyncController
    {
        //
        // GET: /Authen/

        /*
        public ActionResult Index(string email, string code)
        {
            ServiceBus.Bus.Send(new UserVerifyingEmailCmd
            {
                EmailAddress = email,
                VerificationCode = code
            });

            return View();
        }
         */

        public void IndexAsync(string email, string code)
        {
            ServiceBus.Bus.Send(new UserVerifyingEmailCmd
            {
                EmailAddress = email,
                VerificationCode = code
            }).Register<int>(status =>
            {
                AsyncManager.Parameters["result"] = status;
            });
        }

        public ActionResult IndexCompleted(int result)
        {
            if (result != 0)
            {
                IRegisterService service = new RegisterService();
                service.UpdateCheck(result);
                return Redirect("/Account/Login");
            }
                
            else
                return Redirect("http://www.baidu.com");
        }
    }
}
