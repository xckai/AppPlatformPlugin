using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.RolePermissionService.BLL
{
    public interface IRolePermissionService
    {
        //RoleID是角色的ID，AppID是功能模块的ID，Des是角色权限的描述
        bool RolePermissionSet(object RolePermission);
        void RolePermissionGet(object RoleID);
        bool RolePermissionRemove(object RoleID,object AppID);
        bool RolePermissionUpdate(object RolePermission);
    }
}
