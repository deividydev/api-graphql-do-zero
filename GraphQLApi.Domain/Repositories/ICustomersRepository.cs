using System.Linq.Expressions;
using GraphQLApi.Domain.Entities;

namespace GraphQLApi.Domain.Repositories
{
    public interface ICustomersRepository
    {
        Task<IEnumerable<Customers>> GetAllAsync(Expression<Func<Customers, bool>> predicate);
        Task AddAsync(Customers customer);
    }
}