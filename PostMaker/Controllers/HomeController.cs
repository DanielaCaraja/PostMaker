using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PostMaker.Models;
using DataContract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL.Abstract;

namespace PostMaker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;
        public HomeController(IPostService postService)
        {

            _postService = postService;
        }
        public IActionResult Index()
        {
            var dtos = _postService.GetPosts();
            var posts = dtos.Select(x => new PostViewModel()
            {
                Author = x.Author,
                Content= x.Content,
                Created = x.Created.ToString()
            }).ToList();
            return View(posts);
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
                var dto = new PostDTO()
                {
                    Author = model.Author,
                    Content = model.Content,
                    Created = model.Created
                };

                _postService.CreatePost(dto);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
