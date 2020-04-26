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
        ApplicationDbContext applicationDbContext;
        // GET: Customer
        public ActionResult Index()
        {

            return View();
        }

        public ViewResult Details(int id)
        {
            applicationDbContext = new ApplicationDbContext();
            Customer customer = applicationDbContext.Customers.Single(t => t.Id == id);
            var container = new CustomerTemplateViewModel(customer)
            {           
                Genres = applicationDbContext.Genres.ToList(),
                MemberShips = applicationDbContext.MemberShips.ToList()
            };

            return View(container);
        }
        [HttpGet]
        public ViewResult NewCustomer(CustomerTemplateViewModel customer)
        {
            applicationDbContext = new ApplicationDbContext();

            customer.Genres = applicationDbContext.Genres.ToList();
            customer.MemberShips = applicationDbContext.MemberShips.ToList();               
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(CustomerTemplateViewModel customerTemplate)
        {
            applicationDbContext = new ApplicationDbContext();
            try
            {
                if (ModelState.IsValid)
                {
                    Customer customerDB = applicationDbContext.Customers.FirstOrDefault(t => t.Id == customerTemplate.Id);

                    if (customerDB == null)
                    {
                        customerDB = new Customer()
                        {
                            Name = customerTemplate.Name,
                            Birthhday = customerTemplate.Birthhday,
                            Email = customerTemplate.Email,
                            // GenreId = customerTemplate.GenreId,
                            MemberShipId = customerTemplate.MemberShipId
                        };
                        applicationDbContext.Entry(customerDB).State = System.Data.Entity.EntityState.Added;
                         //applicationDbContext.SaveChanges();
                    }
                    else
                    {
                        customerDB.Name = customerTemplate.Name;
                        customerDB.Birthhday = customerTemplate.Birthhday;
                        customerDB.Email = customerTemplate.Email;
                        // GenreId = customerTemplate.GenreId,
                        customerDB.MemberShipId = customerTemplate.MemberShipId;
                       
                        applicationDbContext.Entry(customerDB).State = System.Data.Entity.EntityState.Modified;
                       
                    }
                    applicationDbContext.SaveChanges();
                    return RedirectToAction("Index", "Customer");
                }
                else
                {
                    customerTemplate.MemberShips = applicationDbContext.MemberShips.ToList();
                    return View("NewCustomer", customerTemplate);
                }
            }
            catch (Exception)
            {

                throw;
            }          
        }
    }
}