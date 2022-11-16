using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Endpoints.Customers;
using Swashbuckle.AspNetCore.Filters;
using System.Linq.Expressions;

namespace APIEndpointsPOC.Documentation.Examples.Result
{
    public class CreateCustomerResultExample : IExamplesProvider<CreateCustomerResult>
    {
        public CreateCustomerResult GetExamples()
        {
            return new CreateCustomerResult
            {
                Result = true,
                CreatedCustomer = new Customer
                {
                    Id = 1,
                    Name = "Test Customer",
                    Ceased = false
                }
            };
        }
    }
}
