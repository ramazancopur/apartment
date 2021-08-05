using Apartment.Dal.Abstrack;
using Apartment.Dal.Concrete.EntityFramework.Repository;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Concrete.EntityFramework.EFContext
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        Context c = new Context();

        public int GetCategoryID(string Category)
        {
            var categoryValue = c.Categories.Where(x => x.Name == Category).FirstOrDefault();

            return categoryValue.CategoryID;
        }

        public string TopFirstCategoryForExpense()
        {
            throw new NotImplementedException();
        }
    }
}
