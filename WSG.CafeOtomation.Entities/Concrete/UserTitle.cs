using WizardSoftwareGroupsFramework.Core.Entities;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class UserTitle:IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TitleID { get; set; }
    }
    public class Title:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
