using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlatform.Contracts.Commands.RegistryService
{
    public class SendVerificationEmailCmd
    {
        public string EmailAddress { get; set; }
        public string VerificationCode { get; set; }
        public bool IsReminder { get; set; }
    }
}
