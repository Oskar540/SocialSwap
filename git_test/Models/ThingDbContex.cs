using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace git_test.Models
{
    public class ThingDbContex : DbContext
    {
        public ThingDbContex() : base("socialswapconnection")
        { }

        public DbSet<Thing> Thing { get; set; }
    }
}