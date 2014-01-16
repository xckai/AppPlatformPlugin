using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.EnterpriseInfoService.BLL
{
    public interface IEnterpriseInfoService
    {
        void EnterpriseInfoGet(object EnterpriseID);
        void EnterpriseListGet(object EnterpriseClassID);
        bool EnterpriseInfoAdd(object EnterpriseInfo);
        void EnterpriseInfoUpdate(object EnterpriseInfo);
        bool EnterpriseInfoRemove(object EnterpriseID);
    }
}
