using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Controllers;
using TravelTripProje.Models.Classes;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
       
        DbCtx c = new DbCtx();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
    
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogGet(int id)
        {
            var b1 = c.Blogs.Find(id);
            return View("BlogGet", b1);
        }
        public ActionResult UpdateBlog(Blog b)
        {

            var blg = c.Blogs.Find(b.Id);
            blg.Description = b.Description;
            blg.Title = b.Title;
            blg.BlogImage = b.BlogImage;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult CommentList()
        {
            var comments = c.Commentss.ToList();
            return View(comments);
        }
        public ActionResult DeleteComment(int id)
        {
            var b = c.Commentss.Find(id);
            c.Commentss.Remove(b);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult CommentGet(int id)
        {
            var b1 = c.Commentss.Find(id);
            return View("CommentGet", b1);
        }
        public ActionResult UpdateComment(Comments y)
        {

            var yrm = c.Commentss.Find(y.Id);
            yrm.UserName = y.UserName;
            yrm.Mail = y.Mail;
            yrm.Comment = y.Comment;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
     
}
