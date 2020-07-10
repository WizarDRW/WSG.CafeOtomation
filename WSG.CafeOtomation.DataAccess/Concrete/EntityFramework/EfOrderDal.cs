using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using WizardSoftwareGroupsFramework.Core.DataAccess.EntityFramework;
using WSG.CafeOtomation.DataAccess.Abstract;
using WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts;
using WSG.CafeOtomation.Entities.Concrete;
using WSG.CafeOtomation.Entities.Dtos;
using System.Net.Http.Headers;

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
                     join c in context.Customers
                     on o.CurrentBookID equals c.ID into cO
                     from cus in cO.DefaultIfEmpty()
                     select new OrderDto
                     {
                         ID = o.ID,
                         CreateDate = o.CreateDate,
                         CreateUser = u != null ? $"{u.FirstName} {u.LastName}" : "Anonymous",
                         Customer = cus != null ? $"{cus.FirstName} {cus.LastName}" : "Anonymous",
                         DeskNo = d.DeskNo,
                         TotalPrice = o.TotalPrice,
                         Paid = o.Paid,
                         Change = o.Change,
                         IsClose = o.IsClose
                     }).ToList()
                        :
                    (from o in context.Orders.Where(filter)
                     join u in context.Users
                     on o.CreateUserID equals u.ID
                     join d in context.Desks
                     on o.DeskID equals d.ID
                     join c in context.Customers
                     on o.CurrentBookID equals c.ID into cO
                     from cus in cO.DefaultIfEmpty()
                     select new OrderDto
                     {
                         ID = o.ID,
                         CreateDate = DateTime.Now,
                         CreateUser = u != null ? $"{u.FirstName} {u.LastName}" : "Anonymous",
                         Customer = cus != null ? $"{cus.FirstName} {cus.LastName}" : "Anonymous",
                         DeskNo = d.DeskNo,
                         TotalPrice = o.TotalPrice,
                         Paid = o.Paid,
                         Change = o.Change,
                         IsClose = o.IsClose
                     }).ToList();
            }
        }
    }
    public class EfOrderDetailDal : EfEntityRepositoryBase<OrderDetail, CafeContext>, IOrderDetailDal
    {
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
                         Product = p.Name,
                         Amount = o.Amount,
                         TotalPrice = o.TotalPrice,
                         IsComplete = o.IsComplete
                     }).ToList()
                    :
                    (from o in context.OrderDetails.Where(filter)
                     join p in context.Products
                     on o.ProductID equals p.ID
                     select new OrderDetailsDto
                     {
                         ID = o.ID,
                         Product = p.Name,
                         Amount = o.Amount,
                         TotalPrice = o.TotalPrice,
                         IsComplete = o.IsComplete
                     }).ToList();
            }
        }
    }
}
