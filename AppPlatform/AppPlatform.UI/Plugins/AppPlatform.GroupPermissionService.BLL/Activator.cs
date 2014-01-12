using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.GroupPermissionService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IGroupPermissionService>(new GroupPermissionService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
