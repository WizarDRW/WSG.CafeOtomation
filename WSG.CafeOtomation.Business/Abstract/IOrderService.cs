using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.Utilities.Result.Abstract;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll(Expression<Func<Order, bool>> expression = null);
        IDataResult<List<Order>> GetByDesk(int deskId);
        IDataResult<List<Order>> GetByClose(OrderPayStatus orderPayStatus);
        IDataResult<Order> GetByOrderNo(int no);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
    public interface IOrderDetailService
    {
        IDataResult<List<OrderDetailsDto>> GetAll(Expression<Func<OrderDetail, bool>> filter = null);
        IDataResult<List<OrderAllDetailsDto>> GetOrderDetailAll(Expression<Func<OrderDetail, bool>> filter = null);
        IDataResult<List<OrderDetail>> GetByOrderNo(int orderId);
        IDataResult<OrderDetail> GetBy(Expression<Func<OrderDetail, bool>> filter);
        IResult Add(OrderDetail orderDetail);
        IResult Update(OrderDetail orderDetail);
        IResult Delete(OrderDetail orderDetail);
    }
    public interface IOrderDetailTypeService
    {
        IDataResult<List<OrderDetailTypeDto>> GetAll(Expression<Func<OrderDetailType, bool>> filter = null);
        IDataResult<OrderDetailType> GetBy(Expression<Func<OrderDetailType, bool>> filter);
        IResult Add(OrderDetailType orderDetailType);
        IResult Update(OrderDetailType orderDetailType);
        IResult Delete(OrderDetailType orderDetailType);
    }
    public interface IOrderDetailTimeLogService
    {
        IDataResult<List<OrderDetailTimeLog>> GetAll(Expression<Func<OrderDetailTimeLog, bool>> filter = null);
        IDataResult<List<OrderDetailTimeLog>> GetByOrderNo(int orderId);
        IDataResult<OrderDetailTimeLog> GetBy(Expression<Func<OrderDetailTimeLog, bool>> filter);
        IResult Add(OrderDetailTimeLog orderDetailTimeLog);
        IResult Update(OrderDetailTimeLog orderDetailTimeLog);
        IResult Delete(OrderDetailTimeLog orderDetailTimeLog);
    }
    public interface IOrderPaymentService
    {
        IDataResult<List<OrderPayment>> GetAll(Expression<Func<OrderPayment, bool>> filter = null);
        IDataResult<OrderPayment> GetBy(Expression<Func<OrderPayment, bool>> filter);
        IResult Add(OrderPayment orderPayment);
        IResult Update(OrderPayment orderPayment);
        IResult Delete(OrderPayment orderPayment);
    }
    public interface IPayTypeService
    {
        IDataResult<List<PayType>> GetAll(Expression<Func<PayType, bool>> filter = null);
        IDataResult<PayType> GetBy(Expression<Func<PayType, bool>> filter);
        IResult Add(PayType orderPayment);
        IResult Update(PayType orderPayment);
        IResult Delete(PayType orderPayment);
    }
}
