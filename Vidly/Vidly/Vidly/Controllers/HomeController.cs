using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModel;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext applicationDbContext;

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            return View();
        }
        //public ActionResult Create(CustomerTemplateViewModel customer)
        //{
        //    applicationDbContext = new ApplicationDbContext();
        //    CustomerTemplateViewModel customerDB = applicationDbContext.Customers.FirstOrDefault();  

        //}
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}