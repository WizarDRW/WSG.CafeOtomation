using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CafeContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (CafeContext context = new CafeContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.ID equals userOperationClaim.OperationClaimID
                             where userOperationClaim.UserID == user.ID
                             select new OperationClaim { ID = operationClaim.ID, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public User GetSafe(Expression<Func<User, bool>> filter)
        {
            using (CafeContext context = new CafeContext())
            {
                return context.Users.Select(x => new User
                {
                    ID = x.ID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserName = x.UserName,
                    Status = x.Status
                }).SingleOrDefault(filter);
            }
        }

        public List<User> GetSafeList(Expression<Func<User, bool>> filter = null)
        {
            using (CafeContext context = new CafeContext())
            {
                return filter == null ? context.Users.Select(x => new User
                {
                    ID = x.ID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserName = x.UserName,
                    Status = x.Status
                }).ToList() :
                context.Users.Where(filter).Select(x => new User
                {
                    ID = x.ID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    UserName = x.UserName,
                    Status = x.Status
                }).ToList();
            }
        }

        public List<UserStuffDto> GetStuffSafeList(Expression<Func<UserStuffDto, bool>> filter = null)
        {
            using (CafeContext context = new CafeContext())
            {
                return filter == null ?
                    (from u in context.Users
                     join uT in context.UserTitles
                     on u.ID equals uT.UserID
                     select new UserStuffDto
                     {
                         ID = u.ID,
                         UserName = u.UserName,
                         AccessAuth = (AccessAuth)uT.AccessAuth
                     }).ToList()
                        :
                        (from u in context.Users
                         join uT in context.UserTitles
                         on u.ID equals uT.UserID
                         select new UserStuffDto
                         {
                             ID = u.ID,
                             UserName = u.UserName,
                             AccessAuth = (AccessAuth)uT.AccessAuth
                         }).Where(filter).ToList();
            }
        }
    }
    public class EfUserTitleDal : EfEntityRepositoryBase<UserTitle, CafeContext>, IUserTitleDal
    {

    }
    public class EfTitleDal : EfEntityRepositoryBase<Title, CafeContext>, ITitleDal
    {

    }
}
