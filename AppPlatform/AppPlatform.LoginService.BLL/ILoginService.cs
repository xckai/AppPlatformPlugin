using System;
using System.Collections.Generic;
using System.Text;
using AppplatformCommon;

namespace AppPlatform.LoginService.BLL
{
    public interface ILoginService
    {
        //登录认证
        UserLoginInfo LoginAuthen(int EnterpriseAccount,int UserAccount,string PassWord);
    }
}
