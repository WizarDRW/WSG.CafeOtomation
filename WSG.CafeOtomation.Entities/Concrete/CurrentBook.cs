using System;
using System.Collections.Generic;
using System.Text;
using WizardSoftwareGroupsFramework.Core.Entities;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
    }
    public class Supplier : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
    }
    public class CurrentBook : IEntity
    {
        public int ID { get; set; }
        public string CurrentNo { get; set; }
    }

    public class CurrentBookDetail : IEntity
    {
        public int ID { get; set; }
        public int CurrentBookID { get; set; }
        public CurrentBook CurrentBook { get; set; }
        public decimal Payee { get; set; }
        public decimal Debtor { get; set; }
        public decimal Balance { get; set; }
    }
}
