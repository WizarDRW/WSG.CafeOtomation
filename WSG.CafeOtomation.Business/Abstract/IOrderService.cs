using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<List<Order>> GetByDesk(int deskId);
        IDataResult<List<Order>> GetByClose(bool close);
        IDataResult<Order> GetByOrderNo(int no);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
    public interface IOrderDetailService
    {
        IDataResult<List<OrderDetail>> GetAll();
        IDataResult<List<OrderDetail>> GetByOrderNo(int orderId);
        IResult Add(OrderDetail orderDetail);
        IResult Update(OrderDetail orderDetail);
        IResult Delete(OrderDetail orderDetail);
    }
}
