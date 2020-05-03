using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        public ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //Get//api/Movies
        [HttpGet]
        public IHttpActionResult GetMovies()
        {
            return Ok(_context.Movies.Include("Genre")
                .ToList()
                .Select(Mapper.Map<Movies, MoviesDto>));
        }
        //Get//api//Movies//1
        [HttpGet]
        public IHttpActionResult GetMovies(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movies = _context.Movies
                .Include("Genre")
                .SingleOrDefault(t => t.Id == id);

            if (movies == null)
                return NotFound();

            var moviesDto = Mapper.Map<Movies, MoviesDto>(movies);

            return Ok(moviesDto);
            
        }
        //Post//api//Movies
        [HttpPost]
        public IHttpActionResult CreateMovies(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var moviesDB = Mapper.Map<MoviesDto, Movies>(moviesDto);
            moviesDB.GenreId = moviesDto.GenreId;
            _context.Movies.Add(moviesDB);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri.AbsoluteUri) + "/" + moviesDB.Id,moviesDto);

        }
        //Put/api//Movies//
        [HttpPut]
        public IHttpActionResult UpdateMovies(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var moviesDB = _context.Movies.SingleOrDefault(t => t.Name.ToLower() == moviesDto.Name.ToLower());

            if (moviesDto == null)
                return NotFound();

            
            _context.Entry(moviesDB).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

            return Ok();
        }
        //Delete//api//Movies/1
        public IHttpActionResult DeleteMovies(int id)
        {
            var moviesDB = _context.Movies.SingleOrDefault(t => t.Id == id);
            if (moviesDB == null)
                return NotFound();
            _context.Movies.Remove(moviesDB);
            _context.SaveChanges();
            return Ok();

        }
    }
}
