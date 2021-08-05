using Apartment.Bll.Abstrack;
using Apartment.Dal.Abstrack;
using Apartment.Dal.Concrete.EntityFramework.Repository;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public User GetByID(int id)
        {
            return _userDal.Get(x => x.UserID == id);
        }

        public void UpdateUser(User user)
        {
            _userDal.Update(user);
        }

        public void AddUser(User user)
        {
            _userDal.Insert(user);
        }

        public List<User> UserList()
        {
            return _userDal.List();
        }
        

        //These codes aren't important
        public int UserTableCount()
        {
            return _userDal.TotalUserCount();
        }

        public int UserTableCount(String anything)
        {
            return _userDal.TotalUserCount(anything);
        }


    }
}
