﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using WSG.CafeOtomation.Entities.Concrete;

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
        public OrderPayStatus OrderPayStatus { get; set; }
        [DisplayName("Müşteri")]
        public string Customer { get; set; }
    }
    public class OrderDetailsDto
    {
        [DisplayName("No")]
        public int ID { get; set; }
        [DisplayName("Sipariş No")]
        public int OrderID { get; set; }
        [DisplayName("Ürün")]
        public string Product { get; set; }
        [DisplayName("Adet")]
        public int Amount { get; set; }
        [DisplayName("Toplam")]
        public decimal TotalPrice { get; set; }
        [DisplayName("Sipariş Durumu")]
        public OrderStatus EOrderStatus { get; set; }
        [DisplayName("Ödeme Tipi")]
        public PayType PayType { get; set; }
        [DisplayName("Ürün No")]
        public int ProductID { get; set; }
        [DisplayName("Sipariş Oluşturulma Zamanı")]
        public DateTime CreateTime { get; set; }
    }
    public class OrderAllDetailsDto
    {
        [DisplayName("Sipariş Numarası")]
        public int ID { get; set; }
        [DisplayName("Fiş Numarası")]
        public int OrderNo { get; set; }
        [DisplayName("Ürün")]
        public string Product { get; set; }
        [DisplayName("Masa")]
        public string DeskNo { get; set; }
        [DisplayName("Adet")]
        public int Amount { get; set; }
        [DisplayName("Toplam")]
        public decimal TotalPrice { get; set; }
        [DisplayName("Sipariş Durumu")]
        public OrderStatus EOrderStatus { get; set; }
        [DisplayName("Sipariş Oluşturulma Zamanı")]
        public string CreateTime { get; set; }
    }
    public class CustomerOrderCreateDto
    {
        public int Amount { get; set; }
        public int ProductID { get; set; }
        public List<int> ProductTypes { get; set; }
        public string DeskUniqueId { get; set; }
    }
    public class OrderDetailTypeDto
    {
        public int ID { get; set; }
        [DisplayName("Adet")]
        public int Count { get; set; }
        [DisplayName("Ürün Tipi")]
        public string ProductType { get; set; }
    }
    public class OrderPaymentDto
    {
        public int Amount { get; set; }
        public string PayType { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
