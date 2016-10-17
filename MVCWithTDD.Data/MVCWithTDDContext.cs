using Microsoft.AspNet.Identity.EntityFramework;
using MVCWithTDD.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithTDD.Data
{
    public class MVCWithTDDContext : IdentityDbContext
    {
        public MVCWithTDDContext()
            : base("MVCWithTDDContext")
        {
        }

        public DbSet<Post> Posts { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}