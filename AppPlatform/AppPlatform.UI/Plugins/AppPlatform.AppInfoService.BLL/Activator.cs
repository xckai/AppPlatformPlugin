using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.AppInfoService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IAppInfoService>(new AppInfoService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
