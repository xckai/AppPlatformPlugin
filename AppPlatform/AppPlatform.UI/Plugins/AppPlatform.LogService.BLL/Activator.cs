using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.LogService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<ILogService>(new LogService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
