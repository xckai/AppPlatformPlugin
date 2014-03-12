using System;
using System.Collections.Generic;
using System.Text;
using AppplatformCommon;

namespace AppPlatform.RegisterServie.BLL
{
    public interface IRegisterService
    {
        RegisterInfo Regiter(string EnterpriseName,string EnterPriseCode,string PassWord,string Email);
    }
}
