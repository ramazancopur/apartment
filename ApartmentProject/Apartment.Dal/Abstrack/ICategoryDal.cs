using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Abstrack
{
    public interface ICategoryDal : IRepositoryDal<Category>
    {
        int GetCategoryID(String CategoryName);

        String TopFirstCategoryForExpense();
    }
}
