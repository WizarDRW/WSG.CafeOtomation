using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        List<OperationClaim> GetClaims(User user);
        IDataResult<User> GetByID(int id);
        User GetByUserName(string userName);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
    public interface ITitleService
    {
        IDataResult<List<Title>> GetAll();
        IDataResult<Title> GetByID(int id);
        IDataResult<Title> GetByName(string name);
        IResult Add(Title title);
        IResult Update(Title title);
        IResult Delete(Title title);
    }
}
