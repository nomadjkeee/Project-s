using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyAuth.Models;

namespace VidlyAuth.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<Customer> customers { get; set; }

        public CustomerViewModel()
        {
            customers = new List<Customer>();
        }
    }
}