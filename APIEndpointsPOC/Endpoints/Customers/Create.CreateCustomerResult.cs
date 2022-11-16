using APIEndpointsPOC.DomainModels;

namespace APIEndpointsPOC.Endpoints.Customers
{
    public class CreateCustomerResult
    {
        public bool Result { get; set; }
        public Customer CreatedCustomer { get; set; }
    }
}
