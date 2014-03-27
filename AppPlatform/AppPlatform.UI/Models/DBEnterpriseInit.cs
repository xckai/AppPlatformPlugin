using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlatform.Model.Models
{
  public class DBEnterpriseInit : DropCreateDatabaseIfModelChanges<Enterprise_AppContext>
    {
        protected override void Seed(Enterprise_AppContext context)
        {

            //base.Seed(context);
            //初始化平台角色
            List<Group> groupList = new List<Group>
            {
                new Group {Group_Name="PlatformAdmin",Group_Desc="平台管理员",Group_Note=""},
                new Group {Group_Name="EnterpriseAdmin",Group_Desc="企业管理员",Group_Note=""},
                new Group {Group_Name="EnterpriseUser",Group_Desc="企业用户",Group_Note=""},
                new Group {Group_Name="AppProvider",Group_Desc="应用开发商",Group_Note=""}

            };
            groupList.ForEach(g=>context.Group.Add(g));
            //context.SaveChanges();
            //初始化平台功能菜单
            new List<Function>
            {
                //通用功能模块
                 new Function{Function_Name="账户管理",Function_Desc="平台管理员对自身的相关信息进行编辑",Function_Url="/Home/SystemFunction",Function_PID=0},
                //平台管理员功能菜单
                new Function{Function_Name="系统管理",Function_Desc="平台管理员实现系统相关的设置",Function_Url="/Home/SystemFunction",Function_PID=0},
                new Function{Function_Name="企业管理",Function_Desc="平台管理员对使用系统相关的企业的用户以及应用进行管理",Function_Url="/Home/SystemFunction",Function_PID=0},
                new Function{Function_Name="开发者管理",Function_Desc="平台管理员应用提供商的相关操作",Function_Url="/Home/SystemFunction",Function_PID=0},
                new Function{Function_Name="应用管理",Function_Desc="平台管理员实现对系统的所有应用实现管理",Function_Url="/Home/SystemFunction",Function_PID=0},
                //企业管理员功能菜单
                new Function{Function_Name="用户管理",Function_Desc="对企业的员工、企业组织结构、用户角色进行管理",Function_Url="/Home/SystemFunction",Function_PID=0},
                new Function{Function_Name="企业应用管理",Function_Desc="实现企业应用权限的分配以及应用的订阅删除等功能",Function_Url="/Home/SystemFunction",Function_PID=0},

                //企业普通用户功能菜单
                new Function{Function_Name="个人资料编辑",Function_Desc="平台管理员实现系统相关的设置",Function_Url="/Home/SystemFunction",Function_PID=0},
                //应用开发者账户
                new Function{Function_Name="应用管理",Function_Desc="跟本企业相关的应用的添加、删除、编辑等操作",Function_Url="/Home/SystemFunction",Function_PID=0},

                //用户账户二级菜单
                new Function{Function_Name="企业基本资料",Function_Desc="平台管理员对自身的相关信息进行编辑",Function_Url="/Home/SystemFunction",Function_PID=1},//URL设置
                new Function{Function_Name="用户基本管理",Function_Desc="平台管理员对自身的相关信息进行编辑",Function_Url="/UserAccount/Index?plugin=UserManagerPlugin",Function_PID=1},
                //平台管理员二级功能菜单
                new Function{Function_Name="日志管理",Function_Desc="平台管理员平台日志进行管理",Function_Url="/LogManager/Index?plugin=LogManagerPlugin",Function_PID=2},//系统管理
                new Function{Function_Name="角色管理",Function_Desc="平台管理员对平台角色编辑",Function_Url="/Group/Index?plugin=RoleManagerPlugin",Function_PID=2},
                new Function{Function_Name="菜单管理",Function_Desc="平台管理员对功能菜单进行维护",Function_Url="/Home/SystemFunction",Function_PID=2},
                new Function{Function_Name="功能管理",Function_Desc="平台管理员对功能模块信息进行维护",Function_Url="/Home/SystemFunction",Function_PID=2},
                new Function{Function_Name="用户管理",Function_Desc="平台管理员对企业用户进行管理",Function_Url="/EnterpriseInfo/Index?plugin=EnterpriseManagerPlugin",Function_PID=3},//企业管理
                new Function{Function_Name="应用审批",Function_Desc="平台管理员对企业用户相关的应用进行维护",Function_Url="/AppInfo/Index?plugin=AppManagerPlugin",Function_PID=3},
                new Function{Function_Name="用户管理",Function_Desc="平台管理员对开发者用户进行管理",Function_Url="/EnterpriseInfo/Index?plugin=EnterpriseManagerPlugin",Function_PID=4},//开发者管理
                new Function{Function_Name="应用审批",Function_Desc="平台管理员对开发者相关应用进行管理",Function_Url="/AppInfo/Index?plugin=AppManagerPlugin",Function_PID=4},
                new Function{Function_Name="应用管理",Function_Desc="平台管理员对平台所有应用进行管理",Function_Url="/AppInfo/Index?plugin=AppManagerPlugin",Function_PID=5},//应用管理
                new Function{Function_Name="应用上传",Function_Desc="平台管理员对应用进行上传",Function_Url="/AppRelease/Index?plugin=AppManagerPlugin",Function_PID=5},
                //企业管理员二级功能菜单
                new Function{Function_Name="用户角色管理",Function_Desc="企业管理员对企业内部角色进行信息维护",Function_Url="/Role/Index?plugin=RoleManagerPlugin",Function_PID=6},//系统管理
                new Function{Function_Name="企业员工管理",Function_Desc="企业管理员对本企业的员工基本信息进行维护",Function_Url="/UserInfo/Index?plugin=UserManagerPlugin",Function_PID=6},
                new Function{Function_Name="组织结构管理",Function_Desc="企业管理员对企业的组织结构进行维护",Function_Url="/EnterpriseOrganize/Index?plugin=UserManagerPlugin",Function_PID=6},
                new Function{Function_Name="应用管理",Function_Desc="系统管理员对跟本企业相关的应用进行管理",Function_Url="/AppInfo/Index?plugin=AppManagerPlugin",Function_PID=7},//应用管理
                
                //企业普通二级功能菜单
                new Function{Function_Name="用户基本管理",Function_Desc="企业普通员工对自身的基本信息进行编辑",Function_Url="/UserAccount/Index?plugin=UserManagerPlugin",Function_PID=8},

                //应用开发者二级功能菜单
                 new Function{Function_Name="应用管理",Function_Desc="开发者对本企业相关的应用进行信息维护",Function_Url="/AppInfo/Index?plugin=AppManagerPlugin",Function_PID=9},
                 new Function{Function_Name="应用上传",Function_Desc="开发者添加新应用",Function_Url="/AppRelease/Index?plugin=AppManagerPlugin",Function_PID=9}
            }.ForEach(a => context.Function.Add(a));

            new List<Group_Function>
            {
                //平台管理员
                new Group_Function{ Group_ID=1,Function_ID=1},
                new Group_Function{ Group_ID=1,Function_ID=2},
                new Group_Function{ Group_ID=1,Function_ID=3},
                new Group_Function{ Group_ID=1,Function_ID=4},
                new Group_Function{ Group_ID=1,Function_ID=5},
                //企业管理员
                new Group_Function{ Group_ID=2,Function_ID=1},
                new Group_Function{ Group_ID=2,Function_ID=6},
                new Group_Function{ Group_ID=2,Function_ID=7},
                //普通用户
                new Group_Function{ Group_ID=3,Function_ID=8},
                //开发者
                new Group_Function{ Group_ID=4,Function_ID=1},
                new Group_Function{ Group_ID=4,Function_ID=9},
            }.ForEach(a => context.Group_Function.Add(a));
        }

    }
}
