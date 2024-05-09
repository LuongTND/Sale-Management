using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    public class OrderRepository : IOrderRepository
    {
        public int Create(OrderObject entity)
        {
            AppDBContext.Instance.Add(entity);
            AppDBContext.Instance.SaveChanges();

            return entity.OrderId;
        }

        public void Delete(int id)
        {
            OrderObject order = GetById(id);

            if (order != null)
            {
                AppDBContext.Instance.Remove(order);
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }

        public IEnumerable<OrderObject> GetAll()
        {
            return AppDBContext.Instance.Orders;
        }

        public IEnumerable<OrderObject> GetByConditions(Predicate<OrderObject> condition)
        {
            return AppDBContext.Instance.Orders.AsEnumerable().Where(p => condition.Invoke(p));
        }

        public OrderObject GetById(int id)
        {
            return AppDBContext.Instance.Orders.SingleOrDefault(p => p.OrderId == id);
        }

        public void Update(OrderObject entity)
        {
            OrderObject order = GetById(entity.OrderId);

            if (order != null)
            {
                order.Freight = entity.Freight;
                order.OrderDate = entity.OrderDate;
                order.RequiredDate = entity.RequiredDate;
                order.ShippedDate = entity.ShippedDate;
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }
    }
}
