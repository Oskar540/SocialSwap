using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace git_test.Models
{
    public class OurDbContex : DbContext
    {
        public OurDbContex() : base("socialswapconnection")
        {}

        public DbSet<UserAccount> userAccount { get; set; }
    }
}