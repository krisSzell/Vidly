using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            this._context = new ApplicationDbContext();
        }
          
        [HttpPost]
        public IHttpActionResult NewRentalForm(NewRentalDto newRental)
        {
            var rentalCustomer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            var rentalMovies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in rentalMovies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var temp = new Rental
                {
                    Customer = rentalCustomer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(temp);
            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
