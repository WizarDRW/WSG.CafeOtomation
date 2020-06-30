using WizardSoftwareGroupsFramework.Core.Entities;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class Desk : IEntity
    {
        public int ID { get; set; }
        public string DeskNo { get; set; }
        public string UniqueIdentifier { get; set; }
        public bool IsActive { get; set; }
    }
}
