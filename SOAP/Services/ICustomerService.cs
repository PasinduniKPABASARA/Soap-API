using SOAP.Models;
using System.Security.Cryptography.X509Certificates;
using static SOAP.Models.CustomerServiceContract;

namespace SOAP.Services
{
    public class CustomerService:ICustomerService

    {
        public CustomerDataContract GetCustomer()
        {
            return new CustomerDataContract
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                EmailAddress = "iohn.doe@example.com"
            };
        }

       

    }
}
