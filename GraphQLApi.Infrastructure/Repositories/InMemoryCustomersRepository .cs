using GraphQLApi.Domain.Entities;
using GraphQLApi.Domain.Repositories;

namespace GraphQLApi.Infrastructure.Repositories
{
    public class InMemoryCustomersRepository : ICustomersRepository
    {
        private readonly List<Customers> _customers = [];

        public Task AddAsync(Customers customer)
        {
            customer.Id = Guid.NewGuid();
            _customers.Add(customer);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Customers>> GetAllAsync()
        {
            return Task.FromResult(_customers.AsEnumerable());
        }
    }
}