using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieLab.Models;

namespace MovieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var actors = Actor.GetAllActors();
            var movies = Movie.GetAllMovies();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Before()
        {
            return View();
        }
        
        public IActionResult Robin()
        {
            return View();
        }

        public IActionResult Three()
        {
            return View();
        }

        public IActionResult Drama()
        {
            return View();
        }

            public IActionResult MoviePage(int SearchQuery)
        {
            
            return View( new Movie(){
                SearchQuery = SearchQuery,
            });
        }

        
            public IActionResult ActorPage(string ShowActor)
        {
            
            return View( new Movie(){
                ShowActor = ShowActor,
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
