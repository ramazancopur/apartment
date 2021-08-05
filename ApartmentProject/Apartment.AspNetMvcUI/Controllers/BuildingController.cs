using Apartment.Bll.Concrete;
using Apartment.Bll.ValidationRules;
using Apartment.Dal.Concrete.EntityFramework.EFContext;
using Apartment.Entity.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apartment.AspNetMvcUI.Controllers
{
    public class BuildingController : Controller
    {
        BuildingManager bm = new BuildingManager(new EfBuildingDal());

        // GET: Building
        public ActionResult Index()
        {
            var buildingValues = bm.BuildingList();
            return View(buildingValues);
        }

        public ActionResult DeleteBuilding(int id)
        {
            var userValue = bm.GetByID(id);

            bm.DeleteBuilding(userValue);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddBuilding()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBuilding(Building building)
        {
            BuildingValidator buildingValidator = new BuildingValidator();
            ValidationResult result = buildingValidator.Validate(building);

            if (result.IsValid)
            {
                bm.AddBuilding(building);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        [HttpGet]
        public ActionResult UpdateBuilding(int id)
        {
            var value = bm.GetByID(id);

            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateBuilding(Building building)
        {
            BuildingValidator buildingValidator = new BuildingValidator();
            ValidationResult result = buildingValidator.Validate(building);

            if (result.IsValid)
            {
                bm.UpdateBuilding(building);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
