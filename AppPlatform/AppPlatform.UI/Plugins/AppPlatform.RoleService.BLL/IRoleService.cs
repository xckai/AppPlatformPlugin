using AppPlatform.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.RoleService.BLL
{
    public interface IRoleService
    {
        List<Role> RoleGet(int EnterPriseID);//返回是一个Role类型的列表
        bool RoleAdd(Role role);
        bool RoleDelete(int RoleID);
        bool RoleUpdate(Role role);
    }
}
