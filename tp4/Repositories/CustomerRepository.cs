using Microsoft.EntityFrameworkCore;
using tp4.Models;

namespace tp4.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        IEnumerable<Customer> GetAll();
    }

    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }


        public IEnumerable<Customer> GetAll()
        {
            return _db.Customers
                .Include(c => c.MembershipType)
                .Include(c => c.Movies)
                .ToList();
        }
    }
}
