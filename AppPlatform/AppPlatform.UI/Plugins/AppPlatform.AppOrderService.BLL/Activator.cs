using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.AppOrderService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IAppOrderService>(new AppOrderService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
