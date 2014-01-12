using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.EnterpriseMenuService.bll
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IEnterpriseMenuService>(new EnterpriseMenuService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
