using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje.Models.Classes
{
    public class DbCtx:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AdressBlog> AdressBlogs { get; set; }
        public DbSet<Comments> Commentss { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Homepage> Homepages { get; set; }
    }
}