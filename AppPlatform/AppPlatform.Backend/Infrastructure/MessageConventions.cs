using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace AppPlatform.Backend.Infrastructure
{
    public class MessageConventions : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
                .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("AppPlatform.Contracts.Commands."))
                .DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("AppPlatform.Contracts.Events."));
        }
    }
}
