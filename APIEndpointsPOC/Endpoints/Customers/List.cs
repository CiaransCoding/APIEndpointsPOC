using APIEndpointsPOC.Documentation.Examples.Request;
using APIEndpointsPOC.Documentation.Examples.Result;
using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Services.Contracts;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using SBS.WebAPI.Common.Errors;
using Swashbuckle.AspNetCore.Filters;

namespace APIEndpointsPOC.Endpoints.Customers
{
    public class List : EndpointBaseAsync
        .WithRequest<ListCustomerRequest>
        .WithActionResult<ListCustomerResult>
    {
        private readonly IGenericAsyncRepository<Customer> _customersRepository;

        public List(IGenericAsyncRepository<Customer> customersRepository)
        {
            _customersRepository = customersRepository;
        }

        [HttpGet("/api/customers/", Name = "[controller]_customers")]
        //[Route("avm")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [SwaggerRequestExample(typeof(ListCustomerRequest), typeof(ListCustomerRequestExample))]
        [ProducesResponseType(typeof(ListCustomerResult), StatusCodes.Status200OK)]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(ListCustomerResultExample))]
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
        public async override Task<ActionResult<ListCustomerResult>> HandleAsync([FromQuery]ListCustomerRequest request, CancellationToken cancellationToken = default)
        {
            return Ok(await _customersRepository.GetAllAsync(request.MaxResults, request.IncludeCeased));
        }
    }
}
