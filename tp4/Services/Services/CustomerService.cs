using tp4.Models;
using tp4.Repositories;
using tp4.Services.ServiceContracts;

namespace tp4.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetCustomerById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public void AddCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Name))
            {
                throw new ArgumentException("Customer name cannot be null or empty.");
            }

            _customerRepository.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            if (customer.Id == Guid.Empty)
            {
                throw new ArgumentException("Customer ID cannot be empty.");
            }

            _customerRepository.Update(customer);
        }

        public void DeleteCustomer(Guid id)
        {
            _customerRepository.Delete(id);
        }
    }
}
