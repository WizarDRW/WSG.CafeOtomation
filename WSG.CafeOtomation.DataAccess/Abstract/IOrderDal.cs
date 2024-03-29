﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.DataAccess.Abstract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
        List<OrderDto> GetOrderDtos(Expression<Func<Order, bool>> filter = null);
        OrderDto GetOrderDto(Expression<Func<Order, bool>> filter);
    }
    public interface IOrderDetailDal : IEntityRepository<OrderDetail>
    {
        List<OrderDetailsDto> GetOrderDetailDtos(Expression<Func<OrderDetail, bool>> filter = null);
        List<OrderAllDetailsDto> GetListAllOrders(Expression<Func<OrderDetail, bool>> filter = null);
        OrderDetailsDto GetOrderDetailDto(Expression<Func<OrderDetail, bool>> filter);

    }
    public interface IOrderDetailTypeDal : IEntityRepository<OrderDetailType>
    {
        List<OrderDetailTypeDto> GetOrderDetailTypeDtos(Expression<Func<OrderDetailType, bool>> filter = null);
    }
    public interface IOrderDetailTimeLogDal : IEntityRepository<OrderDetailTimeLog>
    {

    }
    public interface IOrderPaymentDal : IEntityRepository<OrderPayment>
    {
        List<OrderPaymentDto> GetReportDto(Expression<Func<OrderPayment, bool>> filter = null);
    }
    public interface IPayTypeDal : IEntityRepository<PayType>
    {

    }
}
