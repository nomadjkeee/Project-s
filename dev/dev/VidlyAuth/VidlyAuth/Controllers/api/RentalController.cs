using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyAuth.Dto;
using VidlyAuth.Models;

namespace VidlyAuth.Controllers.api
{
    public class RentalController : ApiController
    {
        private DataBaseContext _dbContext;
        public RentalController()
        {
            _dbContext = new DataBaseContext();
        }
        //api/rental/
        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto newRental)
        {
            var customer = _dbContext.Customers.SingleOrDefault(t => t.Id == newRental.CustomerId);

            var movies = _dbContext.Movies
                .Where(t => newRental.MoviesId.Contains(t.Id));

            foreach (var movie in movies)
            {
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _dbContext.Rentals.Add(rental);
                
            }
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
