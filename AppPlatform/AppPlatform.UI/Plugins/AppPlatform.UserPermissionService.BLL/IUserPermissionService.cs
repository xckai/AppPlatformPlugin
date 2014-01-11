using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.UserPermissionService.BLL
{
    public interface IUserPermissionService
    {
        void UserPermissionGet();
        void UserPermissionAdd();
        void UserPermissionRemove();
    }
}
