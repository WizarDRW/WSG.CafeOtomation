using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class DeskManager : IDeskService
    {
        private IDeskDal _deskDal;
        public DeskManager(IDeskDal deskDal)
        {
            _deskDal = deskDal;
        }
        public IResult Add(Desk desk)
        {
            _deskDal.Add(desk);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Desk desk)
        {
            _deskDal.Update(desk);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Desk desk)
        {
            _deskDal.Delete(desk);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Desk>> GetAll(Expression<Func<Desk, bool>> filter = null)
        {
            return filter == null ?
                new SuccessDataResult<List<Desk>>(_deskDal.GetList())
                :
                new SuccessDataResult<List<Desk>>(_deskDal.GetList(filter));
        }

        public IDataResult<Desk> GetByNo(string no)
        {
            return new SuccessDataResult<Desk>(_deskDal.Get(x => x.DeskNo == no));
        }

        public IDataResult<Desk> GetByUnique(string uniqueId)
        {
            return new SuccessDataResult<Desk>(_deskDal.Get(x => x.UniqueIdentifier == uniqueId));
        }
    }
}
