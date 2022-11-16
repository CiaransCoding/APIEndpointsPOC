using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Endpoints.Customers;
using Swashbuckle.AspNetCore.Filters;

namespace APIEndpointsPOC.Documentation.Examples.Result
{
    public class ListCustomerResultExample : IExamplesProvider<ListCustomerResult>
    {
        public ListCustomerResult GetExamples()
        {
            return new ListCustomerResult
            {
                Customers = new List<Customer>
                {
                    new Customer
                    {
                        Id = 1,
                        Name = "Customer One",
                        Ceased = false
                    },
                    new Customer
                    {
                        Id = 2,
                        Name = "Customer Two",
                        Ceased = false
                    },
                    new Customer
                    {
                        Id = 3,
                        Name = "Customer three",
                        Ceased = false
                    },
                }
            };
        }
    }
}
