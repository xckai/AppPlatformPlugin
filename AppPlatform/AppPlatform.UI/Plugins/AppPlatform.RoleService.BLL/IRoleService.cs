using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.RoleService.BLL
{
    public interface IRoleService
    {
        void RoleGet(object RoleID);//返回是一个Role类型的列表
        bool RoleAdd(object Role);
        bool RoleDelete(object RoleID);
        bool RoleUpdate(object Role);
    }
}
