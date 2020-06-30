using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WSG.CafeOtomation.Entities.Dtos
{
    public class ProductDto
    {
        [DisplayName("Ürün Numarası")]
        public int ID { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Ürün Stok Adeti")]
        public int Amount { get; set; }
        [DisplayName("Ürün Kategorisi")]
        public string CategoryName { get; set; }

    }
}
