using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevopsLearn.Models;
using DevopsLearn.Repository;

namespace DevopsLearn.Controllers
{
    public class HomeController : Controller
    {
        IPostRepository postRepository;

        public HomeController(IPostRepository  _postRepository)
        {
            postRepository = _postRepository;
        }

        public IActionResult Index()
        {
            var model = postRepository.GetPosts();
            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your Application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration =0,Location =ResponseCacheLocation.None,NoStore =true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
