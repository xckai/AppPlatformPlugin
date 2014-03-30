using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.DAL;
using AppPlatform.Model.Models;
using AppPlatform.Model;
using AppPlatform.IDAL;
using System.Linq;

namespace AppPlatform.EnterpriseInfoService.BLL
{
    public class EnterpriseInfoService : IEnterpriseInfoService
    {

        public List<Enterprise> EnterpriseInfoGet(string Enterprise_Name)
        {
            IEnterpriseRepository _IEnterpriseResitory = RepositoryFactory.EnterpriseRepository;
            List<Enterprise> t = _IEnterpriseResitory.LoadEntities(Enterprise => Enterprise.Enterprise_Name == Enterprise_Name).ToList<Enterprise>();
            return t;
        }

        public Enterprise EnterpriseListGetbyID(int EnterpriseID)
        {
            IEnterpriseRepository _IEnterpriseResitory = RepositoryFactory.EnterpriseRepository;
            Enterprise t = _IEnterpriseResitory.LoadEntities(Enterprise => (Enterprise.Enterprise_ID == EnterpriseID)).FirstOrDefault<Enterprise>();
            return t;

        }
        public List<Enterprise> EnterpriseListGetall()
        {
            IEnterpriseRepository _IEnterpriseResitory = RepositoryFactory.EnterpriseRepository;
            List<Enterprise> t = _IEnterpriseResitory.LoadEntities(Enterprise => (Enterprise.Enterprise_ID >=0)).ToList<Enterprise>();
            return t;

        }

        public bool EnterpriseInfoAdd(Enterprise t,int id)
        {
            IEnterpriseRepository _enterpriseRepository = RepositoryFactory.EnterpriseRepository;
            List<Enterprise>  MaxenterpriseID = _enterpriseRepository.LoadEntities(Enterprise => Enterprise.Enterprise_ID >= 0).ToList<Enterprise>();
            if (MaxenterpriseID.Count() == 0)
                { t.Enterprise_ID = 10000; }

            else if (MaxenterpriseID.Last()== null)
            {
                t.Enterprise_ID = 10000;
            }
            else
            {
                t.Enterprise_ID = MaxenterpriseID.Last().Enterprise_ID + 1;
            }
            IEnterpriseRepository _IEnterpriseResitory = RepositoryFactory.EnterpriseRepository;

           bool _infobool= _IEnterpriseResitory.AddEntity(t);
           if (_infobool)
           {
               IEnterprise_EnterpriseClassRepository _enclass_en = RepositoryFactory.Enterprise_EnterpriseClassRepository;
               Enterprise_EnterpriseClass _enclassen = new Enterprise_EnterpriseClass();
               _enclassen.Enterprise_ID = t.Enterprise_ID;
               _enclassen.EnterpriseClass_ID = id;
               bool in_clasbool = _enclass_en.AddEntity(_enclassen);
               return in_clasbool;
           }
           else
           {
               return false;
           }

            
        }

        public bool EnterpriseInfoUpdate(Enterprise t,int id)
        {
            IEnterpriseRepository _IEnterpriseResitory = RepositoryFactory.EnterpriseRepository;
            bool _infobool = _IEnterpriseResitory.UpdateEntity(t);
            if (_infobool)
            {
                IEnterprise_EnterpriseClassRepository _enclass_en = RepositoryFactory.Enterprise_EnterpriseClassRepository;

                Enterprise_EnterpriseClass temp_en = new Enterprise_EnterpriseClass();
                temp_en = _enclass_en.LoadEntities(Enterprise_EnterpriseClass => (Enterprise_EnterpriseClass.Enterprise_ID == t.Enterprise_ID)).FirstOrDefault<Enterprise_EnterpriseClass>();
               // _enclassen.Enterprise_ID = t.Enterprise_ID;
                   temp_en.EnterpriseClass_ID = id;
                bool in_clasbool = _enclass_en.UpdateEntity(temp_en);
                return in_clasbool;
            }
            else
            {
                return false;
            }
            

        }

        public bool EnterpriseInfoRemove(Enterprise t)
        {
            IEnterpriseRepository _IEnterpriseResitory = RepositoryFactory.EnterpriseRepository;
            return _IEnterpriseResitory.DeleteEntity(t);
        }
    }
}
