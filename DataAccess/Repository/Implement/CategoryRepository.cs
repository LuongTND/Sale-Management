using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    public class CategoryRepository : ICategoryRepository
    {
        public int Create(CategoryObject entity)
        {
            AppDBContext.Instance.Add(entity);
            AppDBContext.Instance.SaveChanges();

            return entity.CategoryId;
        }

        public void Delete(int id)
        {
            CategoryObject product = GetById(id);

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

        public IEnumerable<CategoryObject> GetAll()
        {
            return AppDBContext.Instance.Categories;
        }

        public IEnumerable<CategoryObject> GetByConditions(Predicate<CategoryObject> condition)
        {
            return AppDBContext.Instance.Categories.AsEnumerable().Where(p => condition.Invoke(p));
        }

        public CategoryObject GetById(int id)
        {
            return AppDBContext.Instance.Categories.SingleOrDefault(p => p.CategoryId == id);
        }

        public void Update(CategoryObject entity)
        {
            CategoryObject product = GetById(entity.CategoryId);

            if (product != null)
            {
                product.CategoryName = entity.CategoryName;
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }
    }
}
