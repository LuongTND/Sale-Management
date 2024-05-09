using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    public class ProductRepository : IProductRepository
    {
        public int Create(ProductObject entity)
        {
            AppDBContext.Instance.Add(entity);
            AppDBContext.Instance.SaveChanges();

            return entity.ProductId;
        }

        public void Delete(int id)
        {
            ProductObject product = GetById(id);

            if (product != null)
            {
                AppDBContext.Instance.Remove(product);
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }

        public IEnumerable<ProductObject> GetAll()
        {
            return AppDBContext.Instance.Products;
        }

        public IEnumerable<ProductObject> GetByConditions(Predicate<ProductObject> condition)
        {
            return AppDBContext.Instance.Products.AsEnumerable().Where(p => condition.Invoke(p));
        }

        public ProductObject GetById(int id)
        {
            return AppDBContext.Instance.Products.SingleOrDefault(p => p.ProductId == id);
        }

        public void Update(ProductObject entity)
        {
            ProductObject product = GetById(entity.ProductId);

            if (product != null)
            {
                product.CategoryId = entity.CategoryId;
                product.ProductName = entity.ProductName;
                product.Weight = entity.Weight;
                product.UnitPrice = entity.UnitPrice;
                product.UnitslnStock = entity.UnitslnStock;
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }
    }
}
