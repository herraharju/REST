using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resting.Models;

namespace Resting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {
            _customerRepo = new CustomerRepo();
        }
        
        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(Guid id) => _customerRepo.Read(id);
         
        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] Customer customer) => _customerRepo.Create(customer);
                
        // PUT: api/Customer/5
        [HttpPut("{id}")]
        public bool Put([FromBody] Customer customer) => _customerRepo.Update(customer);

        // DELETE: api/Customer/5
        [HttpDelete("{id}")]
        public bool Delete(Guid id) => _customerRepo.Delete(id);

        private CustomerRepo _customerRepo;
    }
}
