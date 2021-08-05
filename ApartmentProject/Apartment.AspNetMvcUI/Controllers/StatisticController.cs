using Apartment.Bll.Concrete;
using Apartment.Dal.Abstrack;
using Apartment.Dal.Concrete.EntityFramework.EFContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Apartment.AspNetMvcUI.Controllers
{
    public class StatisticController : Controller
    {
        UserManager um = new UserManager(new EfUserDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        ExpenseManager em = new ExpenseManager(new EfExpenseDal());
        
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.Message1 = um.UserTableCount();
            ViewBag.Message2 = em.ExpenseCountOfCategory( cm.getCategoryID("Elektrik") );
            ViewBag.Message3 = um.UserTableCount("A");
            ViewBag.Message4 = "boş";
            ViewBag.Message5 = "boş";

            return View();
        }
    }
}