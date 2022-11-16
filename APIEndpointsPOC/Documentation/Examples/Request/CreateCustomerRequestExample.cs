using APIEndpointsPOC.Endpoints.Customers;
using Swashbuckle.AspNetCore.Filters;

namespace APIEndpointsPOC.Documentation.Examples.Request
{
    public class CreateCustomerRequestExample : IExamplesProvider<CreateCustomerRequest>
    {
        public CreateCustomerRequest GetExamples()
        {
            return new CreateCustomerRequest
            {
                Customer = new DomainModels.Customer
                {
                    Id = 1,
                    Name = "Customer Name",
                    Ceased = false
                }
            };
        }
    }
}
