using APIEndpointsPOC.Endpoints.Customers;
using Swashbuckle.AspNetCore.Filters;

namespace APIEndpointsPOC.Documentation.Examples.Request
{
    public class ListCustomerRequestExample : IExamplesProvider<ListCustomerRequest>
    {
        public ListCustomerRequest GetExamples()
        {
            return new ListCustomerRequest
            {
                IncludeCeased = true,
                MaxResults = 100
            };
        }
    }
}
