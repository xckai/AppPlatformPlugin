using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.GroupService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IGroupService>(new GroupService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
