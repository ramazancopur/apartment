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

        bool Insert(T p);

        bool Delete(T p);

        bool Update(T p);

    }
}
