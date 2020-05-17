using System;
using Resting.Repositories;
using Resting.DTOs;
using Resting.Models;
using Resting.Adapters;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Resting.Services
{
    /// <summary>
    /// Service level for logical/business code.
    /// </summary>
    public class CustomerService
    {
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void Create(CustomerDTO customerDto)
        {
            try
            {
                var customer = customerDto.ToCustomer();

                //Create new Guid for new instances.
                customer.Id = new Guid();

                _customerRepository.Create(customer);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
            }
        }

        public CustomerDTO Read(Guid id)
        {
            try
            {
                var customer = _customerRepository.Read(id);
                return customer.ToCustomerDto();
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
            }
            
            return null;
        }
       
        public bool Delete(Guid id)
        {
            try
            {
                return _customerRepository.Delete(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
            }

            return false;
        }

        public bool Update(CustomerDTO customerDto)
        {
            try
            {
                var customer = customerDto.ToCustomer();
                return _customerRepository.Update(customer);
            }
            catch (Exception e)
            {
                _logger.LogError(e.ToString());
            }

            return false;
        }
        private ILogger _logger;
        private CustomerRepository _customerRepository;
    }
}
