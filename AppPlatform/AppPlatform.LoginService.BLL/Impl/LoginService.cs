using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.IDAL;
using AppPlatform.DAL;
using AppPlatform.Model;
using AppPlatform.Model.Models;
using System.Linq;

namespace AppPlatform.LoginService.BLL
{
    public class LoginService : ILoginService
    {
        public AppplatformCommon.UserLoginInfo userLoginInfo=new AppplatformCommon.UserLoginInfo();

        public AppplatformCommon.UserLoginInfo LoginAuthen(int EnterpriseID, int UserID, string PassWord)
        {
            IUserRepository _userRepository = RepositoryFactory.UserRepository;
            User user = _userRepository.LoadEntities(User => User.Enterprise_ID == EnterpriseID&&User.User_ID == UserID).FirstOrDefault();
            IEnterpriseRepository _enterPriseRepository=RepositoryFactory.EnterpriseRepository;
            Enterprise enterprise=_enterPriseRepository.LoadEntities(Enterprise=>Enterprise.Enterprise_ID==EnterpriseID).FirstOrDefault();
            if (user == null)
            {
                userLoginInfo.loginResult = AppplatformCommon.LoginResult.userNoExist;
            }
            else if (user.Password != PassWord)
            {
                userLoginInfo.loginResult = AppplatformCommon.LoginResult.pwdError;
            }
            else if (enterprise.Checked==false)
            {
                userLoginInfo.loginResult = AppplatformCommon.LoginResult.userUnchecked;
            }
            else
            {
                userLoginInfo.loginResult = AppplatformCommon.LoginResult.ok;
                IUser_GroupRepository _userGroup = RepositoryFactory.User_GroupRepository;
                User_Group userGroup = _userGroup.LoadEntities(User_Group=>User_Group.User_ID==user.User_ID).FirstOrDefault();
                IGroupRepository _Group = RepositoryFactory.GroupRepository;
                Group group = _Group.LoadEntities(Group => Group.Group_ID == userGroup.Group_ID).FirstOrDefault();
                userLoginInfo.UserGroupName = group.Group_Name;
                IUser_RoleRepository _userRole = RepositoryFactory.User_RoleRepository;
                User_Role userRole = _userRole.LoadEntities(User_Role=>User_Role.User_ID==user.User_ID).FirstOrDefault();
                userLoginInfo.UserRoleID = userRole.RoleList_ID;
            }
            return userLoginInfo;
        }
    }
}
