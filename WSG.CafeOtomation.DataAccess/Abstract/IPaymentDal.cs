using WizardSoftwareGroupsFramework.Core.DataAccess;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface IPaymentDal:IEntityRepository<Payment>
    {
    }
    public interface IPaymentDetailDal : IEntityRepository<PaymentDetail>
    {
    }
}
