using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlatform.Contracts.Commands.RegistryService
{
    public class CreateNewUserCmd
    {
        public int EnterpriseId { get; set; }
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
    }
}
