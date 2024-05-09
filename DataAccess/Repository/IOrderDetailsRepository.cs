using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetailsObject>
    {
        OrderDetailsObject GetByKey(int orderId, int productId);
        void DeleteByEntity(OrderDetailsObject entity);
    }
}
