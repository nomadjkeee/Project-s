﻿using System;
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
            applicationDbContext = new ApplicationDbContext();
            var editfilm = new FilmTemplateViewModel
            {
                Movies = movies,
                Genres = applicationDbContext.Genres.ToList()

            };
            return View(editfilm);
        }
        
        public ActionResult New()
        {
            applicationDbContext = new ApplicationDbContext();
            var genresViewModel = new FilmTemplateViewModel
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

                Movies moviesDB = applicationDbContext.Movies.FirstOrDefault(t => t.Name == movies.Name);

                if(moviesDB==null)
                {
                    applicationDbContext.Movies.Add(movies);
                    applicationDbContext.SaveChanges();
                }
                else
                {
                    moviesDB.Name = movies.Name;
                    moviesDB.ReleaseDate = movies.ReleaseDate;
                    moviesDB.GenreId = movies.GenreId;
                    moviesDB.Year = movies.Year;
                    applicationDbContext.Entry(moviesDB).State = System.Data.Entity.EntityState.Modified;
                    applicationDbContext.SaveChanges();
                }

                return RedirectToAction("Index", "Movies");
            }
            catch (Exception)
            {
                return HttpNotFound(); 
            } 
        }
    }
}