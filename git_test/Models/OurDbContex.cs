using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace git_test.Models
{
    public class OurDbContex : DbContext
    {
        public OurDbContex() : base("DefaultConnection")
        { }

        public DbSet<UserAccount> userAccount { get; set; }
        public DbSet<Thing> Thing { get; set; }
    }
}