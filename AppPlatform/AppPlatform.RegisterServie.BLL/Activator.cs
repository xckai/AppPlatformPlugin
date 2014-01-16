using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.RegisterServie.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IRegisterService>(new RegisterService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
