using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implement
{
    public class MemberRepository : IMemberRepository
    {
        public int Create(MemberObject entity)
        {
            AppDBContext.Instance.Add(entity);
            AppDBContext.Instance.SaveChanges();

            return entity.MemberId;
        }

        public void Delete(int id)
        {
            MemberObject member = GetById(id);

            if (member != null)
            {
                AppDBContext.Instance.Remove(member);
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }

        public IEnumerable<MemberObject> GetAll()
        {
            return AppDBContext.Instance.Members;
        }

        public IEnumerable<MemberObject> GetByConditions(Predicate<MemberObject> condition)
        {
            return AppDBContext.Instance.Members.AsEnumerable().Where(p => condition(p));
        }

        public MemberObject GetById(int id)
        {
            return AppDBContext.Instance.Members.SingleOrDefault(p => p.MemberId == id);
        }

        public void Update(MemberObject entity)
        {
            MemberObject member = GetById(entity.MemberId);

            if (member != null)
            {
                member.CompanyName = entity.CompanyName;
                member.Email = entity.Email;
                member.City = entity.City;
                member.Country = entity.Country;
                member.Password = entity.Password;
                AppDBContext.Instance.SaveChanges();
            }
            else
            {
                throw new Exception("Item is not exist");
            }
        }
    }
}
