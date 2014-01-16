using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.LoginService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<ILoginService>(new LoginService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
