using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.GroupPermissionService.BLL
{
    public interface IGroupPermissionService
    {
        void GroupPermissionUpdate(object GroupPermission);
        void GroupPermissionGet(object GroupID);//返回用户权限的设置
        bool GroupPermissionDelete(object GroupID,object EnterpriseID);
        bool GroupPermissionAdd(object GroupPermission);
    }
}
