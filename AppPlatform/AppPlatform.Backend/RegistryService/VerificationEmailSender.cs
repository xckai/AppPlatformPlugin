using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using AppPlatform.Contracts.Commands.RegistryService;
using AppplatformCommon.MailHelper;

namespace AppPlatform.Backend.RegistryService
{
    public class VerificationEmailSender : IHandleMessages<SendVerificationEmailCmd>
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(VerificationEmailSender));

        public void Handle(SendVerificationEmailCmd message)
        {
            // Send Email 
            if (message.IsReminder)
            {
                log.InfoFormat("Send reminder email to {0} with verification code {1}",
                    message.EmailAddress, message.VerificationCode);
            }
            else
            {
                log.InfoFormat("Send original email to {0} with verification code {1}",
                    message.EmailAddress, message.VerificationCode);
            }

            //发送激活邮件
            MailHelper mail = new MailHelper();
            string mailTo = message.EmailAddress;
            string code = message.VerificationCode;
            string url = string.Format("http://localhost:25057/Authen/index?email={0}&code={1}", mailTo, code);
            mail.ActivateMail(url, mailTo);
        }
    }
}
