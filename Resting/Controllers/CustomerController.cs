using Microsoft.AspNetCore.Mvc;
using Resting.DTOs;
using Resting.Services;
using System;

namespace Resting.Controllers
{
    /// <summary>
    /// CRUD-operations for customer.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public CustomerDTO Get(Guid id) => _customerService.Read(id);

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] CustomerDTO customer) => _customerService.Create(customer);

        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public bool Put([FromBody] CustomerDTO customer) => _customerService.Update(customer);

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id) => _customerService.Delete(id);

        private CustomerService _customerService;
    }
}
