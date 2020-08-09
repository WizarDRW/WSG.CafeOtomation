using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CafeContext>, ICustomerDal
    {
    }
    public class EfSupplierDal : EfEntityRepositoryBase<Supplier, CafeContext>, ISupplierDal
    {
    }
    public class EfCurrentBookDal : EfEntityRepositoryBase<CurrentBook, CafeContext>, ICurrentBookDal
    {
    }
    public class EfCurrentBookDetailDal : EfEntityRepositoryBase<CurrentBookDetail, CafeContext>, ICurrentBookDetailDal
    {
    }
}
