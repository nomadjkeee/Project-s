using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyAuth.Dto
{
    public class MoviesDto
    {

        public int Id { get; set; }


        public string Name { get; set; }


        public string Detail { get; set; }


        public short ReleaseDate { get; set; }


        public int? GenreId { get; set; }

        public GenreDto Genre { get; set; }

    }
}