using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModel;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Movies m1 = new Movies { Id = 1, Name = "Shrek", Year = 2001 };
            Movies m2 = new Movies { Id = 2, Name = "Bleyd",  Year = 2004 };
            Movies m3 = new Movies { Id = 3, Name = "Bleyd 2", Year = 2005 };

            Customer c1 = new Customer { Id = 1, Name = "John Vick" };
            Customer c2 = new Customer { Id = 2, Name = "David Black" };
            Customer c3 = new Customer { Id = 3, Name = "Kerol Shelby" };

            var cList = new SomeFilmViewModel();
            cList.Customers.Add(c1);
            cList.Customers.Add(c2);
            cList.Customers.Add(c3);

            //var u1 = new SomeFilmViewModel();
            //u1.Id = 1;
            //u1.Movies = m1;
            //u1.Customers.Add(c1);
            //u1.Customers.Add(c2);

            //var u2 = new SomeFilmViewModel();
            //u2.Id = 2;
            //u2.Movies = m2;
            //u2.Customers.Add(c2);

            //var u3 = new SomeFilmViewModel();
            //u3.Id = 3;
            //u3.Movies = m3;
            //u3.Customers.Add(c2);
            //u3.Customers.Add(c3);

            return View(cList);
        }

        public ViewResult Details(Customer customer)
        {

            return View(customer);
        }
    }
}