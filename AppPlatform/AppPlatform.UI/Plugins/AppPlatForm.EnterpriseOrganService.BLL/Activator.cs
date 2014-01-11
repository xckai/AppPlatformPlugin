using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatForm.EnterpriseOrganService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IEnterpriseOrganService>(new EnterpriseOrganService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
