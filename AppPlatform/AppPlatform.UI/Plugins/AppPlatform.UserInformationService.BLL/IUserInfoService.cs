using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.UserInformationService.BLL
{
    public interface IUserInfoService
    {
        void UserInfoGet();
        void UserInfoUpdate();
        void UserInfoAdd();
        void UserInfoDelete();
    }
}
