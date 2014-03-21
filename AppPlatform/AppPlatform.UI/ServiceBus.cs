using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NServiceBus;
using NServiceBus.Installation.Environments;

namespace AppPlatform.UI
{
    public static class ServiceBus
    {
        public static IBus Bus { get; private set; }

        public static void Init()
        {
            if (Bus != null)
                return;

            lock (typeof(ServiceBus))
            {
                if (Bus != null)
                    return;

                Bus = Configure.With()
                    .DefineEndpointName("AppPlatform.UI")
                    .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("AppPlatform.Contracts.Commands."))
                    .DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("AppPlatform.Contracts.Events."))
                    .DefaultBuilder()
                    .UseTransport<Msmq>()
                    .PurgeOnStartup(true)
                    //.PurgeOnStartup(false)
                    .UnicastBus()
                    .CreateBus()
                    .Start(() => Configure.Instance.ForInstallationOn<Windows>().Install());
            }
        }

    }
}