using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tp2.Models;

namespace tp2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Index
        public ActionResult Index()
        {
            Movie movie = new Movie() { Name = "movie 1" };
            List<Movie> movies = new List<Movie>()
                {
                new Movie{Name="movie 2"},
                new Movie{Name="movie 3"},
                };
            return View(movies);
        }
        public ActionResult Edit(int Id) {
            return Content("Id" + Id);
        }
        public ActionResult byRelease(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}