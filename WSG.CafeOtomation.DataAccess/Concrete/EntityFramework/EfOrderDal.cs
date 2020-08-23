using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, CafeContext>, IOrderDal
    {
        public OrderDto GetOrderDto(Expression<Func<Order, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<OrderDto> GetOrderDtos(Expression<Func<Order, bool>> filter = null)
        {
            using (CafeContext context = new CafeContext())
            {
                return filter == null ?
                    (from o in context.Orders
                     join u in context.Users
                     on o.CreateUserID equals u.ID
                     join d in context.Desks
                     on o.DeskID equals d.ID
                     select new OrderDto
                     {
                         ID = o.ID,
                         CreateDate = o.CreateDate,
                         CreateUser = u != null ? $"{u.FirstName} {u.LastName}" : "Anonymous",
                         DeskNo = d.DeskNo,
                         TotalPrice = o.TotalPrice,
                         OrderPayStatus = o.OrderPayStatus
                     }).ToList()
                        :
                    (from o in context.Orders.Where(filter)
                     join u in context.Users
                     on o.CreateUserID equals u.ID
                     join d in context.Desks
                     on o.DeskID equals d.ID
                     select new OrderDto
                     {
                         ID = o.ID,
                         CreateDate = o.CreateDate,
                         CreateUser = u != null ? $"{u.FirstName} {u.LastName}" : "Anonymous",
                         DeskNo = d.DeskNo,
                         TotalPrice = o.TotalPrice,
                         OrderPayStatus = o.OrderPayStatus
                     }).ToList();
            }
        }
    }
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail, CafeContext>, IOrderDetailDal
    {
        public List<OrderAllDetailsDto> GetListAllOrders(Expression<Func<OrderDetail, bool>> filter = null)
        {
            using (CafeContext context = new CafeContext())
            {
                return filter == null ?
                    (from o in context.OrderDetails
                     join p in context.Products
                     on o.ProductID equals p.ID
                     join or in context.Orders
                     on o.OrderID equals or.ID
                     select new OrderAllDetailsDto
                     {
                         ID = o.ID,
                         OrderNo = o.OrderID,
                         Product = p.Name,
                         DeskNo = or.Desk.DeskNo,
                         Amount = o.Amount,
                         TotalPrice = o.TotalPrice,
                         EOrderStatus = o.EOrderStatus,
                         CreateTime = o.CreateDate.ToString("HH:mm:ss")

                     }).ToList()
                    :
                    (from o in context.OrderDetails.Where(filter)
                     join p in context.Products
                     on o.ProductID equals p.ID
                     join or in context.Orders
                     on o.OrderID equals or.ID
                     select new OrderAllDetailsDto
                     {
                         ID = o.ID,
                         OrderNo = o.OrderID,
                         Product = p.Name,
                         DeskNo = or.Desk.DeskNo,
                         Amount = o.Amount,
                         TotalPrice = o.TotalPrice,
                         EOrderStatus = o.EOrderStatus,
                         CreateTime = o.CreateDate.ToString("HH:mm:ss")
                     }).ToList();
            }
        }

        public OrderDetailsDto GetOrderDetailDto(Expression<Func<OrderDetail, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetailsDto> GetOrderDetailDtos(Expression<Func<OrderDetail, bool>> filter)
        {
            using (CafeContext context = new CafeContext())
            {
                return filter == null ?
                    (from o in context.OrderDetails
                     join p in context.Products
                     on o.ProductID equals p.ID
                     select new OrderDetailsDto
                     {
                         ID = o.ID,
                         OrderID = o.OrderID,
                         Product = p.Name,
                         Amount = o.Amount,
                         TotalPrice = o.TotalPrice,
                         EOrderStatus = o.EOrderStatus,
                         ProductID = p.ID,
                         CreateTime = o.CreateDate
                     }).ToList()
                    :
                    (from o in context.OrderDetails.Where(filter)
                     join p in context.Products
                     on o.ProductID equals p.ID
                     select new OrderDetailsDto
                     {
                         ID = o.ID,
                         OrderID = o.OrderID,
                         Product = p.Name,
                         Amount = o.Amount,
                         TotalPrice = o.TotalPrice,
                         EOrderStatus = o.EOrderStatus,
                         ProductID = p.ID,
                         CreateTime = o.CreateDate
                     }).ToList();
            }
        }
    }
    public class EfOrderDetailTypeDal : EfEntityRepositoryBase<OrderDetailType, CafeContext>, IOrderDetailTypeDal
    {
        public List<OrderDetailTypeDto> GetOrderDetailTypeDtos(Expression<Func<OrderDetailType, bool>> filter = null)
        {
            using (var context = new CafeContext())
            {
                return filter == null ?
                    (from x in context.OrderDetailTypes
                     join od in context.OrderDetails
                     on x.OrderDetailID equals od.ID
                     join pt in context.ProductTypes
                     on x.ProductTypeID equals pt.ID
                     select new OrderDetailTypeDto
                     {
                         ID = x.ID,
                         ProductType = pt.Name,
                         Count = context.OrderDetailTypes.Where(x => x.ProductTypeID == pt.ID).GroupBy(x => x.ProductTypeID).Count()
                     }).ToList() :
                    (from x in context.OrderDetailTypes.Where(filter)
                     join od in context.OrderDetails
                     on x.OrderDetailID equals od.ID
                     join pt in context.ProductTypes
                     on x.ProductTypeID equals pt.ID
                     select new OrderDetailTypeDto
                     {
                         ID = x.ID,
                         ProductType = pt.Name,
                         Count = context.OrderDetailTypes.Where(x => x.ProductTypeID == pt.ID).Count()
                     }).ToList();
            }
        }
    }
    public class EfOrderDetailTimeLogDal : EfEntityRepositoryBase<OrderDetailTimeLog, CafeContext>, IOrderDetailTimeLogDal
    {

    }

    public class EfOrderPaymentDal : EfEntityRepositoryBase<OrderPayment, CafeContext>, IOrderPaymentDal
    {
        public List<OrderPaymentDto> GetReportDto(Expression<Func<OrderPayment, bool>> filter = null)
        {
            using (var context = new CafeContext())
            {
                return filter == null ? context.Orders.Join(
                    context.OrderPayments.Join(context.PayTypes, op => op.PayTypeID,
                    pt => pt.ID,
                    (op, pt) => new { op.OrderID, pt.Name, op.Value }),
                    x => x.ID,
                    op => op.OrderID,
                    (x, op) => new OrderPaymentDto
                    {
                        PayType = op.Name,
                        TotalPrice = op.Value
                    }).ToList():
                    context.Orders.Join(
                    context.OrderPayments.Where(filter).Join(context.PayTypes, op => op.PayTypeID,
                    pt => pt.ID,
                    (op, pt) => new { op.OrderID, pt.Name, op.Value }),
                    x => x.ID,
                    op => op.OrderID,
                    (x, op) => new OrderPaymentDto
                    {
                        PayType = op.Name,
                        TotalPrice = op.Value
                    }).ToList();
            }
        }
    }
    public class EfPayTypeDal : EfEntityRepositoryBase<PayType, CafeContext>, IPayTypeDal
    {
    }
}
