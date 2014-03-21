using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using NServiceBus.Saga;
using AppPlatform.Contracts.Commands.RegistryService;
using NServiceBus.Logging;
using AppPlatform.RegisterServie.BLL;

namespace AppPlatform.Backend.RegistryService
{
    public class VerifyUserEmailPolicy : Saga<VerifyUserEmailPolicyData>,
        IAmStartedByMessages<CreateNewUserCmd>,
        IHandleMessages<UserVerifyingEmailCmd>,
        IHandleTimeouts<VerifyUserEmailReminderTimeout>,
        IHandleTimeouts<VerifyUserEmailExpiredTimeout>
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(VerifyUserEmailPolicy));

        public override void ConfigureHowToFindSaga()
        {
            this.ConfigureMapping<CreateNewUserCmd>(msg => msg.EmailAddress).ToSaga(data => data.EmailAddress);
            this.ConfigureMapping<UserVerifyingEmailCmd>(msg => msg.EmailAddress).ToSaga(data => data.EmailAddress);
        }

        public void Handle(CreateNewUserCmd message)
        {
            this.Data.EnterpriseId = message.EnterpriseId;
            this.Data.EmailAddress = message.EmailAddress;
            this.Data.VerificationCode = Guid.NewGuid().ToString("n").Substring(0, 4);

            Bus.Send(new SendVerificationEmailCmd
            {
                EmailAddress = message.EmailAddress,
                VerificationCode = Data.VerificationCode,
                IsReminder = false
            });

            //第一次发送验证邮件后两天内未完成验证，则重新发送验证邮件
            this.RequestTimeout<VerifyUserEmailReminderTimeout>((TimeSpan.FromDays(2)));
            //第二次发送验证邮件后七天内为完成验证，则结束Saga
            this.RequestTimeout<VerifyUserEmailExpiredTimeout>((TimeSpan.FromDays(7)));
        }

        public void Handle(UserVerifyingEmailCmd message)
        {
            if (message.EmailAddress == Data.EmailAddress && message.VerificationCode == Data.VerificationCode)
            {
                /*
                Bus.Send(new CreateNewUserWithVerifiedEmailCmd
                {
                    EmailAddress = message.EmailAddress
                });
                */
                //更新数据库



                //IRegisterService _registerService = new RegisterService();
                //_registerService.UpdateCheck(this.Data.EnterpriseId);

                log.InfoFormat("Enterprise {2} Email '{0}' with code {1}",
                message.EmailAddress, message.VerificationCode, this.Data.EnterpriseId);
                Bus.Return(this.Data.EnterpriseId);
                this.MarkAsComplete();
            }
            else
                Bus.Return(0);
        }

        public void Timeout(VerifyUserEmailReminderTimeout state)
        {
            //两天内没有完成验证则重新发送一封验证邮件
            Bus.Send(new SendVerificationEmailCmd
            {
                EmailAddress = Data.EmailAddress,
                VerificationCode = Data.VerificationCode,
                IsReminder = true
            });
        }

        public void Timeout(VerifyUserEmailExpiredTimeout state)
        {
            //在重新发送验证邮件后七天内未完成验证则结束Saga
            this.MarkAsComplete();
        }
    }

    public class VerifyUserEmailPolicyData : ContainSagaData
    {
        public int EnterpriseId { get; set; }
        [Unique]
        public string EmailAddress { get; set; }
        public string VerificationCode { get; set; }
    }

    public class VerifyUserEmailReminderTimeout 
    {

    }

    public class VerifyUserEmailExpiredTimeout 
    {

    }
}
