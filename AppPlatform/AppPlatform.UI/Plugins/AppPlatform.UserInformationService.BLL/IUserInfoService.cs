using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.UserInformationService.BLL
{
    public interface IUserInfoService
    {
        void UserLIstGet();
        void UserInfoGet(object UserInfoID);
        bool UserInfoUpdate(object UserInfo);
        bool UserInfoAdd(object UserInfo);
        bool UserInfoDelete(object UserInfoID);
    }
}
