using GraphQLApi.Domain.Entities;

namespace GraphQLApi.Domain.Repositories
{
    public interface ICustomersRepository
    {
        Task<IEnumerable<Customers>> GetAllAsync();
        Task AddAsync(Customers customer);
    }
}