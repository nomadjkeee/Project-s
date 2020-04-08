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
        ApplicationDbContext applicationDbContext;
        // GET: Movies
        [HttpGet]
        public ActionResult Index()
        {
            applicationDbContext = new ApplicationDbContext();
            var mList = new SomeFilmViewModel();

            foreach (var item in applicationDbContext.Movies.Include("Genre").ToList())
            {
                mList.Movies.Add(item);
            }
            return View(mList);
        }

        public ViewResult Details(Movies movies)
        {

            return View(movies);
        }
    }
}