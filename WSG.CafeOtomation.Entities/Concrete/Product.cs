using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WizardSoftwareGroupsFramework.Core.Entities;

namespace WSG.CafeOtomation.Entities.Concrete
{
    public class ProductCategory : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string IconPath { get; set; }
        public int Order { get; set; }
        public int ParentID { get; set; }
        public ProductCategory Parent { get; set; }
    }
    public class Product:IEntity
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ürün Stok Adeti")]
        public int StockAmount { get; set; }
        [DisplayName("Satış Fiyatı")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Ürün Kategorisi")]
        public int ProductCategoryID { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
    public class ProductImage : IEntity
    {
        [Key]
        public int ID { get; set; }
        public string Path { get; set; }
        public bool IsCover { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
    public class ProductDetail : IEntity
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
