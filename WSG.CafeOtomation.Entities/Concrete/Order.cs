using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        [DisplayName("Toplam Tutar")]
        public decimal TotalPrice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<OrderPayment> OrderPayments { get; set; }
        public OrderPayStatus OrderPayStatus { get; set; }
    }
    [TypeConverter(typeof(ExpectationResultConverter))]
    public enum OrderPayStatus
    {
        [Description("Açık Masa")]
        [Display(Name = "Açık Masa")]
        Open = 0,
        [Description("Müşteri")]
        [Display(Name = "Müşteri")]
        Customer = 1,
        [Description("Ödendi")]
        [Display(Name = "Ödendi")]
        Paid = 2
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
        public DateTime? UpdateDate { get; set; }
        public int? UpdateUserID { get; set; }
        public int? CurrentBookID { get; set; }
        public CurrentBook CurrentBook { get; set; }
        public List<OrderDetailTimeLog> OrderDetailTimeLogs { get; set; }
        public List<OrderDetailType> OrderDetailTypes { get; set; }
    }
    public class OrderDetailType : IEntity
    {
        public int ID { get; set; }
        public int OrderDetailID { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public int ProductTypeID { get; set; }
        public ProductType ProductType { get; set; }
    }
    public class OrderDetailTimeLog : IEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int OrderDetailID { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal Minute { get; set; }
        public decimal Second { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
    [TypeConverter(typeof(ExpectationResultConverter))]
    public enum OrderStatus
    {
        [Description("Bekliyor!")]
        [Display(Name = "Bekliyor!")]
        Waiting = 0,
        [Description("Hazırlanıyor!")]
        [Display(Name = "Hazırlanıyor!")]
        Prepares = 1,
        [Description("Garsonda!")]
        [Display(Name = "Garsonda!")]
        AtWaiters = 2,
        [Description("Tamamlandı!")]
        [Display(Name = "Tamamlandı!")]
        Complete = 3,
    }
    public class PayType : IEntity
    {
        public int ID { get; set; }
        [Description("Ödeme Tipi")]
        [Display(Name = "Ödeme Tipi")]
        public string Name { get; set; }
    }

    public class OrderPayment : IEntity
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int PayTypeID { get; set; }
        public PayType PayType { get; set; }
        public decimal Value { get; set; }
        public decimal Balance { get; set; }
    }
}
