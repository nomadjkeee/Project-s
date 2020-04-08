using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Birthhday { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public int? MemberShipId { get; set; }
        public MemberShip MemberShip { get; set; }
        [Required]
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}