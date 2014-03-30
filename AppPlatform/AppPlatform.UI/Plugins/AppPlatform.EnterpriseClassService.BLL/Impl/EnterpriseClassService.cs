using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.DAL;
using AppPlatform.Model.Models;
using AppPlatform.Model;
using AppPlatform.IDAL;
using System.Linq;


namespace AppPlatform.EnterpriseClassService.BLL
{
    public class EnterpriseClassService : IEnterpriseClassService
    {

        public List<EnterpriseClass> EnterPriseClassGetall()
        {
            IEnterpriseClassRepository _IEnterpriseClassRepository = RepositoryFactory.EnterpriseClassRepository;
            List<EnterpriseClass> t = _IEnterpriseClassRepository.LoadEntities(EnterpriseClass => (EnterpriseClass.EnterpriseClass_ID>=0)).ToList<EnterpriseClass>();

            //List<EnterpriseClass> t = _IEnterpriseClassRepository.LoadEntities(EnterpriseClass => (EnterpriseClass.EnterpriseClass_ID == EnterpriseClassID)).ToList<EnterpriseClass>();
            return t;



        }
        public List<EnterpriseClass> EnterPriseClassGet(string entpristname)
        {
            IEnterpriseClassRepository _IEnterpriseClassRepository = RepositoryFactory.EnterpriseClassRepository;
            List<EnterpriseClass> t = _IEnterpriseClassRepository.LoadEntities(EnterpriseClass => (EnterpriseClass.EnterpriseClass_Name ==entpristname)).ToList<EnterpriseClass>();

            //List<EnterpriseClass> t = _IEnterpriseClassRepository.LoadEntities(EnterpriseClass => (EnterpriseClass.EnterpriseClass_ID == EnterpriseClassID)).ToList<EnterpriseClass>();
            return t;



        }
        public bool EnterPriseClassUpdate(EnterpriseClass t)
        {
           
            IEnterpriseClassRepository _IEnterpriseClassRepository = RepositoryFactory.EnterpriseClassRepository;
            return _IEnterpriseClassRepository.UpdateEntity(t);


        }

        public bool EnterPriseClassDelete(EnterpriseClass t)
        {
            IEnterpriseClassRepository _IEnterpriseClassRepository = RepositoryFactory.EnterpriseClassRepository;
            return _IEnterpriseClassRepository.DeleteEntity(t);
        }

        public bool EnterPriseClassAdd(string  EnterpriseClassName, string Des)
        {
            //EnterpriseClass enterprise = new EnterpriseClass();

            //try
            //{

            
            //    IEnterpriseClassRepository _enterpriseRepository = RepositoryFactory.EnterpriseClassRepository;
            //    EnterpriseClass MaxenterpriseID = _enterpriseRepository.LoadEntities(EnterpriseClass => EnterpriseClass.EnterpriseClass_ID >= 1000).Last();
            //    if (MaxenterpriseID == null)
            //    {
            //        enterprise.EnterpriseClass_ID = 10000;
            //    }
            //    else
            //    {
            //        enterprise.EnterpriseClass_ID = MaxenterpriseID.EnterpriseClass_ID + 1;
            //    }
            //    enterprise.EnterpriseClass_Name = EnterpriseClassName;
            //    enterprise.EnterpriseClass_Option = Des;
            //    _enterpriseRepository.AddEntity(enterprise);

            //}
            //catch (System.Exception ex)
            //{
            //    //写日志,数据库写错误

            //}
            EnterpriseClass t = new EnterpriseClass();

            t.EnterpriseClass_Name = EnterpriseClassName;
            t.EnterpriseClass_Option = Des;
            IEnterpriseClassRepository _IEnterpriseClassRepository = RepositoryFactory.EnterpriseClassRepository;
            return _IEnterpriseClassRepository.AddEntity(t);

        }
        public bool EnterpriseClass_EnterpriseAdd(int class_id ,int en_id)

        {
            Enterprise_EnterpriseClass t = new Enterprise_EnterpriseClass();
            t.Enterprise_ID = en_id;
            t.EnterpriseClass_ID = class_id;
            IEnterprise_EnterpriseClassRepository temp = new Enterprise_EnterpriseClassRepository();
            return temp.AddEntity(t);
        }
        public bool EnterpriseClass_EnterpriseDelete(int class_id, int en_id)
        {
            Enterprise_EnterpriseClass t = new Enterprise_EnterpriseClass();
            t.Enterprise_ID = en_id;
            t.EnterpriseClass_ID = class_id;
            IEnterprise_EnterpriseClassRepository temp = new Enterprise_EnterpriseClassRepository();
            return temp.DeleteEntity(t);
        }
        public List<Enterprise_EnterpriseClass> getlistbyclassid(int enid)
        {
            IEnterprise_EnterpriseClassRepository temp = new Enterprise_EnterpriseClassRepository();
            return temp.LoadEntities(Enterprise_EnterpriseClass =>( Enterprise_EnterpriseClass.Enterprise_ID == enid)).ToList<Enterprise_EnterpriseClass>();

        }
       
      
    }
}
