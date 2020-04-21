using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberShip
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string MemberShipType { get; set; }
        [Required]
        public short PercentCount { get; set; }
    }
}