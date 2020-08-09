using WizardSoftwareGroupsFramework.Core.DataAccess;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
    public interface ISupplierDal : IEntityRepository<Supplier>
    {
    }
    public interface ICurrentBookDal : IEntityRepository<CurrentBook>
    {
    }
    public interface ICurrentBookDetailDal : IEntityRepository<CurrentBookDetail>
    {
    }
}
