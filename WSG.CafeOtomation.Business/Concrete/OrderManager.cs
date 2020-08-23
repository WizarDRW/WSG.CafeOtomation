using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Concrete;
using WSG.CafeOtomation.Business.Abstract;
using WSG.CafeOtomation.Business.Constants;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

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

        public IDataResult<List<Order>> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(filter));
        }

        public IDataResult<List<Order>> GetByClose(OrderPayStatus orderPayStatus)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(x => x.OrderPayStatus == orderPayStatus));
        }

        public IDataResult<List<Order>> GetByDesk(int deskId)
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList(x => x.DeskID == deskId));
        }

        public IDataResult<Order> GetByOrderNo(int no)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(x => x.ID == no));
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
        public IDataResult<List<OrderDetailsDto>> GetAll(Expression<Func<OrderDetail, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrderDetailsDto>>(_orderDetailDal.GetOrderDetailDtos(filter));
        }

        public IDataResult<List<OrderDetail>> GetByOrderNo(int id)
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetailDal.GetList(x => x.OrderID == id));
        }

        public IDataResult<OrderDetail> GetBy(Expression<Func<OrderDetail, bool>> filter)
        {
            return new SuccessDataResult<OrderDetail>(_orderDetailDal.Get(filter));
        }

        public IDataResult<List<OrderAllDetailsDto>> GetOrderDetailAll(Expression<Func<OrderDetail, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrderAllDetailsDto>>(_orderDetailDal.GetListAllOrders(filter));
        }
    }
    public class OrderDetailTypeManager : IOrderDetailTypeService
    {
        private IOrderDetailTypeDal _orderDetailTypeDal;
        public OrderDetailTypeManager(IOrderDetailTypeDal orderDetailTypeDal)
        {
            _orderDetailTypeDal = orderDetailTypeDal;
        }
        public IResult Add(OrderDetailType orderDetailType)
        {
            _orderDetailTypeDal.Add(orderDetailType);
            return new SuccessResult();
        }

        public IResult Update(OrderDetailType orderDetailType)
        {
            _orderDetailTypeDal.Update(orderDetailType);
            return new SuccessResult();
        }

        public IResult Delete(OrderDetailType orderDetailType)
        {
            _orderDetailTypeDal.Delete(orderDetailType);
            return new SuccessResult();
        }

        public IDataResult<List<OrderDetailTypeDto>> GetAll(Expression<Func<OrderDetailType, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrderDetailTypeDto>>(_orderDetailTypeDal.GetOrderDetailTypeDtos(filter));
        }

        public IDataResult<OrderDetailType> GetBy(Expression<Func<OrderDetailType, bool>> filter)
        {
            return new SuccessDataResult<OrderDetailType>(_orderDetailTypeDal.Get(filter));
        }
    }
    public class OrderDetailTimeLogManager : IOrderDetailTimeLogService
    {
        private IOrderDetailTimeLogDal _orderDetailTimeLogDal;
        public OrderDetailTimeLogManager(IOrderDetailTimeLogDal orderDetailTimeLogDal)
        {
            _orderDetailTimeLogDal = orderDetailTimeLogDal;
        }

        public IResult Add(OrderDetailTimeLog orderDetailTimeLog)
        {
            _orderDetailTimeLogDal.Add(orderDetailTimeLog);
            return new SuccessResult();
        }

        public IResult Update(OrderDetailTimeLog orderDetailTimeLog)
        {
            _orderDetailTimeLogDal.Update(orderDetailTimeLog);
            return new SuccessResult();
        }

        public IResult Delete(OrderDetailTimeLog orderDetailTimeLog)
        {
            _orderDetailTimeLogDal.Delete(orderDetailTimeLog);
            return new SuccessResult();
        }

        public IDataResult<List<OrderDetailTimeLog>> GetAll(Expression<Func<OrderDetailTimeLog, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrderDetailTimeLog>>(_orderDetailTimeLogDal.GetList(filter));
        }

        public IDataResult<OrderDetailTimeLog> GetBy(Expression<Func<OrderDetailTimeLog, bool>> filter)
        {
            return new SuccessDataResult<OrderDetailTimeLog>(_orderDetailTimeLogDal.Get(filter));
        }

        public IDataResult<List<OrderDetailTimeLog>> GetByOrderNo(int orderId)
        {
            return new SuccessDataResult<List<OrderDetailTimeLog>>(_orderDetailTimeLogDal.GetList(x => x.OrderDetailID == orderId));
        }
    }
    public class OrderPaymentManager : IOrderPaymentService
    {
        private IOrderPaymentDal _orderPaymentDal;
        public OrderPaymentManager(IOrderPaymentDal orderPaymentDal)
        {
            _orderPaymentDal = orderPaymentDal;
        }
        public IResult Add(OrderPayment orderPayment)
        {
            _orderPaymentDal.Add(orderPayment);
            return new SuccessResult();
        }

        public IResult Update(OrderPayment orderPayment)
        {
            _orderPaymentDal.Update(orderPayment);
            return new SuccessResult();
        }

        public IResult Delete(OrderPayment orderPayment)
        {
            _orderPaymentDal.Delete(orderPayment);
            return new SuccessResult();
        }

        public IDataResult<List<OrderPaymentDto>> GetAll(Expression<Func<OrderPayment, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrderPaymentDto>>(_orderPaymentDal.GetReportDto(filter));
        }

        public IDataResult<OrderPayment> GetBy(Expression<Func<OrderPayment, bool>> filter)
        {
            return new SuccessDataResult<OrderPayment>(_orderPaymentDal.Get(filter));
        }

        public IDataResult<List<OrderPayment>> GetSafeAll(Expression<Func<OrderPayment, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrderPayment>>(_orderPaymentDal.GetList(filter));
        }
    }
    public class PayTypeManager : IPayTypeService
    {
        private IPayTypeDal _payTypeDal;
        public PayTypeManager(IPayTypeDal payTypeDal)
        {
            _payTypeDal = payTypeDal;
        }
        public IResult Add(PayType orderPayment)
        {
            _payTypeDal.Add(orderPayment);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(PayType orderPayment)
        {
            _payTypeDal.Update(orderPayment);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(PayType orderPayment)
        {
            _payTypeDal.Delete(orderPayment);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<PayType>> GetAll(Expression<Func<PayType, bool>> filter = null)
        {
            return new SuccessDataResult<List<PayType>>(_payTypeDal.GetList(filter));
        }

        public IDataResult<PayType> GetBy(Expression<Func<PayType, bool>> filter)
        {
            return new SuccessDataResult<PayType>(_payTypeDal.Get(filter));
        }
    }
}
