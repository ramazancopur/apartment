using Apartment.Bll.Abstrack;
using Apartment.Dal.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Concrete
{
    public class ExpenseManager : IExpenseService
    {
        IExpenseDal _expenseDal;

        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }

        public int ExpenseCountOfCategory(int categoryID)
        {
            return _expenseDal.TotalExpenseCount(categoryID);
        }
    }
}
