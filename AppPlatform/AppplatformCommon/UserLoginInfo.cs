using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppplatformCommon
{
    public enum LoginResult
    {
        pwdError,//密码错误
        userNoExist,//用户不存在
        ok//登录成功

    }
    /// <summary>
    /// 用户登录信息返回列表
    /// </summary>
    public class UserLoginInfo
    {
      public string UserGroupName;//用户组别,默认为空
      public  int UserRoleID;//用户角色ID,默认为空
      public  LoginResult loginResult;//登录成功与否
    }
}
