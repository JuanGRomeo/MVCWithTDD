using MVCWithTDD.Model;
using MVCWithTDD.Models;
using MVCWithTDD.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithTDD.Controllers
{
    public class BlogController : Controller
    {
        IPostService postService;

        public BlogController(IPostService postService)
        {
            this.postService = postService;
        }

        // GET: Blog
        public ActionResult Recent()
        {
            List<Post> posts = this.postService.ListRecentPosts(5);
            return View(posts);
        }
    }
}