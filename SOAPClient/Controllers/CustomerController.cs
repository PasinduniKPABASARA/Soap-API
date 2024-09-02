using CustomerService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOAPClient.Controllers
{
    
    [ApiController]
    [Route("CustomerController")]
    public class CustomerController : Controller
    {
        [HttpGet]

        public async Task<CustomerDataContract> GetCustomersAsync()
        {
            ICustomerService customerService =
                new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await customerService.GetCustomerAsync();

        }
    }
}
