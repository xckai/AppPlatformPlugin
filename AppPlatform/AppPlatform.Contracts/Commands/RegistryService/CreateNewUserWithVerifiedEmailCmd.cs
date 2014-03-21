using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlatform.Contracts.Commands.RegistryService
{
    public class CreateNewUserWithVerifiedEmailCmd
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
