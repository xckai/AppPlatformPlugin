using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.UserRoleService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IUserRoleService>(new UserRoleService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
