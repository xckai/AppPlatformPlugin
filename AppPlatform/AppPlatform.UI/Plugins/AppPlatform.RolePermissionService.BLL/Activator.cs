using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.RolePermissionService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IRolePermissionService>(new UserPermissionService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
