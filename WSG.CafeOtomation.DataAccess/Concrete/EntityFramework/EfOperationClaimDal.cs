using System.Linq;
using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, CafeContext>, IOperationClaimDal
    {
        public OperationClaim GetByUserID(int id)
        {
            using (CafeContext context = new CafeContext())
            {
                return (from o in context.OperationClaims
                        join uO in context.UserOperationClaims
                        on o.ID equals uO.OperationClaimID
                        where uO.UserID == id
                        select new OperationClaim { ID = o.ID, Name = o.Name }).SingleOrDefault();
            }
        }
    }
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, CafeContext>, IUserOperationClaimDal
    {
    }
}
