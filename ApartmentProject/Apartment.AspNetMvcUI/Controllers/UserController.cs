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
    [Authorize]
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());

        // GET: User
        public ActionResult Index()
        {
            var userValues = um.UserList();
            return View(userValues);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View();  
        }

        [HttpPost]
        public ActionResult AddUser(User p)
        {
            UserValidator userValidator = new UserValidator();
            ValidationResult result = userValidator.Validate(p);

            if (result.IsValid)
            {
                um.AddUser(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }

        public ActionResult DeleteUser(int id)
        {
            var userValue = um.GetByID(id);

            um.DeleteUser(userValue);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateUser(int id)
        {

            var userValue = um.GetByID(id);

            return View(userValue);

        }

        [HttpPost]
        public ActionResult UpdateUser(User user)
        {

            UserValidator userValidator = new UserValidator();
            ValidationResult result = userValidator.Validate(user);

            if (result.IsValid)
            {
                um.UpdateUser(user);
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