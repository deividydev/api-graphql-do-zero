using GraphQL.Types;
using GraphQLApi.Contracts.Customers.Dtos;

namespace GraphQLApi.Presentation.GraphQL.Customers.Types
{
    public class CustomerType : ObjectGraphType<CustomersDto>
    {
        public CustomerType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.DateBirth);
        }
    }
}