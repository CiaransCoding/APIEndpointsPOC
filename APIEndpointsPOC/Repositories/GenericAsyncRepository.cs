using APIEndpointsPOC.DomainModels;
using APIEndpointsPOC.Services.Contracts;

namespace APIEndpointsPOC.Repositories
{
    public class GenericAsyncRepository<T> : IGenericAsyncRepository<T> where T : BaseEntity
    {
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
