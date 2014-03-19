using System;
using System.Collections.Generic;
using System.Text;
using AppplatformCommon;
using AppPlatform.Model.Models;

namespace AppPlatform.RegisterServie.BLL
{
    public interface IRegisterService
    {
        RegisterInfo Regiter(Enterprise enterPrise, User user, string enterPriseType);
        bool UpdateCheck(int enterPriseID);
    }
}
