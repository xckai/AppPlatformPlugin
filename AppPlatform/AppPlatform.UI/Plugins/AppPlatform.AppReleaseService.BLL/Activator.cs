using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.AppReleaseService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IAppReleaseService>(new AppReleaseService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
