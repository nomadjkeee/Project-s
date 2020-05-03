using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MoviesTemplateViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "Bad news for you")]
        public string Name { get; set; }

        [Required]
        public short Year { get; set; } 

        [Required]
        public string Detail { get; set; }

        [YearValidation]
        [DisplayName("Realease Date")]
        public short ReleaseDate { get; set; }

        [Required]
        public int? GenreId { get; set; }

        public Genre Genre { get; set; }

        public ICollection<Customer> Customers { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit movies" : "New Movies";
            }
        }

        public MoviesTemplateViewModel()
        {

        }
        public MoviesTemplateViewModel(Movies movies)
        {
            Id = movies.Id;
            Name = movies.Name;
            Year = movies.Year;
            Detail = movies.Detail;
            ReleaseDate = movies.ReleaseDate;
            GenreId = movies.GenreId;
        }
    }
}