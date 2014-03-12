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
        public RegisterInfo Regiter(string EnterpriseName, string EnterPriseCode, string PassWord, string Email)
        {
            Enterprise enterprise = new Enterprise();
            User user = new User();
            RegisterInfo rgInfo = new RegisterInfo();
            try
            {
               
                enterprise.Enterprise_Name = EnterpriseName;
                enterprise.Enterprise_Code = EnterPriseCode;
                enterprise.Enterprise_Email = Email;
                IEnterpriseRepository _enterpriseRepository = RepositoryFactory.EnterpriseRepository;
                Enterprise MaxenterpriseID = _enterpriseRepository.LoadEntities(Enterprise=>Enterprise.Enterprise_ID!=null).Max();
                if (MaxenterpriseID.Enterprise_ID==null)
                {
                    enterprise.Enterprise_ID = 100000;
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
               
                user.Password = PassWord;
                IUserRepository _userRepository=RepositoryFactory.UserRepository;
                var MaxUserID = _userRepository.LoadEntities(User=>User.User_ID!=null).Max();
                if (MaxUserID.User_ID==null)
                {
                    user.User_ID = 100000;
                } 
                else
                {
                    user.User_ID = MaxUserID.User_ID + 1;
                }
                
            }
            catch (System.Exception ex)
            {
                //数据写失败
            }
            try
            {
                IGroupRepository _groupRepository = RepositoryFactory.GroupRepository;
                Group group = _groupRepository.LoadEntities(Group => Group.Group_Name == "EnterpriseAdmin").FirstOrDefault();
                User_Group uGroup = new User_Group();
                uGroup.Group_ID = group.Group_ID;
                uGroup.User_ID = user.User_ID;
                IUser_GroupRepository _userGroupRepository = RepositoryFactory.User_GroupRepository;
                _userGroupRepository.AddEntity(uGroup);
            }
            catch (System.Exception ex)
            {
            	
            }
            rgInfo.EnterpriseID = enterprise.Enterprise_ID;
            rgInfo.UserID = user.User_ID;
            return rgInfo ;
        }
    }
}
