using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WSG.CafeOtomation.Entities.Dtos
{
    public class OrderDto
    {
        [DisplayName("Sipariş Numarası")]
        public int ID { get; set; }
        [DisplayName("Sipariş Tarihi")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Sipariş Alan")]
        public string CreateUser { get; set; }
        [DisplayName("Masa")]
        public string DeskNo { get; set; }
        [DisplayName("Toplam Tutar")]
        public decimal TotalPrice { get; set; }
        [DisplayName("Ödenen Tutar")]
        public decimal Paid { get; set; }
        [DisplayName("Para Üstü")]
        public decimal Change { get; set; }
        [DisplayName("Satış Durumu")]
        public bool IsClose { get; set; }
        [DisplayName("Müşteri")]
        public string Customer { get; set; }
    }
    public class OrderDetailsDto
    {
        [DisplayName("No")]
        public int ID { get; set; }
        [DisplayName("Ürün")]
        public string Product { get; set; }
        [DisplayName("Adet")]
        public int Amount { get; set; }
        [DisplayName("Toplam")]
        public decimal TotalPrice { get; set; }
        [DisplayName("Sipariş Durumu")]
        public bool IsComplete { get; set; }
    }
}
