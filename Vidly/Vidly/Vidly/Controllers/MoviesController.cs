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
           

            return View();
        }

        public ViewResult Details(Movies movies)
        {

            return View(movies);
        }
    }
}