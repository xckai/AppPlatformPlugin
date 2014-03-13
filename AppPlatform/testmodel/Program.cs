using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPlatform.Model.Models;
using System.Data.SqlClient;
using AppPlatform.IDAL;
using AppPlatform.DAL;

namespace testmodel
{
    class Program
    {
        static void Main(string[] args)
        {
           // AppClass appclass1 = new AppClass
           // {
           //     AppClass_ID = 1,
           //     AppClass_PID=0,
           //     AppClass_Name = "class1"
           // };
           //AppClass appclass2 = new AppClass
           // {
           //     AppClass_ID=2,
           //     AppClass_PID=1,
           //     AppClass_Name = "class2"
           // };
           //IAppClassRepository _appClassRepository = RepositoryFactory.AppClassRepository;
           //_appClassRepository.AddEntity(appclass1);
           //// _appClassRepository.AddEntity(appclass2);

           // //_appClassRepository.UpdateEntity(appclass2);
           //// _appClassRepository.DeleteEntity(appclass1);

           // List<AppClass> t=_appClassRepository.LoadEntities(AppClass => AppClass.AppClass_ID>0).ToList<AppClass>();
           // foreach(AppClass x in t)
           // {
           //     Console.WriteLine("AppClass_ID:"+x.AppClass_ID);
           //     Console.WriteLine("AppClass_Name:" + x.AppClass_Name);
           //     Console.WriteLine("AppClass_PID:" + x.AppClass_PID);
           //     Console.WriteLine("AppClass_Note:" + x.AppClass_Note);
           // }



           // Console.WriteLine("end");

           // Console.Read();

            Group group = new Group();
            group.Group_Name = "Administration";
            group.Group_Desc = "平台管理员";
            Group group1 = new Group();
            group1.Group_Name = "EnterpriseAdmin";
            group1.Group_Desc = "企业管理员";
            Group group2 = new Group();
            group2.Group_Name = "EnterpriseUser";
            group2.Group_Desc = "企业普通用户";
            Group group3 = new Group();
            group3.Group_Name = "AppProvider";
            group3.Group_Desc = "应用提供商";
            IGroupRepository _group = RepositoryFactory.GroupRepository;
            _group.AddEntity(group);
            _group.AddEntity(group1);
            _group.AddEntity(group2);
            _group.AddEntity(group3);

            Enterprise enterprise = new Enterprise();
            enterprise.Checked = true;
            enterprise.Enterprise_Name = "同济大学CAD中心";
            enterprise.Enterprise_Code = "12345678";
            enterprise.Enterprise_Email = "350455378@qq.com";
            enterprise.Enterprise_ID =10001;
            IEnterpriseRepository _ER = RepositoryFactory.EnterpriseRepository;
            _ER.AddEntity(enterprise);
            Enterprise entp = _ER.LoadEntities(Enterprise => Enterprise.Enterprise_ID == enterprise.Enterprise_ID).FirstOrDefault();
            User user = new User();
            user.Enterprise_ID = entp.Enterprise_ID;
            user.User_Name = "陈瑶";
            user.User_ID = 10001;
            user.User_State = true;
            user.Password = "123456";
            IUserRepository _user = RepositoryFactory.UserRepository;
            _user.AddEntity(user);

            IUser_GroupRepository _UGR = RepositoryFactory.User_GroupRepository;
            User_Group ug = new User_Group();
            ug.Group_ID = 1;
            ug.User_ID = 10001;
            _UGR.AddEntity(ug);

        }
    }
}
