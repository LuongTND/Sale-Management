using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByConditions(Predicate<T> condition);
        int Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
