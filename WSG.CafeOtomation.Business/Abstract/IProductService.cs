﻿using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IProductCategoryService
    {
        IDataResult<List<ProductCategory>> GetAll();
        IDataResult<ProductCategory> GetByID(int id);
        IDataResult<ProductCategory> GetByName(string name);
        IResult Add(ProductCategory productCategory);
        IResult Update(ProductCategory productCategory);
        IResult Delete(ProductCategory productCategory);
    }
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDto>> GetByCategory(int id);
        IDataResult<Product> GetByID(int id);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
    public interface IProductImageService
    {
        IDataResult<List<ProductImage>> GetAll();
        IDataResult<List<ProductImage>> GetByProduct(int id);
        IDataResult<ProductImage> GetByID(int id);
        IResult Add(ProductImage productImage);
        IResult Update(ProductImage productImage);
        IResult Delete(ProductImage productImage);
    }
    public interface IProductDetailService
    {
        IDataResult<List<ProductDetail>> GetAll();
        IDataResult<List<ProductDetail>> GetByProductID(int id);
        IDataResult<ProductDetail> GetByID(int id);
        IResult Add(ProductDetail productDetail);
        IResult Update(ProductDetail productDetail);
        IResult Delete(ProductDetail productDetail);
    }
}