using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.AppOrderService.BLL
{
    public interface IAppOrderService
    {
        void AppOrderListGet();
        void AppOrderDelete();
        void AppOrderInfoGet();
        void AppPermissionSet();
    }
}
