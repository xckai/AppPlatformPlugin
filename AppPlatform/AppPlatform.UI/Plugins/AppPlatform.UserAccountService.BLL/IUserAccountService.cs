using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.UserAccountService.BLL
{
    public interface IUserAccountService
    {
        void AccountPermissionSet();
        void AccountInfoGet();
        void AccountInfoUpadate();
        void AccountAdd();
    }
}
