using WizardSoftwareGroupsFramework.Core.DataAccess;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface IOperationClaimDal : IEntityRepository<OperationClaim>
    {
        OperationClaim GetByUserID(int id);
    }
    public interface IUserOperationClaimDal : IEntityRepository<UserOperationClaim>
    {

    }
}
