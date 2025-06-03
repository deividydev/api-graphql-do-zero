using GraphQLApi.Contracts.Customers.Dtos;
using GraphQLApi.Contracts.Customers.Inputs;
using GraphQLApi.Domain.Entities;
using GraphQLApi.Domain.Repositories;

namespace GraphQLApi.Application.CustomersServices
{
    public class CustomersService(ICustomersRepository customersRepository) : ICustomersServices
    {
        private readonly ICustomersRepository _customersRepository = customersRepository;

        public async Task<IEnumerable<CustomersDto>> GetAllAsync()
        {
            var customers = await _customersRepository.GetAllAsync();
            return customers.Select(res => new CustomersDto
            {
                Id = res.Id,
                Name = res.Name.Trim(),
                DateBirth = res.DateBirth
            });
        }

        public async Task<CustomersDto> CreateAsync(CreateCustomersInput input)
        {
            var customer = new Customers
            {
                Name = input.Name.Trim(),
                DateBirth = input.DateBirth
            };

            await _customersRepository.AddAsync(customer);

            return new CustomersDto
            {
                Id = customer.Id,
                Name = customer.Name,
                DateBirth = customer.DateBirth
            };
        }
    }
}