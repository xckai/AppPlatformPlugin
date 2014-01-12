using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.RolePermissionService.BLL
{
    public interface IRolePermissionService
    {
        void UserPermissionGet();
        void UserPermissionAdd();
        void UserPermissionRemove();
    }
}
