using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.UserInformationService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<IUserInfoService>(new UserInfoService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
