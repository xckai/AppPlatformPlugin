using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.EnterpriseMenuService.bll
{
    public interface IEnterpriseMenuService
    {
        void EnterpriseMenuGet(object EnterpriseMenuID);
        bool EnterpriseMenuUpdate(object EnterpriseMenu);
        bool EnterpriseMenuDelete(object EnterpriseMenuID);
        bool EnterpriseMenuAdd(object EnterpriseMenu);

    }
}
