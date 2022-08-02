using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog

        DbCtx c = new DbCtx();
        BlogComment by = new BlogComment();
        public ActionResult Index()
        {
            // var bloglar = c.Blogs.ToList();
            by.Value1 = c.Blogs.ToList();
            by.Value3 = c.Blogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(by);
        }

        
        public ActionResult BlogDetail(int id)
        {
            //var blogsearch = c.Blogs.Where(x => x.Id==id).ToList();
            by.Value1 = c.Blogs.Where(x => x.Id == id).ToList();
            by.Value2 = c.Commentss.Where(x => x.Blogid == id).ToList();
            return View(by);
        }
    }
}