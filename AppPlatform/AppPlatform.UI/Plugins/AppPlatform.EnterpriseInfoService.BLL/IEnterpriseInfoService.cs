using System;
using System.Collections.Generic;
using System.Text;

namespace AppPlatform.EnterpriseInfoService.BLL
{
    public interface IEnterpriseInfoService
    {
        void EnterpriseClassListGet();
        void EnterpriseClassAdd();
        void EnterpriseClassRemove();
        void EnterpriseClassUpadate();
        void EnterpriseInfoGet();
        void EnterpriseInfoAdd();
        void EnterpriseInfoUpdate();
    }
}
