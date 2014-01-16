using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatForm.EnterpriseOrganService.BLL
{
    public interface IEnterpriseOrganService
    {
        void EnterpriseOrganListGet();
        void EnterPriseOrganGet(object EnterPriseOrganID);
        bool EnterPriseOrganAdd(object EnterpriseOrgan);
        bool EnterPriseOrganRemove(object EnterpriseOrganID);
        bool EnterPriseOrganUpdate(object EnterpriseOrgan);
    }
}
