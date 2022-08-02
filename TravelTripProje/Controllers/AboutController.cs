using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        DbCtx c = new DbCtx();
        public ActionResult Index()
        {
            var degerler = c.Abouts.ToList();
            return View(degerler);
        }
    }
}