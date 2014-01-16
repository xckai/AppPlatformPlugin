using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.UserRoleService.BLL
{
    public interface IUserRoleService
    {
        void UserRoleGet(object UserID);
        void UserRoleAdd(object UserID,object RoleID);
        void UserRoleDelete(object UserID,object RoleID);

    }
}
