using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IDeskService
    {
        IDataResult<List<Desk>> GetAll(Expression<Func<Desk, bool>> filter = null);
        IDataResult<Desk> GetByNo(string no);
        IDataResult<Desk> GetByUnique(string uniqueId);
        IResult Add(Desk desk);
        IResult Update(Desk desk);
        IResult Delete(Desk desk);
    }
}
