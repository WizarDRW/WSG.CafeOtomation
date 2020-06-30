using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order, CafeContext>, IOrderDal
    {
    }
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail, CafeContext>, IOrderDetailDal
    {
    }
}
