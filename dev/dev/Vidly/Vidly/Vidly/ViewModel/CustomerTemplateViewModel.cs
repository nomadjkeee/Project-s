using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Full name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Your Birthday")]
        public string Birthhday { get; set; } = "1 Jan 0001";      
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Member ship")]
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