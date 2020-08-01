using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface IProductCategoryDal : IEntityRepository<ProductCategory>
    {
    }
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDto> GetProductDtoList(Expression<Func<Product, bool>> filter = null);
    }
    public interface IProductTypeDal : IEntityRepository<ProductType>
    {

    }
    public interface IProductImageDal : IEntityRepository<ProductImage>
    {
    }
    public interface IProductDetailDal : IEntityRepository<ProductDetail>
    {
    }
}
