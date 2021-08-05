using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Abstrack
{
    public interface IExpenseDal : IRepositoryDal<Expense>
    { 
        int TotalExpenseCount(int categoryID);
    }
}
