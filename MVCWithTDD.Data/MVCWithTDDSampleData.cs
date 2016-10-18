using MVCWithTDD.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithTDD.Data
{
    public class MVCWithTDDSampleData : DropCreateDatabaseIfModelChanges<MVCWithTDDContext>
    {
        protected override void Seed(MVCWithTDDContext context)
        {
            Post post = new Post
            {
                Content = "Content",
                Title = "Title"
            };

            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}