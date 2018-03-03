using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NanPoc.Web.Models;

namespace NanPoc.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            SearchModel model = new SearchModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Search(SearchModel model)
        {
            return View();
        }

        public IActionResult PostAd()
        {
            PostAdModel model = new PostAdModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult PostAd(PostAdModel model)
        {
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
