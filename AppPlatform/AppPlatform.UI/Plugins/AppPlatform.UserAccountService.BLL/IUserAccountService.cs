using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.UserAccountService.BLL
{
    public interface IUserAccountService
    {
        void AccountInfoGet(object AccountInfoID);
        void AccountInfoUpadate(object AccountInfo);
    }
}
