
using Resting.Models;
using System;
using System.Data.Common;

namespace Resting.Repositories
{
    /// <summary>
    /// Handles customer related database operations.
    /// </summary>
    public class CustomerRepository
    {

        public void Create(Customer customer)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                try
                {
                    repo.Insert(customer);
                }
                catch (DbException e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// Find customer from database by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer Read(Guid id)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                try
                {
                    return repo.Query<Customer>().Where(x => x.Id == id).First();
                }
                catch (DbException e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// Updates customer information to database.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool Update(Customer customer)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                try
                {
                    return repo.Update(customer);
                }
                catch (DbException e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// Deletes customer from database by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(Guid id)
        {
            using (var repo = new LiteDB.LiteRepository(ConnectionString))
            {
                try
                {
                    return repo.Delete<Customer>(id);
                }
                catch(DbException e)
                {
                    throw e;
                }
            }
        }

        public const string ConnectionString = "Database.db";
    }
}
