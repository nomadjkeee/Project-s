using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        public ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        //Get/api/customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        //Get/api/customers/1
        [HttpGet]
        public CustomerDto GetCustomer(int id)
        {
            var customerDB = _context.Customers.SingleOrDefault(t => t.Id == id);
            if (customerDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            CustomerDto customerDto = new CustomerDto
            {
                Id = customerDB.Id,
                Name = customerDB.Name,
                Birthhday = customerDB.Birthhday,
                Email = customerDB.Email,
                MemberShipId = customerDB.MemberShipId,
            };

            return customerDto;
        }
        //Post/api/customers
        [HttpPost]
        public CustomerDto CreateCustomer(CustomerDto customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            Customer _customer = new Customer();
            _customer.Name = customer.Name;
            _customer.Email = customer.Email;
            _customer.Birthhday = customer.Birthhday;
            _customer.MemberShipId = customer.MemberShipId;

            _context.Customers.Add(_customer);
            _context.SaveChanges();
            return customer;
        }
        [HttpPut]
        public void UpdateCustomer(CustomerDto customer)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var customerDB = _context.Customers.SingleOrDefault(t => t.Id == customer.Id);

            if (customerDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            customerDB.Name = customer.Name;
            customerDB.Email = customer.Email;
            customerDB.Birthhday = customer.Birthhday;
            customerDB.MemberShipId = customer.MemberShipId;

        }
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerDB = _context.Customers.SingleOrDefault(t => t.Id == id);

            if (customerDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Entry(customerDB).State = System.Data.Entity.EntityState.Deleted;
            _context.SaveChanges();

        }
    }
}
