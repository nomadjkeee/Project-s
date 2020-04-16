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

        //public ViewResult Details(Movies movies)
        //{
        //    applicationDbContext = new ApplicationDbContext();
        //    var editfilm = new FilmTemplateViewModel(movies)
        //    {
        //        Genres = applicationDbContext.Genres.ToList()

        //    };
        //    return View("New",editfilm);
        //}

        public ActionResult New(Movies movies)
        {
            applicationDbContext = new ApplicationDbContext();
            var genresViewModel = new MoviesTemplateViewModel(movies)
            {
                Genres = applicationDbContext.Genres.ToList(),
            };

            return View(genresViewModel);
        }
        [HttpPost]
        public ActionResult Create(MoviesTemplateViewModel moviesTemplate)
        {
            applicationDbContext = new ApplicationDbContext();

            try
            {
                if (ModelState.IsValid)
                {
                    Movies moviesDB = applicationDbContext.Movies.FirstOrDefault(t => t.Id == moviesTemplate.Id);

                    if (moviesDB == null)
                    {
                        moviesDB = new Movies
                        {
                            Name = moviesTemplate.Name,
                            ReleaseDate = moviesTemplate.ReleaseDate,
                            GenreId = moviesTemplate.GenreId,
                            Year = moviesTemplate.Year,
                            Detail = moviesTemplate.Detail

                        };
                        applicationDbContext.Entry(moviesDB).State = System.Data.Entity.EntityState.Added;
                        applicationDbContext.SaveChanges();
                    }
                    else
                    {

                        moviesDB.Name = moviesTemplate.Name;
                        moviesDB.ReleaseDate = moviesTemplate.ReleaseDate;
                        moviesDB.GenreId = moviesTemplate.GenreId;
                        moviesDB.Year = moviesTemplate.Year;
                        moviesDB.Detail = moviesTemplate.Detail;


                        applicationDbContext.Entry(moviesDB).State = System.Data.Entity.EntityState.Modified;
                        applicationDbContext.SaveChanges();
                    }

                    return RedirectToAction("Index", "Movies");
                }
                else
                {
                    moviesTemplate.Genres = applicationDbContext.Genres.ToList();
                    return View("New", moviesTemplate);
                }

            }
            catch (Exception)
            {
                return HttpNotFound();
            }
        }
    }
}