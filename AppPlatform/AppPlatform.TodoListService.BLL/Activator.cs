using System;
using System.Collections.Generic;
using System.Text;
using UIShell.OSGi;

namespace AppPlatform.TodoListService.BLL
{
    public class Activator : IBundleActivator
    {
        public void Start(IBundleContext context)
        {
            context.AddService<ITodoListService>(new TodoListService());
        }

        public void Stop(IBundleContext context)
        {
            //todo:
        }
    }
}
