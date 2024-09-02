using System.ServiceModel;

namespace SOAP.Models
{
    public class CustomerServiceContract
    {
        [ServiceContract]
        public interface ICustomerService
        {
            [OperationContract]
            CustomerDataContract GetCustomer();
        }
    }
}
