using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyAuth.Dto
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MoviesId { get; set; }
    }
}