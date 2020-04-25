using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthhday { get; set; }
        public string Email { get; set; }
        public int? MemberShipDtoId { get; set; }
        public MemberShipDto MemberShipDto { get; set; }

    }
    public class MemberShipDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}