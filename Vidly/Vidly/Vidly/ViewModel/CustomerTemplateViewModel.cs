using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerTemplateViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Birthhday { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int? MemberShipId { get; set; }

        public MemberShip MemberShip { get; set; }

        public int? GenreId { get; set; }

        public Genre Genre { get; set; }
        
        public IEnumerable<MemberShip> MemberShips { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
        public CustomerTemplateViewModel()
        {

        }
        public CustomerTemplateViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Birthhday = customer.Birthhday;
            Email = customer.Email;
            MemberShipId = customer.MemberShipId;   
        }
    }
}