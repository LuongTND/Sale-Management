using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public int Create(OrderDetailsObject entity)
        {
            AppDBContext.Instance.Add(entity);
            AppDBContext.Instance.SaveChanges();

            return 0;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByEntity(OrderDetailsObject entity)
        {
            var orderDetail = GetByKey(entity.OrderId, entity.ProductId);
            if (orderDetail != null)
            {
                AppDBContext.Instance.Remove(orderDetail);
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }

        public IEnumerable<OrderDetailsObject> GetAll()
        {
            return AppDBContext.Instance.OrderDetails;
        }

        public IEnumerable<OrderDetailsObject> GetByConditions(Predicate<OrderDetailsObject> condition)
        {
            return AppDBContext.Instance.OrderDetails.AsEnumerable().Where(p => condition.Invoke(p));
        }

        public OrderDetailsObject GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetailsObject GetByKey(int orderId, int productId)
        {
            return AppDBContext.Instance.OrderDetails.SingleOrDefault(od => od.OrderId == orderId && od.ProductId == productId);
        }

        public void Update(OrderDetailsObject entity)
        {
            OrderDetailsObject orderDetail = AppDBContext.Instance.OrderDetails.FirstOrDefault(od =>
                                                    od.ProductId == entity.ProductId && od.OrderId == entity.OrderId);

            if (orderDetail != null)
            {
                orderDetail.UnitPrice = entity.UnitPrice;
                orderDetail.Quantity = entity.Quantity;
                orderDetail.Discount = entity.Discount;
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }
    }
}
