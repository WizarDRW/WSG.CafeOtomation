using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class ProductCategoryManager : IProductCategoryService
    {
        private IProductCategoryDal _productCategoryDal;
        public ProductCategoryManager(IProductCategoryDal productCategoryDal)
        {
            _productCategoryDal = productCategoryDal;
        }
        public IResult Add(ProductCategory productCategory)
        {
            _productCategoryDal.Add(productCategory);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(ProductCategory productCategory)
        {
            _productCategoryDal.Update(productCategory);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(ProductCategory productCategory)
        {
            _productCategoryDal.Delete(productCategory);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ProductCategory>> GetAll()
        {
            return new SuccessDataResult<List<ProductCategory>>(_productCategoryDal.GetList());
        }

        public IDataResult<ProductCategory> GetByID(int id)
        {
            return new SuccessDataResult<ProductCategory>(_productCategoryDal.Get(x => x.ID == id));
        }

        public IDataResult<ProductCategory> GetByName(string name)
        {
            return new SuccessDataResult<ProductCategory>(_productCategoryDal.Get(x => x.Name == name));
        }
    }
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(ProductMessages.Added);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(product.ID + ProductMessages.Updated);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(product.ID + ProductMessages.Deleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList());
        }

        public IDataResult<List<ProductDto>> GetByCategory(int id)
        {
            return new SuccessDataResult<List<ProductDto>>(_productDal.GetProductDtoList(x => x.ProductCategoryID == id));
        }

        public IDataResult<Product> GetByID(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.ID == id));
        }

        public IDataResult<Product> GetByName(string name)
        {
            return new SuccessDataResult<Product>(_productDal.Get(x => x.Name == name));
        }
    }
    public class ProductTypeManager : IProductTypeService
    {
        private IProductTypeDal _productTypeDal;
        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }

        public IResult Add(ProductType productType)
        {
            _productTypeDal.Add(productType);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(ProductType productType)
        {
            _productTypeDal.Update(productType);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(ProductType productType)
        {
            _productTypeDal.Delete(productType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ProductType>> GetAll(Expression<Func<ProductType, bool>> filter = null)
        {
            return new SuccessDataResult<List<ProductType>>(_productTypeDal.GetList(filter));
        }

        public IDataResult<ProductType> GetByID(int id)
        {
            return new SuccessDataResult<ProductType>(_productTypeDal.Get(x => x.ID == id));
        }

        public IDataResult<List<ProductType>> GetByProduct(int id)
        {
            return new SuccessDataResult<List<ProductType>>(_productTypeDal.GetList(x => x.ProductID == id));
        }
    }
    public class ProductImageManager : IProductImageService
    {
        private IProductImageDal _productImageDal;
        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }
        public IResult Add(ProductImage productImage)
        {
            _productImageDal.Add(productImage);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(ProductImage productImage)
        {
            _productImageDal.Update(productImage);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(ProductImage productImage)
        {
            _productImageDal.Delete(productImage);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetList());
        }

        public IDataResult<ProductImage> GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<ProductImage>> GetByProduct(int id)
        {
            return new SuccessDataResult<List<ProductImage>>(_productImageDal.GetList(x => x.ProductID == id));
        }
    }
    public class ProductDetailManager : IProductDetailService
    {
        private IProductDetailDal _productDetailDal;
        public ProductDetailManager(IProductDetailDal productDetailDal)
        {
            _productDetailDal = productDetailDal;
        }
        public IResult Add(ProductDetail productDetail)
        {
            _productDetailDal.Add(productDetail);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(ProductDetail productDetail)
        {
            _productDetailDal.Update(productDetail);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(ProductDetail productDetail)
        {
            _productDetailDal.Delete(productDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ProductDetail>> GetAll()
        {
            return new SuccessDataResult<List<ProductDetail>>(_productDetailDal.GetList());
        }

        public IDataResult<ProductDetail> GetByID(int id)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<List<ProductDetail>> GetByProductID(int id)
        {
            return new SuccessDataResult<List<ProductDetail>>(_productDetailDal.GetList(x => x.ProductID == id));
        }
    }
}
