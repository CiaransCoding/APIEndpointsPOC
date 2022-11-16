using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Services.Contracts;

namespace APIEndpointsPOC.Repositories
{
    public class CustomerAsyncRepository : IGenericAsyncRepository<Customer>
    {
        public Task<Customer> CreateAsync(Customer entity)
        {
            return Task.FromResult(new Customer
            {
                Id = entity.Id,
                Name = entity.Name,
                Ceased = entity.Ceased
            });
        }

        public Task<Customer> DeleteAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync(int maxResults, bool returnCeased)
        {
            var customers = new List<Customer>
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
                    Name = "Customer One",
                    Ceased = false
                },
                new Customer
                {
                    Id = 3,
                    Name = "Customer One",
                    Ceased = false
                }
            };

            return Task.FromResult(customers);
        }

        public Task<Customer> GetAsync(int id)
        {
            return Task.FromResult(new Customer { Id = id, Name = "Test Customer" });
        }

        public Task<Customer> UpdateAsync(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
