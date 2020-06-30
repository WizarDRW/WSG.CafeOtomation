using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IOperationClaimService
    {
        IDataResult<List<OperationClaim>> GetAll();
        IDataResult<OperationClaim> GetByID(int id);
        IDataResult<OperationClaim> GetByName(string name);
        IResult Add(OperationClaim operationClaim);
        IResult Update(OperationClaim operationClaim);
        IResult Delete(OperationClaim operationClaim);
    }
}
