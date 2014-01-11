using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.UserAccountService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IUserAccountService>(new UserAccountService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
