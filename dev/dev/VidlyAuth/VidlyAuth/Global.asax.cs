using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VidlyAuth.Models;
using AutoMapper;

namespace VidlyAuth
{ 
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            Mapper.Initialize(t => t.AddProfile<VidlyAuth.App_Start.AutoMapperConfig>());
            Database.SetInitializer(new DataBaseInitialize());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
