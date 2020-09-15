using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        List<User> GetSafeList(Expression<Func<User, bool>> filter = null);
        List<UserStuffDto> GetStuffSafeList(Expression<Func<UserStuffDto, bool>> filter = null);
        User GetSafe(Expression<Func<User, bool>> filter);
    }
    public interface IUserEntryDal : IEntityRepository<UserEntry>
    {

    }
    public interface IUserTitleDal : IEntityRepository<UserTitle>
    {

    }
    public interface ITitleDal : IEntityRepository<Title>
    {

    }
}
