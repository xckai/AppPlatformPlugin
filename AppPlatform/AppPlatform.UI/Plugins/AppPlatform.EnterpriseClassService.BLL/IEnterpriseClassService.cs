using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.EnterpriseClassService.BLL
{
    public interface IEnterpriseClassService
    {
        void EnterPriseClassGet(object EnterpriseClassID);
        void EnterPriseClassUpdate(object EnterpriseClassID, object EnterpriseClassName,object Des);
        void EnterPriseClassDelete(object EnterpriseClassID);
        void EnterPriseClassAdd(object EnterpriseClassName, object Des);
    }
}
