using GraphQLApi.Contracts.Customers.Dtos;
using GraphQLApi.Contracts.Customers.Inputs;

namespace GraphQLApi.Application.CustomersServices
{
    public interface ICustomersServices
    {
        Task<IEnumerable<CustomersDto>> GetAllAsync();
        Task<CustomersDto> CreateAsync(CreateCustomersInput input);
    }
}