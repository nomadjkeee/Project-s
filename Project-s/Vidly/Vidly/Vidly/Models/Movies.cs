using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public short Year { get; set; }
        [Required]
        public string  Detail { get; set; }
        [Required]
        public short ReleaseDate { get; set; }
        [Required]
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public Movies()
        {
            Customers = new List<Customer>();
        }
    }
}