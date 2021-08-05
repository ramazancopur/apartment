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
    public class BuildingManager : IBuildingService
    {
        IBuildingDal _buildingDal;

        public BuildingManager(IBuildingDal buildingDal)
        {
            _buildingDal = buildingDal;
        }
        
        public void AddBuilding(Building building)
        {
            _buildingDal.Insert(building);
        }

        public List<Building> BuildingList()
        {
            return _buildingDal.List();
        }

        public void DeleteBuilding(Building building)
        {
            _buildingDal.Delete(building);
        }

        public Building GetByID(int id)
        {
            return _buildingDal.Get(x => x.BuildingID == id);
        }

        public void UpdateBuilding(Building building)
        {
            _buildingDal.Update(building);
        }
    }
}
