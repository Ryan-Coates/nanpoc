using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NanPoc.Web.Models;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace NanPoc.Web.Controllers
{
    public class HomeController : Controller
    {
        private static MockDataBase mockdb = new MockDataBase();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            DisplayModel model = new DisplayModel
            {
                Search = new SearchModel(),
                Posts = new List<PostAdModel>()
            };
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Search(DisplayModel model)
        {
            model.Posts = mockdb.GetPosts(model.Search);
            foreach(var post in model.Posts)
            {
                post.SetImageURL();
            }
            return View(model);
        }

        public IActionResult PostAd()
        {
            PostAdModel model = new PostAdModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult PostAd(PostAdModel model)
        {
            mockdb.SavePost(model);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
