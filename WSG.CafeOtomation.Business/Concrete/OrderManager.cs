using System.Collections.Generic;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList());
        }

        public IDataResult<List<Order>> GetByClose(bool close)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(x=>x.IsClose == close));
        }

        public IDataResult<List<Order>> GetByDesk(int deskId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(x=>x.DeskID == deskId));
        }

        public IDataResult<Order> GetByOrderNo(int no)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(x=>x.ID == no));
        }
    }
    public class OrderDetailManager : IOrderDetailService
    {
        private IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<OrderDetail>> GetAll()
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetList());
        }

        public IDataResult<List<OrderDetail>> GetByOrderNo(int id)
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetList(x => x.OrderID == id));
        }
    }
}
