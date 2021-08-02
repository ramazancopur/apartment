using Apartment.Dal.Abstrack;
using Apartment.Dal.Concrete.EntityFramework.EFContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Concrete.EntityFramework.Repository
{
    public class GenericRepository<T> : IRepositoryDal<T> where T:class
    {
        Context c = new Context();

        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public bool Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
            return true;
        }

        public bool Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
            return true;
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public bool Update(T p)
        {
            c.SaveChanges();
            return true;
        }

       

        
    }
}
