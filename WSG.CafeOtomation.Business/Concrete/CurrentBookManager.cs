using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList());
        }

        public IDataResult<Customer> GetByID(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(x => x.ID == id));
        }
    }
    public class SupplierManager : ISupplierService
    {
        private ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }
        public IResult Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Supplier>> GetAll()
        {
            return new SuccessDataResult<List<Supplier>>(_supplierDal.GetList());
        }

        public IDataResult<Supplier> GetByID(int id)
        {
            return new SuccessDataResult<Supplier>(_supplierDal.Get(x => x.ID == id));
        }
    }
    public class CurrentBookManager : ICurrentBookService
    {
        private ICurrentBookDal _currentBookDal;
        public CurrentBookManager(ICurrentBookDal currentBookDal)
        {
            _currentBookDal = currentBookDal;
        }
        public IResult Add(CurrentBook currentBook)
        {
            _currentBookDal.Add(currentBook);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(CurrentBook currentBook)
        {
            _currentBookDal.Update(currentBook);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(CurrentBook currentBook)
        {
            _currentBookDal.Delete(currentBook);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CurrentBook>> GetAll()
        {
            return new SuccessDataResult<List<CurrentBook>>(_currentBookDal.GetList());
        }

        public IDataResult<CurrentBook> GetByID(int id)
        {
            return new SuccessDataResult<CurrentBook>(_currentBookDal.Get(x => x.ID == id));
        }
    }
    public class CurrentBookDetailManager : ICurrentBookDetailService
    {
        private ICurrentBookDetailDal _currentBookDetailDal;
        public CurrentBookDetailManager(ICurrentBookDetailDal currentBookDetailDal)
        {
            _currentBookDetailDal = currentBookDetailDal;
        }
        public IResult Add(CurrentBookDetail currentBookDetail)
        {
            _currentBookDetailDal.Add(currentBookDetail);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(CurrentBookDetail currentBookDetail)
        {
            _currentBookDetailDal.Update(currentBookDetail);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(CurrentBookDetail currentBookDetail)
        {
            _currentBookDetailDal.Delete(currentBookDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CurrentBookDetail>> GetAll()
        {
            return new SuccessDataResult<List<CurrentBookDetail>>(_currentBookDetailDal.GetList());
        }

        public IDataResult<CurrentBookDetail> GetByCurrentID(int id)
        {
            return new SuccessDataResult<CurrentBookDetail>(_currentBookDetailDal.Get(x => x.CurrentBookID == id));
        }
    }
}
