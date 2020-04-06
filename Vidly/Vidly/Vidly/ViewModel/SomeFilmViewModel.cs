using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class SomeFilmViewModel
    {
        public int Id { get; set; }
        public ICollection<Movies> Movies { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public SomeFilmViewModel()
        {
            Customers = new List<Customer>();
            Movies = new List<Movies>();
        }
    }
}