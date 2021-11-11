using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PostMaker.Models;


namespace PostMaker.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {


        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost (CreatePostViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
    

}
