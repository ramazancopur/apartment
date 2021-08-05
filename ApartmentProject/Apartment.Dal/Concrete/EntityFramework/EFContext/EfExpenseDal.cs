using Apartment.Dal.Abstrack;
using Apartment.Dal.Concrete.EntityFramework.Repository;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Concrete.EntityFramework.EFContext
{
    public class EfExpenseDal : GenericRepository<Expense>, IExpenseDal
    {
        Context c = new Context();

        public int TotalExpenseCount(int categoryID)
        {
            int count = c.Expenses.Count(x => x.CategoryID == categoryID);

            return count;
        }
    }
}
