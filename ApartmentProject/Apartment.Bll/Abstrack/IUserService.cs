using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Abstrack
{
    public interface IUserService
    {
        List<User> UserList();

        void AddUser(User user);

        User GetByID(int id);

        void DeleteUser(User user);

        void UpdateUser(User user);

        int UserTableCount();
  
    }
}
