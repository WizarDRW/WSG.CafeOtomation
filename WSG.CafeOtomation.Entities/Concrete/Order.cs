using System;
using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Entities;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class Order : IEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get { return DateTime.Now; } }
        public int? CreateUserID { get; set; }
        public User CreateUser { get; set; }
        public int? UpdateUserID { get; set; }
        public User UpdateUser { get; set; }
        public int DeskID { get; set; }
        public Desk Desk { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Paid { get; set; }
        public decimal Change { get; set; }
        public bool IsClose { get; set; }
        public int? CurrentBookID { get; set; }
        public CurrentBook CurrentBook { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
    public class OrderDetail : IEntity
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
