using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeachingVidly.Models;

namespace TeachingVidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            ViewBag.Hz = 5;
            var movie = new Movie()
            {
                
                Name = "Shrek"
            };

            var movie2 = new Movie()
            {
                
                Name = "Feona"
            };

            var movies = new List<Movie> {movie, movie2};

            var moviesView = new MoviesViewModel {Movies = movies};

            return View(moviesView);
        }

        public ActionResult Random()
        {
            
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            return RedirectToAction("Index","Home", new { page = 1, sort = 2});
        }

        public ActionResult Edit(int movieId=0)
        {
            return Content("id=" + movieId);
        }
    }
}