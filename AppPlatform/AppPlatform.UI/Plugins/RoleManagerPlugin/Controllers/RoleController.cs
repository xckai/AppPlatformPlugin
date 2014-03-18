using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppPlatform.RoleService.BLL;
using AppPlatform.Model.Models;
using AppPlatform.IDAL;
using AppPlatform.DAL;

namespace EnterpriseManagerPlugin.Controllers
{
    public class RoleController : Controller
    {
        //
        // GET: /Role/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUserRoleJson()
        {
            IRoleService _roleService = new RoleService();
            int enterpriseID = Convert.ToInt32(Session["EnterpriseAccount"]);
            var RoleList = _roleService.RoleGet(enterpriseID);
           if (RoleList.Count()==0)
           {
            Role role = new Role();
            role.Role_Name = "Null";
            role.Role_Description = "Null";
            role.Role_Option = "Null";
            RoleList.Add(role);
           }
            var jsonResult = new { total = RoleList.Count(), rows = RoleList };
            return Json(jsonResult,JsonRequestBehavior.AllowGet);
        }
        public bool AddNewRole()
        {
            Role role = new Role();
            role.Enterprise_ID = Convert.ToInt32(Session["EnterpriseAccount"]);
            role.Role_Name = Request.Form["newrolename"];
            role.Role_Description = Request.Form["newdescribe"];
            role.Role_Option = Request.Form["newinfo"];
            IRoleService _roleService = new RoleService();
            return  _roleService.RoleAdd(role);
        }

        public bool SaveRoleEdit(int id)
        {
            int roleid = id;
            IRoleRepository _roleRepository = RepositoryFactory.RoleRepository;
            Role role = _roleRepository.LoadEntities(Role => Role.Role_ID == roleid).FirstOrDefault();
            role.Role_Name = Request.Form["Role_Name"];
            role.Role_Description = Request.Form["Role_Description"];
            role.Role_Option = Request.Form["Role_Option"];
            IRoleService _roleService = new RoleService();
            return _roleService.RoleUpdate(role);
        
        }

    }
}
