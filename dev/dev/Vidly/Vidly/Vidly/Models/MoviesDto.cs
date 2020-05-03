using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MoviesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public short Year { get; set; }

        public string Detail { get; set; }

        public short ReleaseDate { get; set; }

        public int? GenreId { get; set; }
        public GenreDto Genre { get; set; }

    }
}