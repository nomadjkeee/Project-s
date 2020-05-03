using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyAuth.Dto;
using VidlyAuth.Models;
using AutoMapper;
using System.Threading.Tasks;

namespace VidlyAuth.Controllers.api
{
    public class MoviesController : ApiController
    {
        DataBaseContext _dataBaseContext;

        public MoviesController()
        {
            _dataBaseContext = new DataBaseContext();
        }

        //Get//Movies
        [HttpGet]
        public  IHttpActionResult GetMovies()
        {
            return  Ok(_dataBaseContext.Movies.Include("Genre").ToList().Select(Mapper.Map<Movies, MoviesDto>));
        }

        //Get//Movies//1
        public IHttpActionResult GetMovies(int id)
        {
            var moviesDB = _dataBaseContext.Movies.SingleOrDefault(t => t.Id == id);
            if (moviesDB == null)
                return NotFound();
            return Ok(Mapper.Map<Movies, MoviesDto>(moviesDB));           
        }

        //Post//Movies//
        public IHttpActionResult CreateMovies(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movies = Mapper.Map<MoviesDto, Movies>(moviesDto);

            var search = _dataBaseContext.Movies.FirstOrDefault(t => t.Name.ToLower() == movies.Name.ToLower());

            if (search != null)
                return BadRequest();
            _dataBaseContext.Movies.Add(movies);
            _dataBaseContext.SaveChanges();

            return Created(Request.RequestUri.AbsoluteUri + movies.Id,moviesDto);
        }

        //Put//Movies//1
        [HttpPut]
        public IHttpActionResult UpdateMovies(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var moviesDB = _dataBaseContext.Movies.SingleOrDefault(t => t.Id == moviesDto.Id);
            moviesDB = Mapper.Map<MoviesDto, Movies>(moviesDto);
            _dataBaseContext.Entry(moviesDB).State = System.Data.Entity.EntityState.Modified;
            _dataBaseContext.SaveChanges();
            return Ok();           
        }

        //Delete//Movies//1
        [HttpDelete]
        public IHttpActionResult DeleteMovies(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var moviesDB = _dataBaseContext.Movies.SingleOrDefault(t => t.Id == id);
            if (moviesDB == null)
                return NotFound();
            _dataBaseContext.Entry(moviesDB).State = System.Data.Entity.EntityState.Deleted;
            return Ok();
        }
    }
}
