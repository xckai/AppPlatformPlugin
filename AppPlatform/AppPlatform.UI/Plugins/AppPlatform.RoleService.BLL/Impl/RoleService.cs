using System;
using System.Collections.Generic;
using System.Text;
using AppPlatform.DAL;
using AppPlatform.IDAL;
using AppPlatform.Model;
using System.Linq;
using AppPlatform.Model.Models;

namespace AppPlatform.RoleService.BLL
{
    public class RoleService : IRoleService
    {


        public List<Model.Models.Role> RoleGet(int enterpriseID)
        {
            IRoleRepository _roleRepository = RepositoryFactory.RoleRepository;
            List<Role> rolelist = _roleRepository.LoadEntities(Role => Role.Enterprise_ID == enterpriseID).ToList<Role>();
            return rolelist;
        }

        public bool RoleAdd(Model.Models.Role role)
        {
            IRoleRepository _roleRepository = RepositoryFactory.RoleRepository;
            return  _roleRepository.AddEntity(role);
            
        }

        public bool RoleDelete(int RoleID)
        {
            IRoleRepository _roleRepository = RepositoryFactory.RoleRepository;
            Role role = _roleRepository.LoadEntities(Role => Role.Role_ID == RoleID).FirstOrDefault();
            return _roleRepository.DeleteEntity(role);
            
        }

        public bool RoleUpdate(Model.Models.Role role)
        {
            IRoleRepository _roleRepository = RepositoryFactory.RoleRepository;
            return _roleRepository.UpdateEntity(role);
        }
    }
}
