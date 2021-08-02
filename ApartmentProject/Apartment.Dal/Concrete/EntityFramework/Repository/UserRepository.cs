using Apartment.Dal.Abstrack;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using Apartment.Dal.Concrete.EntityFramework.EFContext;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Apartment.Dal.Concrete.EntityFramework.Repository
{
    public class UserRepository : IUserDal
    {

        Context c = new Context();

        public bool Delete(User p)
        {
            throw new NotImplementedException();
        }

        public bool Insert(User p)
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            throw new NotImplementedException();
        }

        public List<User> List(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public bool Update(User p)
        {
            throw new NotImplementedException();
        }
    }
}
