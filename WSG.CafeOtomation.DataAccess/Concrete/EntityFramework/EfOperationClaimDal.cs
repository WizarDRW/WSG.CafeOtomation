using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfOperationClaimDal:EfEntityRepositoryBase<OperationClaim, CafeContext>, IOperationClaimDal
    {
    }
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, CafeContext>, IUserOperationClaimDal
    {
    }
}
