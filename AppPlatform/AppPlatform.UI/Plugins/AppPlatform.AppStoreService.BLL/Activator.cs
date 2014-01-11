using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.AppStoreService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IAppstoreService>(new AppStoreService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
