using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.UserPermissionService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IUserPermissionService>(new UserPermissionService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
