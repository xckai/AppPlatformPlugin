using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.Model.Models;
using AppPlatform.DAL;
using AppPlatform.IDAL;
using AppPlatform.Model;

namespace AppPlatform.EnterpriseClassService.BLL
{
    public interface IEnterpriseClassService
    {
        List<EnterpriseClass> EnterPriseClassGetall();
        bool EnterPriseClassUpdate(EnterpriseClass t);
        bool EnterPriseClassDelete(EnterpriseClass t);
        bool EnterPriseClassAdd(string EnterpriseClassName, string Des);
        List<EnterpriseClass> EnterPriseClassGet(string entpristname);
    }
}
