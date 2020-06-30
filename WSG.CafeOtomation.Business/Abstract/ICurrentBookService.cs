using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetByID(int id);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
    }
    public interface ISupplierService
    {
        IDataResult<List<Supplier>> GetAll();
        IDataResult<Supplier> GetByID(int id);
        IResult Add(Supplier supplier);
        IResult Update(Supplier supplier);
        IResult Delete(Supplier supplier);
    }
    public interface ICurrentBookService
    {
        IDataResult<List<CurrentBook>> GetAll();
        IDataResult<CurrentBook> GetByID(int id);
        IResult Add(CurrentBook currentBook);
        IResult Update(CurrentBook currentBook);
        IResult Delete(CurrentBook currentBook);
    }
    public interface ICurrentBookDetailService
    {
        IDataResult<List<CurrentBookDetail>> GetAll();
        IDataResult<CurrentBookDetail> GetByCurrentID(int id);
        IResult Add(CurrentBookDetail currentBookDetail);
        IResult Update(CurrentBookDetail currentBookDetail);
        IResult Delete(CurrentBookDetail currentBookDetail);
    }
}
