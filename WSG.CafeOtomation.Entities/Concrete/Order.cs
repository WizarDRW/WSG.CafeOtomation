using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using WizardSoftwareGroupsFramework.Core.Entities;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Extensions;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
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
        [Key]
        public int ID { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public OrderStatus EOrderStatus { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public DateTime CreateDate { get; set; }
        public int? CreateUserID { get; set; }
        public DateTime? UpdateDate{ get; set; }
        public int? UpdateUserID { get; set; }
    }
    public class OrderDetailTimeLog:IEntity
    {
        public int ID { get; set; }
        public int OrderDetailID { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Minute { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
    [TypeConverter(typeof(ExpectationResultConverter))]
    public enum OrderStatus
    {
        [Description("Bekliyor!")]
        Waiting = 0,
        [Description("Hazırlanıyor!")]
        Prepares = 1,
        [Description("Garsonda!")]
        AtWaiters = 2,
        [Description("Tamamlandı!")]
        Complete = 3,
    }
}
