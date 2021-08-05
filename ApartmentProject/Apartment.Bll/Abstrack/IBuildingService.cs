using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Bll.Abstrack
{
    interface IBuildingService
    {
        List<Building> BuildingList();

        void AddBuilding(Building building);

        Building GetByID(int id);

        void DeleteBuilding(Building building);

        void UpdateBuilding(Building building);
    }
}
