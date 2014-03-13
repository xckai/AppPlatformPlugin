using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.Model.Models;
using AppPlatform.IDAL;
using AppPlatform.DAL;
using System.Linq;
using AppplatformCommon;

namespace AppPlatform.RegisterServie.BLL
{
    public class RegisterService : IRegisterService
    {
        public RegisterInfo Regiter(Enterprise enterPriseVariable, User userVariable, string enterPriseType)
        {
            Enterprise enterprise = new Enterprise();
            User user = new User();
            RegisterInfo rgInfo = new RegisterInfo();
            try
            {

                enterprise = enterPriseVariable;
                enterprise.Checked = false;
                IEnterpriseRepository _enterpriseRepository = RepositoryFactory.EnterpriseRepository;
                Enterprise MaxenterpriseID = _enterpriseRepository.LoadEntities(Enterprise => Enterprise.Enterprise_ID >= 10000).Max();
                if (MaxenterpriseID == null)
                {
                    enterprise.Enterprise_ID = 10000;
                }
                else
                {
                    enterprise.Enterprise_ID = MaxenterpriseID.Enterprise_ID + 1;
                }
                _enterpriseRepository.AddEntity(enterprise);

            }
            catch (System.Exception ex)
            {
                //写日志,数据库写错误

            }
            try
            {

                user = userVariable;
                user.User_State = true;//开启用户账户
                user.Enterprise_ID = enterprise.Enterprise_ID;
                IUserRepository _userRepository = RepositoryFactory.UserRepository;
                var MaxUserAccount = _userRepository.LoadEntities(User =>User.Enterprise_ID==enterprise.Enterprise_ID&& User.User_ID >= 10000).Max();
                if (MaxUserAccount == null)
                {
                    user.User_ID = 10000;
                }
                else
                {
                    user.User_ID = MaxUserAccount.User_ID + 1;
                }
                _userRepository.AddEntity(user);

            }
            catch (System.Exception ex)
            {
                //数据写失败
            }
            try
            {
                IGroupRepository _groupRepository = RepositoryFactory.GroupRepository;
                Group group = _groupRepository.LoadEntities(Group => Group.Group_Name == enterPriseType).FirstOrDefault();//读取用户组别类型ID
                IUserRepository _userRepository = RepositoryFactory.UserRepository;
                var UserNew = _userRepository.LoadEntities(User => User.Enterprise_ID == user.Enterprise_ID && User.User_ID ==user.User_ID).FirstOrDefault();
                User_Group uGroup = new User_Group();
                uGroup.Group_ID = group.Group_ID;
                uGroup.User_ID = UserNew.User_ID;
                IUser_GroupRepository _userGroupRepository = RepositoryFactory.User_GroupRepository;
                _userGroupRepository.AddEntity(uGroup);
            }
            catch (System.Exception ex)
            {

            }
            rgInfo.EnterpriseAccount = enterprise.Enterprise_ID;
            rgInfo.UserAccount= user.User_ID;
            return rgInfo;
        }
    }
}
