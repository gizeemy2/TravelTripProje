using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact

        DbCtx c = new DbCtx();
        public ActionResult Index()
        {
            var degerler = c.Contacts.ToList();
            return View(degerler);
        }
    }
}