using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserStuffDto>> GetAllStuff(Expression<Func<UserStuffDto, bool>> filter = null);
        List<OperationClaim> GetClaims(User user);
        IDataResult<User> GetByID(int id);
        User GetByUserName(string userName);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
    }
    public interface IUserEntryService
    {
        IDataResult<List<UserEntry>> GetAll();
        IDataResult<List<UserEntry>> GetAllByUserID(Expression<Func<UserEntry, bool>> filter = null);
        IDataResult<UserEntry> GetByID(int id);
        IResult Add(UserEntry userEntry);
        IResult Update(UserEntry userEntry);
        IResult Delete(UserEntry userEntry);
    }
    public interface IUserTitleService
    {
        IDataResult<List<UserTitle>> GetAll();
        IDataResult<UserTitle> GetByID(int id);
        IDataResult<UserTitle> GetByUserID(int id);
        IDataResult<UserTitle> GetByCartPass(string pass);
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
