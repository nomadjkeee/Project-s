using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyAuth.Dto;
using VidlyAuth.Models;

namespace VidlyAuth.Controllers.api
{
    public class CustomerController : ApiController
    {
        private DataBaseContext _dbContext;
        public CustomerController()
        {
            _dbContext = new DataBaseContext();
        }

        //api/customer/get/
        [HttpGet]
        public IHttpActionResult Getcustomer()
        {
            return Ok( _dbContext.Customers
                .Include("Membership")
                .ToList()
                .Select(Mapper.Map<Customer,CustomerDto>));
        }
    }
}
