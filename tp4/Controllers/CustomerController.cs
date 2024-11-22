using Microsoft.AspNetCore.Mvc;
using tp4.Services.ServiceContracts;

namespace tp4.Controllers
{
    [Route("Customers")]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetAllCustomers();

            return View(customers);
        }



    }
}
