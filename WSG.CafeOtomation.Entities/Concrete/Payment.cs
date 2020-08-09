using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Entities;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class Payment : IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public decimal Salary { get; set; }
        public string Description { get; set; }
        public List<PaymentDetail> PaymentDetails { get; set; }
    }
    public class PaymentDetail : IEntity
    {
        public int ID { get; set; }
        public int PaymentID { get; set; }
        public Payment Payment { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Paid { get; set; }
        public decimal Balance { get; set; }
    }
}
