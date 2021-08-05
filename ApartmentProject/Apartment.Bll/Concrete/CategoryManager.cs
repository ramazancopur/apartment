using Apartment.Bll.Abstrack;
using Apartment.Dal.Abstrack;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public int getCategoryID(String CategoryName)
        {
            return _categoryDal.GetCategoryID(CategoryName);
        }
    }
}
