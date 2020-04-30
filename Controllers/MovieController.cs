using RentalMovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalMovieApp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Radnom
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Avengers" };

            return View(movie);
        }
    }
}