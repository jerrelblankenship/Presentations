using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlogApp.Models;

namespace MVCBlogApp.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBlog(BlogViewModel model)
        {
            ViewBag.BlogEntry = string.Format("{0} --- {1}", model.Title, model.Body);
            return View("Index");

        }
    }
}
