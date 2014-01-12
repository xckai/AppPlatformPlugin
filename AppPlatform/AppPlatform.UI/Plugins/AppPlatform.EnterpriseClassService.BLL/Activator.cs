using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.EnterpriseClassService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IEnterpriseClassService>(new EnterpriseClassService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
