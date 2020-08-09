using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfPaymentDal : EfEntityRepositoryBase<Payment, CafeContext>, IPaymentDal
    {
    }
    public class EfPaymentDetailDal : EfEntityRepositoryBase<PaymentDetail, CafeContext>, IPaymentDetailDal
    {
    }
}
