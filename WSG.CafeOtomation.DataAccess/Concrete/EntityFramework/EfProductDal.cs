using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfProductCategoryDal : EfEntityRepositoryBase<ProductCategory, CafeContext>, IProductCategoryDal
    {
    }
    public class EfProductDal : EfEntityRepositoryBase<Product, CafeContext>, IProductDal
    {
        public List<ProductDto> GetProductDtoList(Expression<Func<Product, bool>> filter)
        {
            using (CafeContext context = new CafeContext())
            {
                return filter == null ?
                    (from p in context.Products
                     join pC in context.ProductCategories
                     on p.ProductCategoryID equals pC.ID
                     select new ProductDto
                     {
                         ID = p.ID,
                         Name = p.Name,
                         Description = p.Description,
                         Amount = p.StockAmount,
                         UnitPrice = p.UnitPrice,
                         CategoryName = pC.Name,
                         ProductImages = p.ProductImages,
                         Minute = p.OrderDetails.Sum(x => x.OrderDetailTimeLogs.Count) <= 0 ? 0 : (p.OrderDetails.Sum(x => x.OrderDetailTimeLogs.Sum(c =>c.Minute)) / p.OrderDetails.Sum(x => x.OrderDetailTimeLogs.Count))
                     }).ToList()
                    :
                    (from p in context.Products.Where(filter)
                     join pC in context.ProductCategories
                     on p.ProductCategoryID equals pC.ID
                     select new ProductDto
                     {
                         ID = p.ID,
                         Name = p.Name,
                         Description = p.Description,
                         Amount = p.StockAmount,
                         UnitPrice = p.UnitPrice,
                         CategoryName = pC.Name,
                         ProductImages = p.ProductImages,
                         Minute = p.OrderDetails.Sum(x => x.OrderDetailTimeLogs.Count) <= 0 ? 0 : (p.OrderDetails.Sum(x => x.OrderDetailTimeLogs.Sum(c => c.Minute)) / p.OrderDetails.Sum(x => x.OrderDetailTimeLogs.Count))
                     }).ToList();
            }
        }
    }
    public class EfProductTypeDal:EfEntityRepositoryBase<ProductType, CafeContext>, IProductTypeDal
    {

    }
    public class EfProductImageDal : EfEntityRepositoryBase<ProductImage, CafeContext>, IProductImageDal
    {
    }
    public class EfProductDetailDal : EfEntityRepositoryBase<ProductDetail, CafeContext>, IProductDetailDal
    {
    }
}
