using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Resting.Models;
using Resting.DTOs;

namespace Resting.Adapters
{
    /// <summary>
    /// Contains mapper functions for mapping.
    /// </summary>
    public static class CustomerAdapters
    {
        /// <summary>
        /// Maps customerDto class to customer.
        /// </summary>
        /// <param name="customerDto"></param>
        /// <returns></returns>
        public static Customer ToCustomer(this CustomerDTO customerDto)
            => new Customer()
            {
                FirstName = customerDto.FirstName,
                Id = customerDto.Id,
                LastName = customerDto.LastName
            };

        /// <summary>
        /// Maps customer class to customerDto.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static CustomerDTO ToCustomerDto(this Customer customer)
            => new CustomerDTO()
            {
                FirstName = customer.FirstName,
                Id = customer.Id,
                LastName = customer.LastName
            };
    }
}
