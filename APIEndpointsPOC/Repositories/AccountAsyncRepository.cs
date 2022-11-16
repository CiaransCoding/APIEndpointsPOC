using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Enums;
using APIEndpointsPOC.Services.Contracts;

namespace APIEndpointsPOC.Repositories
{
    public class AccountAsyncRepository : IGenericAsyncRepository<Account>
    {
        public Task<Account> CreateAsync(Account entity)
        {
            throw new NotImplementedException();
        }

        public Task<Account> DeleteAsync(Account entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Account>> GetAllAsync(int maxResults, bool returnCeased)
        {
            throw new NotImplementedException();
        }

        public async Task<Account> GetAsync(int id)
        {
            return await Task.FromResult(new Account
            {
                AccountType = AccountTypes.MortgageAccount,
                Id = 123,
                Ceased = false,
                Customers = new List<Customer>
                {
                    new Customer
                    {
                        Id = 456,
                        Name = "Customer Name",
                        Ceased = true
                    }
                }
            });
        }

        public Task<Account> UpdateAsync(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
