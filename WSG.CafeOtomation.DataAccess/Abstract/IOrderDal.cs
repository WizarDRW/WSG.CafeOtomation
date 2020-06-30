using WizardSoftwareGroupsFramework.Core.DataAccess;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
    }
    public interface IOrderDetailDal:IEntityRepository<OrderDetail>
    {

    }
}
