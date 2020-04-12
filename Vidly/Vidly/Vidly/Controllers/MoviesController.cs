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
        public ActionResult New()
        {
            applicationDbContext = new ApplicationDbContext();
            var genresViewModel = new NewFirmViewModel
            {
                Genres = applicationDbContext.Genres.ToList()
            };

            return View(genresViewModel);
        }
        [HttpPost]
        public ActionResult Create(Movies movies)
        {
            try
            {
                applicationDbContext = new ApplicationDbContext();
                applicationDbContext.Movies.Add(movies);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index", "Movies");
            }
            catch (Exception)
            {
                return HttpNotFound(); 
            } 
        }
    }
}