using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [HttpGet]
        public ActionResult Index()
        {
            Movies m1 = new Movies { Id = 1, Name = "Shrek", Type = "Comedy", Year = 2001 };
            Movies m2 = new Movies { Id = 2, Name = "Bleyd", Type = "Action", Year = 2004 };
            Movies m3 = new Movies { Id = 3, Name = "Bleyd 2", Type = "Action", Year = 2005 };

            var unit = new SomeFilmViewModel();
            unit.Movies.Add(m1);
            unit.Movies.Add(m2);
            unit.Movies.Add(m3);

            return View(unit);
        }

        public ViewResult Details(Movies movies)
        {

            return View(movies);
        }
    }
}