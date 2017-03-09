using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace MyBlog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index(string slug)
        {
            var fileName = Path.Combine(GlobalString.WebRootPath, "posts", "posts.json");
            var loader = new JsonRepositoryLoader<Post>(fileName);
            var items = loader.Load();
            var item = items.FirstOrDefault(c => string.Equals(c.Slug, slug));

            if (item == null)
                return NotFound();
            ViewData["Message"] = item.Title;
            ViewData["Title"] = "9efish Blog";
            return View(item);
        }
    }
}
