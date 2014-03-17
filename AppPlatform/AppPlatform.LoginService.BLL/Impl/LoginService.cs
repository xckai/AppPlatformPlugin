using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.IDAL;
using AppPlatform.DAL;
using AppPlatform.Model;
using AppPlatform.Model.Models;
using System.Linq;
using AppplatformCommon;

namespace AppPlatform.LoginService.BLL
{
    public class LoginService : ILoginService
    {
        public AppplatformCommon.UserLoginInfo userLoginInfo=new AppplatformCommon.UserLoginInfo();

        public AppplatformCommon.UserLoginInfo LoginAuthen(int EnterpriseID, int UserID, string PassWord)
        {
            IEnterpriseRepository _enterPriseRepository = RepositoryFactory.EnterpriseRepository;
            Enterprise enterprise = _enterPriseRepository.LoadEntities(Enterprise => Enterprise.Enterprise_ID== EnterpriseID).FirstOrDefault();
            if (enterprise != null)
            {
                IUserRepository _userRepository = RepositoryFactory.UserRepository;
                User user = _userRepository.LoadEntities(User => User.Enterprise_ID == enterprise.Enterprise_ID && User.User_ID == UserID).FirstOrDefault();

                if (user == null)
                {
                    userLoginInfo.loginResult = AppplatformCommon.LoginResult.userNoExist;
                }
                else if (user.Password != PassWord)
                {
                    userLoginInfo.loginResult = AppplatformCommon.LoginResult.pwdError;
                }
                else if (enterprise.Checked == false)
                {
                    userLoginInfo.loginResult = AppplatformCommon.LoginResult.userUnchecked;
                }
                else if (user.User_State==false)
                {
                    userLoginInfo.loginResult = LoginResult.userStop;
                }
                else
                {
                    userLoginInfo.loginResult = AppplatformCommon.LoginResult.ok;
                    IUser_GroupRepository _userGroup = RepositoryFactory.User_GroupRepository;
                    User_Group userGroup = _userGroup.LoadEntities(User_Group => User_Group.User_ID == user.User_ID).FirstOrDefault();
                    userLoginInfo.UserGroupID = userGroup.Group_ID;
                    IUser_RoleRepository _userRole = RepositoryFactory.User_RoleRepository;
                    User_Role userRole = _userRole.LoadEntities(User_Role => User_Role.User_ID == user.User_ID).FirstOrDefault();
                    if (userRole!=null)
                    {
                        userLoginInfo.UserRoleID = userRole.RoleList_ID;
                    }
                    
                }
            }
            else
            {
                userLoginInfo.loginResult = LoginResult.userNoExist;
            }
            return userLoginInfo;
        }
    }
}
