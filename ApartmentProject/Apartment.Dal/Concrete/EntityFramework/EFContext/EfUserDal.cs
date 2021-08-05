using Apartment.Dal.Abstrack;
using Apartment.Dal.Concrete.EntityFramework.Repository;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Concrete.EntityFramework.EFContext
{
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        Context c = new Context();
        //first mission
        //Toplam kullanıcı sayısını getiren method
        public int TotalUserCount()
        {
            int count = c.Users.Count();

            return count;
        }

        public int TotalUserCount(string anyting)
        {
            var uservalues = c.Users.Where(x => x.UserName.Contains(anyting));

            return uservalues.Count();
        }
    }
}
