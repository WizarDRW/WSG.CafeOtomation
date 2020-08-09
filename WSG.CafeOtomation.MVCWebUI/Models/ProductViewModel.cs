using System.Collections.Generic;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.MVCWebUI.Models
{
    public class ProductViewModel
    {
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
