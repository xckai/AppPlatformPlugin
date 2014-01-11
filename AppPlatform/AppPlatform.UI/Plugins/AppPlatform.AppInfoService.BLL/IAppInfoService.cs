using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppInfoService.BLL
{
    public interface IAppInfoService
    {
        //接口方法的返回类型以及参数根据数据库定义，接口的实现在Impl文件夹AppService实现
        void AppListGet();
        void AppInfoGet();
        void AppInfoCreate();
        void AppInfoUpdate();
        void AppDelete();
    }
}
