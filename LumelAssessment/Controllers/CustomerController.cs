using LumelAssessment.Services.Customer;
using Microsoft.AspNetCore.Mvc;

namespace LumelAssessment.Controllers
{
    [ApiController]
    public class CustomerController : Controller
    {
        public readonly ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet]
        [Route("api/customer/details")]
        public async Task<IActionResult> GetCustomerDetails()
            => await _customerServices.GetCustomerDetailsAsync();

        [HttpPost]
        [Route("api/customer/register")]
        public async Task<IActionResult> RegisterCustomer()
            => await _customerServices.RegisterCustomerAsync(); 
        
        [HttpPost]
        [Route("api/customer/upload")]
        public async Task<IActionResult> UploadCustomerData()
        => await _customerServices.UploadCustomerDataAsync();
    }
}
