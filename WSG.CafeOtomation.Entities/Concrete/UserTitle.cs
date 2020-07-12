using System.ComponentModel;
using WizardSoftwareGroupsFramework.Core.Entities;
using WizardSoftwareGroupsFramework.Core.Extensions;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class UserTitle : IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TitleID { get; set; }
        public AccessAuth AccessAuth { get; set; }
    }
    public class Title : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    [TypeConverter(typeof(ExpectationResultConverter))]
    public enum AccessAuth
    {
        [Description("Sistem Yöneticisi")]
        Admin = 0,
        [Description("IT")]
        ICT = 1,
        [Description("Yönetici")]
        Manager = 2,
        [Description("Muhasebeci")]
        Accountant = 3,
        [Description("Şef/Barista")]
        Chef = 4,
        [Description("Garson")]
        Waiter = 5,
        [Description("Personel")]
        Staff = 6
    }
}
