using Apartment.Dal.Concrete.EntityFramework.EFContext;
using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Apartment.AspNetMvcUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();

            var adminUserInfo = c.Admins.FirstOrDefault(x => x.AdminName == p.AdminName && x.Password == p.Password);

            if(adminUserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminName, false);
                Session["AdminName"] = adminUserInfo.AdminName;
                return RedirectToAction("Index","User");
            }
            else
            {
                
                return RedirectToAction("Index");
            }


        }
    }
}