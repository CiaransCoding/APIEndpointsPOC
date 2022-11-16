using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Services.Contracts;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace APIEndpointsPOC.Endpoints.Accounts
{
    public class Get : EndpointBaseAsync
        .WithRequest<int>
        .WithActionResult<GetAccountResult>
    {
        private readonly IGenericAsyncRepository<Account> _accountRepository;

        public Get(IGenericAsyncRepository<Account> accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet("/api/accounts/{id}", Name = "[controller]_account")]
        public override async Task<ActionResult<GetAccountResult>> HandleAsync(int id, CancellationToken cancellationToken = default)
        {
            return Ok(await Task.FromResult(_accountRepository.GetAsync(id)));
        }
    }
}
