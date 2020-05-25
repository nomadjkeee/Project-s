using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using VidlyAuth.Dto;
using VidlyAuth.Models;

namespace VidlyAuth.Controllers
{
    public class MoviesController : Controller
    {

        private DataBaseContext _dbContext;
        public MoviesController()
        {
            _dbContext = new DataBaseContext();
        }
        //[Authorize(Roles = "CanManage")]
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id )
        {
            var film = _dbContext.Movies
                .Include("Genre")
                .SingleOrDefault(t => t.Id == id);

            if (film == null)
                return HttpNotFound();

            MoviesDto moviesDto = Mapper.Map<Movies, MoviesDto>(film);

            return View(moviesDto);

        }
    }
}