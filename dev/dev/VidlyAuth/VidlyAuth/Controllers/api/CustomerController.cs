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
        public IHttpActionResult GetСustomer(string query = null)
        {
            IQueryable<Customer> customersQuery = _dbContext.Customers
                .Include("MemberShip");


            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(t => t.Name.Contains(query));


            var customerDto = customersQuery
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);

            //    return Ok( _dbContext.Customers
            //        .Include("Membership")
            //        .ToList()
            //        .Select(Mapper.Map<Customer,CustomerDto>));

            return Ok(customerDto);
        }
    }
}
