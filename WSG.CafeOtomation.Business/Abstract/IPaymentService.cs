using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IPaymentService
    {
        IDataResult<List<Payment>> GetAll();
        IDataResult<Payment> GetByUserID(int userId);
        IResult Add(Payment payment);
        IResult Update(Payment payment);
        IResult Delete(Payment payment);
    }
    public interface IPaymentDetailService
    {
        IDataResult<List<PaymentDetail>> GetAll();
        IDataResult<List<PaymentDetail>> GetByPaymentID(int paymentId);
        IResult Add(PaymentDetail paymentDetail);
        IResult Update(PaymentDetail paymentDetail);
        IResult Delete(PaymentDetail paymentDetail);
    }
}
