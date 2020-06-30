using System;
using System.Collections.Generic;
using System.Text;
using WizardSoftwareGroupsFramework.Core.Entities;

namespace WSG.CafeOtomation.Entities.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
