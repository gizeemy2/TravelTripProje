using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCtx c = new DbCtx();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
     
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.Id).Take(2).ToList();
            return PartialView(degerler);
        }
    }
}