using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyAuth.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthhday { get; set; }
        public string Email { get; set; }
        public int? MemberShipId { get; set; }
        public MemberShipDto MemberShip { get; set; }
        public int? GenreId { get; set; }
        public GenreDto Genre { get; set; }
    }
}