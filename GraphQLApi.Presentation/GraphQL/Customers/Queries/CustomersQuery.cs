using GraphQL.Types;
using GraphQLApi.Application.CustomersServices;
using GraphQLApi.Presentation.GraphQL.Customers.Types;

namespace GraphQLApi.Presentation.GraphQL.Customers.Queries
{
    public class CustomersQuery : ObjectGraphType
    {
        public CustomersQuery(ICustomersServices cutomersService)
        {
            Field<ListGraphType<CustomerType>>("customers")
            .ResolveAsync(async _ =>
            {
                var customers = await cutomersService.GetAllAsync();
                return customers.ToList();
            });
        }
    }
}