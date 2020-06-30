using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }
        public IResult Add(Payment payment)
        {
            _paymentDal.Add(payment);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Payment payment)
        {
            _paymentDal.Update(payment);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Payment>> GetAll()
        {
            return new SuccessDataResult<List<Payment>>(_paymentDal.GetList());
        }

        public IDataResult<Payment> GetByUserID(int userId)
        {
            return new SuccessDataResult<Payment>(_paymentDal.Get(x => x.UserID == userId));
        }
    }
    public class PaymentDetailManager : IPaymentDetailService
    {
        private IPaymentDetailDal _paymentDetailDal;
        public PaymentDetailManager(IPaymentDetailDal paymentDetailDal)
        {
            _paymentDetailDal = paymentDetailDal;
        }
        public IResult Add(PaymentDetail paymentDetail)
        {
            _paymentDetailDal.Add(paymentDetail);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(PaymentDetail paymentDetail)
        {
            _paymentDetailDal.Update(paymentDetail);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(PaymentDetail paymentDetail)
        {
            _paymentDetailDal.Delete(paymentDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<PaymentDetail>> GetAll()
        {
            return new SuccessDataResult<List<PaymentDetail>>(_paymentDetailDal.GetList());
        }

        public IDataResult<List<PaymentDetail>> GetByPaymentID(int paymentId)
        {
            return new SuccessDataResult<List<PaymentDetail>>(_paymentDetailDal.GetList(x => x.PaymentID == paymentId));
        }
    }
}
