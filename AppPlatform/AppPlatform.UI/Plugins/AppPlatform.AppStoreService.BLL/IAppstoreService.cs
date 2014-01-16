using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppStoreService.BLL
{
    public interface IAppstoreService
    {
        void AppSearch(object Text);
        bool AppOrder(object App);
    }
}
