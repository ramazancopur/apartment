using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Abstrack
{
    public interface IRepositoryDal<T> 
    {
        List<T> List();

        List<T> List(Expression<Func<T, bool>> filter);

        void Insert(T p);

        T Get(Expression<Func<T, bool>> filter);

        void Delete(T p);

        void Update(T p);

    }
}
