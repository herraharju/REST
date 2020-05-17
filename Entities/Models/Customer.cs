using System;

namespace Resting.Models
{
    /// <summary>
    /// POCO class for customer objects.
    /// </summary>
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
