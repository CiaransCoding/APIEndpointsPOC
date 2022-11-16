using APIEndpointsPOC.Documentation.Examples.Request;
using APIEndpointsPOC.Documentation.Examples.Result;
using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Services.Contracts;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;

namespace APIEndpointsPOC.Endpoints.Customers
{
    public class Create : EndpointBaseAsync
        .WithRequest<CreateCustomerRequest>
        .WithActionResult<CreateCustomerResult>
    {
        private readonly IGenericAsyncRepository<Customer> _customerRepository;

        public Create(IGenericAsyncRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost("/api/customer", Name = "[controller]_customer")]
        //[Route("avm")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [SwaggerRequestExample(typeof(CreateCustomerRequest), typeof(CreateCustomerRequestExample))]
        [ProducesResponseType(typeof(CreateCustomerResult), StatusCodes.Status200OK)]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(CreateCustomerResultExample))]
        //[ProducesResponseType(typeof(WebAPIException), StatusCodes.Status400BadRequest)]
        //[SwaggerResponseExample(StatusCodes.Status400BadRequest, typeof(BadRequestExample))]
        //[ProducesResponseType(typeof(WebAPIException), StatusCodes.Status401Unauthorized)]
        ////[SwaggerResponseExample(StatusCodes.Status401Unauthorized, typeof(UnauthorizedExamples))]
        //[ProducesResponseType(typeof(WebAPIException), StatusCodes.Status403Forbidden)]
        ////[SwaggerResponseExample(StatusCodes.Status403Forbidden, typeof(ForbiddenExamples))]
        //[ProducesResponseType(typeof(WebAPIException), StatusCodes.Status409Conflict)]
        ////[SwaggerResponseExample(StatusCodes.Status409Conflict, typeof(AddressMatchConflictExamples))]
        //[ProducesResponseType(typeof(WebAPIException), StatusCodes.Status500InternalServerError)]
        ////[SwaggerResponseExample(StatusCodes.Status500InternalServerError, typeof(InternalServerExamples))]
        public async override Task<ActionResult<CreateCustomerResult>> HandleAsync([FromBody]CreateCustomerRequest request, CancellationToken cancellationToken = default)
        {
            return Ok(await _customerRepository.CreateAsync(request.Customer));
        }
    }
}
