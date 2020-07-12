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
    public interface IUserTitleService
    {
        IDataResult<List<UserTitle>> GetAll();
        IDataResult<UserTitle> GetByID(int id);
        IDataResult<UserTitle> GetByUserID(int id);
        IResult Add(UserTitle title);
        IResult Update(UserTitle title);
        IResult Delete(UserTitle title);
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
