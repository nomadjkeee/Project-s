using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerTemplateViewModel
    {

        public Customer Customer { get; set; }
        public IEnumerable<MemberShip> MemberShips { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}