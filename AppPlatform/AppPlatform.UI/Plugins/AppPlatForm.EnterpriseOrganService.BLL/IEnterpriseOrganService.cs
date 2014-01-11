using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatForm.EnterpriseOrganService.BLL
{
    public interface IEnterpriseOrganService
    {
        void EnterpriseOrganListGet();
        void EnterPriseOrganAdd();
        void EnterPriseOrganRemove();
        void EnterPriseOrganUpdate();
    }
}
