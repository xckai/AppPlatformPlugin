using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.Model;
using AppPlatform.Model.Models;
using AppPlatform.IDAL;
using AppPlatform.DAL;

namespace AppPlatform.EnterpriseInfoService.BLL
{
    public interface IEnterpriseInfoService
    {
        List<Enterprise> EnterpriseInfoGet(string enEnterprise_Name);
        Enterprise EnterpriseListGetbyID(int EnterpriseID);
        bool EnterpriseInfoAdd(Enterprise t,int id);
        bool EnterpriseInfoUpdate(Enterprise t,int id);
        bool EnterpriseInfoRemove(Enterprise t);
        List<Enterprise> EnterpriseListGetall();
    }
}
