using Apartment.Dal.Concrete.EntityFramework.Repository;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Concrete
{
    public class UserManager
    {
        GenericRepository<User> repo = new GenericRepository<User>();

        public List<User> GetAllBL()
        {
            return repo.List();
        }

        public bool CategortAddBL(User p)
        {
            try
            {
                if (p.UserName == "" || p.Password.Length <= 4 || p.Surname.Length < 3)
                {
                    //Validation error
                    return false;
                }
                else
                {
                    repo.Insert(p);
                    return true;
                }
            }
            catch(InvalidCastException e) 
            {
                Console.Write(e);
                return false;
            }
        }
    }
}
