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
    public class EfBuildingDal : GenericRepository<Building>, IBuildingDal
    {

    }
}
