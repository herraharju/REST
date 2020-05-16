
using Resting.Models;
using System;
using System.Linq;

namespace Entities.Repositories
{
    public class CustomerRepo
    {
        public void Create(Customer customer)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                customer.Id = new Guid();
                repo.Insert(customer);
            }
        }

        public Customer Read(Guid id)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                return repo.Query<Customer>().Where(x => x.Id == id).First();
            }
        }

        public bool Update(Customer customer)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                return repo.Update(customer);
            }
        }

        public bool Delete(int id)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                return repo.Delete<Customer>(id);
            }
        }

        public const string ConnectionString = "Database.db";
    }
}
