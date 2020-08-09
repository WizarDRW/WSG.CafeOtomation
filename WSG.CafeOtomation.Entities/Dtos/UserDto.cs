using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Entities.Dtos
{
    public class UserStuffDto
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public AccessAuth AccessAuth { get; set; }
    }
}
