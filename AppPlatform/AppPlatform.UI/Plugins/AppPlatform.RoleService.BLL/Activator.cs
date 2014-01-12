using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.RoleService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IRoleService>(new RoleService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
