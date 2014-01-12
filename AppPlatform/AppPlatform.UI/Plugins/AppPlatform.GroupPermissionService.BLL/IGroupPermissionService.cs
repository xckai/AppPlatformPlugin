using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.GroupPermissionService.BLL
{
    public interface IGroupPermissionService
    {
        void GroupPermissionUpdate();
        void GroupPermissionGet();
        void GroupPermissionDelete();
        void GroupPermissionAdd();
    }
}
