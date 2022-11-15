using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Repositories;
using APIEndpointsPOC.Services.Contracts;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace APIEndpointsPOC.Endpoints.Customers
{ 
    public class Get : EndpointBaseAsync
        .WithRequest<GetCustomerRequest>
        .WithActionResult<GetCustomerResult>
    {
        private readonly IGenericAsyncRepository<Customer> _customerRepository;

        public Get(IGenericAsyncRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("api/", Name = "Test")]
        public override async Task<ActionResult<GetCustomerResult>> HandleAsync([FromQuery]GetCustomerRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _customerRepository.GetAsync();
            return Ok(result);
        }
    }
}
