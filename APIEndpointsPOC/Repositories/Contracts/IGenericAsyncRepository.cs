using APIEndpointsPOC.DomainModels;

namespace APIEndpointsPOC.Services.Contracts
{
    public interface IGenericAsyncRepository<T> where T : BaseEntity
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync(int maxResults, bool returnCeased);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> CreateAsync(T entity);
    }
}
