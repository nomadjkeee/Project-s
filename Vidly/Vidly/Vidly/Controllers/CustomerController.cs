﻿using System;
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
            applicationDbContext = new ApplicationDbContext();
           
            var cList = new SomeFilmViewModel();
            cList.Customers = applicationDbContext.Customers.Include("MemberShip").Include("Genre").ToList();


            return View(cList);
        }

        public ViewResult Details(Customer customer)
        {
            applicationDbContext = new ApplicationDbContext();
            var container = new CustomerTemplateViewModel
            {
                Customer = customer,
                Genres = applicationDbContext.Genres.ToList(),
                MemberShips = applicationDbContext.MemberShips.ToList()
            };

            return View(container);
        }
        [HttpGet]
        public ViewResult NewCustomer()
        {
            applicationDbContext = new ApplicationDbContext();
            var container = new CustomerTemplateViewModel
            {
                Genres = applicationDbContext.Genres.ToList(),
                MemberShips = applicationDbContext.MemberShips.ToList()               
            };
            return View(container);
        }

    }
}