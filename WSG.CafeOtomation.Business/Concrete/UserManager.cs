using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(UserMessages.Added);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(UserMessages.Updated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(UserMessages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetSafeList());
        }
        public IDataResult<List<UserStuffDto>> GetAllStuff(Expression<Func<UserStuffDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<UserStuffDto>>(_userDal.GetStuffSafeList(filter));
        }

        public IDataResult<User> GetByID(int id)
        {
            return new SuccessDataResult<User>(_userDal.GetSafe(x => x.ID == id));
        }

        public User GetByUserName(string userName)
        {
            return _userDal.Get(x => x.UserName == userName);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
    public class TitleManager : ITitleService
    {
        private ITitleDal _titleDal;
        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public IResult Add(Title title)
        {
            _titleDal.Add(title);
            return new SuccessResult(UserTitleMessages.Added);
        }

        public IResult Update(Title title)
        {
            _titleDal.Add(title);
            return new SuccessResult(UserTitleMessages.Updated);
        }

        public IResult Delete(Title title)
        {
            _titleDal.Add(title);
            return new SuccessResult(UserTitleMessages.Deleted);
        }

        public IDataResult<List<Title>> GetAll()
        {
            return new SuccessDataResult<List<Title>>(_titleDal.GetList());
        }

        public IDataResult<Title> GetByID(int id)
        {
            return new SuccessDataResult<Title>(_titleDal.Get(x => x.ID == id));
        }

        public IDataResult<Title> GetByName(string name)
        {
            return new SuccessDataResult<Title>(_titleDal.Get(x => x.Name == name));
        }
    }
    public class UserTitleManager : IUserTitleService
    {
        private IUserTitleDal _userTitleDal;
        public UserTitleManager(IUserTitleDal userTitleDal)
        {
            _userTitleDal = userTitleDal;
        }
        public IResult Add(UserTitle title)
        {
            _userTitleDal.Add(title);
            return new SuccessResult(UserTitleMessages.Added);
        }

        public IResult Update(UserTitle title)
        {
            _userTitleDal.Update(title);
            return new SuccessResult(UserTitleMessages.Updated);
        }

        public IResult Delete(UserTitle title)
        {
            _userTitleDal.Delete(title);
            return new SuccessResult(UserTitleMessages.Deleted);
        }

        public IDataResult<List<UserTitle>> GetAll()
        {
            return new SuccessDataResult<List<UserTitle>>(_userTitleDal.GetList());
        }

        public IDataResult<UserTitle> GetByID(int id)
        {
            return new SuccessDataResult<UserTitle>(_userTitleDal.Get(x => x.ID == id));
        }

        public IDataResult<UserTitle> GetByUserID(int id)
        {
            return new SuccessDataResult<UserTitle>(_userTitleDal.Get(x => x.UserID == id));
        }

        public IDataResult<UserTitle> GetByCartPass(string pass)
        {
            return new SuccessDataResult<UserTitle>(_userTitleDal.Get(x => x.CartPass == pass));
        }
    }
}
