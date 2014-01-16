using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppOrderService.BLL
{
    public interface IAppOrderService
    {
        void AppOrderListGet();
        bool AppOrderDelete(object AppID);
        void AppOrderInfoGet(object AppID);
    }
}
