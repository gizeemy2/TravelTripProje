using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        DbCtx c = new DbCtx();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            var info = c.Admins.FirstOrDefault(x => x.User == ad.User && x.Password == ad.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.User, false);
                Session["User"] = info.User.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }
    }
}
