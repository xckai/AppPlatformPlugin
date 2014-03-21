using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using AppPlatform.Contracts.Commands.RegistryService;

namespace AppPlatform.Backend.RegistryService
{
    public class UserCreator : IHandleMessages<CreateNewUserWithVerifiedEmailCmd>
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserCreator));

        public void Handle(CreateNewUserWithVerifiedEmailCmd message)
        {
            /*
            string username = "abcd";//随机生成用户名
            string password = "123456";//初始化默认密码
            log.InfoFormat("Creating user '{0}' with email {1}",
                username,
                message.EmailAddress);
             * */
        }
    }
}
