using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyAuth.Models;

namespace VidlyAuth.Controllers
{
    public class HomeController : Controller
    {
        public DataBaseContext dataBaseContext;
        public ActionResult Index()
        {
            dataBaseContext = new DataBaseContext();
            var t = dataBaseContext.Movies.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}