using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.EnterpriseInfoService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IEnterpriseInfoService>(new EnterpriseInfoService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
