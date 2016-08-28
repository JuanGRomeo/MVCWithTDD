using MVCWithTDD.Model;
using MVCWithTDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithTDD.Controllers
{
    public class BlogController : Controller
    {
        IPostRepository postRepository;

        public BlogController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        // GET: Blog
        public ActionResult Recent()
        {
            IList<Post> posts = postRepository.ListRecentPosts(10); //Doh! Magic Number!
            return View(posts);
        }
    }
}