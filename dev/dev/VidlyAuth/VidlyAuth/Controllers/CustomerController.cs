using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyAuth.Models;

namespace VidlyAuth.Controllers
{
    public class CustomerController : Controller
    {
        private DataBaseContext _dbContext;
        public CustomerController()
        {
            _dbContext = new DataBaseContext();
        }
        // GET: Customer
        public ActionResult Index()
        {
            if (!User.IsInRole("CanManage"))
                return RedirectToAction("Index", "Home");
            return View();
        }
    }
}