using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.UserGuopService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IUserGruopService>(new UserGroupService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
