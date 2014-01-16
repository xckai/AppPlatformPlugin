using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppClassService.BLL
{
    public interface IAppClassService
    {
        void AppClassListGet();
        void AppClassGet(object AppClassID);
        bool AppClassUpdate(object AppClass);
        bool AppClassDelete(object AppClassID);
    }
}
