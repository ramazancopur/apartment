using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Abstrack
{
    interface IExpenseService
    {
        int ExpenseCountOfCategory(int categoryID);
        
    }
}
