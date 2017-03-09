using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "9efish home";
            ViewData["Message"] = "Simple person site";
            var fileName = Path.Combine(GlobalString.WebRootPath,"posts","posts.json");
            var loader=new JsonRepositoryLoader<Post>(fileName);
            var items=loader.Load();
            return View(items);
        }

        public IActionResult About()
        {

            ViewData["Title"] = "About Me";
            ViewData["Message"] = "Enjoy life, Enjoy develop";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
