using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VidlyAuth.Controllers
{
    public class MoviesController : Controller
    {
        [Authorize(Roles = "CanManage")]
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
    }
}