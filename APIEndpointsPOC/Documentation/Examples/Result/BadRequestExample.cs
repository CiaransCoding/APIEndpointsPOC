using SBS.WebAPI.Common.Errors;
using Swashbuckle.AspNetCore.Filters;
using System.Net;

namespace APIEndpointsPOC.Documentation.Examples.Result
{
    public class BadRequestExample : IExamplesProvider<WebAPIException>
    {
        private const string ValidationFailed = "SBS-ESB-00003";
        private const string ValidationFailedError = "Validation failed";
        public WebAPIException GetExamples()
        {

            var errorDetail = new WebAPIErrorDetails[]
            {
                new WebAPIErrorDetails("All search criteria must be entered","searchDetails")
            };
            var error = new WebAPIError(ValidationFailed, ValidationFailedError, errorDetail);
            return new WebAPIException(HttpStatusCode.BadRequest, error);

        }
    }
}
